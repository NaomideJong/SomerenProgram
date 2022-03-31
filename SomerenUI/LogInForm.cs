using System;
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
            LogIn logIn = logInService.CheckPassword(userIdBox.Text, passwordBox.Text, SHA256.Create());
            if (IsValid())
            {
                if (logIn != null)
                {
                    bool adminStatus = false;
                    if (logIn.AdminStatus == "admin") adminStatus = true;
                    SomerenUI SomerenUI = new SomerenUI(adminStatus);
                    this.Hide();
                    SomerenUI.Show();
                }
                else
                {
                    MessageBox.Show("User email or password are inccorect.");
                }
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
