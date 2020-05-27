using AbstractFactoryAndFactoryPatterns.Ingredients.Factory;
using AbstractFactoryAndFactoryPatterns.Pizzas;

namespace AbstractFactoryAndFactoryPatterns.PizzaShops
{
    public class ChicagoPizzaShop : PizzaShop
    {
        public override Pizza createPizza(string type)
        {
            ingredientFactory = new ChicagoPizzaIngredientFactory();

            if (type.Equals("Cheese"))
            {
                pizza = new CheesePizza(ingredientFactory);
                pizza.setName("Chicago Style Cheese Pizza");
            }
            else if (type.Equals("Clam"))
            {
                pizza = new ClamPizza(ingredientFactory);
                pizza.setName("Chicago Style Clam Pizza");
            }
            return pizza;
        }
    }
}