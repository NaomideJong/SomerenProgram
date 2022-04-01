
namespace SomerenUI
{
    partial class LogInForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogInForm));
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.logInButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.registerButton = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.userIdBox = new System.Windows.Forms.TextBox();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.pnlRegister = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxRegisterUser = new System.Windows.Forms.ComboBox();
            this.lblLicenseKey = new System.Windows.Forms.Label();
            this.lblRegister = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnRegisterNewUser = new System.Windows.Forms.Button();
            this.lblRegisterId = new System.Windows.Forms.Label();
            this.btnRegisterLogIn = new System.Windows.Forms.Button();
            this.textBoxRegisterId = new System.Windows.Forms.TextBox();
            this.textBoxRegisterPassword = new System.Windows.Forms.TextBox();
            this.lblRegisterPassword = new System.Windows.Forms.Label();
            this.textBoxRegisterLicenseKey = new System.Windows.Forms.TextBox();
            this.pnlLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.pnlRegister.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlLogin
            // 
            this.pnlLogin.Controls.Add(this.logInButton);
            this.pnlLogin.Controls.Add(this.label7);
            this.pnlLogin.Controls.Add(this.pictureBox3);
            this.pnlLogin.Controls.Add(this.registerButton);
            this.pnlLogin.Controls.Add(this.label11);
            this.pnlLogin.Controls.Add(this.userIdBox);
            this.pnlLogin.Controls.Add(this.passwordBox);
            this.pnlLogin.Controls.Add(this.label12);
            this.pnlLogin.Location = new System.Drawing.Point(5, 12);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(776, 426);
            this.pnlLogin.TabIndex = 18;
            // 
            // logInButton
            // 
            this.logInButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logInButton.Location = new System.Drawing.Point(256, 253);
            this.logInButton.Name = "logInButton";
            this.logInButton.Size = new System.Drawing.Size(254, 48);
            this.logInButton.TabIndex = 17;
            this.logInButton.Text = "Log In";
            this.logInButton.UseVisualStyleBackColor = true;
            this.logInButton.Click += new System.EventHandler(this.logInButton_Click_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(14, 20);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 33);
            this.label7.TabIndex = 4;
            this.label7.Text = "Log In";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::SomerenUI.Properties.Resources.someren;
            this.pictureBox3.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.InitialImage")));
            this.pictureBox3.Location = new System.Drawing.Point(627, 4);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(145, 121);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // registerButton
            // 
            this.registerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerButton.Location = new System.Drawing.Point(256, 336);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(254, 48);
            this.registerButton.TabIndex = 13;
            this.registerButton.Text = "Register";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(252, 82);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(273, 20);
            this.label11.TabIndex = 7;
            this.label11.Text = "User e-mail (example@email.com):";
            // 
            // userIdBox
            // 
            this.userIdBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userIdBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.userIdBox.Location = new System.Drawing.Point(236, 119);
            this.userIdBox.Name = "userIdBox";
            this.userIdBox.Size = new System.Drawing.Size(299, 28);
            this.userIdBox.TabIndex = 8;
            // 
            // passwordBox
            // 
            this.passwordBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordBox.Location = new System.Drawing.Point(236, 194);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.PasswordChar = '*';
            this.passwordBox.Size = new System.Drawing.Size(299, 28);
            this.passwordBox.TabIndex = 10;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(345, 160);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(88, 20);
            this.label12.TabIndex = 11;
            this.label12.Text = "Password:";
            // 
            // pnlRegister
            // 
            this.pnlRegister.Controls.Add(this.textBoxRegisterLicenseKey);
            this.pnlRegister.Controls.Add(this.label1);
            this.pnlRegister.Controls.Add(this.comboBoxRegisterUser);
            this.pnlRegister.Controls.Add(this.lblLicenseKey);
            this.pnlRegister.Controls.Add(this.lblRegister);
            this.pnlRegister.Controls.Add(this.pictureBox1);
            this.pnlRegister.Controls.Add(this.btnRegisterNewUser);
            this.pnlRegister.Controls.Add(this.lblRegisterId);
            this.pnlRegister.Controls.Add(this.btnRegisterLogIn);
            this.pnlRegister.Controls.Add(this.textBoxRegisterId);
            this.pnlRegister.Controls.Add(this.textBoxRegisterPassword);
            this.pnlRegister.Controls.Add(this.lblRegisterPassword);
            this.pnlRegister.Location = new System.Drawing.Point(8, 12);
            this.pnlRegister.Name = "pnlRegister";
            this.pnlRegister.Size = new System.Drawing.Size(776, 426);
            this.pnlRegister.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(336, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Admin Status:";
            // 
            // comboBoxRegisterUser
            // 
            this.comboBoxRegisterUser.FormattingEnabled = true;
            this.comboBoxRegisterUser.Items.AddRange(new object[] {
            "user",
            "admin"});
            this.comboBoxRegisterUser.Location = new System.Drawing.Point(236, 227);
            this.comboBoxRegisterUser.Name = "comboBoxRegisterUser";
            this.comboBoxRegisterUser.Size = new System.Drawing.Size(299, 24);
            this.comboBoxRegisterUser.TabIndex = 17;
            // 
            // lblLicenseKey
            // 
            this.lblLicenseKey.AutoSize = true;
            this.lblLicenseKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLicenseKey.Location = new System.Drawing.Point(336, 150);
            this.lblLicenseKey.Name = "lblLicenseKey";
            this.lblLicenseKey.Size = new System.Drawing.Size(106, 20);
            this.lblLicenseKey.TabIndex = 15;
            this.lblLicenseKey.Text = "License Key:";
            // 
            // lblRegister
            // 
            this.lblRegister.AutoSize = true;
            this.lblRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegister.Location = new System.Drawing.Point(14, 20);
            this.lblRegister.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRegister.Name = "lblRegister";
            this.lblRegister.Size = new System.Drawing.Size(124, 33);
            this.lblRegister.TabIndex = 4;
            this.lblRegister.Text = "Register";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SomerenUI.Properties.Resources.someren;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(627, 4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(145, 121);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnRegisterNewUser
            // 
            this.btnRegisterNewUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegisterNewUser.Location = new System.Drawing.Point(256, 272);
            this.btnRegisterNewUser.Name = "btnRegisterNewUser";
            this.btnRegisterNewUser.Size = new System.Drawing.Size(254, 48);
            this.btnRegisterNewUser.TabIndex = 13;
            this.btnRegisterNewUser.Text = "Register new user";
            this.btnRegisterNewUser.UseVisualStyleBackColor = true;
            this.btnRegisterNewUser.Click += new System.EventHandler(this.btnRegisterNewUser_Click);
            // 
            // lblRegisterId
            // 
            this.lblRegisterId.AutoSize = true;
            this.lblRegisterId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegisterId.Location = new System.Drawing.Point(252, 42);
            this.lblRegisterId.Name = "lblRegisterId";
            this.lblRegisterId.Size = new System.Drawing.Size(273, 20);
            this.lblRegisterId.TabIndex = 7;
            this.lblRegisterId.Text = "User e-mail (example@email.com):";
            // 
            // btnRegisterLogIn
            // 
            this.btnRegisterLogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegisterLogIn.Location = new System.Drawing.Point(256, 350);
            this.btnRegisterLogIn.Name = "btnRegisterLogIn";
            this.btnRegisterLogIn.Size = new System.Drawing.Size(254, 48);
            this.btnRegisterLogIn.TabIndex = 12;
            this.btnRegisterLogIn.Text = "Go back to Log In page";
            this.btnRegisterLogIn.UseVisualStyleBackColor = true;
            this.btnRegisterLogIn.Click += new System.EventHandler(this.btnRegisterLogIn_Click);
            // 
            // textBoxRegisterId
            // 
            this.textBoxRegisterId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRegisterId.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxRegisterId.Location = new System.Drawing.Point(236, 65);
            this.textBoxRegisterId.Name = "textBoxRegisterId";
            this.textBoxRegisterId.Size = new System.Drawing.Size(299, 28);
            this.textBoxRegisterId.TabIndex = 8;
            // 
            // textBoxRegisterPassword
            // 
            this.textBoxRegisterPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRegisterPassword.Location = new System.Drawing.Point(236, 119);
            this.textBoxRegisterPassword.Name = "textBoxRegisterPassword";
            this.textBoxRegisterPassword.PasswordChar = '*';
            this.textBoxRegisterPassword.Size = new System.Drawing.Size(299, 28);
            this.textBoxRegisterPassword.TabIndex = 10;
            // 
            // lblRegisterPassword
            // 
            this.lblRegisterPassword.AutoSize = true;
            this.lblRegisterPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegisterPassword.Location = new System.Drawing.Point(345, 96);
            this.lblRegisterPassword.Name = "lblRegisterPassword";
            this.lblRegisterPassword.Size = new System.Drawing.Size(88, 20);
            this.lblRegisterPassword.TabIndex = 11;
            this.lblRegisterPassword.Text = "Password:";
            // 
            // textBoxRegisterLicenseKey
            // 
            this.textBoxRegisterLicenseKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRegisterLicenseKey.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxRegisterLicenseKey.Location = new System.Drawing.Point(236, 173);
            this.textBoxRegisterLicenseKey.Name = "textBoxRegisterLicenseKey";
            this.textBoxRegisterLicenseKey.Size = new System.Drawing.Size(299, 28);
            this.textBoxRegisterLicenseKey.TabIndex = 19;
            // 
            // LogInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlRegister);
            this.Controls.Add(this.pnlLogin);
            this.Name = "LogInForm";
            this.Text = "Log In";
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.pnlRegister.ResumeLayout(false);
            this.pnlRegister.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.Panel pnlRegister;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxRegisterUser;
        private System.Windows.Forms.Label lblLicenseKey;
        private System.Windows.Forms.Label lblRegister;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnRegisterNewUser;
        private System.Windows.Forms.Label lblRegisterId;
        private System.Windows.Forms.Button btnRegisterLogIn;
        private System.Windows.Forms.TextBox textBoxRegisterId;
        private System.Windows.Forms.TextBox textBoxRegisterPassword;
        private System.Windows.Forms.Label lblRegisterPassword;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox userIdBox;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button logInButton;
        private System.Windows.Forms.TextBox textBoxRegisterLicenseKey;
    }
}