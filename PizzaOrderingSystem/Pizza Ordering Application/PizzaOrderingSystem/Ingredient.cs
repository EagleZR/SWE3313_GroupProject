using System;
using PizzaOrderingSystem;

namespace PizzaOrderingSystem {
	/// <summary>
	/// A class used to store information for each ingredient to be used on the pizza in the <see cref="PizzaOrderingSystem"/>.
	/// </summary>
	public class Ingredient {

		#region Private Variables
		private string name;
		private int category;
		private int amount;
		#endregion

		#region Properties
		public string Name {
			get { return ( this.name == null ? "name uninitialized" : this.name ); }
			set { this.name = value; }
		}

		public int Category {
			get { return this.category; }
			set {
				if( Enum.IsDefined( typeof( Enums.IngredientCategory ), value ) ) {
					this.category = value;
				}
			}
		}

		public int Amount {
			get { return this.amount; }
			set {
				if( Enum.IsDefined( typeof( Enums.IngredientAmount ), value ) ) {
					this.amount = value;
				}
			}
		}
		#endregion

		#region Constructors
		/// <summary>
		/// 
		/// </summary>
		/// <param name="name"></param>
		/// <param name="category">Use <see cref="PizzaOrderingSystem.Enums.IngredientCategory"/></param>
		public Ingredient( string name, int category ) {
			this.Name = name;
			this.Category = category;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="name"></param>
		/// <param name="category">Use <see cref="PizzaOrderingSystem.Enums.IngredientCategory"/></param>
		/// <param name="amount">Use <see cref="PizzaOrderingSystem.Enums.IngredientAmount"/></param>
		public Ingredient( string name, int category, int amount ) : this( name, category ) {
			this.Amount = amount;
		}
		#endregion

		#region Methods
		/// <summary>
		/// Increases the amount of this ingredient, not to exceed <see cref="Enums.IngredientAmount.EXTRA"/>.
		/// </summary>
		protected void IncreaseAmount() {
			if( Enum.IsDefined( typeof(Enums.IngredientAmount), this.amount + 1 ) ) {
				this.amount++;
			}
		}

		/// <summary>
		/// Decreases the amount of this ingredient, not to fall below <see cref="Enums.IngredientAmount.NONE"/>.
		/// </summary>
		protected void DecreaseAmount() {
			if( Enum.IsDefined( typeof( Enums.IngredientAmount ), this.amount - 1 ) ) {
				this.amount--;
			}
		}

		/// <summary>
		/// Sets the ingredient amount to the given value if the value does not exceed <see cref="Enums.IngredientAmount.EXTRA"/> or fall below <see cref="Enums.IngredientAmount.NONE"/>
		/// </summary>
		/// <param name="amount">Use <see cref="Enums.IngredientAmount"/>.</param>
		public void SetAmount( int amount ) {
			if( Enum.IsDefined( typeof( Enums.IngredientAmount ), amount ) ) {
				this.amount = amount;
			}
		}

		/// <summary>
		/// Returns a new copy of this <see cref="Ingredient"/>
		/// </summary>
		/// <returns></returns>
		public Ingredient Copy() {
			return new Ingredient( this.Name, this.Category, this.Amount );
		}

		/// <summary>
		/// Checks if the <see cref="Name"/>s are equal. 
		/// </summary>
		/// <param name="ingredient"></param>
		/// <returns></returns>
		public bool Equals( Ingredient ingredient ) {
			return this.name == ingredient.name;
		}

		/// <summary>
		/// Checks to see if the string parameter matches the name of this ingredient.
		/// </summary>
		/// <param name="ingredientName"></param>
		/// <returns></returns>
		protected bool Equals( string ingredientName ) {
			return this.name == ingredientName;
		}

		protected string GenerateReceipt() {
			string returnValue = "";
			returnValue += "\t" + this.name + ": " + ( this.amount == (int)Enums.IngredientAmount.LIGHT ? "Light" : ( this.amount == (int)Enums.IngredientAmount.NORMAL ? "Normal" : ( this.amount == (int)Enums.IngredientAmount.EXTRA ? "Extra" : "" ) ) );
			return returnValue;
		}
		#endregion
	}
}
