using AbstractFactoryAndFactoryPatterns.Ingredients.Cheese;
using AbstractFactoryAndFactoryPatterns.Ingredients.Clams;
using AbstractFactoryAndFactoryPatterns.Ingredients.Dough;
using AbstractFactoryAndFactoryPatterns.Ingredients.Pepperoni;
using AbstractFactoryAndFactoryPatterns.Ingredients.Sauce;
using AbstractFactoryAndFactoryPatterns.Ingredients.Vegetable;

namespace AbstractFactoryAndFactoryPatterns.Ingredients.Factory
{
    public class ChicagoPizzaIngredientFactory : IPizzaIngredientFactory
    {
        public ICheese createCheese()
        {
            return new Mozzarella();
        }

        public IClams createClams()
        {
            return new FrozenClams();
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
            return new PlumTomatoSauce();
        }

        public IVegetable[] createVeggies()
        {
            throw new System.NotImplementedException();
        }
    }
}