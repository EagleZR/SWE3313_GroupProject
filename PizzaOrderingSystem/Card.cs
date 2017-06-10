using System;

namespace PizzaOrderingSystem {
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
			get { return this.cardNickname; }
			set {
				Cards[] cards = owner.Cards;
				bool validName = true;
				for (int i = 0; i < cards.Length; i++) {
					if (value.Equals(cards[i].CardNickname)) {
						validName = false;
					}
				}
				if ( validName ) {
					this.cardNickname = value;
				}
			} 
		}
		/// <summary>
		/// Name of the cardholder.
		/// </summary>
		public string NameOnCard {
			get { return this.nameOnCard; }
			set { this.nameOnCard = value; }
		}
		public string CardNumber {
			get { return this.cardNumber; }
			set { this.cardNumber = value; }
		}
		public string ExpDate {
			get { return this.expDate; }
			set { this.expDate = value; }
		}
		#endregion

		#region Constructors 
		public Card ( string nameOnCard, string cardNumber, string expDate, Customer owner ) {
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
		public bool Equals (Card other) {
			return this.NameOnCard == other.NameOnCard && this.CardNumber == other.CardNickname && this.ExpDate == other.ExpDate;
		}
		#endregion
	}
}