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
        const string LicenseKey = "XsZAb-tgz3PsD-qYh69un-WQCEx";
        public LogInForm()
        {
            InitializeComponent();
            pnlRegister.Hide();
        }

        private void logInButton_Click_1(object sender, EventArgs e)
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

        private void btnRegisterNewUser_Click(object sender, EventArgs e)
        {
            try
            {
                LogInService logInUserService = new LogInService();
                // check if the correct licensekey has been entered
                if (textBoxRegisterLicenseKey.Text != LicenseKey)
                {
                    MessageBox.Show("Please enter valid license key");
                } else
                {
                    logInUserService.AddUser(textBoxRegisterId.Text, comboBoxRegisterUser.Text, textBoxRegisterPassword.Text, SHA256.Create());
                    MessageBox.Show($"{textBoxRegisterId.Text} you have succesfully been registered, please login");
                    pnlRegister.Hide();
                    pnlLogin.Show();
                }
            }
            catch (Exception x)
            {
                // catch a error when something went wrong with the UI
                MessageBox.Show("Something went wrong while trying to register: " + x.Message);
            }
        }

        private void btnRegisterLogIn_Click(object sender, EventArgs e)
        {
            pnlRegister.Hide();
            pnlLogin.Show();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            pnlLogin.Hide();
            pnlRegister.Show();
        }
    }
}
