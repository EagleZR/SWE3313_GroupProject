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
            this.ItemCustomizationPanel = new System.Windows.Forms.Panel();
            this.PizzaSizeLabel = new System.Windows.Forms.Label();
            this.CrustLabel = new System.Windows.Forms.Label();
            this.PanCrustRadio = new System.Windows.Forms.RadioButton();
            this.ThinCrustRadio = new System.Windows.Forms.RadioButton();
            this.OriginalCrustRadio = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Meats = new System.Windows.Forms.CheckedListBox();
            this.Cheeses = new System.Windows.Forms.CheckedListBox();
            this.Vegetables = new System.Windows.Forms.CheckedListBox();
            this.AddToCartButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.ItemCustomizationTitle = new System.Windows.Forms.Label();
            this.MeatToppingsAmount = new System.Windows.Forms.GroupBox();
            this.LessM = new System.Windows.Forms.RadioButton();
            this.NormalM = new System.Windows.Forms.RadioButton();
            this.MoreM = new System.Windows.Forms.RadioButton();
            this.VeggiesToppingsAmount = new System.Windows.Forms.GroupBox();
            this.MoreV = new System.Windows.Forms.RadioButton();
            this.NormalV = new System.Windows.Forms.RadioButton();
            this.LessV = new System.Windows.Forms.RadioButton();
            this.CheesesAmount = new System.Windows.Forms.GroupBox();
            this.MoreC = new System.Windows.Forms.RadioButton();
            this.NormalC = new System.Windows.Forms.RadioButton();
            this.LessC = new System.Windows.Forms.RadioButton();
            this.LoginPanel.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.LoginPage.SuspendLayout();
            this.RegisterPage.SuspendLayout();
            this.MainMenuPanel.SuspendLayout();
            this.ItemCustomizationPanel.SuspendLayout();
            this.MeatToppingsAmount.SuspendLayout();
            this.VeggiesToppingsAmount.SuspendLayout();
            this.CheesesAmount.SuspendLayout();
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
            this.OrderSPizza.Click += new System.EventHandler(this.OrderSPizza_Click);
            // 
            // OrderLPizza
            // 
            this.OrderLPizza.Location = new System.Drawing.Point(285, 369);
            this.OrderLPizza.Name = "OrderLPizza";
            this.OrderLPizza.Size = new System.Drawing.Size(75, 23);
            this.OrderLPizza.TabIndex = 7;
            this.OrderLPizza.Text = "Order Now";
            this.OrderLPizza.UseVisualStyleBackColor = true;
            this.OrderLPizza.Click += new System.EventHandler(this.OrderLPizza_Click);
            // 
            // OrderMPizza
            // 
            this.OrderMPizza.Location = new System.Drawing.Point(285, 317);
            this.OrderMPizza.Name = "OrderMPizza";
            this.OrderMPizza.Size = new System.Drawing.Size(75, 23);
            this.OrderMPizza.TabIndex = 8;
            this.OrderMPizza.Text = "Order Now";
            this.OrderMPizza.UseVisualStyleBackColor = true;
            this.OrderMPizza.Click += new System.EventHandler(this.OrderMPizza_Click);
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
            this.MainMenuPanel.Controls.Add(this.ItemCustomizationPanel);
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
            // ItemCustomizationPanel
            // 
            this.ItemCustomizationPanel.Controls.Add(this.CheesesAmount);
            this.ItemCustomizationPanel.Controls.Add(this.VeggiesToppingsAmount);
            this.ItemCustomizationPanel.Controls.Add(this.MeatToppingsAmount);
            this.ItemCustomizationPanel.Controls.Add(this.PizzaSizeLabel);
            this.ItemCustomizationPanel.Controls.Add(this.CrustLabel);
            this.ItemCustomizationPanel.Controls.Add(this.PanCrustRadio);
            this.ItemCustomizationPanel.Controls.Add(this.ThinCrustRadio);
            this.ItemCustomizationPanel.Controls.Add(this.OriginalCrustRadio);
            this.ItemCustomizationPanel.Controls.Add(this.label5);
            this.ItemCustomizationPanel.Controls.Add(this.label4);
            this.ItemCustomizationPanel.Controls.Add(this.label2);
            this.ItemCustomizationPanel.Controls.Add(this.Meats);
            this.ItemCustomizationPanel.Controls.Add(this.Cheeses);
            this.ItemCustomizationPanel.Controls.Add(this.Vegetables);
            this.ItemCustomizationPanel.Controls.Add(this.AddToCartButton);
            this.ItemCustomizationPanel.Controls.Add(this.BackButton);
            this.ItemCustomizationPanel.Controls.Add(this.ItemCustomizationTitle);
            this.ItemCustomizationPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ItemCustomizationPanel.Location = new System.Drawing.Point(0, 0);
            this.ItemCustomizationPanel.Name = "ItemCustomizationPanel";
            this.ItemCustomizationPanel.Size = new System.Drawing.Size(539, 643);
            this.ItemCustomizationPanel.TabIndex = 11;
            this.ItemCustomizationPanel.Visible = false;
            // 
            // PizzaSizeLabel
            // 
            this.PizzaSizeLabel.AutoSize = true;
            this.PizzaSizeLabel.Location = new System.Drawing.Point(223, 67);
            this.PizzaSizeLabel.Name = "PizzaSizeLabel";
            this.PizzaSizeLabel.Size = new System.Drawing.Size(55, 13);
            this.PizzaSizeLabel.TabIndex = 15;
            this.PizzaSizeLabel.Text = "Pizza Size";
            // 
            // CrustLabel
            // 
            this.CrustLabel.AutoSize = true;
            this.CrustLabel.Location = new System.Drawing.Point(222, 517);
            this.CrustLabel.Name = "CrustLabel";
            this.CrustLabel.Size = new System.Drawing.Size(36, 13);
            this.CrustLabel.TabIndex = 14;
            this.CrustLabel.Text = "Crusts";
            // 
            // PanCrustRadio
            // 
            this.PanCrustRadio.AutoSize = true;
            this.PanCrustRadio.Location = new System.Drawing.Point(346, 546);
            this.PanCrustRadio.Name = "PanCrustRadio";
            this.PanCrustRadio.Size = new System.Drawing.Size(44, 17);
            this.PanCrustRadio.TabIndex = 13;
            this.PanCrustRadio.TabStop = true;
            this.PanCrustRadio.Text = "Pan";
            this.PanCrustRadio.UseVisualStyleBackColor = true;
            // 
            // ThinCrustRadio
            // 
            this.ThinCrustRadio.AutoSize = true;
            this.ThinCrustRadio.Location = new System.Drawing.Point(225, 546);
            this.ThinCrustRadio.Name = "ThinCrustRadio";
            this.ThinCrustRadio.Size = new System.Drawing.Size(46, 17);
            this.ThinCrustRadio.TabIndex = 12;
            this.ThinCrustRadio.TabStop = true;
            this.ThinCrustRadio.Text = "Thin";
            this.ThinCrustRadio.UseVisualStyleBackColor = true;
            // 
            // OriginalCrustRadio
            // 
            this.OriginalCrustRadio.AutoSize = true;
            this.OriginalCrustRadio.Location = new System.Drawing.Point(84, 546);
            this.OriginalCrustRadio.Name = "OriginalCrustRadio";
            this.OriginalCrustRadio.Size = new System.Drawing.Size(60, 17);
            this.OriginalCrustRadio.TabIndex = 11;
            this.OriginalCrustRadio.TabStop = true;
            this.OriginalCrustRadio.Text = "Original";
            this.OriginalCrustRadio.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 379);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Cheeses";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Vegetables";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Meats";
            // 
            // Meats
            // 
            this.Meats.CheckOnClick = true;
            this.Meats.FormattingEnabled = true;
            this.Meats.Items.AddRange(new object[] {
            "Pepperoni",
            "Grilled Chicken",
            "Beef",
            "Spicy Italian Sausage",
            "Bacon",
            "Sausage",
            "Anchovies",
            "Canadian Bacon"});
            this.Meats.Location = new System.Drawing.Point(33, 115);
            this.Meats.Name = "Meats";
            this.Meats.Size = new System.Drawing.Size(378, 94);
            this.Meats.TabIndex = 6;
            this.Meats.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.Meats_ItemCheck);
            // 
            // Cheeses
            // 
            this.Cheeses.CheckOnClick = true;
            this.Cheeses.FormattingEnabled = true;
            this.Cheeses.Items.AddRange(new object[] {
            "Extra Cheese",
            "3-Cheese Blend",
            "Parmesan Romano",
            "Cheddar Cheese"});
            this.Cheeses.Location = new System.Drawing.Point(33, 402);
            this.Cheeses.Name = "Cheeses";
            this.Cheeses.Size = new System.Drawing.Size(378, 94);
            this.Cheeses.TabIndex = 4;
            this.Cheeses.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.Cheeses_ItemCheck);
            // 
            // Vegetables
            // 
            this.Vegetables.CheckOnClick = true;
            this.Vegetables.FormattingEnabled = true;
            this.Vegetables.Items.AddRange(new object[] {
            "Pickles",
            "Green Peppers",
            "Mushrooms",
            "Roma Tomatoes",
            "Pineapple",
            "Onions",
            "Black Olives",
            "Jalapeno Peppers",
            "Banana Peppers"});
            this.Vegetables.Location = new System.Drawing.Point(33, 262);
            this.Vegetables.Name = "Vegetables";
            this.Vegetables.Size = new System.Drawing.Size(378, 94);
            this.Vegetables.TabIndex = 3;
            this.Vegetables.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.Vegetables_ItemCheck);
            // 
            // AddToCartButton
            // 
            this.AddToCartButton.Location = new System.Drawing.Point(364, 32);
            this.AddToCartButton.Name = "AddToCartButton";
            this.AddToCartButton.Size = new System.Drawing.Size(75, 23);
            this.AddToCartButton.TabIndex = 2;
            this.AddToCartButton.Text = "Add To Cart";
            this.AddToCartButton.UseVisualStyleBackColor = true;
            this.AddToCartButton.Click += new System.EventHandler(this.AddToCartButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(61, 32);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 23);
            this.BackButton.TabIndex = 1;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // ItemCustomizationTitle
            // 
            this.ItemCustomizationTitle.AutoSize = true;
            this.ItemCustomizationTitle.Location = new System.Drawing.Point(206, 37);
            this.ItemCustomizationTitle.Name = "ItemCustomizationTitle";
            this.ItemCustomizationTitle.Size = new System.Drawing.Size(95, 13);
            this.ItemCustomizationTitle.TabIndex = 0;
            this.ItemCustomizationTitle.Text = "Item Customization";
            // 
            // MeatToppingsAmount
            // 
            this.MeatToppingsAmount.Controls.Add(this.MoreM);
            this.MeatToppingsAmount.Controls.Add(this.NormalM);
            this.MeatToppingsAmount.Controls.Add(this.LessM);
            this.MeatToppingsAmount.Location = new System.Drawing.Point(417, 102);
            this.MeatToppingsAmount.Name = "MeatToppingsAmount";
            this.MeatToppingsAmount.Size = new System.Drawing.Size(106, 107);
            this.MeatToppingsAmount.TabIndex = 22;
            this.MeatToppingsAmount.TabStop = false;
            this.MeatToppingsAmount.Text = "ToppingsAmount";
            this.MeatToppingsAmount.Visible = false;
            // 
            // LessM
            // 
            this.LessM.AutoSize = true;
            this.LessM.Location = new System.Drawing.Point(2, 30);
            this.LessM.Name = "LessM";
            this.LessM.Size = new System.Drawing.Size(47, 17);
            this.LessM.TabIndex = 0;
            this.LessM.TabStop = true;
            this.LessM.Text = "Less";
            this.LessM.UseVisualStyleBackColor = true;
            this.LessM.Click += new System.EventHandler(this.LessM_Click);
            // 
            // NormalM
            // 
            this.NormalM.AutoSize = true;
            this.NormalM.Location = new System.Drawing.Point(2, 51);
            this.NormalM.Name = "NormalM";
            this.NormalM.Size = new System.Drawing.Size(58, 17);
            this.NormalM.TabIndex = 1;
            this.NormalM.TabStop = true;
            this.NormalM.Text = "Normal";
            this.NormalM.UseVisualStyleBackColor = true;
            this.NormalM.Click += new System.EventHandler(this.NormalM_Click);
            // 
            // MoreM
            // 
            this.MoreM.AutoSize = true;
            this.MoreM.Location = new System.Drawing.Point(2, 74);
            this.MoreM.Name = "MoreM";
            this.MoreM.Size = new System.Drawing.Size(49, 17);
            this.MoreM.TabIndex = 2;
            this.MoreM.TabStop = true;
            this.MoreM.Text = "More";
            this.MoreM.UseVisualStyleBackColor = true;
            this.MoreM.Click += new System.EventHandler(this.MoreM_Click);
            // 
            // VeggiesToppingsAmount
            // 
            this.VeggiesToppingsAmount.Controls.Add(this.MoreV);
            this.VeggiesToppingsAmount.Controls.Add(this.NormalV);
            this.VeggiesToppingsAmount.Controls.Add(this.LessV);
            this.VeggiesToppingsAmount.Location = new System.Drawing.Point(417, 249);
            this.VeggiesToppingsAmount.Name = "VeggiesToppingsAmount";
            this.VeggiesToppingsAmount.Size = new System.Drawing.Size(106, 107);
            this.VeggiesToppingsAmount.TabIndex = 23;
            this.VeggiesToppingsAmount.TabStop = false;
            this.VeggiesToppingsAmount.Text = "ToppingsAmount";
            this.VeggiesToppingsAmount.Visible = false;
            // 
            // MoreV
            // 
            this.MoreV.AutoSize = true;
            this.MoreV.Location = new System.Drawing.Point(2, 74);
            this.MoreV.Name = "MoreV";
            this.MoreV.Size = new System.Drawing.Size(49, 17);
            this.MoreV.TabIndex = 2;
            this.MoreV.TabStop = true;
            this.MoreV.Text = "More";
            this.MoreV.UseVisualStyleBackColor = true;
            this.MoreV.Click += new System.EventHandler(this.MoreV_Click);
            // 
            // NormalV
            // 
            this.NormalV.AutoSize = true;
            this.NormalV.Location = new System.Drawing.Point(2, 51);
            this.NormalV.Name = "NormalV";
            this.NormalV.Size = new System.Drawing.Size(58, 17);
            this.NormalV.TabIndex = 1;
            this.NormalV.TabStop = true;
            this.NormalV.Text = "Normal";
            this.NormalV.UseVisualStyleBackColor = true;
            this.NormalV.Click += new System.EventHandler(this.NormalV_Click);
            // 
            // LessV
            // 
            this.LessV.AutoSize = true;
            this.LessV.Location = new System.Drawing.Point(2, 30);
            this.LessV.Name = "LessV";
            this.LessV.Size = new System.Drawing.Size(47, 17);
            this.LessV.TabIndex = 0;
            this.LessV.TabStop = true;
            this.LessV.Text = "Less";
            this.LessV.UseVisualStyleBackColor = true;
            this.LessV.Click += new System.EventHandler(this.LessV_Click);
            // 
            // CheesesAmount
            // 
            this.CheesesAmount.Controls.Add(this.MoreC);
            this.CheesesAmount.Controls.Add(this.NormalC);
            this.CheesesAmount.Controls.Add(this.LessC);
            this.CheesesAmount.Location = new System.Drawing.Point(417, 389);
            this.CheesesAmount.Name = "CheesesAmount";
            this.CheesesAmount.Size = new System.Drawing.Size(106, 107);
            this.CheesesAmount.TabIndex = 23;
            this.CheesesAmount.TabStop = false;
            this.CheesesAmount.Text = "ToppingsAmount";
            this.CheesesAmount.Visible = false;
            // 
            // MoreC
            // 
            this.MoreC.AutoSize = true;
            this.MoreC.Location = new System.Drawing.Point(2, 74);
            this.MoreC.Name = "MoreC";
            this.MoreC.Size = new System.Drawing.Size(49, 17);
            this.MoreC.TabIndex = 2;
            this.MoreC.TabStop = true;
            this.MoreC.Text = "More";
            this.MoreC.UseVisualStyleBackColor = true;
            this.MoreC.Click += new System.EventHandler(this.MoreC_Click);
            // 
            // NormalC
            // 
            this.NormalC.AutoSize = true;
            this.NormalC.Location = new System.Drawing.Point(2, 51);
            this.NormalC.Name = "NormalC";
            this.NormalC.Size = new System.Drawing.Size(58, 17);
            this.NormalC.TabIndex = 1;
            this.NormalC.TabStop = true;
            this.NormalC.Text = "Normal";
            this.NormalC.UseVisualStyleBackColor = true;
            this.NormalC.Click += new System.EventHandler(this.NormalC_Click);
            // 
            // LessC
            // 
            this.LessC.AutoSize = true;
            this.LessC.Location = new System.Drawing.Point(2, 30);
            this.LessC.Name = "LessC";
            this.LessC.Size = new System.Drawing.Size(47, 17);
            this.LessC.TabIndex = 0;
            this.LessC.TabStop = true;
            this.LessC.Text = "Less";
            this.LessC.UseVisualStyleBackColor = true;
            this.LessC.Click += new System.EventHandler(this.LessC_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 643);
            this.Controls.Add(this.MainMenuPanel);
            this.Controls.Add(this.LoginPanel);
            this.Name = "Form1";
            this.Text = "Pizza Ordering Application";
            this.LoginPanel.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.LoginPage.ResumeLayout(false);
            this.LoginPage.PerformLayout();
            this.RegisterPage.ResumeLayout(false);
            this.RegisterPage.PerformLayout();
            this.MainMenuPanel.ResumeLayout(false);
            this.MainMenuPanel.PerformLayout();
            this.ItemCustomizationPanel.ResumeLayout(false);
            this.ItemCustomizationPanel.PerformLayout();
            this.MeatToppingsAmount.ResumeLayout(false);
            this.MeatToppingsAmount.PerformLayout();
            this.VeggiesToppingsAmount.ResumeLayout(false);
            this.VeggiesToppingsAmount.PerformLayout();
            this.CheesesAmount.ResumeLayout(false);
            this.CheesesAmount.PerformLayout();
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
        private System.Windows.Forms.Panel ItemCustomizationPanel;
        private System.Windows.Forms.Label CrustLabel;
        private System.Windows.Forms.RadioButton PanCrustRadio;
        private System.Windows.Forms.RadioButton ThinCrustRadio;
        private System.Windows.Forms.RadioButton OriginalCrustRadio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox Meats;
        private System.Windows.Forms.CheckedListBox Cheeses;
        private System.Windows.Forms.CheckedListBox Vegetables;
        private System.Windows.Forms.Button AddToCartButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Label ItemCustomizationTitle;
        private System.Windows.Forms.Label PizzaSizeLabel;
        private System.Windows.Forms.GroupBox MeatToppingsAmount;
        private System.Windows.Forms.GroupBox CheesesAmount;
        private System.Windows.Forms.RadioButton MoreC;
        private System.Windows.Forms.RadioButton NormalC;
        private System.Windows.Forms.RadioButton LessC;
        private System.Windows.Forms.GroupBox VeggiesToppingsAmount;
        private System.Windows.Forms.RadioButton MoreV;
        private System.Windows.Forms.RadioButton NormalV;
        private System.Windows.Forms.RadioButton LessV;
        private System.Windows.Forms.RadioButton MoreM;
        private System.Windows.Forms.RadioButton NormalM;
        private System.Windows.Forms.RadioButton LessM;
    }
}

