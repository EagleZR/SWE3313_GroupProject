namespace Pizza_Ordering_Application
{
    partial class Form1
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.LoginPage = new System.Windows.Forms.TabPage();
            this.RegisterPage = new System.Windows.Forms.TabPage();
            this.UsernameLabelL = new System.Windows.Forms.Label();
            this.PasswordLabelL = new System.Windows.Forms.Label();
            this.UsernameL = new System.Windows.Forms.TextBox();
            this.PasswordL = new System.Windows.Forms.TextBox();
            this.LoginButton = new System.Windows.Forms.Button();
            this.RegisterButton = new System.Windows.Forms.Button();
            this.PasswordR = new System.Windows.Forms.TextBox();
            this.PasswordLabelR = new System.Windows.Forms.Label();
            this.UsernameR = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.TextBox();
            this.UsernameLabelR = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.LastName = new System.Windows.Forms.TextBox();
            this.FirstName = new System.Windows.Forms.TextBox();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.LoginPage.SuspendLayout();
            this.RegisterPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.LoginPage);
            this.tabControl.Controls.Add(this.RegisterPage);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(515, 619);
            this.tabControl.TabIndex = 0;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // LoginPage
            // 
            this.LoginPage.Controls.Add(this.LoginButton);
            this.LoginPage.Controls.Add(this.PasswordL);
            this.LoginPage.Controls.Add(this.UsernameL);
            this.LoginPage.Controls.Add(this.PasswordLabelL);
            this.LoginPage.Controls.Add(this.UsernameLabelL);
            this.LoginPage.Location = new System.Drawing.Point(4, 22);
            this.LoginPage.Name = "LoginPage";
            this.LoginPage.Padding = new System.Windows.Forms.Padding(3);
            this.LoginPage.Size = new System.Drawing.Size(507, 593);
            this.LoginPage.TabIndex = 0;
            this.LoginPage.Text = "Login";
            // 
            // RegisterPage
            // 
            this.RegisterPage.Controls.Add(this.LastName);
            this.RegisterPage.Controls.Add(this.FirstName);
            this.RegisterPage.Controls.Add(this.LastNameLabel);
            this.RegisterPage.Controls.Add(this.FirstNameLabel);
            this.RegisterPage.Controls.Add(this.UsernameR);
            this.RegisterPage.Controls.Add(this.Email);
            this.RegisterPage.Controls.Add(this.UsernameLabelR);
            this.RegisterPage.Controls.Add(this.EmailLabel);
            this.RegisterPage.Controls.Add(this.RegisterButton);
            this.RegisterPage.Controls.Add(this.PasswordR);
            this.RegisterPage.Controls.Add(this.PasswordLabelR);
            this.RegisterPage.Location = new System.Drawing.Point(4, 22);
            this.RegisterPage.Name = "RegisterPage";
            this.RegisterPage.Padding = new System.Windows.Forms.Padding(3);
            this.RegisterPage.Size = new System.Drawing.Size(507, 593);
            this.RegisterPage.TabIndex = 1;
            this.RegisterPage.Text = "Register";
            // 
            // UsernameLabelL
            // 
            this.UsernameLabelL.AutoSize = true;
            this.UsernameLabelL.Location = new System.Drawing.Point(164, 394);
            this.UsernameLabelL.Name = "UsernameLabelL";
            this.UsernameLabelL.Size = new System.Drawing.Size(58, 13);
            this.UsernameLabelL.TabIndex = 0;
            this.UsernameLabelL.Text = "Username:";
            // 
            // PasswordLabelL
            // 
            this.PasswordLabelL.AutoSize = true;
            this.PasswordLabelL.Location = new System.Drawing.Point(164, 449);
            this.PasswordLabelL.Name = "PasswordLabelL";
            this.PasswordLabelL.Size = new System.Drawing.Size(56, 13);
            this.PasswordLabelL.TabIndex = 1;
            this.PasswordLabelL.Text = "Password:";
            // 
            // UsernameL
            // 
            this.UsernameL.Location = new System.Drawing.Point(244, 394);
            this.UsernameL.Name = "UsernameL";
            this.UsernameL.Size = new System.Drawing.Size(100, 20);
            this.UsernameL.TabIndex = 2;
            // 
            // PasswordL
            // 
            this.PasswordL.Location = new System.Drawing.Point(244, 449);
            this.PasswordL.Name = "PasswordL";
            this.PasswordL.Size = new System.Drawing.Size(100, 20);
            this.PasswordL.TabIndex = 3;
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(219, 512);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(75, 23);
            this.LoginButton.TabIndex = 4;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            // 
            // RegisterButton
            // 
            this.RegisterButton.Location = new System.Drawing.Point(219, 515);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(75, 23);
            this.RegisterButton.TabIndex = 9;
            this.RegisterButton.Text = "Register";
            this.RegisterButton.UseVisualStyleBackColor = true;
            // 
            // PasswordR
            // 
            this.PasswordR.Location = new System.Drawing.Point(254, 453);
            this.PasswordR.Name = "PasswordR";
            this.PasswordR.Size = new System.Drawing.Size(100, 20);
            this.PasswordR.TabIndex = 7;
            // 
            // PasswordLabelR
            // 
            this.PasswordLabelR.AutoSize = true;
            this.PasswordLabelR.Location = new System.Drawing.Point(174, 453);
            this.PasswordLabelR.Name = "PasswordLabelR";
            this.PasswordLabelR.Size = new System.Drawing.Size(56, 13);
            this.PasswordLabelR.TabIndex = 5;
            this.PasswordLabelR.Text = "Password:";
            // 
            // UsernameR
            // 
            this.UsernameR.Location = new System.Drawing.Point(254, 405);
            this.UsernameR.Name = "UsernameR";
            this.UsernameR.Size = new System.Drawing.Size(100, 20);
            this.UsernameR.TabIndex = 13;
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(254, 350);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(100, 20);
            this.Email.TabIndex = 12;
            // 
            // UsernameLabelR
            // 
            this.UsernameLabelR.AutoSize = true;
            this.UsernameLabelR.Location = new System.Drawing.Point(174, 405);
            this.UsernameLabelR.Name = "UsernameLabelR";
            this.UsernameLabelR.Size = new System.Drawing.Size(58, 13);
            this.UsernameLabelR.TabIndex = 11;
            this.UsernameLabelR.Text = "Username:";
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Location = new System.Drawing.Point(174, 350);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(35, 13);
            this.EmailLabel.TabIndex = 10;
            this.EmailLabel.Text = "Email:";
            // 
            // LastName
            // 
            this.LastName.Location = new System.Drawing.Point(254, 296);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(100, 20);
            this.LastName.TabIndex = 17;
            // 
            // FirstName
            // 
            this.FirstName.Location = new System.Drawing.Point(254, 241);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(100, 20);
            this.FirstName.TabIndex = 16;
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Location = new System.Drawing.Point(174, 296);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(61, 13);
            this.LastNameLabel.TabIndex = 15;
            this.LastNameLabel.Text = "Last Name:";
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Location = new System.Drawing.Point(174, 241);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(60, 13);
            this.FirstNameLabel.TabIndex = 14;
            this.FirstNameLabel.Text = "First Name:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 643);
            this.Controls.Add(this.tabControl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl.ResumeLayout(false);
            this.LoginPage.ResumeLayout(false);
            this.LoginPage.PerformLayout();
            this.RegisterPage.ResumeLayout(false);
            this.RegisterPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage LoginPage;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.TextBox PasswordL;
        private System.Windows.Forms.TextBox UsernameL;
        private System.Windows.Forms.Label PasswordLabelL;
        private System.Windows.Forms.Label UsernameLabelL;
        private System.Windows.Forms.TabPage RegisterPage;
        private System.Windows.Forms.TextBox LastName;
        private System.Windows.Forms.TextBox FirstName;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.TextBox UsernameR;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.Label UsernameLabelR;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Button RegisterButton;
        private System.Windows.Forms.TextBox PasswordR;
        private System.Windows.Forms.Label PasswordLabelR;
    }
}

