using System.Windows.Forms;
using TaxiSystem.Src.Auth;
using TaxiSystem.Src.Common;
using TaxiSystem.Src.Object;

namespace TaxiSystem
{
    public partial class AuthForm : Form
    {
        public AuthForm()
        {
            InitializeComponent();
        }

        private void _btAuth_Click(object sender, System.EventArgs e)
        {
            User user = Auth.Instance.Authorization(_textBoxUsername.Text, _textBoxPassword.Text);
            if (user == null)
            {
                _lbAuthError.Text = "Ошибка авторизации!";
                return;
            }

            UserMgr.Instance.AddUser(user);
            ManagerForm form = new ManagerForm(user);
            form.Show();

            Close();
        }
    }
}
