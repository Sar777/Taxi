using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;
using TaxiSystem.Common;
using TaxiSystem.Database.MySQL;

namespace TaxiSystem
{
    public partial class RegForm : Form
    {
        private readonly string[] _regErrors = { "Заполните все поля!", "Пользователь с таким именем уже существует", "Пароли не совпадают", "Длина пароля должна быть более 5 символов" };

        public RegForm()
        {
            InitializeComponent();
        }

        private void _btReg_Click(object sender, EventArgs e)
        {
            int errIdx = -1;
            if (_tbUsername.Text.Length == 0 || _tbPassowrd1.Text.Length == 0 || _tbPassowrd2.Text.Length == 0)
                errIdx = 0;
            else if (!_tbPassowrd1.Text.Equals(_tbPassowrd2.Text))             // Проверка паролей
                errIdx = 2;
            else if (_tbPassowrd1.Text.Length < 5)
                errIdx = 3;

            MySQL mysql = MySQL.Instance();
            using (MySqlDataReader reader = mysql.Execute($"SELECT 1 FROM `users` WHERE `username` = '{ _lbUsername.Text}'"))
            {
                if (reader == null)
                    throw new FormatException("MySQL: Not execute query");

                if (reader.Read())
                    errIdx = 1;
            }

            if (errIdx != -1)
            {
                _lbErrors.Text = _regErrors[errIdx];
                _tbPassowrd1.Text = "";
                _tbPassowrd2.Text = "";
                return;
            }

            mysql.PExecute($"INSERT INTO `users` (`username`, `password`) VALUES ('{_tbUsername.Text}', '{MD5Hash.Get(_tbUsername + ":" + _tbPassowrd1.Text)}')");
            Close();
        }

        private void RegForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Owner.Visible = true;
        }
    }
}
