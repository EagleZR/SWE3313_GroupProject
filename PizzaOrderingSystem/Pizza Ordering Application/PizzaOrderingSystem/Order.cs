using System;

namespace PizzaOrderingSystem {
	public class Order {

		#region Private Variables
		private Customer purchaser;
		private MenuItem[] items;
		private int paymentType;
		private Card paymentCard;
		private int orderStatus = (int)Enums.OrderStatus.PENDING;
		#endregion

		#region Properties
		public Customer Purchaser {
			get { return this.purchaser; }
			set {
				if ( this.OrderStatus == (int)Enums.OrderStatus.PENDING ) {
					this.purchaser = value;
				}
			}
		}
		public MenuItem[] Items {
			get { return this.items; }
		}
		public int PaymentType {
			get { return this.paymentType; }
			set {
				if ( this.OrderStatus == (int)Enums.OrderStatus.PENDING ) {
					this.paymentType = value;
				}
			}
		}
		/// <summary>
		/// If the PaymentType is not CARD, returns null. Otherwise, returns the current card, or null if no card is set.
		/// </summary>
		public Card PaymentCard {
			get {
				if ( this.PaymentType == (int)Enums.PaymentType.CARD ) {
					return this.paymentCard;
				} else {
					return null;
				}
			}
			set {
				if ( this.OrderStatus == (int)Enums.OrderStatus.PENDING && this.PaymentType == (int)Enums.PaymentType.CARD ) {
					this.paymentCard = value;
				}
			}
		}
		/// <summary>
		/// OrderStatus will only be changed through methods such as SubmitOrder() and CompleteOrder(). 
		/// </summary>
		public int OrderStatus {
			get { return this.orderStatus; }
		}
		#endregion

		#region Constructors
		/// <summary>
		/// Default/empty Order. Must be built for a customer. 
		/// </summary>
		/// <param name="purchaser"></param>
		public Order ( Customer purchaser ) {
			this.purchaser = purchaser;
			this.orderStatus = (int)Enums.OrderStatus.PENDING;
		}

		/// <summary>
		/// Use this when the initial construction of the Order has something other than CARD as the payment type.
		/// </summary>
		/// <param name="purchaser"></param>
		/// <param name="items"></param>
		/// <param name="paymentType"></param>
		public Order ( Customer purchaser, MenuItem[] items, int paymentType ) : this( purchaser ) {
			this.items = items;
			this.paymentType = paymentType;
		}

		/// <summary>
		/// Use this only when the initial payment type is a Card
		/// </summary>
		/// <param name="purchaser"></param>
		/// <param name="items"></param>
		/// <param name="paymentType"></param>
		/// <param name="card"></param>
		public Order ( Customer purchaser, MenuItem[] items, int paymentType, Card card ) : this( purchaser, items, paymentType ) {
			this.PaymentCard = card;
		}

		/// <summary>
		/// NOTE: Only use this when reconstructing orders from the database.
		/// </summary>
		/// <param name="purchaser"></param>
		/// <param name="items"></param>
		/// <param name="paymentType"></param>
		/// <param name="card"></param>
		/// <param name="orderStatus"></param>
		public Order ( Customer purchaser, MenuItem[] items, int paymentType, Card card, int orderStatus ) : this( purchaser, items, paymentType ) {
			this.orderStatus = orderStatus;
		}
		#endregion

		#region Methods
		public void AddItem ( MenuItem item ) {
			if (this.OrderStatus == (int)Enums.OrderStatus.PENDING) {
				MenuItem[] tempItems = items;
				items = new MenuItem[tempItems.Length + 1];
				for (int i = 0; i < tempItems.Length; i++) {
					items[i] = tempItems[i];
				}
				items[items.Length - 1] = item;
			} // TODO Throw exception?
		}

		public void PlaceOrder() {
			if ( this.OrderStatus == (int)Enums.OrderStatus.PENDING ) {
				this.orderStatus = (int)Enums.OrderStatus.SUBMITTED;
				// TODO do more stuff
			} // TODO Throw exception?
		}

		public string GenerateReceipt() {
			string receipt = "Receipt:\n";
			// TODO Build a receipt to be returned.

			return receipt;
		}

		public void FulfillOrder() {
			if ( this.OrderStatus == (int)Enums.OrderStatus.SUBMITTED ) {
				this.orderStatus = (int)Enums.OrderStatus.COMPLETED;
				// TODO do more stuff
			} // TODO Throw exception?
		}
		#endregion
	}
}