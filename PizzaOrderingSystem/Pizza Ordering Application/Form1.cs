using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PizzaOrderingSystem;

namespace Pizza_Ordering_Application {
	public partial class Form1 : Form
    {
		List<Ingredient> availableSauces = new List<Ingredient>();
		List<Ingredient> availableCheeses = new List<Ingredient>();
		List<Ingredient> availableMeats = new List<Ingredient>();
		List<Ingredient> availableVegetables = new List<Ingredient>();

		Pizza currPizza = null;
		Ingredient currIngredient;
		Order currOrder;
		Customer currCustomer;

		public Form1()
        {
			InitializeComponent();
		}

		#region Login Screen
		private void tabControl_SelectedIndexChanged( object sender, EventArgs e )
        {
			if ( tabControl.SelectedTab == LoginPage )
            {
				FirstName.Clear();
				LastName.Clear();
				Email.Clear();
				UsernameR.Clear();
				PasswordR.Clear();
			}
            else if( tabControl.SelectedTab == RegisterPage )
            {
				UsernameL.Clear();
				PasswordL.Clear();
			}
		}

		private void LoginButton_Click( object sender, EventArgs e )
        {
			MessageBox.Show( "Logged in successfully", "Success!", MessageBoxButtons.OK, MessageBoxIcon.None );
			MainMenuPanel.Visible = true;
			currCustomer = new Customer(); // TODO Fix this after Michael gets his DB class up
			currOrder = new Order( currCustomer );
		}

		private void RegisterButton_Click( object sender, EventArgs e )
        {
			MessageBox.Show( "Registered successfully", "Success!", MessageBoxButtons.OK, MessageBoxIcon.None );
			MainMenuPanel.Visible = true;
			currCustomer = new Customer(); // TODO Fix this after Michael gets his DB class up
			currOrder = new Order( currCustomer );
		}
		#endregion

		#region Pizza Selection Screen
		private void OrderSPizza_Click( object sender, EventArgs e )
        {
			ItemCustomizationPanel.Visible = true;
			PizzaSizeLabel.Text = "Small Pizza";
			currPizza = new Pizza( (int) Enums.PizzaSize.SMALL );

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
        }

		private void OrderMPizza_Click( object sender, EventArgs e )
        {
			ItemCustomizationPanel.Visible = true;
			PizzaSizeLabel.Text = "Medium Pizza";
			currPizza = new Pizza( (int)Enums.PizzaSize.MEDIUM );

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
        }

		private void OrderLPizza_Click( object sender, EventArgs e )
        {
			ItemCustomizationPanel.Visible = true;
			PizzaSizeLabel.Text = "Large Pizza";
			currPizza = new Pizza( (int)Enums.PizzaSize.LARGE );

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
        }
		#endregion

		#region Item Customization Screen
		private void BackButton_Click( object sender, EventArgs e )
        {
			MainMenuPanel.Visible = true;
			Meats.Enabled = true;
			MeatToppingsAmount.Visible = false;
			Vegetables.Enabled = true;
			VeggiesToppingsAmount.Visible = false;
			Cheeses.Enabled = true;
			CheesesAmount.Visible = false;

			currPizza = null;

			foreach( int i in Meats.CheckedIndices )
            {
				Meats.SetItemCheckState( i, CheckState.Unchecked );
			}

			foreach( int i in Vegetables.CheckedIndices )
            {
				Vegetables.SetItemCheckState( i, CheckState.Unchecked );
			}

			foreach( int i in Cheeses.CheckedIndices )
            {
				Cheeses.SetItemCheckState( i, CheckState.Unchecked );
			}

			ItemCustomizationPanel.Visible = false;
		}

