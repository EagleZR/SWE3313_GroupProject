using System;
using PizzaOrderingSystem;

namespace PizzaOrderingSystem {
	public class Ingredient {

		#region Private Variables
		public string name;
		private int category;
		private int amount;
		#endregion

		#region Properties
		public string Name {
			get { return this.name; }
			set { this.name = value; }
		}

		public int Category {
			get { return this.category; }
			set { this.category = value; }
		}

		public int Amount {
			get { return this.amount; }
			set {
				if ( value >= (int)Enums.IngredientAmount.LIGHT && value <= (int)Enums.IngredientAmount.EXTRA ) {
					this.amount = value;
				}
			}
		}
		#endregion

		#region Constructors
		public Ingredient ( string name, int category, int amount ) {
			this.Name = name;
			this.Category = category;
			this.Amount = amount;
		}
		#endregion

		#region Methods
		/// <summary>
		/// Increases the amount of this ingredient, not to exceed Enums.IngredientAmount.EXTRA
		/// </summary>
		public void IncreaseAmount () {
			if ( this.amount <= (int)Enums.IngredientAmount.EXTRA ) {
				this.amount++;
			}
		}

		/// <summary>
		/// Decreases the amount of this ingredient, not to fall below Enums.IngredientAmount.NONE
		/// </summary>
		public void DecreaseAmount () {
			if ( this.amount >= (int)Enums.IngredientAmount.LIGHT ) {
				this.amount--;
			}
		}

        /// <summary>
        /// Sets the ingredient amount to the given value if the value does not exceed EXTRA or fall below NONE
        /// </summary>
        /// <param name="amount"></param>
        public void SetAmount(int amount) {
            if (amount <= (int)Enums.IngredientAmount.EXTRA && amount >= (int)Enums.IngredientAmount.LIGHT) {
                this.amount = amount;
            }
        }
		#endregion
	}
}
