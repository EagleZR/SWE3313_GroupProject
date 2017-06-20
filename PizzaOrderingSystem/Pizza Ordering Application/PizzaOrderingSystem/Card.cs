using System;

namespace PizzaOrderingSystem {
	/// <summary>
	/// A class for storing information about a <see cref="PizzaOrderingSystem.Customer"/>'s credit card.
	/// </summary>
	public class Card {

		#region Private Variables
		private string cardNickname;
		private string nameOnCard;
		private string cardNumber;
		private string expDate;
		private Customer owner;
		#endregion

		#region Properties
		/// <summary>
		/// Nickname for the card for usability purposes. Only sets a new nickname if no other cards by the same owner have that name. 
		/// </summary>
		public string CardNickname {
			get { return ( this.cardNickname == null ? "nickname uninitialized" : this.cardNickname ); }
			set {
				Card[] cards = owner.Cards;
				bool validName = true;
				for( int i = 0; i < cards.Length; i++ ) {
					if( value.Equals( cards[i].CardNickname ) ) {
						validName = false;
					}
				}
				if( validName ) {
					this.cardNickname = value;
				}
			}
		}
		/// <summary>
		/// Name of the cardholder.
		/// </summary>
		public string NameOnCard {
			get { return ( this.nameOnCard == null ? "name uninitialized" : this.nameOnCard ); }
			set { this.nameOnCard = value; }
		}
		public string CardNumber {
			get { return ( this.cardNumber == null ? "number uninitialized" : this.cardNumber ); }
			set { this.cardNumber = value; }
		}
		public string ExpDate {
			get { return ( this.expDate == null ? "date uninitialized" : this.expDate ); }
			set { this.expDate = value; }
		}
		public Customer Owner {
			get { return this.owner; } 
			set { this.owner = value; }
		}
		#endregion

		#region Constructors 
		public Card( string nameOnCard, string cardNumber, string expDate, Customer owner ) {
			this.NameOnCard = nameOnCard;
			this.CardNumber = cardNumber;
			this.ExpDate = expDate;
			this.owner = owner;
		}
		#endregion

		#region Methods
		/// <summary>
		/// Compares all areas other than CardNickname.
		/// </summary>
		/// <param name="other">True if all fields are the same, excluding the nickname.</param>
		/// <returns></returns>
		public bool Equals( Card other ) {
			return this.NameOnCard == other.NameOnCard && this.CardNumber == other.CardNickname && this.ExpDate == other.ExpDate;
		}
		#endregion
	}
}