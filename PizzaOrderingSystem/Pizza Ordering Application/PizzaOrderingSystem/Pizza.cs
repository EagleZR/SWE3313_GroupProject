using System;

namespace PizzaOrderingSystem {
	public class Pizza {
		#region Private Variables
		private int pizzaSize;
		private Ingredient[] ingredients;
		#endregion

		#region Properties
		public int PizzaSize {
			get { return this.pizzaSize; }
			set {
				if (value <= (int)Enums.PizzaSize.LARGE && value >= (int)Enums.PizzaSize.SMALL) {
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
		public Pizza(int pizzaSize) {
			this.PizzaSize = pizzaSize;
		}

		/// <summary>
		/// Use this if you're rebuilding a pizza, or you're starting a pizza with default toppings.
		/// </summary>
		/// <param name="pizzaSize"></param>
		/// <param name="ingredients"></param>
		public Pizza(int pizzaSize, Ingredient[] ingredients) {
			this.PizzaSize = pizzaSize;
			this.ingredients = ingredients;
		}
		#endregion

		#region Methods
		public void AddIngredient(Ingredient ingredient) {

		}

		public void RemoveIngredient(Ingredient ingredient) {

		}

		/// <summary>
		/// Returns a list of the associated <see cref="Ingredient"/>s, each separated by a ", ". 
		/// </summary>
		/// <returns></returns>
		public string PrintIngredients() {
			string returnValue = "";

			if (ingredients != null) {
				for (int i = 0; i < ingredients.Length; i++) {
					returnValue += ingredients[i].Name + ", ";
				}
			}

			return returnValue;
		}
		#endregion
	}
}