		private void Meats_ItemCheck( object sender, ItemCheckEventArgs e )
        {
			if ( e.NewValue == CheckState.Checked )
            {
				currIngredient = new Ingredient( Meats.SelectedItem.ToString(), (int)Enums.IngredientCategory.MEAT);
				AddToCartButton.Enabled = false;
				Meats.Enabled = false;
				MeatToppingsAmount.Visible = true;
				MeatToppingsAmount.Text = Meats.SelectedItem.ToString() + " Amount?";
				LessM.Checked = false;
				NormalM.Checked = false;
				MoreM.Checked = false;
			}

            else if( e.NewValue == CheckState.Unchecked )
            {
				Ingredient curr = currPizza.Contains( Meats.SelectedItem.ToString() );
				if( curr != null )
                {
					currPizza.RemoveIngredient( curr );
				}
			}
		}

		private void Vegetables_ItemCheck( object sender, ItemCheckEventArgs e )
        {
			if( e.NewValue == CheckState.Checked )
            {
				currIngredient = new Ingredient( Vegetables.SelectedItem.ToString(), (int)Enums.IngredientCategory.VEGETABLE );
				AddToCartButton.Enabled = false;
				Vegetables.Enabled = false;
				VeggiesToppingsAmount.Visible = true;
				VeggiesToppingsAmount.Text = Vegetables.SelectedItem.ToString() + " Amount?";
				LessV.Checked = false;
				NormalV.Checked = false;
				MoreV.Checked = false;
			}

            else if( e.NewValue == CheckState.Unchecked )
            {
				Ingredient curr = currPizza.Contains( Meats.SelectedItem.ToString() );
				if( curr != null )
                {
					currPizza.RemoveIngredient( curr );
				}
			}
		}

		private void Cheeses_ItemCheck( object sender, ItemCheckEventArgs e )
        {
			if( e.NewValue == CheckState.Checked )
            {
				currIngredient = new Ingredient( Cheeses.SelectedItem.ToString(), (int)Enums.IngredientCategory.CHEESE );
				AddToCartButton.Enabled = false;
				Cheeses.Enabled = false;
				CheesesAmount.Visible = true;
				CheesesAmount.Text = Cheeses.SelectedItem.ToString() + " Amount?";
				LessC.Checked = false;
				NormalC.Checked = false;
				MoreC.Checked = false;
			}

            else if( e.NewValue == CheckState.Unchecked )
            {
				Ingredient curr = currPizza.Contains( Meats.SelectedItem.ToString() );
				if( curr != null )
                {
					currPizza.RemoveIngredient( curr );
				}
			}
		}

		private void LessM_Click( object sender, EventArgs e )
        {
			AddToCartButton.Enabled = true;
			currIngredient.SetAmount( (int)Enums.IngredientAmount.LIGHT );
			Meats.Enabled = true;
			MeatToppingsAmount.Visible = false;
			currPizza.AddIngredient( currIngredient );
		}

		private void NormalM_Click( object sender, EventArgs e )
        {
			AddToCartButton.Enabled = true;
			currIngredient.SetAmount( (int)Enums.IngredientAmount.NORMAL );
			Meats.Enabled = true;
			MeatToppingsAmount.Visible = false;
			currPizza.AddIngredient( currIngredient );
		}

		private void MoreM_Click( object sender, EventArgs e )
        {
			AddToCartButton.Enabled = true;
			currIngredient.SetAmount( (int)Enums.IngredientAmount.EXTRA );
			Meats.Enabled = true;
			MeatToppingsAmount.Visible = false;
			currPizza.AddIngredient( currIngredient );
		}

		private void LessV_Click( object sender, EventArgs e )
        {
			AddToCartButton.Enabled = true;
			currIngredient.SetAmount( (int)Enums.IngredientAmount.LIGHT );
			Vegetables.Enabled = true;
			VeggiesToppingsAmount.Visible = false;
			currPizza.AddIngredient( currIngredient );
		}

