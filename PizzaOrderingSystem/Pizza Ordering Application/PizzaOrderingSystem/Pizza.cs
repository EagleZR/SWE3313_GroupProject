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
		}

		/// <summary>
		/// Use this if you're rebuilding a pizza, or you're starting a pizza with default toppings.
		/// </summary>
		/// <param name="pizzaSize"></param>
		/// <param name="ingredients"></param>
		public Pizza( int pizzaSize, Ingredient[] ingredients ) {
			this.PizzaSize = pizzaSize;
			this.ingredients = ingredients;
		}
		#endregion

		#region Methods
		/// <summary>
		/// Adds the specified <see cref="Ingredient"/>, if applicable. 
		/// </summary>
		/// <param name="ingredient"></param>
		public void AddIngredient( Ingredient ingredient ) {
			if( !Contains( ingredient ) ) {
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

		public bool Equals( Pizza pizza ) {
			// TODO don't forget this...
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
		#endregion
	}
}