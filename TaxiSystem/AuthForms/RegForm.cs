using System;
using System.Windows.Forms;
using TaxiSystem.Common.Enums;
using TaxiSystem.Networking;
using TaxiSystem.Protocol;
using TaxiSystem.Protocol.Enums;

namespace TaxiSystem.AuthForms
{
    public partial class RegForm : Form
    {
        public static RegForm Form { get; private set; }

        private bool _authed = false;

        public RegForm()
        {
            InitializeComponent();
            Form = this;
        }

        private void _btReg_Click(object sender, EventArgs e)
        {
            _lbErrors.Text = string.Empty;
            if (string.IsNullOrEmpty(_tbUsername.Text) ||
                string.IsNullOrEmpty(_tbPassowrd1.Text) ||
                string.IsNullOrEmpty(_tbPassowrd2.Text))
            {
                _lbErrors.Text = "Заполните все поля!";
                return;
            }

            if (!_tbPassowrd1.Text.Equals(_tbPassowrd2.Text))
            {
                _lbErrors.Text = "Пароли не совпадают!";
                return;
            }

            _btReg.Enabled = false;
            var packet = new Packet(Opcode.CMSG_REGISTRATION);
            packet.WriteUTF8String(_tbUsername.Text);
            packet.WriteUTF8String(_tbPassowrd1.Text);
            TCPSocket.Instance.SendPacket(packet);
        }

        private void RegForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!_authed)
                Owner.Visible = true;
        }

        public void Registration(int userId, string username, UserType userType, RegistrationResponse code)
        {
            _tbUsername.Text = string.Empty;
            _tbPassowrd1.Text = string.Empty;
            _tbPassowrd2.Text = string.Empty;
            _btReg.Enabled = true;
            if (code == RegistrationResponse.REG_RESPONSE_HERE_USER)
            {
                _lbErrors.Text = "Пользователь с таким логином уже существует.";
                return;
            }

            _authed = true;

            // Авторизация
            AuthForm.Form.Invoke(new Action(() =>
            {
                AuthForm.Form.Auth(userId, username, userType, AuthResponse.AUTH_RESPONSE_SUCCESS);
            }));
            Close();
        }
    }
}
