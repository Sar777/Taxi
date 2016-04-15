using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using TaxiSystem.Common;
using TaxiSystem.Database.MySQL;
using TaxiSystem.Object;
using TaxiSystem.Src.Common;
using TaxiSystem.Users;

namespace TaxiSystem.ClientForms
{
    public partial class ClientForm : Form
    {
        private Timer _orderUpdateTimer;

        private Order _order;

        public User User { get; private set; }

        public ClientForm(User user)
        {
            this.User = user;
            this._order = null;
            InitializeComponent();
        }

        private void ClientForm_Load(object sender, EventArgs e)
        {
            this.Text = $"{User.Username}, Здравствуйте!";

            // Загрузка данных
            Task.Factory.StartNew(LoadData);

            // Запуск таймера
            _orderUpdateTimer = new Timer { Interval = 1000 };
            _orderUpdateTimer.Tick += UpdateOrderTimer;
            _orderUpdateTimer.Start();
        }
 
        private void ClientForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Вы действительно хотите закрыть приложение?", "Закрыть приложение", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation))
                Application.Exit();
            else
                e.Cancel = true;
        }

        private void _toolStripSettings_Click(object sender, EventArgs e)
        {
            var form = new ClientSettingsForm { Owner = this };
            form.ShowDialog();
        }

        private void _lbOrderType_SelectedIndexChanged(object sender, EventArgs e)
        {
            _btAddOrder.Enabled = true;
        }

        private void _btAddOrder_Click(object sender, EventArgs e)
        {
            if (_order != null)
            {
                MessageBox.Show("Вы уже сделали заказ!");
                return;
            }

            string sAddress = _cbSAddress.SelectedIndex != -1 ? _cbSAddress.Items[_cbSAddress.SelectedIndex].ToString() : _cbSAddress.Text;
            string eAddress = _cbEAddress.SelectedIndex != -1 ? _cbEAddress.Items[_cbEAddress.SelectedIndex].ToString() : _cbEAddress.Text;

            _order = new Order(User, (TaxiType)_lbOrderType.SelectedIndex, Address.Parse(sAddress), Address.Parse(eAddress));
            string errorText = "";
            _order.Validate(out errorText, true);
            if (!_order.Validate(out errorText))
            {
                _order = null;
                _lbErrors.Text = errorText;
                return;
            }

            _order.SaveToDb();

            _lbErrors.Text = "";
            _cbSAddress.Text = "";
            _cbEAddress.Text = "";
            _cbSAddress.SelectedIndex = -1;
            _cbEAddress.SelectedIndex = -1;
            _lbOrderType.SelectedIndex = -1;
            _btAddOrder.Enabled = false;
        }

        private void LoadData()
        {
            LoadTaxiType();
            LoadAddresses();
            LoadCurrentOrder();
        }

        private void LoadTaxiType()
        {
            var mysql = MySQL.Instance();
            using (var reader = mysql.Execute("SELECT `name` FROM `taxi_type`"))
            {
                if (reader == null)
                    return;

                while (reader.Read())
                {
                    _lbOrderType.Invoke((Action)(() =>
                    {
                        _lbOrderType.Items.Add(reader.GetString(0));
                    }));
                }
            }
        }

        private void LoadAddresses()
        {
            var mysql = MySQL.Instance();
            using (var reader = mysql.Execute($"SELECT `address` FROM `save_address` WHERE `ownerId` = {User.Id}"))
            {
                if (reader == null)
                    return;

                while (reader.Read())
                {
                    var address = new Address(reader.GetString(0));
                    _cbSAddress.Invoke((Action)(() =>
                    {
                        _cbSAddress.Items.Add(address);
                    }));

                    _cbEAddress.Invoke((Action)(() =>
                    {
                        _cbEAddress.Items.Add(address);
                    }));
                }
            }
        }

        private void LoadCurrentOrder()
        {
            if (_order != null)
                return;

            var mysql = MySQL.Instance();
            using (var reader = mysql.Execute($"SELECT o.`Id`, o.`type`, o.`status`, o.`s_address`, o.`e_address`, o.`date`, o.`driverId`, u.`Id`, u.`username` FROM `orders` o LEFT JOIN users u ON u.Id = o.driverId WHERE `ownerId` = {User.Id} AND `status` != {(int)OrderStatus.ORDERING_STATUS_DONE} AND `status` != {(int)OrderStatus.ORDERING_STATUS_CANCELED}"))
            {
                if (reader == null || !reader.Read())
                    return;

                User driver = null;
                if (reader.GetUInt32(6) != 0)
                    driver = new Driver(reader.GetInt32(7), reader.GetString(8), null);

                _order = new Order(reader.GetInt32(0), User, driver, (TaxiType)reader.GetByte(1), (OrderStatus)reader.GetByte(2), new Address(reader.GetString(3)), new Address(reader.GetString(4)), Time.UnixTimeStampToDateTime(reader.GetInt32(5)));
                _toolStripStatusOrder.Text = $"Состояние заказа: {Order.GetOrderStatusString(_order.Status)}";
            }
        }

        private void UpdateOrderTimer(object sender, EventArgs e)
        {

        }

        private void _btOrderCancel_Click(object sender, EventArgs e)
        {
            if (_order == null)
                return;

            if (!_order.IsQueue())
            {
                MessageBox.Show("Ваш заказ выполняется, отменить нельзя!");
                return;
            }

            _order.Cancel();
            _order = null;
            _toolStripStatusOrder.Text = "Состояние: Заказ отменен";
        }
    }
}
