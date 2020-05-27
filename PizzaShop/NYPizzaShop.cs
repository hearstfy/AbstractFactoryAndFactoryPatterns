using AbstractFactoryAndFactoryPatterns.Ingredients.Factory;
using AbstractFactoryAndFactoryPatterns.Pizzas;

namespace AbstractFactoryAndFactoryPatterns.PizzaShops
{
    public class NYPizzaShop : PizzaShop
    {

        public override Pizza createPizza(string type)
        {
            ingredientFactory = new NYPizzaIngredientFactory();

            if (type.Equals("Cheese"))
            {
                pizza = new CheesePizza(ingredientFactory);
                pizza.setName("New York Style Cheese Pizza");
            }
            else if (type.Equals("Clam"))
            {
                pizza = new ClamPizza(ingredientFactory);
                pizza.setName("New York Style Clam Pizza");
            }

            return pizza;

        }
    }
}