using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza_Ordering_Application
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl.SelectedTab == LoginPage)
            {
                FirstName.Clear();
                LastName.Clear();
                Email.Clear();
                UsernameR.Clear();
                PasswordR.Clear();
            }
            
            else if (tabControl.SelectedTab == RegisterPage)
            {
                UsernameL.Clear();
                PasswordL.Clear();
            }
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Logged in successfully", "Success!", MessageBoxButtons.OK, MessageBoxIcon.None);
            MainMenuPanel.Visible = true;
            LoginPanel.Visible = false;
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Registered successfully", "Success!", MessageBoxButtons.OK, MessageBoxIcon.None);
            MainMenuPanel.Visible = true;
            LoginPanel.Visible = false;
        }
    }
}
