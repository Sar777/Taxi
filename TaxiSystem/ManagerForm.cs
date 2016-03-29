using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaxiSystem.Src.Common;
using TaxiSystem.Src.Object;

namespace TaxiSystem
{
    public partial class ManagerForm : Form
    {
        public User User { get; private set; }

        public ManagerForm(User user)
        {
            User = user;
            InitializeComponent();
        }

        private void ManagerForm_Load(object sender, EventArgs e)
        {
            this.Text = "Панель Менеджера. " + User.Username + ", Здравствуйте!";
        }

        private void ManagerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            UserMgr.Instance.RemoveUser(User);
        }
    }
}
