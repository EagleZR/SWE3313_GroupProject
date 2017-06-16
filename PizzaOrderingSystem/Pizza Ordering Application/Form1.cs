﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PizzaOrderingSystem;

namespace Pizza_Ordering_Application
{
    public partial class Form1 : Form
    {
        List<Ingredient> ingredients = new List<Ingredient>();
        List<Pizza> pizzas = new List<Pizza>();
        Ingredient meat = new Ingredient("", 0, 0);
        Ingredient vegetable = new Ingredient("", 0, 0);
        Ingredient cheese = new Ingredient("", 0, 0);

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

        private void BackButton_Click(object sender, EventArgs e)
        {
            MainMenuPanel.Visible = true;
            Meats.Enabled = true;
            MeatToppingsAmount.Visible = false;
            Vegetables.Enabled = true;
            VeggiesToppingsAmount.Visible = false;
            Cheeses.Enabled = true;
            CheesesAmount.Visible = false;

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
                meat = new Ingredient(Meats.SelectedItem.ToString(), 0, 0);
                AddToCartButton.Enabled = false;
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
                vegetable = new Ingredient(Vegetables.SelectedItem.ToString(), 1, 0);
                AddToCartButton.Enabled = false;
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
                cheese = new Ingredient(Cheeses.SelectedItem.ToString(), 2, 0);
                AddToCartButton.Enabled = false;
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
            AddToCartButton.Enabled = true;
            meat.SetAmount(0);
            Meats.Enabled = true;
            MeatToppingsAmount.Visible = false;
            ingredients.Add(meat);        
        }

        private void NormalM_Click(object sender, EventArgs e)
        {
            AddToCartButton.Enabled = true;
            meat.SetAmount(1);
            Meats.Enabled = true;
            MeatToppingsAmount.Visible = false;
            ingredients.Add(meat);
        }

        private void MoreM_Click(object sender, EventArgs e)
        {
            AddToCartButton.Enabled = true;
            meat.SetAmount(2);
            Meats.Enabled = true;
            MeatToppingsAmount.Visible = false;
            ingredients.Add(meat);
        }

        private void LessV_Click(object sender, EventArgs e)
        {
            AddToCartButton.Enabled = true;
            vegetable.SetAmount(0);
            Vegetables.Enabled = true;
            VeggiesToppingsAmount.Visible = false;
            ingredients.Add(vegetable);
        }

        private void NormalV_Click(object sender, EventArgs e)
        {
            AddToCartButton.Enabled = true;
            vegetable.SetAmount(1);
            Vegetables.Enabled = true;
            VeggiesToppingsAmount.Visible = false;
            ingredients.Add(vegetable);
        }

        private void MoreV_Click(object sender, EventArgs e)
        {
            AddToCartButton.Enabled = true;
            vegetable.SetAmount(2);
            Vegetables.Enabled = true;
            VeggiesToppingsAmount.Visible = false;
            ingredients.Add(vegetable);
        }

        private void LessC_Click(object sender, EventArgs e)
        {
            AddToCartButton.Enabled = true;
            cheese.SetAmount(0);
            Cheeses.Enabled = true;
            CheesesAmount.Visible = false;
            ingredients.Add(cheese);
        }

        private void NormalC_Click(object sender, EventArgs e)
        {
            AddToCartButton.Enabled = true;
            cheese.SetAmount(1);
            Cheeses.Enabled = true;
            CheesesAmount.Visible = false;
            ingredients.Add(cheese);
        }

        private void MoreC_Click(object sender, EventArgs e)
        {
            AddToCartButton.Enabled = true;
            cheese.SetAmount(2);
            Cheeses.Enabled = true;
            CheesesAmount.Visible = false;
            ingredients.Add(cheese);
        }

        private void BackButtonC_Click(object sender, EventArgs e)
        {
            AddToCartPanel.Visible = false;
        }

        private void AddToCartButton_Click(object sender, EventArgs e)
        {
            int i = 0;
            int pSize = 0;
            Ingredient[] defaultArray = new Ingredient[100];

            if (PizzaSizeLabel.Text == "Small Pizza")
            {
                pSize = 0;
            }

            else if (PizzaSizeLabel.Text == "Medium Pizza")
            {
                pSize = 1;
            }

            else if (PizzaSizeLabel.Text == "Large Pizza")
            {
                pSize = 2;
            }

            Pizza pizza = new Pizza(pSize, defaultArray);

            foreach(Ingredient ingredient in ingredients)
            {
                pizza.Ingredients[i] = ingredient;
                i++;
            }

            i = 0;

            pizzas.Add(pizza);

            AddToCartPanel.Visible = true;

            ItemList.Items.Clear();

            foreach(Pizza p in pizzas)
            {
                ItemList.Items.Add(p, true);
            }
        }

        private void PaymentMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (PaymentMethod.SelectedItem.ToString() == "Cash")
            {
                CreditCardInfo.Visible = false;
            }

            else if (PaymentMethod.SelectedItem.ToString() == "Credit")
            {
                CreditCardInfo.Visible = true;
            }

            else
            {
                CreditCardInfo.Visible = false;
            }
        }

        private void CartButton_Click(object sender, EventArgs e)
        {
            ItemCustomizationPanel.Visible = true;
            AddToCartPanel.Visible = true;
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
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

            ingredients.Clear();
        }
    }
}