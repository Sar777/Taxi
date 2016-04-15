using System;
using System.Windows.Forms;
using TaxiSystem.Auth;
using TaxiSystem.ClientForms;
using TaxiSystem.Object;
using TaxiSystem.Src.Common;

namespace TaxiSystem.AuthForms
{
    public partial class AuthForm : Form
    {
        private readonly string[] _errMessage = { "Ошибка MySQL", "Пользователь не найден" };

        public AuthForm()
        {
            InitializeComponent();
        }

        private void _btAuth_Click(object sender, System.EventArgs e)
        {
            int errCode = -1;
            var user = Auth.Auth.Instance.Authorization(_tbUsername.Text, _tbPassword.Text, ref errCode);
            if (user == null)
            {
                _lbAuthError.Text = _errMessage[errCode];
                return;
            }

            Form form = null;
            switch (user.UserTypeId)
            {
                case UserType.USER_TYPE_CLIENT:
                    form = new ClientForm(user);
                    break;
                case UserType.USER_TYPE_MANAGER:
                    form = new ManagerForm(user);
                    break;
                case UserType.USER_TYPE_DRIVER:
                default:
                    throw new NotSupportedException(string.Format($"Auth: Unsupported user type {0}", user.UserTypeId));
            }

            form.Owner = this;
            form.Show();

            this.Visible = false;
        }

        private void _btReg_Click(object sender, System.EventArgs e)
        {
            this.Visible = false;
            RegForm form = new RegForm();
            form.Owner = this;
            form.Show();
        }
    }
}
