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

			for (int i = 0; i < ingredients.Length; i++) {
				returnValue += ingredients[i].Name + ", ";
			}

			return returnValue;
		}
		#endregion
	}
}