using System;

namespace PizzaOrderingSystem {
	/// <summary>
	/// A class for storing customer information in the <see cref="PizzaOrderingSystem"/>, including the associated <see cref="PizzaOrderingSystem.Order"/>s and <see cref="PizzaOrderingSystem.Card"/>s.
	/// </summary>
	public class Customer {

		#region Private Variables
		private string name;
		private string address;
		private string phoneNumber;
		private Order[] pastOrders;
		private Card[] cards;
		#endregion

		#region Properties
		public string Name {
			get { return this.name; }
			set { this.name = value; }
		}

		public string Address {
			get { return this.address; }
			set { this.address = value; }
		}

		public string PhoneNumber {
			get { return this.phoneNumber; }
			set { this.phoneNumber = value; }
		}

		public Order[] PastOrders {
			get { return this.pastOrders; }
		}

		public Card[] Cards {
			get { return this.cards; }
		}
		#endregion

		#region Constructors
		/// <summary>
		/// Use this when creating a new <see cref="PizzaOrderingSystem.Customer"/>.
		/// </summary>
		/// <param name="name"></param>
		/// <param name="address"></param>
		/// <param name="phoneNumber"></param>
		protected Customer ( string name, string address, string phoneNumber ) { 
			// TODO Do we even need this, or should we create a new customer in the database, then load back into here?
			this.Name = name;
			this.Address = address;
			this.PhoneNumber = phoneNumber;
		}

		/// <summary>
		/// Use this when loading a <see cref="PizzaOrderingSystem.Customer"/> from the database.
		/// </summary>
		/// <param name="name"></param>
		/// <param name="address"></param>
		/// <param name="phoneNumber"></param>
		/// <param name="pastOrders"></param>
		/// <param name="cards"></param>
		protected Customer ( string name, string address, string phoneNumber, Order[] pastOrders, Card[] cards ) : this( name, address, phoneNumber ) {
			this.pastOrders = pastOrders;
			this.cards = cards;
		}
		#endregion

		#region Methods
		/// <summary>
		/// Adds a new <see cref"PizzaOrderingSystem.Order"/> to the list of previous Orders.
		/// </summary>
		/// <param name="order">The new <see cref"PizzaOrderingSystem.Order"/> to be added.</param>
		public void AddOrder ( Order order ) {
			Order[] tempOrders = pastOrders;
			pastOrders = new Order[tempOrders.Length + 1];
			for ( int i = 0; i < tempOrders.Length; i++ ) {
				pastOrders[i] = tempOrders[i];
			}
			pastOrders[pastOrders.Length - 1] = order;
		}

		/// <summary>
		/// Adds a new <see cref"PizzaOrderingSystem.Card"/> to the list of available Cards.
		/// </summary>
		/// <param name="card">The new <see cref"PizzaOrderingSystem.Card"/> to be added.</param>
		public void AddCard ( Card card ) {
			Card[] tempCards = cards;
			cards = new Card[tempCards.Length + 1];
			for ( int i = 0; i < tempCards.Length; i++ ) {
				cards[i] = tempCards[i];
			}
			cards[cards.Length - 1] = card;
		}

		/// <summary>
		/// Removes the specified <see cref"PizzaOrderingSystem.Card"/> from the list of available Cards.
		/// </summary>
		/// <param name="card">The <see cref"PizzaOrderingSystem.Card"/> to be removed.</param>
		public void RemoveCard ( Card card ) {
			Card[] newCards = new Card[cards.Length - 1];
			for ( int i = 0, u = 0; i < cards.Length; i++, u++ ) {
				if ( cards[i] == card ) {
					u--;
				} else {
					newCards[u] = cards[i];
				}
			}
			cards = newCards;
		}
		#endregion
	}
}