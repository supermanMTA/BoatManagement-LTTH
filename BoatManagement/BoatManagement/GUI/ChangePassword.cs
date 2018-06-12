using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BoatManagement.ServiceLogin;

namespace BoatManagement.GUI
{
    public partial class ChangePassword : Form
    {
        string nameaccount;
        public ChangePassword(string account)
        {
            InitializeComponent();
            nameaccount = account;
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            var sv =new  LoginSoapClient();
            var user = sv.getUser(nameaccount);
            if (txtPassold.Text != user.Password) MessageBox.Show("Old Password is false");
            else if (txtPassnew.Text != txtConfirm.Text) MessageBox.Show("New password is false");
            else
            {
                if (sv.updatepass(nameaccount, txtPassnew.Text) == true)
                    MessageBox.Show("Change password successfully");
                    }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
