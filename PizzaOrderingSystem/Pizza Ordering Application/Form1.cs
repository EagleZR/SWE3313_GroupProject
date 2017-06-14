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

        private void AddToCartButton_Click(object sender, EventArgs e)
        {

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            MainMenuPanel.Visible = true;

            ThinCrustRadio.Checked = false;

            OriginalCrustRadio.Checked = false;

            PanCrustRadio.Checked = false;

            foreach (int i in Meats.CheckedIndices)
            {
                Meats.SetItemCheckState(i, CheckState.Unchecked);
            }

            foreach (int i in Vegetables.CheckedIndices)
            {
                Vegetables.SetItemCheckState(i, CheckState.Unchecked);
            }

            foreach (int i in Cheeses.CheckedIndices)
            {
                Cheeses.SetItemCheckState(i, CheckState.Unchecked);
            }

            ItemCustomizationPanel.Visible = false;
        }

        private void OrderSPizza_Click(object sender, EventArgs e)
        {
            ItemCustomizationPanel.Visible = true;
            PizzaSizeLabel.Text = "Small Pizza";
        }

        private void OrderMPizza_Click(object sender, EventArgs e)
        {
            ItemCustomizationPanel.Visible = true;
            PizzaSizeLabel.Text = "Medium Pizza";
        }

        private void OrderLPizza_Click(object sender, EventArgs e)
        {
            ItemCustomizationPanel.Visible = true;
            PizzaSizeLabel.Text = "Large Pizza";
        }

        private void Meats_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
            {
                Meats.Enabled = false;
                MeatToppingsAmount.Visible = true;
                MeatToppingsAmount.Text = Meats.SelectedItem.ToString() + " Amount?";
                LessM.Checked = false;
                NormalM.Checked = false;
                MoreM.Checked = false;
            }
        }

        private void Vegetables_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
            {
                Vegetables.Enabled = false;
                VeggiesToppingsAmount.Visible = true;
                VeggiesToppingsAmount.Text = Vegetables.SelectedItem.ToString() + " Amount?";
                LessV.Checked = false;
                NormalV.Checked = false;
                MoreV.Checked = false;
            }
        }

        private void Cheeses_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
            {
                Cheeses.Enabled = false;
                CheesesAmount.Visible = true;
                CheesesAmount.Text = Cheeses.SelectedItem.ToString() + " Amount?";
                LessC.Checked = false;
                NormalC.Checked = false;
                MoreC.Checked = false;
            }
        }

        private void LessM_Click(object sender, EventArgs e)
        {
            Meats.Enabled = true;
            MeatToppingsAmount.Visible = false;         
        }

        private void NormalM_Click(object sender, EventArgs e)
        {
            Meats.Enabled = true;
            MeatToppingsAmount.Visible = false;
        }

        private void MoreM_Click(object sender, EventArgs e)
        {
            Meats.Enabled = true;
            MeatToppingsAmount.Visible = false;
        }

        private void LessV_Click(object sender, EventArgs e)
        {
            Vegetables.Enabled = true;
            VeggiesToppingsAmount.Visible = false;
        }

        private void NormalV_Click(object sender, EventArgs e)
        {
            Vegetables.Enabled = true;
            VeggiesToppingsAmount.Visible = false;
        }

        private void MoreV_Click(object sender, EventArgs e)
        {
            Vegetables.Enabled = true;
            VeggiesToppingsAmount.Visible = false;
        }

        private void LessC_Click(object sender, EventArgs e)
        {
            Cheeses.Enabled = true;
            CheesesAmount.Visible = false;
        }

        private void NormalC_Click(object sender, EventArgs e)
        {
            Cheeses.Enabled = true;
            CheesesAmount.Visible = false;
        }

        private void MoreC_Click(object sender, EventArgs e)
        {
            Cheeses.Enabled = true;
            CheesesAmount.Visible = false;
        }
    }
}
