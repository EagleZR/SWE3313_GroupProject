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
    }
}
