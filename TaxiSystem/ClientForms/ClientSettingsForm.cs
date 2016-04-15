using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaxiSystem.Common;
using TaxiSystem.Database.MySQL;
using TaxiSystem.Src;

namespace TaxiSystem.ClientForms
{
    public partial class ClientSettingsForm : Form
    {
        private readonly string[] _errMessages = { "Заполните все поля!" };

        private readonly List<Address> _addresses;

        public ClientSettingsForm()
        {
            InitializeComponent();
            _addresses = new List<Address>();
        }

        private void ClientSettingsForm_Load(object sender, EventArgs e)
        {
            Task.Factory.StartNew(LoadMyAddress);
        }

        private void LoadMyAddress()
        {
            var mysql = MySQL.Instance();
            using (var reader = mysql.Execute(string.Format($"SELECT `address` FROM `save_address` WHERE `ownerId` = {((ClientForm)Owner).User.Id}")))
            {
                while (reader.Read())
                {
                    var address = new Address(reader.GetString(0));
                    _addresses.Add(address);
                    _lbMyAddress.Invoke((Action)(() =>
                    {
                        _lbMyAddress.Items.Add(address.ToString());
                    }));
                }
            }
        }

        private void _lbMyAddress_SelectedIndexChanged(object sender, EventArgs e)
        {
            _btRemoveAddress.Enabled = _lbMyAddress.SelectedItem != null;
        }

        private void _btRemoveAddress_Click(object sender, EventArgs e)
        {
            if (_lbMyAddress.SelectedItem == null)
                return;

            _addresses.RemoveAt(_lbMyAddress.SelectedIndex);
            _lbMyAddress.Items.RemoveAt(_lbMyAddress.SelectedIndex);
        }

        private void ClientSettingsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            var mysql = MySQL.Instance();
            mysql.BeginTransaction();
            mysql.PExecute($"DELETE FROM `save_address` WHERE `ownerId` = {((ClientForm)Owner).User.Id}");
            foreach (var address in _addresses)
                mysql.PExecute($"INSERT INTO `save_address` (`ownerId`, `address`) VALUES ({((ClientForm)Owner).User.Id}, '{address.DbFormat()}')");

            mysql.CommitTransaction();
        }

        private void _btAddAddress_Click(object sender, EventArgs e)
        {
            if (_tbCity.Text.Length == 0 || _tbStreet.Text.Length == 0 || _tbHouse.Text.Length == 0)
            {
                _lbErrors.Text = _errMessages[0];
                return;
            }

            var address = new Address(_tbCity.Text, _tbStreet.Text, _tbHouse.Text);
            _addresses.Add(address);
            _lbMyAddress.Items.Add(address.ToString());

            // Сброс полей ввода
            _lbCity.Text = "";
            _lbStreet.Text = "";
            _lbHouse.Text = "";
            _lbErrors.Text = "";

            _tbControl.SelectTab(0);
        }
    }
}
