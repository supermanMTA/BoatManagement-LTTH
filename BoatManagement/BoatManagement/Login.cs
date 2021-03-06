﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BoatManagement.ServiceLogin;

namespace BoatManagement
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var sv = new LoginSoapClient();
            var account = txtAccount.Text;
            var password = txtPassword.Text;
            if (sv.CheckLogin(account, password) == true)
            {
                MessageBox.Show("Login successfully!");
                this.Hide();
                Main main = new Main(txtAccount.Text);
                main.Show();
            }
            else
            {
                MessageBox.Show("Account is falsed! "); txtAccount.Text = ""; txtPassword.Text = "";
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

   
    }
}
