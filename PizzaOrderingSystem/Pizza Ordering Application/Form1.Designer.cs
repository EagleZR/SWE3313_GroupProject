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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label customerNameLabel;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label phoneNumberLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label usernameLabel;
            System.Windows.Forms.Label passwordLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.LoginPanel = new System.Windows.Forms.Panel();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.LoginPage = new System.Windows.Forms.TabPage();
            this.MainMenuPanel = new System.Windows.Forms.Panel();
            this.ItemCustomizationPanel = new System.Windows.Forms.Panel();
            this.AddToCartPanel = new System.Windows.Forms.Panel();
            this.CheckoutPanel = new System.Windows.Forms.Panel();
            this.AccountPanel = new System.Windows.Forms.Panel();
            this.AccountBackButton = new System.Windows.Forms.Button();
            this.AccountLastNameTBox = new System.Windows.Forms.TextBox();
            this.AccountEmailTBox = new System.Windows.Forms.TextBox();
            this.AccountUsernameTBox = new System.Windows.Forms.TextBox();
            this.AccountAddressTBox = new System.Windows.Forms.TextBox();
            this.AccountPasswordTBox = new System.Windows.Forms.TextBox();
            this.AccountFirstNameTBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AccountLogoutButton = new System.Windows.Forms.Button();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.OrderProgress = new System.Windows.Forms.Label();
            this.OrderProgressLabel = new System.Windows.Forms.Label();
            this.OrderCompleteLabel = new System.Windows.Forms.Label();
            this.CreditCardInfo = new System.Windows.Forms.GroupBox();
            this.CardNumber = new System.Windows.Forms.TextBox();
            this.ZIPCode = new System.Windows.Forms.TextBox();
            this.CVV = new System.Windows.Forms.TextBox();
            this.ExpirDate = new System.Windows.Forms.TextBox();
            this.NameOnCard = new System.Windows.Forms.TextBox();
            this.ZIPCodeLabel = new System.Windows.Forms.Label();
            this.CVVLabel = new System.Windows.Forms.Label();
            this.ExpirationDateLabel = new System.Windows.Forms.Label();
            this.CardNumberLabel = new System.Windows.Forms.Label();
            this.CardNameLabel = new System.Windows.Forms.Label();
            this.CheckoutButton = new System.Windows.Forms.Button();
            this.BackButtonC = new System.Windows.Forms.Button();
            this.PaymentMethod = new System.Windows.Forms.ComboBox();
            this.PaymentLabel = new System.Windows.Forms.Label();
            this.SpecialInstructions = new System.Windows.Forms.TextBox();
            this.SpecialInstructionsLabel = new System.Windows.Forms.Label();
            this.ItemList = new System.Windows.Forms.CheckedListBox();
            this.CartLabel = new System.Windows.Forms.Label();
            this.CheesesAmount = new System.Windows.Forms.GroupBox();
            this.MoreC = new System.Windows.Forms.RadioButton();
            this.NormalC = new System.Windows.Forms.RadioButton();
            this.LessC = new System.Windows.Forms.RadioButton();
            this.VeggiesToppingsAmount = new System.Windows.Forms.GroupBox();
            this.MoreV = new System.Windows.Forms.RadioButton();
            this.NormalV = new System.Windows.Forms.RadioButton();
            this.LessV = new System.Windows.Forms.RadioButton();
            this.MeatToppingsAmount = new System.Windows.Forms.GroupBox();
            this.MoreM = new System.Windows.Forms.RadioButton();
            this.NormalM = new System.Windows.Forms.RadioButton();
            this.LessM = new System.Windows.Forms.RadioButton();
            this.PizzaSizeLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Meats = new System.Windows.Forms.CheckedListBox();
            this.Cheeses = new System.Windows.Forms.CheckedListBox();
            this.Vegetables = new System.Windows.Forms.CheckedListBox();
            this.AddToCartButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.ItemCustomizationTitle = new System.Windows.Forms.Label();
            this.AccountButton = new System.Windows.Forms.Button();
            this.CartButton = new System.Windows.Forms.Button();
            this.OrderMPizza = new System.Windows.Forms.Button();
            this.OrderLPizza = new System.Windows.Forms.Button();
            this.OrderSPizza = new System.Windows.Forms.Button();
            this.MPizzaLabel = new System.Windows.Forms.Label();
            this.LPizzaLabel = new System.Windows.Forms.Label();
            this.SPizzaLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LoginButton = new System.Windows.Forms.Button();
            this.PasswordL = new System.Windows.Forms.TextBox();
            this.UsernameL = new System.Windows.Forms.TextBox();
            this.PasswordLabelL = new System.Windows.Forms.Label();
            this.UsernameLabelL = new System.Windows.Forms.Label();
            this.RegisterPage = new System.Windows.Forms.TabPage();
            this.customerNameTextBox = new System.Windows.Forms.TextBox();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerInformationDataSet = new Pizza_Ordering_Application.CustomerInformationDataSet();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.phoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.RegisterButton = new System.Windows.Forms.Button();
            this.customerTableAdapter = new Pizza_Ordering_Application.CustomerInformationDataSetTableAdapters.CustomerTableAdapter();
            this.tableAdapterManager = new Pizza_Ordering_Application.CustomerInformationDataSetTableAdapters.TableAdapterManager();
            this.customerBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.customerBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            customerNameLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            phoneNumberLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            usernameLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            this.LoginPanel.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.LoginPage.SuspendLayout();
            this.MainMenuPanel.SuspendLayout();
            this.ItemCustomizationPanel.SuspendLayout();
            this.AddToCartPanel.SuspendLayout();
            this.CheckoutPanel.SuspendLayout();
            this.AccountPanel.SuspendLayout();
            this.CreditCardInfo.SuspendLayout();
            this.CheesesAmount.SuspendLayout();
            this.VeggiesToppingsAmount.SuspendLayout();
            this.MeatToppingsAmount.SuspendLayout();
            this.RegisterPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerInformationDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingNavigator)).BeginInit();
            this.customerBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // customerNameLabel
            // 
            customerNameLabel.AutoSize = true;
            customerNameLabel.Location = new System.Drawing.Point(73, 202);
            customerNameLabel.Name = "customerNameLabel";
            customerNameLabel.Size = new System.Drawing.Size(38, 13);
            customerNameLabel.TabIndex = 9;
            customerNameLabel.Text = "Name:";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(73, 228);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(48, 13);
            addressLabel.TabIndex = 11;
            addressLabel.Text = "Address:";
            // 
            // phoneNumberLabel
            // 
            phoneNumberLabel.AutoSize = true;
            phoneNumberLabel.Location = new System.Drawing.Point(73, 254);
            phoneNumberLabel.Name = "phoneNumberLabel";
            phoneNumberLabel.Size = new System.Drawing.Size(81, 13);
            phoneNumberLabel.TabIndex = 13;
            phoneNumberLabel.Text = "Phone Number:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(73, 284);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(35, 13);
            emailLabel.TabIndex = 19;
            emailLabel.Text = "Email:";
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Location = new System.Drawing.Point(73, 310);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new System.Drawing.Size(58, 13);
            usernameLabel.TabIndex = 21;
            usernameLabel.Text = "Username:";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new System.Drawing.Point(73, 336);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(56, 13);
            passwordLabel.TabIndex = 23;
            passwordLabel.Text = "Password:";
            // 
            // LoginPanel
            // 
            this.LoginPanel.Controls.Add(this.tabControl);
            this.LoginPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LoginPanel.Location = new System.Drawing.Point(0, 0);
            this.LoginPanel.Name = "LoginPanel";
            this.LoginPanel.Size = new System.Drawing.Size(539, 585);
            this.LoginPanel.TabIndex = 0;
            this.LoginPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.LoginPanel_Paint);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.LoginPage);
            this.tabControl.Controls.Add(this.RegisterPage);
            this.tabControl.Location = new System.Drawing.Point(3, 21);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(515, 619);
            this.tabControl.TabIndex = 2;
            // 
            // LoginPage
            // 
            this.LoginPage.Controls.Add(this.MainMenuPanel);
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
            this.MainMenuPanel.Location = new System.Drawing.Point(3, 3);
            this.MainMenuPanel.Name = "MainMenuPanel";
            this.MainMenuPanel.Size = new System.Drawing.Size(501, 587);
            this.MainMenuPanel.TabIndex = 2;
            this.MainMenuPanel.Visible = false;
            // 
            // ItemCustomizationPanel
            // 
            this.ItemCustomizationPanel.Controls.Add(this.AddToCartPanel);
            this.ItemCustomizationPanel.Controls.Add(this.CheesesAmount);
            this.ItemCustomizationPanel.Controls.Add(this.VeggiesToppingsAmount);
            this.ItemCustomizationPanel.Controls.Add(this.MeatToppingsAmount);
            this.ItemCustomizationPanel.Controls.Add(this.PizzaSizeLabel);
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
            this.ItemCustomizationPanel.Size = new System.Drawing.Size(501, 587);
            this.ItemCustomizationPanel.TabIndex = 11;
            this.ItemCustomizationPanel.Visible = false;
            // 
            // AddToCartPanel
            // 
            this.AddToCartPanel.Controls.Add(this.CheckoutPanel);
            this.AddToCartPanel.Controls.Add(this.CreditCardInfo);
            this.AddToCartPanel.Controls.Add(this.CheckoutButton);
            this.AddToCartPanel.Controls.Add(this.BackButtonC);
            this.AddToCartPanel.Controls.Add(this.PaymentMethod);
            this.AddToCartPanel.Controls.Add(this.PaymentLabel);
            this.AddToCartPanel.Controls.Add(this.SpecialInstructions);
            this.AddToCartPanel.Controls.Add(this.SpecialInstructionsLabel);
            this.AddToCartPanel.Controls.Add(this.ItemList);
            this.AddToCartPanel.Controls.Add(this.CartLabel);
            this.AddToCartPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddToCartPanel.Location = new System.Drawing.Point(0, 0);
            this.AddToCartPanel.Name = "AddToCartPanel";
            this.AddToCartPanel.Size = new System.Drawing.Size(501, 587);
            this.AddToCartPanel.TabIndex = 24;
            this.AddToCartPanel.Visible = false;
            // 
            // CheckoutPanel
            // 
            this.CheckoutPanel.Controls.Add(this.AccountPanel);
            this.CheckoutPanel.Controls.Add(this.LogoutButton);
            this.CheckoutPanel.Controls.Add(this.OrderProgress);
            this.CheckoutPanel.Controls.Add(this.OrderProgressLabel);
            this.CheckoutPanel.Controls.Add(this.OrderCompleteLabel);
            this.CheckoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CheckoutPanel.Location = new System.Drawing.Point(0, 0);
            this.CheckoutPanel.Name = "CheckoutPanel";
            this.CheckoutPanel.Size = new System.Drawing.Size(501, 587);
            this.CheckoutPanel.TabIndex = 9;
            this.CheckoutPanel.Visible = false;
            // 
            // AccountPanel
            // 
            this.AccountPanel.Controls.Add(this.AccountBackButton);
            this.AccountPanel.Controls.Add(this.AccountLastNameTBox);
            this.AccountPanel.Controls.Add(this.AccountEmailTBox);
            this.AccountPanel.Controls.Add(this.AccountUsernameTBox);
            this.AccountPanel.Controls.Add(this.AccountAddressTBox);
            this.AccountPanel.Controls.Add(this.AccountPasswordTBox);
            this.AccountPanel.Controls.Add(this.AccountFirstNameTBox);
            this.AccountPanel.Controls.Add(this.label10);
            this.AccountPanel.Controls.Add(this.label9);
            this.AccountPanel.Controls.Add(this.label8);
            this.AccountPanel.Controls.Add(this.label7);
            this.AccountPanel.Controls.Add(this.label6);
            this.AccountPanel.Controls.Add(this.label3);
            this.AccountPanel.Controls.Add(this.AccountLogoutButton);
            this.AccountPanel.Location = new System.Drawing.Point(518, 65);
            this.AccountPanel.Name = "AccountPanel";
            this.AccountPanel.Size = new System.Drawing.Size(539, 643);
            this.AccountPanel.TabIndex = 12;
            this.AccountPanel.Visible = false;
            // 
            // AccountBackButton
            // 
            this.AccountBackButton.Location = new System.Drawing.Point(84, 40);
            this.AccountBackButton.Name = "AccountBackButton";
            this.AccountBackButton.Size = new System.Drawing.Size(75, 23);
            this.AccountBackButton.TabIndex = 13;
            this.AccountBackButton.Text = "Back";
            this.AccountBackButton.UseVisualStyleBackColor = true;
            this.AccountBackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // AccountLastNameTBox
            // 
            this.AccountLastNameTBox.Location = new System.Drawing.Point(210, 197);
            this.AccountLastNameTBox.Name = "AccountLastNameTBox";
            this.AccountLastNameTBox.Size = new System.Drawing.Size(282, 20);
            this.AccountLastNameTBox.TabIndex = 12;
            // 
            // AccountEmailTBox
            // 
            this.AccountEmailTBox.Location = new System.Drawing.Point(210, 243);
            this.AccountEmailTBox.Name = "AccountEmailTBox";
            this.AccountEmailTBox.Size = new System.Drawing.Size(282, 20);
            this.AccountEmailTBox.TabIndex = 11;
            // 
            // AccountUsernameTBox
            // 
            this.AccountUsernameTBox.Location = new System.Drawing.Point(210, 286);
            this.AccountUsernameTBox.Name = "AccountUsernameTBox";
            this.AccountUsernameTBox.Size = new System.Drawing.Size(282, 20);
            this.AccountUsernameTBox.TabIndex = 10;
            // 
            // AccountAddressTBox
            // 
            this.AccountAddressTBox.Location = new System.Drawing.Point(210, 371);
            this.AccountAddressTBox.Name = "AccountAddressTBox";
            this.AccountAddressTBox.Size = new System.Drawing.Size(282, 20);
            this.AccountAddressTBox.TabIndex = 9;
            // 
            // AccountPasswordTBox
            // 
            this.AccountPasswordTBox.Location = new System.Drawing.Point(210, 324);
            this.AccountPasswordTBox.Name = "AccountPasswordTBox";
            this.AccountPasswordTBox.Size = new System.Drawing.Size(282, 20);
            this.AccountPasswordTBox.TabIndex = 8;
            // 
            // AccountFirstNameTBox
            // 
            this.AccountFirstNameTBox.Location = new System.Drawing.Point(210, 151);
            this.AccountFirstNameTBox.Name = "AccountFirstNameTBox";
            this.AccountFirstNameTBox.Size = new System.Drawing.Size(282, 20);
            this.AccountFirstNameTBox.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(112, 327);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "Password";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(112, 246);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Email:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(112, 289);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Username:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(112, 200);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Last Name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(112, 369);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Address:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(112, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "First Name:";
            // 
            // AccountLogoutButton
            // 
            this.AccountLogoutButton.Location = new System.Drawing.Point(417, 40);
            this.AccountLogoutButton.Name = "AccountLogoutButton";
            this.AccountLogoutButton.Size = new System.Drawing.Size(75, 23);
            this.AccountLogoutButton.TabIndex = 0;
            this.AccountLogoutButton.Text = "Logout";
            this.AccountLogoutButton.UseVisualStyleBackColor = true;
            this.AccountLogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // LogoutButton
            // 
            this.LogoutButton.Location = new System.Drawing.Point(217, 347);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(75, 23);
            this.LogoutButton.TabIndex = 3;
            this.LogoutButton.Text = "Logout";
            this.LogoutButton.UseVisualStyleBackColor = true;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // OrderProgress
            // 
            this.OrderProgress.AutoSize = true;
            this.OrderProgress.Location = new System.Drawing.Point(216, 223);
            this.OrderProgress.Name = "OrderProgress";
            this.OrderProgress.Size = new System.Drawing.Size(55, 13);
            this.OrderProgress.TabIndex = 2;
            this.OrderProgress.Text = "Pending...";
            // 
            // OrderProgressLabel
            // 
            this.OrderProgressLabel.AutoSize = true;
            this.OrderProgressLabel.Location = new System.Drawing.Point(206, 141);
            this.OrderProgressLabel.Name = "OrderProgressLabel";
            this.OrderProgressLabel.Size = new System.Drawing.Size(80, 13);
            this.OrderProgressLabel.TabIndex = 1;
            this.OrderProgressLabel.Text = "Order Progress:";
            // 
            // OrderCompleteLabel
            // 
            this.OrderCompleteLabel.AutoSize = true;
            this.OrderCompleteLabel.Location = new System.Drawing.Point(206, 50);
            this.OrderCompleteLabel.Name = "OrderCompleteLabel";
            this.OrderCompleteLabel.Size = new System.Drawing.Size(80, 13);
            this.OrderCompleteLabel.TabIndex = 0;
            this.OrderCompleteLabel.Text = "Order Complete";
            // 
            // CreditCardInfo
            // 
            this.CreditCardInfo.Controls.Add(this.CardNumber);
            this.CreditCardInfo.Controls.Add(this.ZIPCode);
            this.CreditCardInfo.Controls.Add(this.CVV);
            this.CreditCardInfo.Controls.Add(this.ExpirDate);
            this.CreditCardInfo.Controls.Add(this.NameOnCard);
            this.CreditCardInfo.Controls.Add(this.ZIPCodeLabel);
            this.CreditCardInfo.Controls.Add(this.CVVLabel);
            this.CreditCardInfo.Controls.Add(this.ExpirationDateLabel);
            this.CreditCardInfo.Controls.Add(this.CardNumberLabel);
            this.CreditCardInfo.Controls.Add(this.CardNameLabel);
            this.CreditCardInfo.Location = new System.Drawing.Point(126, 454);
            this.CreditCardInfo.Name = "CreditCardInfo";
            this.CreditCardInfo.Size = new System.Drawing.Size(391, 177);
            this.CreditCardInfo.TabIndex = 8;
            this.CreditCardInfo.TabStop = false;
            this.CreditCardInfo.Visible = false;
            // 
            // CardNumber
            // 
            this.CardNumber.Location = new System.Drawing.Point(85, 42);
            this.CardNumber.Name = "CardNumber";
            this.CardNumber.Size = new System.Drawing.Size(237, 20);
            this.CardNumber.TabIndex = 9;
            // 
            // ZIPCode
            // 
            this.ZIPCode.Location = new System.Drawing.Point(97, 140);
            this.ZIPCode.Name = "ZIPCode";
            this.ZIPCode.Size = new System.Drawing.Size(87, 20);
            this.ZIPCode.TabIndex = 8;
            // 
            // CVV
            // 
            this.CVV.Location = new System.Drawing.Point(52, 109);
            this.CVV.Name = "CVV";
            this.CVV.Size = new System.Drawing.Size(71, 20);
            this.CVV.TabIndex = 7;
            // 
            // ExpirDate
            // 
            this.ExpirDate.Location = new System.Drawing.Point(129, 73);
            this.ExpirDate.Name = "ExpirDate";
            this.ExpirDate.Size = new System.Drawing.Size(85, 20);
            this.ExpirDate.TabIndex = 6;
            // 
            // NameOnCard
            // 
            this.NameOnCard.Location = new System.Drawing.Point(92, 13);
            this.NameOnCard.Name = "NameOnCard";
            this.NameOnCard.Size = new System.Drawing.Size(237, 20);
            this.NameOnCard.TabIndex = 5;
            // 
            // ZIPCodeLabel
            // 
            this.ZIPCodeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ZIPCodeLabel.AutoSize = true;
            this.ZIPCodeLabel.Location = new System.Drawing.Point(6, 143);
            this.ZIPCodeLabel.Name = "ZIPCodeLabel";
            this.ZIPCodeLabel.Size = new System.Drawing.Size(85, 13);
            this.ZIPCodeLabel.TabIndex = 4;
            this.ZIPCodeLabel.Text = "Billing ZIP Code:";
            // 
            // CVVLabel
            // 
            this.CVVLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CVVLabel.AutoSize = true;
            this.CVVLabel.Location = new System.Drawing.Point(6, 112);
            this.CVVLabel.Name = "CVVLabel";
            this.CVVLabel.Size = new System.Drawing.Size(40, 13);
            this.CVVLabel.TabIndex = 3;
            this.CVVLabel.Text = "C.V.V.:";
            // 
            // ExpirationDateLabel
            // 
            this.ExpirationDateLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ExpirationDateLabel.AutoSize = true;
            this.ExpirationDateLabel.Location = new System.Drawing.Point(6, 76);
            this.ExpirationDateLabel.Name = "ExpirationDateLabel";
            this.ExpirationDateLabel.Size = new System.Drawing.Size(117, 13);
            this.ExpirationDateLabel.TabIndex = 2;
            this.ExpirationDateLabel.Text = "Exp. Data (MM/YYYY):";
            // 
            // CardNumberLabel
            // 
            this.CardNumberLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CardNumberLabel.AutoSize = true;
            this.CardNumberLabel.Location = new System.Drawing.Point(6, 45);
            this.CardNumberLabel.Name = "CardNumberLabel";
            this.CardNumberLabel.Size = new System.Drawing.Size(72, 13);
            this.CardNumberLabel.TabIndex = 1;
            this.CardNumberLabel.Text = "Card Number:";
            // 
            // CardNameLabel
            // 
            this.CardNameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CardNameLabel.AutoSize = true;
            this.CardNameLabel.Location = new System.Drawing.Point(6, 16);
            this.CardNameLabel.Name = "CardNameLabel";
            this.CardNameLabel.Size = new System.Drawing.Size(80, 13);
            this.CardNameLabel.TabIndex = 0;
            this.CardNameLabel.Text = "Name On Card:";
            // 
            // CheckoutButton
            // 
            this.CheckoutButton.Location = new System.Drawing.Point(454, 8);
            this.CheckoutButton.Name = "CheckoutButton";
            this.CheckoutButton.Size = new System.Drawing.Size(69, 23);
            this.CheckoutButton.TabIndex = 7;
            this.CheckoutButton.Text = "Checkout";
            this.CheckoutButton.UseVisualStyleBackColor = true;
            this.CheckoutButton.Click += new System.EventHandler(this.CheckoutButton_Click);
            // 
            // BackButtonC
            // 
            this.BackButtonC.Location = new System.Drawing.Point(24, 8);
            this.BackButtonC.Name = "BackButtonC";
            this.BackButtonC.Size = new System.Drawing.Size(69, 23);
            this.BackButtonC.TabIndex = 6;
            this.BackButtonC.Text = "Back";
            this.BackButtonC.UseVisualStyleBackColor = true;
            this.BackButtonC.Click += new System.EventHandler(this.BackButtonC_Click);
            // 
            // PaymentMethod
            // 
            this.PaymentMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PaymentMethod.FormattingEnabled = true;
            this.PaymentMethod.Items.AddRange(new object[] {
            "Cash",
            "Credit"});
            this.PaymentMethod.Location = new System.Drawing.Point(126, 418);
            this.PaymentMethod.Name = "PaymentMethod";
            this.PaymentMethod.Size = new System.Drawing.Size(131, 21);
            this.PaymentMethod.TabIndex = 5;
            this.PaymentMethod.SelectedIndexChanged += new System.EventHandler(this.PaymentMethod_SelectedIndexChanged);
            // 
            // PaymentLabel
            // 
            this.PaymentLabel.AutoSize = true;
            this.PaymentLabel.Location = new System.Drawing.Point(30, 421);
            this.PaymentLabel.Name = "PaymentLabel";
            this.PaymentLabel.Size = new System.Drawing.Size(90, 13);
            this.PaymentLabel.TabIndex = 4;
            this.PaymentLabel.Text = "Payment Method:";
            // 
            // SpecialInstructions
            // 
            this.SpecialInstructions.Location = new System.Drawing.Point(126, 224);
            this.SpecialInstructions.Multiline = true;
            this.SpecialInstructions.Name = "SpecialInstructions";
            this.SpecialInstructions.Size = new System.Drawing.Size(391, 172);
            this.SpecialInstructions.TabIndex = 3;
            // 
            // SpecialInstructionsLabel
            // 
            this.SpecialInstructionsLabel.AutoSize = true;
            this.SpecialInstructionsLabel.Location = new System.Drawing.Point(21, 224);
            this.SpecialInstructionsLabel.Name = "SpecialInstructionsLabel";
            this.SpecialInstructionsLabel.Size = new System.Drawing.Size(102, 13);
            this.SpecialInstructionsLabel.TabIndex = 2;
            this.SpecialInstructionsLabel.Text = "Special Instructions:";
            // 
            // ItemList
            // 
            this.ItemList.CheckOnClick = true;
            this.ItemList.FormattingEnabled = true;
            this.ItemList.HorizontalScrollbar = true;
            this.ItemList.Location = new System.Drawing.Point(24, 37);
            this.ItemList.Name = "ItemList";
            this.ItemList.Size = new System.Drawing.Size(499, 169);
            this.ItemList.TabIndex = 1;
            // 
            // CartLabel
            // 
            this.CartLabel.AutoSize = true;
            this.CartLabel.Location = new System.Drawing.Point(245, 18);
            this.CartLabel.Name = "CartLabel";
            this.CartLabel.Size = new System.Drawing.Size(26, 13);
            this.CartLabel.TabIndex = 0;
            this.CartLabel.Text = "Cart";
            // 
            // CheesesAmount
            // 
            this.CheesesAmount.Controls.Add(this.MoreC);
            this.CheesesAmount.Controls.Add(this.NormalC);
            this.CheesesAmount.Controls.Add(this.LessC);
            this.CheesesAmount.Location = new System.Drawing.Point(406, 436);
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
            // VeggiesToppingsAmount
            // 
            this.VeggiesToppingsAmount.Controls.Add(this.MoreV);
            this.VeggiesToppingsAmount.Controls.Add(this.NormalV);
            this.VeggiesToppingsAmount.Controls.Add(this.LessV);
            this.VeggiesToppingsAmount.Location = new System.Drawing.Point(406, 296);
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
            // MeatToppingsAmount
            // 
            this.MeatToppingsAmount.Controls.Add(this.MoreM);
            this.MeatToppingsAmount.Controls.Add(this.NormalM);
            this.MeatToppingsAmount.Controls.Add(this.LessM);
            this.MeatToppingsAmount.Location = new System.Drawing.Point(406, 149);
            this.MeatToppingsAmount.Name = "MeatToppingsAmount";
            this.MeatToppingsAmount.Size = new System.Drawing.Size(106, 107);
            this.MeatToppingsAmount.TabIndex = 22;
            this.MeatToppingsAmount.TabStop = false;
            this.MeatToppingsAmount.Text = "ToppingsAmount";
            this.MeatToppingsAmount.Visible = false;
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
            // PizzaSizeLabel
            // 
            this.PizzaSizeLabel.AutoSize = true;
            this.PizzaSizeLabel.Location = new System.Drawing.Point(227, 86);
            this.PizzaSizeLabel.Name = "PizzaSizeLabel";
            this.PizzaSizeLabel.Size = new System.Drawing.Size(55, 13);
            this.PizzaSizeLabel.TabIndex = 15;
            this.PizzaSizeLabel.Text = "Pizza Size";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 426);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Cheeses";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Vegetables";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 141);
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
            this.Meats.Location = new System.Drawing.Point(22, 162);
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
            this.Cheeses.Location = new System.Drawing.Point(22, 449);
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
            this.Vegetables.Location = new System.Drawing.Point(22, 309);
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
            // AccountButton
            // 
            this.AccountButton.Location = new System.Drawing.Point(84, 94);
            this.AccountButton.Name = "AccountButton";
            this.AccountButton.Size = new System.Drawing.Size(75, 23);
            this.AccountButton.TabIndex = 10;
            this.AccountButton.Text = "Account";
            this.AccountButton.UseVisualStyleBackColor = true;
            this.AccountButton.Click += new System.EventHandler(this.AccountButton_Click);
            // 
            // CartButton
            // 
            this.CartButton.Location = new System.Drawing.Point(380, 94);
            this.CartButton.Name = "CartButton";
            this.CartButton.Size = new System.Drawing.Size(75, 23);
            this.CartButton.TabIndex = 9;
            this.CartButton.Text = "Cart";
            this.CartButton.UseVisualStyleBackColor = true;
            this.CartButton.Click += new System.EventHandler(this.CartButton_Click);
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
            // MPizzaLabel
            // 
            this.MPizzaLabel.AutoSize = true;
            this.MPizzaLabel.Location = new System.Drawing.Point(152, 322);
            this.MPizzaLabel.Name = "MPizzaLabel";
            this.MPizzaLabel.Size = new System.Drawing.Size(72, 13);
            this.MPizzaLabel.TabIndex = 5;
            this.MPizzaLabel.Text = "Medium Pizza";
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
            // SPizzaLabel
            // 
            this.SPizzaLabel.AutoSize = true;
            this.SPizzaLabel.Location = new System.Drawing.Point(155, 267);
            this.SPizzaLabel.Name = "SPizzaLabel";
            this.SPizzaLabel.Size = new System.Drawing.Size(60, 13);
            this.SPizzaLabel.TabIndex = 3;
            this.SPizzaLabel.Text = "Small Pizza";
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
            this.RegisterPage.Controls.Add(customerNameLabel);
            this.RegisterPage.Controls.Add(this.customerNameTextBox);
            this.RegisterPage.Controls.Add(addressLabel);
            this.RegisterPage.Controls.Add(this.addressTextBox);
            this.RegisterPage.Controls.Add(phoneNumberLabel);
            this.RegisterPage.Controls.Add(this.phoneNumberTextBox);
            this.RegisterPage.Controls.Add(emailLabel);
            this.RegisterPage.Controls.Add(this.emailTextBox);
            this.RegisterPage.Controls.Add(usernameLabel);
            this.RegisterPage.Controls.Add(this.usernameTextBox);
            this.RegisterPage.Controls.Add(passwordLabel);
            this.RegisterPage.Controls.Add(this.passwordTextBox);
            this.RegisterPage.Controls.Add(this.RegisterButton);
            this.RegisterPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RegisterPage.Location = new System.Drawing.Point(4, 22);
            this.RegisterPage.Name = "RegisterPage";
            this.RegisterPage.Padding = new System.Windows.Forms.Padding(3);
            this.RegisterPage.Size = new System.Drawing.Size(507, 593);
            this.RegisterPage.TabIndex = 1;
            this.RegisterPage.Text = "Register";
            // 
            // customerNameTextBox
            // 
            this.customerNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "CustomerName", true));
            this.customerNameTextBox.Location = new System.Drawing.Point(164, 199);
            this.customerNameTextBox.Name = "customerNameTextBox";
            this.customerNameTextBox.Size = new System.Drawing.Size(264, 20);
            this.customerNameTextBox.TabIndex = 10;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "Customer";
            this.customerBindingSource.DataSource = this.customerInformationDataSet;
            // 
            // customerInformationDataSet
            // 
            this.customerInformationDataSet.DataSetName = "CustomerInformationDataSet";
            this.customerInformationDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // addressTextBox
            // 
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "Address", true));
            this.addressTextBox.Location = new System.Drawing.Point(164, 225);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(264, 20);
            this.addressTextBox.TabIndex = 12;
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "PhoneNumber", true));
            this.phoneNumberTextBox.Location = new System.Drawing.Point(164, 251);
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.Size = new System.Drawing.Size(264, 20);
            this.phoneNumberTextBox.TabIndex = 14;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(164, 281);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(264, 20);
            this.emailTextBox.TabIndex = 20;
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "Username", true));
            this.usernameTextBox.Location = new System.Drawing.Point(164, 307);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(264, 20);
            this.usernameTextBox.TabIndex = 22;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "Password", true));
            this.passwordTextBox.Location = new System.Drawing.Point(164, 333);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(264, 20);
            this.passwordTextBox.TabIndex = 24;
            // 
            // RegisterButton
            // 
            this.RegisterButton.Location = new System.Drawing.Point(251, 413);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(75, 23);
            this.RegisterButton.TabIndex = 9;
            this.RegisterButton.Text = "Register";
            this.RegisterButton.UseVisualStyleBackColor = true;
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CreditCardsTableAdapter = null;
            this.tableAdapterManager.CustomerTableAdapter = this.customerTableAdapter;
            this.tableAdapterManager.OrdersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Pizza_Ordering_Application.CustomerInformationDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // customerBindingNavigator
            // 
            this.customerBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.customerBindingNavigator.BindingSource = this.customerBindingSource;
            this.customerBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.customerBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.customerBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.customerBindingNavigatorSaveItem});
            this.customerBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.customerBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.customerBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.customerBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.customerBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.customerBindingNavigator.Name = "customerBindingNavigator";
            this.customerBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.customerBindingNavigator.Size = new System.Drawing.Size(539, 25);
            this.customerBindingNavigator.TabIndex = 1;
            this.customerBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // customerBindingNavigatorSaveItem
            // 
            this.customerBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.customerBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("customerBindingNavigatorSaveItem.Image")));
            this.customerBindingNavigatorSaveItem.Name = "customerBindingNavigatorSaveItem";
            this.customerBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.customerBindingNavigatorSaveItem.Text = "Save Data";
            this.customerBindingNavigatorSaveItem.Click += new System.EventHandler(this.customerBindingNavigatorSaveItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 585);
            this.Controls.Add(this.customerBindingNavigator);
            this.Controls.Add(this.LoginPanel);
            this.Name = "Form1";
            this.Text = "Pizza Ordering Application";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.LoginPanel.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.LoginPage.ResumeLayout(false);
            this.LoginPage.PerformLayout();
            this.MainMenuPanel.ResumeLayout(false);
            this.MainMenuPanel.PerformLayout();
            this.ItemCustomizationPanel.ResumeLayout(false);
            this.ItemCustomizationPanel.PerformLayout();
            this.AddToCartPanel.ResumeLayout(false);
            this.AddToCartPanel.PerformLayout();
            this.CheckoutPanel.ResumeLayout(false);
            this.CheckoutPanel.PerformLayout();
            this.AccountPanel.ResumeLayout(false);
            this.AccountPanel.PerformLayout();
            this.CreditCardInfo.ResumeLayout(false);
            this.CreditCardInfo.PerformLayout();
            this.CheesesAmount.ResumeLayout(false);
            this.CheesesAmount.PerformLayout();
            this.VeggiesToppingsAmount.ResumeLayout(false);
            this.VeggiesToppingsAmount.PerformLayout();
            this.MeatToppingsAmount.ResumeLayout(false);
            this.MeatToppingsAmount.PerformLayout();
            this.RegisterPage.ResumeLayout(false);
            this.RegisterPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerInformationDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingNavigator)).EndInit();
            this.customerBindingNavigator.ResumeLayout(false);
            this.customerBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Button RegisterButton;
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
        private System.Windows.Forms.Panel AddToCartPanel;
        private System.Windows.Forms.Button CheckoutButton;
        private System.Windows.Forms.Button BackButtonC;
        private System.Windows.Forms.ComboBox PaymentMethod;
        private System.Windows.Forms.Label PaymentLabel;
        private System.Windows.Forms.TextBox SpecialInstructions;
        private System.Windows.Forms.Label SpecialInstructionsLabel;
        private System.Windows.Forms.CheckedListBox ItemList;
        private System.Windows.Forms.Label CartLabel;
        private System.Windows.Forms.GroupBox CreditCardInfo;
        private System.Windows.Forms.Label ZIPCodeLabel;
        private System.Windows.Forms.Label CVVLabel;
        private System.Windows.Forms.Label ExpirationDateLabel;
        private System.Windows.Forms.Label CardNumberLabel;
        private System.Windows.Forms.Label CardNameLabel;
        private System.Windows.Forms.TextBox CardNumber;
        private System.Windows.Forms.TextBox ZIPCode;
        private System.Windows.Forms.TextBox CVV;
        private System.Windows.Forms.TextBox ExpirDate;
        private System.Windows.Forms.TextBox NameOnCard;
        private System.Windows.Forms.Panel CheckoutPanel;
        private System.Windows.Forms.Button LogoutButton;
        private System.Windows.Forms.Label OrderProgress;
        private System.Windows.Forms.Label OrderProgressLabel;
        private System.Windows.Forms.Label OrderCompleteLabel;
        private System.Windows.Forms.Panel AccountPanel;
        private System.Windows.Forms.Button AccountLogoutButton;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button AccountBackButton;
        private System.Windows.Forms.TextBox AccountLastNameTBox;
        private System.Windows.Forms.TextBox AccountEmailTBox;
        private System.Windows.Forms.TextBox AccountUsernameTBox;
        private System.Windows.Forms.TextBox AccountAddressTBox;
        private System.Windows.Forms.TextBox AccountPasswordTBox;
        private System.Windows.Forms.TextBox AccountFirstNameTBox;
        private CustomerInformationDataSet customerInformationDataSet;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private CustomerInformationDataSetTableAdapters.CustomerTableAdapter customerTableAdapter;
        private CustomerInformationDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator customerBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton customerBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox customerNameTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox phoneNumberTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
    }
}

