using System;
using System.Windows.Forms;
using TaxiSystem.Forms;
using TaxiSystem.Networking;
using TaxiSystem.Protocol;
using TaxiSystem.UserForms.Client;

namespace TaxiSystem.UserForms
{
    public partial class ClientForm : Form
    {
        public static ClientForm Form { get; private set; }
        public int UserID { get; set; }
        public string Username { get; set; }
        public uint OrderId { get; set; }

        public ClientForm(int userId, string username)
        {
            UserID = userId;
            Username = username;

            InitializeComponent();
            Form = this;
        }

        private void ClientForm_Load(object sender, EventArgs e)
        {
            Text = $"{Username}, Здравствуйте!";

            TCPSocket.Instance.SendPacket(new Packet(Opcode.CMSG_GET_TAXI_INFO));
        }
 
        private void ClientForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            TCPSocket.Instance.SendPacket(new Packet(Opcode.CMSG_LOGOUT));
            Owner.Visible = true;
        }

        private void _toolStripSettings_Click(object sender, EventArgs e)
        {
          var form = new ClientSettingsForm { Owner = this };
            form.ShowDialog();
        }

        private void _lbOrderType_SelectedIndexChanged(object sender, EventArgs e)
        {
         //   _btAddOrder.Enabled = true;
        }

        private void _btAddOrder_Click(object sender, EventArgs e)
        {
         /*   if (_order != null)
            {
                MessageBox.Show("Вы уже сделали заказ!");
                return;
            }

            var sAddress = _cbSAddress.SelectedIndex != -1 ? _cbSAddress.Items[_cbSAddress.SelectedIndex].ToString() : _cbSAddress.Text;
            var eAddress = _cbEAddress.SelectedIndex != -1 ? _cbEAddress.Items[_cbEAddress.SelectedIndex].ToString() : _cbEAddress.Text;

            _order = new Order(User, (TaxiType)_lbOrderType.SelectedIndex, Address.Parse(sAddress), Address.Parse(eAddress));
            var errorText = string.Empty;
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
            _btAddOrder.Enabled = false;*/
        }

        private void _btOrderCancel_Click(object sender, EventArgs e)
        {
           /* if (_order == null)
                return;

            if (!_order.IsQueue())
            {
                MessageBox.Show("Ваш заказ выполняется, отменить нельзя!");
                return;
            }

            _order.Cancel();
            _order = null;
            _toolStripStatusOrder.Text = "Состояние: Заказ отменен";*/
        }

        public void LoadTaxiInfo(Packet packet)
        {
            OrderId = packet.ReadUInt32();
            var count = packet.ReadUInt8();
            for (var i = 0; i < count; ++i)
            {
                var type = packet.ReadUTF8String();
                _lbOrderType.Invoke((Action)(() =>
                {
                    _lbOrderType.Items.Add(type);
                }));
            }

            count = packet.ReadUInt16();
            for (var i = 0; i < count; ++i)
            {
                _cbEAddress.Invoke((Action)(() =>
                {
                    _cbEAddress.Items.Add(packet.ReadUTF8String());
                }));

                _cbSAddress.Invoke((Action)(() =>
                {
                    _cbSAddress.Items.Add(packet.ReadUTF8String());
                }));
            }

            if (OrderId > 0)
                _currOrderToolStripMenuItem.Enabled = true;
        }

        private void _currOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (OrderId == 0)
                return;

            var form = new OrderInformationForm(OrderId) {Owner =  this};
            form.ShowDialog();
        }
    }
}
