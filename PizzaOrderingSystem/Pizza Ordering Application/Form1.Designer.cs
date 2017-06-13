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
            this.LoginPanel = new System.Windows.Forms.Panel();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.LoginPage = new System.Windows.Forms.TabPage();
            this.LoginButton = new System.Windows.Forms.Button();
            this.PasswordL = new System.Windows.Forms.TextBox();
            this.UsernameL = new System.Windows.Forms.TextBox();
            this.PasswordLabelL = new System.Windows.Forms.Label();
            this.UsernameLabelL = new System.Windows.Forms.Label();
            this.RegisterPage = new System.Windows.Forms.TabPage();
            this.LastName = new System.Windows.Forms.TextBox();
            this.FirstName = new System.Windows.Forms.TextBox();
            this.UsernameR = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.TextBox();
            this.PasswordR = new System.Windows.Forms.TextBox();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.UsernameLabelR = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.RegisterButton = new System.Windows.Forms.Button();
            this.PasswordLabelR = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SPizzaLabel = new System.Windows.Forms.Label();
            this.LPizzaLabel = new System.Windows.Forms.Label();
            this.MPizzaLabel = new System.Windows.Forms.Label();
            this.OrderSPizza = new System.Windows.Forms.Button();
            this.OrderLPizza = new System.Windows.Forms.Button();
            this.OrderMPizza = new System.Windows.Forms.Button();
            this.CartButton = new System.Windows.Forms.Button();
            this.AccountButton = new System.Windows.Forms.Button();
            this.MainMenuPanel = new System.Windows.Forms.Panel();
            this.LoginPanel.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.LoginPage.SuspendLayout();
            this.RegisterPage.SuspendLayout();
            this.MainMenuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoginPanel
            // 
            this.LoginPanel.Controls.Add(this.tabControl);
            this.LoginPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LoginPanel.Location = new System.Drawing.Point(0, 0);
            this.LoginPanel.Name = "LoginPanel";
            this.LoginPanel.Size = new System.Drawing.Size(539, 643);
            this.LoginPanel.TabIndex = 0;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.LoginPage);
            this.tabControl.Controls.Add(this.RegisterPage);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(515, 619);
            this.tabControl.TabIndex = 2;
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
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(219, 512);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(75, 23);
            this.LoginButton.TabIndex = 4;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // PasswordL
            // 
            this.PasswordL.Location = new System.Drawing.Point(244, 449);
            this.PasswordL.Name = "PasswordL";
            this.PasswordL.Size = new System.Drawing.Size(100, 20);
            this.PasswordL.TabIndex = 3;
            // 
            // UsernameL
            // 
            this.UsernameL.Location = new System.Drawing.Point(244, 394);
            this.UsernameL.Name = "UsernameL";
            this.UsernameL.Size = new System.Drawing.Size(100, 20);
            this.UsernameL.TabIndex = 2;
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
            // UsernameLabelL
            // 
            this.UsernameLabelL.AutoSize = true;
            this.UsernameLabelL.Location = new System.Drawing.Point(164, 394);
            this.UsernameLabelL.Name = "UsernameLabelL";
            this.UsernameLabelL.Size = new System.Drawing.Size(58, 13);
            this.UsernameLabelL.TabIndex = 0;
            this.UsernameLabelL.Text = "Username:";
            // 
            // RegisterPage
            // 
            this.RegisterPage.Controls.Add(this.LastName);
            this.RegisterPage.Controls.Add(this.FirstName);
            this.RegisterPage.Controls.Add(this.UsernameR);
            this.RegisterPage.Controls.Add(this.Email);
            this.RegisterPage.Controls.Add(this.PasswordR);
            this.RegisterPage.Controls.Add(this.LastNameLabel);
            this.RegisterPage.Controls.Add(this.FirstNameLabel);
            this.RegisterPage.Controls.Add(this.UsernameLabelR);
            this.RegisterPage.Controls.Add(this.EmailLabel);
            this.RegisterPage.Controls.Add(this.RegisterButton);
            this.RegisterPage.Controls.Add(this.PasswordLabelR);
            this.RegisterPage.Location = new System.Drawing.Point(4, 22);
            this.RegisterPage.Name = "RegisterPage";
            this.RegisterPage.Padding = new System.Windows.Forms.Padding(3);
            this.RegisterPage.Size = new System.Drawing.Size(507, 593);
            this.RegisterPage.TabIndex = 1;
            this.RegisterPage.Text = "Register";
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
            // PasswordR
            // 
            this.PasswordR.Location = new System.Drawing.Point(254, 453);
            this.PasswordR.Name = "PasswordR";
            this.PasswordR.Size = new System.Drawing.Size(100, 20);
            this.PasswordR.TabIndex = 7;
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
            // RegisterButton
            // 
            this.RegisterButton.Location = new System.Drawing.Point(219, 515);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(75, 23);
            this.RegisterButton.TabIndex = 9;
            this.RegisterButton.Text = "Register";
            this.RegisterButton.UseVisualStyleBackColor = true;
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(232, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Main Menu";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // SPizzaLabel
            // 
            this.SPizzaLabel.AutoSize = true;
            this.SPizzaLabel.Location = new System.Drawing.Point(155, 267);
            this.SPizzaLabel.Name = "SPizzaLabel";
            this.SPizzaLabel.Size = new System.Drawing.Size(60, 13);
            this.SPizzaLabel.TabIndex = 3;
            this.SPizzaLabel.Text = "Small Pizza";
            // 
            // LPizzaLabel
            // 
            this.LPizzaLabel.AutoSize = true;
            this.LPizzaLabel.Location = new System.Drawing.Point(152, 374);
            this.LPizzaLabel.Name = "LPizzaLabel";
            this.LPizzaLabel.Size = new System.Drawing.Size(62, 13);
            this.LPizzaLabel.TabIndex = 4;
            this.LPizzaLabel.Text = "Large Pizza";
            // 
            // MPizzaLabel
            // 
            this.MPizzaLabel.AutoSize = true;
            this.MPizzaLabel.Location = new System.Drawing.Point(152, 322);
            this.MPizzaLabel.Name = "MPizzaLabel";
            this.MPizzaLabel.Size = new System.Drawing.Size(72, 13);
            this.MPizzaLabel.TabIndex = 5;
            this.MPizzaLabel.Text = "Medium Pizza";
            // 
            // OrderSPizza
            // 
            this.OrderSPizza.Location = new System.Drawing.Point(285, 262);
            this.OrderSPizza.Name = "OrderSPizza";
            this.OrderSPizza.Size = new System.Drawing.Size(75, 23);
            this.OrderSPizza.TabIndex = 6;
            this.OrderSPizza.Text = "Order Now";
            this.OrderSPizza.UseVisualStyleBackColor = true;
            // 
            // OrderLPizza
            // 
            this.OrderLPizza.Location = new System.Drawing.Point(285, 369);
            this.OrderLPizza.Name = "OrderLPizza";
            this.OrderLPizza.Size = new System.Drawing.Size(75, 23);
            this.OrderLPizza.TabIndex = 7;
            this.OrderLPizza.Text = "Order Now";
            this.OrderLPizza.UseVisualStyleBackColor = true;
            // 
            // OrderMPizza
            // 
            this.OrderMPizza.Location = new System.Drawing.Point(285, 317);
            this.OrderMPizza.Name = "OrderMPizza";
            this.OrderMPizza.Size = new System.Drawing.Size(75, 23);
            this.OrderMPizza.TabIndex = 8;
            this.OrderMPizza.Text = "Order Now";
            this.OrderMPizza.UseVisualStyleBackColor = true;
            // 
            // CartButton
            // 
            this.CartButton.Location = new System.Drawing.Point(380, 94);
            this.CartButton.Name = "CartButton";
            this.CartButton.Size = new System.Drawing.Size(75, 23);
            this.CartButton.TabIndex = 9;
            this.CartButton.Text = "Cart";
            this.CartButton.UseVisualStyleBackColor = true;
            // 
            // AccountButton
            // 
            this.AccountButton.Location = new System.Drawing.Point(84, 94);
            this.AccountButton.Name = "AccountButton";
            this.AccountButton.Size = new System.Drawing.Size(75, 23);
            this.AccountButton.TabIndex = 10;
            this.AccountButton.Text = "Account";
            this.AccountButton.UseVisualStyleBackColor = true;
            // 
            // MainMenuPanel
            // 
            this.MainMenuPanel.Controls.Add(this.AccountButton);
            this.MainMenuPanel.Controls.Add(this.CartButton);
            this.MainMenuPanel.Controls.Add(this.OrderMPizza);
            this.MainMenuPanel.Controls.Add(this.OrderLPizza);
            this.MainMenuPanel.Controls.Add(this.OrderSPizza);
            this.MainMenuPanel.Controls.Add(this.MPizzaLabel);
            this.MainMenuPanel.Controls.Add(this.LPizzaLabel);
            this.MainMenuPanel.Controls.Add(this.SPizzaLabel);
            this.MainMenuPanel.Controls.Add(this.label1);
            this.MainMenuPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainMenuPanel.Location = new System.Drawing.Point(0, 0);
            this.MainMenuPanel.Name = "MainMenuPanel";
            this.MainMenuPanel.Size = new System.Drawing.Size(539, 643);
            this.MainMenuPanel.TabIndex = 2;
            this.MainMenuPanel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 643);
            this.Controls.Add(this.MainMenuPanel);
            this.Controls.Add(this.LoginPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.LoginPanel.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.LoginPage.ResumeLayout(false);
            this.LoginPage.PerformLayout();
            this.RegisterPage.ResumeLayout(false);
            this.RegisterPage.PerformLayout();
            this.MainMenuPanel.ResumeLayout(false);
            this.MainMenuPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel LoginPanel;
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
        private System.Windows.Forms.TextBox UsernameR;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.TextBox PasswordR;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.Label UsernameLabelR;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Button RegisterButton;
        private System.Windows.Forms.Label PasswordLabelR;
        private System.Windows.Forms.Panel MainMenuPanel;
        private System.Windows.Forms.Button AccountButton;
        private System.Windows.Forms.Button CartButton;
        private System.Windows.Forms.Button OrderMPizza;
        private System.Windows.Forms.Button OrderLPizza;
        private System.Windows.Forms.Button OrderSPizza;
        private System.Windows.Forms.Label MPizzaLabel;
        private System.Windows.Forms.Label LPizzaLabel;
        private System.Windows.Forms.Label SPizzaLabel;
        private System.Windows.Forms.Label label1;
    }
}

