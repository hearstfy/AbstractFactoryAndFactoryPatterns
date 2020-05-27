using System;
using AbstractFactoryAndFactoryPatterns.Pizzas;
using AbstractFactoryAndFactoryPatterns.PizzaShops;

namespace AbstractFactoryAndFactoryPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            PizzaShop nyShop = new NYPizzaShop();
            PizzaShop chicagoShop = new ChicagoPizzaShop();

            Pizza pizza = nyShop.orderPizza("Cheese");
            Console.WriteLine($"Ethan ordered a {pizza.getName()}");

            pizza = chicagoShop.orderPizza("Cheese");
            Console.WriteLine($"Joel ordered a {pizza.getName()}");
        }
    }
}
