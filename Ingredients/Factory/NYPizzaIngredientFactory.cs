using AbstractFactoryAndFactoryPatterns.Ingredients.Cheese;
using AbstractFactoryAndFactoryPatterns.Ingredients.Clams;
using AbstractFactoryAndFactoryPatterns.Ingredients.Dough;
using AbstractFactoryAndFactoryPatterns.Ingredients.Pepperoni;
using AbstractFactoryAndFactoryPatterns.Ingredients.Sauce;
using AbstractFactoryAndFactoryPatterns.Ingredients.Vegetable;

namespace AbstractFactoryAndFactoryPatterns.Ingredients.Factory
{
    public class NYPizzaIngredientFactory : IPizzaIngredientFactory
    {
        public ICheese createCheese()
        {
            return new ReggianoCheese();
        }

        public IClams createClams()
        {
            return new FreshClams();
        }

        public IDough createDough()
        {
            return new ThinCrustDough();
        }

        public IPepperoni createPepperoni()
        {
            return new SlicedPepperoni();
        }

        public ISauce createSauce()
        {
            return new MarinaraSauce();
        }

        public IVegetable[] createVeggies()
        {
            IVegetable[] veggies = { new Garlic(), new Onion(), new Mushroom(), new RedPepper() };
            return veggies;
        }
    }
}