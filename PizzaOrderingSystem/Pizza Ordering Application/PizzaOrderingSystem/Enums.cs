using System;

// Idea found from https://stackoverflow.com/questions/2282976/should-enums-in-c-sharp-have-their-own-file

namespace PizzaOrderingSystem {
	public class Enums {

		public enum IngredientAmount { NONE, LIGHT, NORMAL, EXTRA };
		public enum IngredientCategory { SAUCE, CHEESE, MEAT, VEGETABLE };
		public enum PizzaSize { SMALL, MEDIUM, LARGE };
		public enum OrderStatus { PENDING, SUBMITTED, COMPLETED, CANCELLED };
		public enum PaymentType { CARD, CHECK, CASH };

	}
}