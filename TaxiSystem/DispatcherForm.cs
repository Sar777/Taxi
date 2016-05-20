using System;
using System.Windows.Forms;
using TaxiSystem.Networking;
using TaxiSystem.Protocol;
using TaxiSystem.UserForms;

namespace TaxiSystem
{
    public partial class DispatcherForm : Form
    {
        private DispatcherForm Form { get; set; }
        public int UserID { get; set; }
        public string Username { get; set; }

        public DispatcherForm(int userId, string username)
        {
            InitializeComponent();
        }

        private void ManagerForm_Load(object sender, EventArgs e)
        {
            Text = "Панель диспетчера: " + Username + ", Здравствуйте!";
        }

        private void ManagerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            TCPSocket.Instance.SendPacket(new Packet(Opcode.CMSG_LOGOUT));
            Owner.Visible = true;
        }

        private void _toolStripRefresh_Click(object sender, EventArgs e)
        {
          //  UpdateOrders();
        }

        /*
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
        }*/
    }
}
