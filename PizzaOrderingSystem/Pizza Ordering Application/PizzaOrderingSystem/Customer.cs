using System;

namespace PizzaOrderingSystem {
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
		public Customer () {
			this.Name = "";
			this.Address = "";
			this.PhoneNumber = "";
		}

		public Customer ( string name, string address, string phoneNumber, Order[] pastOrders, Card[] cards ) {
			this.Name = name;
			this.Address = address;
			this.PhoneNumber = phoneNumber;
			this.pastOrders = pastOrders;
			this.cards = cards;
		}
		#endregion

		#region Methods
		/// <summary>
		/// Adds a new Order to the list of previous Orders.
		/// </summary>
		/// <param name="order">The new Order to be added.</param>
		public void AddOrder ( Order order ) {
			Order[] tempOrders = pastOrders;
			pastOrders = new Order[tempOrders.Length + 1];
			for ( int i = 0; i < tempOrders.Length; i++ ) {
				pastOrders[i] = tempOrders[i];
			}
			pastOrders[pastOrders.Length - 1] = order;
		}
		/// <summary>
		/// Adds a new Card to the list of available Cards.
		/// </summary>
		/// <param name="card">The new Card to be added.</param>
		public void AddCard ( Card card ) {
			Card[] tempCards = cards;
			cards = new Card[tempCards.Length + 1];
			for ( int i = 0; i < tempCards.Length; i++ ) {
				cards[i] = tempCards[i];
			}
			cards[cards.Length - 1] = card;
		}
		/// <summary>
		/// Removes the specified Card from the list of available Cards.
		/// </summary>
		/// <param name="card">The Card to be removed.</param>
		public void RemoveCard ( Card card ) {
			Card[] newCards = new Card[cards.Length - 1];
			bool isRemoved = false;
			for ( int i = 0; i < cards.Length; i++ ) {
				if ( isRemoved ) {
					newCards[i - 1] = cards[i];
				} else if ( cards[i].Equals( card ) ) {
					isRemoved = true;
				} else {
					newCards[i] = cards[i];
				}
			}
			cards = newCards;
		}
		#endregion
	}
}