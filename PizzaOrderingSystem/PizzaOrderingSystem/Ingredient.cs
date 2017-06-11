﻿using System;
using PizzaOrderingSystem;

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
			set {
				if ( value >= (int)Enums.IngredientAmount.NONE && value <= (int)Enums.IngredientAmount.EXTRA ) {
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
			if ( this.amount > (int)Enums.IngredientAmount.NONE ) {
				this.amount--;
			}
		}
		#endregion
	}
}
