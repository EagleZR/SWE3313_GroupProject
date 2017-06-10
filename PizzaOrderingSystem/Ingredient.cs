using System;

namespace PizzaOrderingSystem {
	public class Ingredient {

		#region Private Variables
		private string name;
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
			set { this.amount = value; }
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
		public void IncreaseAmount() {

		}

		public void DecreaseAmount() {

		}
		#endregion
	}
}
