using System;

namespace PizzaOrderingSystem {
    public class Pizza {
        #region Private Variables
        private int pizzaSize;
        private Ingredient[] ingredients = new Ingredient[100];
        #endregion

        #region Properties
        public int PizzaSize {
            get { return this.pizzaSize; }
            set {
                if ( value <= (int)Enums.PizzaSize.LARGE && value >= (int)Enums.PizzaSize.SMALL ) {
                    this.pizzaSize = value;
                }
            }
        }
        public Ingredient[] Ingredients {
            get { return this.ingredients; }
        }
        #endregion

        #region Constructors
        public Pizza ( int pizzaSize, Ingredient[] ingredients ) {
            this.PizzaSize = pizzaSize;
            this.ingredients = ingredients;
        }
        #endregion

        #region Methods
        public void AddIngredient(Ingredient ingredient) {

        }

        public void RemoveIngredient(Ingredient ingredient) {

        }

        //I need help here. Seriously.
        public override string ToString()
        {
            string size = "";
            string[] iName = new string[100];

            if (pizzaSize == 0)
            {
                size = "Small Pizza: ";
            }

            else if (pizzaSize == 1)
            {
                size = "Medium Pizza: ";
            }

            else if (pizzaSize == 2)
            {
                size = "Large Pizza: ";
            }

            for (int i = 0; i <= ingredients.Length; i++)
            {
                iName[i] = ingredients[i].name;
            }

            return size + string.Join(", ", iName);
        }

        #endregion
    }
}