using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

using TaxiSystem.Src.Database.MySQL;

namespace TaxiSystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            Console.WriteLine(MySQL.Instance().ToString());
            MySQL.Instance().Execute("INSERT INTO autos VALUES (1)");
            MySqlDataReader reader = MySQL.Instance().Execute("SELECT * FROM autos");
            while (reader.Read())
            {
                Console.WriteLine(reader.GetUInt32(0));
            }
        }
    }
}
