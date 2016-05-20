using System;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaxiSystem.Common;
using TaxiSystem.Common.Enums;
using TaxiSystem.Networking;
using TaxiSystem.Protocol;
using TaxiSystem.Protocol.Enums;
using TaxiSystem.UserForms;

namespace TaxiSystem.AuthForms
{
    public partial class AuthForm : Form
    {
        public static AuthForm Form { get; private set; }
        public AuthForm()
        {
            InitializeComponent();
            Form = this;
        }

        public void Auth(int userId, string username, UserType userType, AuthResponse code)
        {
            _tbUsername.Text = string.Empty;
            _tbPassword.Text = string.Empty;
            _btAuth.Enabled = true;
            if (code == AuthResponse.AUTH_RESPONSE_UNKNOWN_USER)
            {
                _lbAuthError.Text = "Неизвестный пользователь";
                return;
            }

            if (code == AuthResponse.AUTH_RESPONSE_UNKNOWN_ERROR)
            {
                _lbAuthError.Text = "Неизвестныя ошибка...";
                return;
            }

            Form userForm = null;
            switch (userType)
            {
                case UserType.USER_TYPE_CLIENT:
                    userForm = new ClientForm(userId, username);
                    break;
                case UserType.USER_TYPE_DISPATCHER:
                    userForm = new DispatcherForm(userId, username);
                    break;
                case UserType.USER_TYPE_DRIVER:
                default:
                    throw new NotSupportedException($"Not supported usertype {userType}");
            }

            Visible = false;
            userForm.Owner = this;
            userForm.Show();
        }

        private void _btAuth_Click(object sender, EventArgs e)
        {
            _lbAuthError.Text = string.Empty;
            if (string.IsNullOrEmpty(_tbUsername.Text) || string.IsNullOrEmpty(_tbPassword.Text))
            {
                _lbAuthError.Text = "Заполните все поля!";
                return;
            }

            var packet = new Packet(Opcode.CMSG_AUTH);
            packet.WriteUTF8String(_tbUsername.Text);
            packet.WriteUTF8String(_tbPassword.Text);
            TCPSocket.Instance.SendPacket(packet);
            _btAuth.Enabled = false;
            _lbAuthError.Text = string.Empty;
        }

        private void _btReg_Click(object sender, EventArgs e)
        {
            Visible = false;
            var form = new RegForm {Owner = this};
            form.Show();
        }

        private void AuthForm_Load(object sender, EventArgs e)
        {
            Task.Factory.StartNew(() => { TCPSocket.Instance.Connect(Constants.CONNECT_INFO_HOST, Constants.CONNECT_INFO_PORT); });
        }

        private void AuthForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            TCPSocket.Instance.SendPacket(new Packet(Opcode.CMSG_DISCONNECTED), true);
        }
    }
}