		private void NormalV_Click( object sender, EventArgs e )
        {
			AddToCartButton.Enabled = true;
			currIngredient.SetAmount( (int)Enums.IngredientAmount.NORMAL );
			Vegetables.Enabled = true;
			VeggiesToppingsAmount.Visible = false;
			currPizza.AddIngredient( currIngredient );
		}

		private void MoreV_Click( object sender, EventArgs e )
        {
			AddToCartButton.Enabled = true;
			currIngredient.SetAmount( (int)Enums.IngredientAmount.EXTRA );
			Vegetables.Enabled = true;
			VeggiesToppingsAmount.Visible = false;
			currPizza.AddIngredient( currIngredient );
		}

		private void LessC_Click( object sender, EventArgs e )
        {
			AddToCartButton.Enabled = true;
			currIngredient.SetAmount( (int)Enums.IngredientAmount.LIGHT );
			Cheeses.Enabled = true;
			CheesesAmount.Visible = false;
			currPizza.AddIngredient( currIngredient );
		}

		private void NormalC_Click( object sender, EventArgs e )
        {
			AddToCartButton.Enabled = true;
			currIngredient.SetAmount( (int)Enums.IngredientAmount.NORMAL );
			Cheeses.Enabled = true;
			CheesesAmount.Visible = false;
			currPizza.AddIngredient( currIngredient );
		}

		private void MoreC_Click( object sender, EventArgs e )
        {
			AddToCartButton.Enabled = true;
			currIngredient.SetAmount( (int)Enums.IngredientAmount.EXTRA );
			Cheeses.Enabled = true;
			CheesesAmount.Visible = false;
			currPizza.AddIngredient( currIngredient );
		}

		private void AddToCartButton_Click( object sender, EventArgs e )
        {
			currOrder.AddPizza( currPizza );

			AddToCartPanel.Visible = true;

			ItemList.Items.Clear();

			for (int i = 0; i < currPizza.Ingredients.Length; i++ )
            {
				Console.WriteLine( currPizza.Ingredients[i].Name );
			}

			foreach( Pizza p in currOrder.Pizzas )
            {
				Console.WriteLine( "Ingredients: " +  p.PrintIngredients() );
				ItemList.Items.Add( p.PrintIngredients(), true );
			}
		}
		#endregion

		#region Cart Screen
		private void BackButtonC_Click( object sender, EventArgs e )
        {
			AddToCartPanel.Visible = false;
			ItemCustomizationPanel.Visible = false;

			foreach( int i in Meats.CheckedIndices )
            {
				Meats.SetItemCheckState( i, CheckState.Unchecked );
			}

			foreach( int i in Vegetables.CheckedIndices )
            {
				Vegetables.SetItemCheckState( i, CheckState.Unchecked );
			}

			foreach( int i in Cheeses.CheckedIndices )
            {
				Cheeses.SetItemCheckState( i, CheckState.Unchecked );
			}
		}

		private void PaymentMethod_SelectedIndexChanged( object sender, EventArgs e )
        {
			if( PaymentMethod.SelectedItem.ToString() == "Cash" )
            {
				CreditCardInfo.Visible = false;
			}

            else if( PaymentMethod.SelectedItem.ToString() == "Credit" )
            {
				CreditCardInfo.Visible = true;
			}

            else
            {
				CreditCardInfo.Visible = false;
			}
		}

		private void CartButton_Click( object sender, EventArgs e )
        {
			ItemCustomizationPanel.Visible = true;
			AddToCartPanel.Visible = true;
		}

        private void CheckoutButton_Click(object sender, EventArgs e)
        {
            CheckoutPanel.Visible = true;
            currOrder.FulfillOrder();
        }

        #endregion

        #region Checkout Screen
        private void LogoutButton_Click(object sender, EventArgs e)
        {
            CheckoutPanel.Visible = false;
            AddToCartPanel.Visible = false;
            ItemCustomizationPanel.Visible = false;
            MainMenuPanel.Visible = false;

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
        }

        #endregion
    }
}
