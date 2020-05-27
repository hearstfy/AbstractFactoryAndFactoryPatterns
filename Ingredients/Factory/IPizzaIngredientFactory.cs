using AbstractFactoryAndFactoryPatterns.Ingredients.Cheese;
using AbstractFactoryAndFactoryPatterns.Ingredients.Clams;
using AbstractFactoryAndFactoryPatterns.Ingredients.Dough;
using AbstractFactoryAndFactoryPatterns.Ingredients.Pepperoni;
using AbstractFactoryAndFactoryPatterns.Ingredients.Sauce;
using AbstractFactoryAndFactoryPatterns.Ingredients.Vegetable;

namespace AbstractFactoryAndFactoryPatterns.Ingredients.Factory
{
    public interface IPizzaIngredientFactory
    {
        IDough createDough();
        ISauce createSauce();
        ICheese createCheese();
        IVegetable[] createVeggies();
        IPepperoni createPepperoni();
        IClams createClams();

    }
}