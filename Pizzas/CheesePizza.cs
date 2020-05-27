using System;
using AbstractFactoryAndFactoryPatterns.Ingredients.Factory;

namespace AbstractFactoryAndFactoryPatterns.Pizzas
{
    public class CheesePizza : Pizza
    {
        private readonly IPizzaIngredientFactory ingredientFactory;

        public CheesePizza(IPizzaIngredientFactory ingredientFactory)
        {
            this.ingredientFactory = ingredientFactory;
        }

        public override void prepare()
        {
            Console.WriteLine("Preparing " + name);
            dough = ingredientFactory.createDough();
            sauce = ingredientFactory.createSauce();
            cheese = ingredientFactory.createCheese();
        }
    }
}