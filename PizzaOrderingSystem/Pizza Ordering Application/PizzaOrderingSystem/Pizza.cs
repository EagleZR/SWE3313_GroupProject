using System;

namespace PizzaOrderingSystem {
	public class Pizza {
		#region Private Variables
		private int pizzaSize;
		private Ingredient[] ingredients;
		/// <summary>
		/// Added to differentiate between identical pizzas in the same order.
		/// </summary>
		protected DateTime dateCreated;
		private static int limitCheese = 2;
		private static int limitSauce = 1;
		#endregion

		#region Properties
		public int PizzaSize {
			get { return this.pizzaSize; }
			set {
				if( value <= (int)Enums.PizzaSize.LARGE && value >= (int)Enums.PizzaSize.SMALL ) {
					this.pizzaSize = value;
				}
			}
		}
		public Ingredient[] Ingredients {
			get { return this.ingredients; }
		}
		#endregion

		#region Constructors
		/// <summary>
		/// Use this if you're creating a pizza with no toppings.
		/// </summary>
		/// <param name="pizzaSize"></param>
		public Pizza( int pizzaSize ) {
			this.PizzaSize = pizzaSize;
			this.dateCreated = System.DateTime.UtcNow;
		}

		/// <summary>
		/// Use this if you're rebuilding a pizza, or you're starting a pizza with default toppings.
		/// </summary>
		/// <param name="pizzaSize"></param>
		/// <param name="ingredients"></param>
		public Pizza( int pizzaSize, Ingredient[] ingredients ) {
			this.PizzaSize = pizzaSize;
			this.ingredients = ingredients;
			this.dateCreated = System.DateTime.UtcNow;
		}
		#endregion

		#region Methods
		/// <summary>
		/// Adds the specified <see cref="Ingredient"/>, if applicable. 
		/// </summary>
		/// <param name="ingredient"></param>
		public void AddIngredient( Ingredient ingredient ) {
			if( !Contains( ingredient ) && ( ingredient.Category == (int)Enums.IngredientCategory.CHEESE && CountIngredients( ingredient.Category ) < limitCheese ) && ( ingredient.Category == (int)Enums.IngredientCategory.SAUCE && CountIngredients( ingredient.Category ) < limitSauce ) ) {
				Ingredient[] temp = new Ingredient[Ingredients.Length + 1];
				for( int i = 0; i < temp.Length; i++ ) {
					temp[i] = ingredients[i];
				}
				temp[temp.Length - 1] = ingredient;
				ingredients = temp;
			}
		}

		/// <summary>
		/// Removes the specified <see cref="Ingredient"/>, if applicable.  
		/// </summary>
		/// <param name="ingredient"></param>
		public void RemoveIngredient( Ingredient ingredient ) {
			if( Contains( ingredient ) ) {
				Ingredient[] temp = new Ingredient[ingredients.Length - 1];
				// TODO I'll need someone to test the hell out of this one.
				for( int i = 0, u = 0; i < ingredients.Length; i++, u++ ) {
					if( ingredients[i].Equals( ingredient ) ) {
						u--;
					} else {
						temp[u] = ingredients[i];
					}
				}
				ingredients = temp;
			}
		}

		/// <summary>
		/// If the ingredient is on the pizza, it sets the amount. If the ingredient is not on the pizza, it adds it at the specified amount.
		/// </summary>
		/// <param name="ingredient"></param>
		/// <param name="amount"></param>
		public void SetIngredientAmount( Ingredient ingredient, int amount ) {
			if( Contains( ingredient ) ) {
				ingredient.SetAmount( amount );
			} else {
				AddIngredient( ingredient );
				ingredient.SetAmount( amount );
			}
		}

		/// <summary>
		/// Checks if this pizza has an ingredient of the same name as the parameter.
		/// </summary>
		/// <param name="ingredient"></param>
		/// <returns></returns>
		public bool Contains( Ingredient ingredient ) {
			foreach( Ingredient curr in ingredients ) {
				if( curr.Equals( ingredient ) ) return true;
			}
			return false;
		}

		/// <summary>
		/// Checks if the <see cref="DateTime"/> that the pizzas were (originally) instantiated, the ingredients, and the pizza size all match. 
		/// </summary>
		/// <param name="pizza"></param>
		/// <returns></returns>
		public bool Equals( Pizza pizza ) {
			return ( this.dateCreated.Equals( pizza.dateCreated ) ) && Equals( pizza.ingredients ) && this.pizzaSize == pizza.pizzaSize;
		}

		/// <summary>
		/// Checks if the ingredients match this pizza's ingredients. 
		/// </summary>
		/// <param name="ingredients"></param>
		/// <returns></returns>
		private bool Equals( Ingredient[] ingredients ) {
			if( this.ingredients.Length != ingredients.Length ) {
				return false;
			}
			for( int i = 0; i < this.ingredients.Length; i++ ) {
				if( this.ingredients[i] != ingredients[i] ) {
					return false;
				}
			}
			return true;
		}

		/// <summary>
		/// Returns a list of the associated <see cref="Ingredient"/>s, each separated by a ", ". 
		/// </summary>
		/// <returns></returns>
		public string PrintIngredients() {
			string returnValue = "";

			if( ingredients != null ) {
				for( int i = 0; i < ingredients.Length; i++ ) {
					returnValue += ingredients[i].Name + ", ";
				}
			}

			return returnValue;
		}

		protected int CountIngredients( int ingredientCategory ) {
			int counter = 0;
			for( int i = 0; i < ingredients.Length; i++ ) {
				if( ingredients[i].Category == ingredientCategory ) {
					counter++;
				}
			}
			return counter;
		}

		protected string PrintReceipt() {
			string returnString = "";
			returnString += "Pizza size: " + ( this.pizzaSize == (int)Enums.PizzaSize.SMALL ? "Small" : ( this.pizzaSize == (int)Enums.PizzaSize.MEDIUM ? "Medium" : "Large" ) );
			for( int i = 0; i < this.ingredients.Length; i++ ) {

			}
			return returnString;
		}
		#endregion
	}
}