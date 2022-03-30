﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SomerenLogic;
using SomerenModel;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace SomerenUI
{
    public partial class LogInForm : Form
    {
        public LogInForm()
        {
            InitializeComponent();
        }

        private void logInButton_Click(object sender, EventArgs e)
        {
            LogInService logInService = new LogInService();
            LogIn logIn = logInService.GetById(userIdBox.Text);
            if (logInService.CheckPassword(logIn.UserId, passwordBox.Text, logIn.PasswordSalt, logIn.PasswordDigest, SHA256.Create()))
            {
                MessageBox.Show("yeh");
            }
            else
            {
                MessageBox.Show("nop");
            }

            if (IsValid())
            {
               // SomerenUI SomerenUI = new SomerenUI();
               // this.Hide();
               // SomerenUI.Show();
            }
        }

        private bool IsValid()
        {
            if(userIdBox.Text == string.Empty)
            {
                MessageBox.Show("Please enter a valid username.");
                return false;
            }
            else if (passwordBox.Text == string.Empty)
            {
                MessageBox.Show("Please enter a valid password.");
                return false;
            }
            return true;
        }
    }
}
