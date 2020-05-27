using AbstractFactoryAndFactoryPatterns.Ingredients.Factory;
using AbstractFactoryAndFactoryPatterns.Pizzas;


namespace AbstractFactoryAndFactoryPatterns.PizzaShops
{
    public abstract class PizzaShop
    {
        public Pizza pizza;
        public IPizzaIngredientFactory ingredientFactory;

        public Pizza orderPizza(string type)
        {
            pizza = createPizza(type);
            pizza.prepare();
            pizza.bake();
            pizza.cut();
            pizza.box();

            return pizza;
        }

        public abstract Pizza createPizza(string type);
    }
}