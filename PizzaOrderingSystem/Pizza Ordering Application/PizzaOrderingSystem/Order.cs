﻿using System;

namespace PizzaOrderingSystem {
	public class Order {

		#region Private Variables
		private Customer purchaser;
		private Pizza[] pizzas;
		private int paymentType;
		private Card paymentCard;
		private int orderStatus = (int)Enums.OrderStatus.PENDING;
		#endregion

		#region Properties
		public Customer Purchaser {
			get { return this.purchaser; }
			set {
				if( this.OrderStatus == (int)Enums.OrderStatus.PENDING ) {
					this.purchaser = value;
				}
			}
		}
		public Pizza[] Pizzas {
			get { return this.pizzas; }
		}
		public int PaymentType {
			get { return this.paymentType; }
			set {
				if( this.OrderStatus == (int)Enums.OrderStatus.PENDING ) {
					this.paymentType = value;
				}
			}
		}
		/// <summary>
		/// If the PaymentType is not CARD, returns null. Otherwise, returns the current card, or null if no card is set.
		/// </summary>
		public Card PaymentCard {
			get {
				if( this.PaymentType == (int)Enums.PaymentType.CARD ) {
					return this.paymentCard;
				} else {
					return null;
				}
			}
			set {
				if( this.OrderStatus == (int)Enums.OrderStatus.PENDING && this.PaymentType == (int)Enums.PaymentType.CARD ) {
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
		public Order( Customer purchaser ) {
			this.purchaser = purchaser;
			this.orderStatus = (int)Enums.OrderStatus.PENDING;
			this.pizzas = new Pizza[0];
		}

		/// <summary>
		/// Use this when the initial construction of the Order has something other than CARD as the payment type.
		/// </summary>
		/// <param name="purchaser"></param>
		/// <param name="items"></param>
		/// <param name="paymentType"></param>
		protected Order( Customer purchaser, Pizza[] items, int paymentType ) : this( purchaser ) {
			this.pizzas = items;
			this.paymentType = paymentType;
		}

		/// <summary>
		/// Use this only when the initial payment type is a Card
		/// </summary>
		/// <param name="purchaser"></param>
		/// <param name="items"></param>
		/// <param name="paymentType"></param>
		/// <param name="card"></param>
		protected Order( Customer purchaser, Pizza[] items, int paymentType, Card card ) : this( purchaser, items, paymentType ) {
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
		protected Order( Customer purchaser, Pizza[] items, int paymentType, Card card, int orderStatus ) {
			this.purchaser = purchaser;
			this.pizzas = items;
			this.paymentType = paymentType;
			this.PaymentCard = card;
			this.orderStatus = orderStatus;
		}
		#endregion

		#region Methods
		/// <summary>
		/// Adds a pizza to the order. 
		/// </summary>
		/// <param name="pizza"></param>
		public void AddPizza( Pizza pizza ) {
			if( this.OrderStatus == (int)Enums.OrderStatus.PENDING ) {
				Pizza[] tempItems = pizzas;
				pizzas = new Pizza[tempItems.Length + 1];
				for( int i = 0; i < tempItems.Length; i++ ) {
					pizzas[i] = tempItems[i];
				}
				pizzas[pizzas.Length - 1] = pizza;
			} // TODO Throw exception?
		}

		/// <summary>
		/// Removes a pizza from the order
		/// </summary>
		/// <param name="pizza">Must be the exact (same pointer) pizza you want removed. If you need the list of pizzas, get it from <see cref="Order.Pizzas"/>.</param>
		public void RemovePizza( Pizza pizza ) {
			if( this.OrderStatus == (int)Enums.OrderStatus.PENDING ) {
				Pizza[] temp = new Pizza[pizzas.Length];
				for( int i = 0, u = 0; i < pizzas.Length; i++, u++ ) {
					if( pizzas[i].Equals( pizza ) ) {
						u--;
					} else {
						temp[u] = pizzas[i];
					}
				}
				pizzas = temp;
			}
		}

		/// <summary>
		/// Submits the order to the store. After this method has been run, this order can no longer be edited.
		/// </summary>
		public void PlaceOrder() {
			if( this.OrderStatus == (int)Enums.OrderStatus.PENDING ) {
				this.orderStatus = (int)Enums.OrderStatus.SUBMITTED;
				// TODO do more stuff
			} // TODO Throw exception?
		}

		/// <summary>
		/// Generates the receipt for this order.
		/// </summary>
		/// <returns></returns>
		public string GenerateReceipt() {
			string receipt = "Receipt:\n";
			// TODO Build a receipt to be returned.
			// 1. Generate "Store" info
			receipt += "Thank you for your purchase!\n\nOrder Number: \n";

			// 2. Generate Pizzas info

			// 3. Generate Customer info

			// 4. Generate Payment (card) info

			// 5. Generate Tax, Tip, Total, Signature areas

			return receipt;
		}

		/// <summary>
		/// Fulfills the order 
		/// </summary>
		public void FulfillOrder() {
			// idk if we need this or will use it, but I included it just in case
			if( this.OrderStatus == (int)Enums.OrderStatus.SUBMITTED ) {
				this.orderStatus = (int)Enums.OrderStatus.COMPLETED;
				// TODO do more stuff
			} // TODO Throw exception?
		}
		#endregion
	}
}