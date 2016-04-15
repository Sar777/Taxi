using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;
using TaxiSystem.Common;
using TaxiSystem.Database.MySQL;
using TaxiSystem.Object;
using TaxiSystem.Src.Common;
using TaxiSystem.Src.Object;

namespace TaxiSystem
{
    public partial class ManagerForm : Form
    {
        public User User { get; private set; }
        private Form MainForm { get; set; }

        public ManagerForm(User user)
        {
            User = user;
            InitializeComponent();
        }

        private void ManagerForm_Load(object sender, EventArgs e)
        {
            this.Text = "Панель диспетчера: " + User.Username + ", Здравствуйте!";
            UpdateOrders();
        }

        private void ManagerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Owner.Visible = true;
        }

        private void _toolStripRefresh_Click(object sender, EventArgs e)
        {
            UpdateOrders();
        }

        private void UpdateOrders()
        {
            MySQL mysql = MySQL.Instance();
            using (MySqlDataReader reader = mysql.Execute($"SELECT `Id`, `type`, `date`, `s_address`, `e_address` FROM `orders` WHERE `status` = {(int)OrderStatus.ORDERING_STATUS_QUEUE}"))
            {
                if (reader == null)
                    return;

                int i = 0;
                while (reader.Read())
                {
                    dataGridView1.Rows[i].Cells[0].Value = reader.GetUInt32(0);
                    dataGridView1.Rows[i].Cells[1].Value = Order.GetTaxiType((TaxiType)reader.GetByte(1));
                    dataGridView1.Rows[i].Cells[2].Value = reader.GetString(2);
                    dataGridView1.Rows[i].Cells[3].Value = reader.GetString(3);
                    dataGridView1.Rows[i].Cells[4].Value = reader.GetString(4);
                    ++i;
                }
            }
        }
    }
}
