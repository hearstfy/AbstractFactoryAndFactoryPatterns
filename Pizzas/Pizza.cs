using System;
using AbstractFactoryAndFactoryPatterns.Ingredients.Cheese;
using AbstractFactoryAndFactoryPatterns.Ingredients.Clams;
using AbstractFactoryAndFactoryPatterns.Ingredients.Dough;
using AbstractFactoryAndFactoryPatterns.Ingredients.Pepperoni;
using AbstractFactoryAndFactoryPatterns.Ingredients.Sauce;
using AbstractFactoryAndFactoryPatterns.Ingredients.Vegetable;

namespace AbstractFactoryAndFactoryPatterns.Pizzas
{
    public abstract class Pizza
    {
        protected string name;
        protected IDough dough;
        protected ISauce sauce;
        protected IVegetable[] veggies;
        protected ICheese cheese;
        protected IPepperoni pepperoni;
        protected IClams clams;

        public abstract void prepare();

        public void bake()
        {
            Console.WriteLine("Bake for 25 minutes at 350");
        }

        public virtual void cut()
        {
            Console.WriteLine("Cutting the pizza into diagonal slices");
        }

        public void box()
        {
            Console.WriteLine("Place pizza in official PizzaStore box");
        }

        public string getName()
        {
            return name;
        }

        public void setName(string name)
        {
            this.name = name;
        }
    }
}