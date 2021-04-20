using System;
using System.Collections.Generic;

namespace DesignPatternConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            StarbuzzCoffeeFirst();
            StarbuzzCoffeeSecond();
            StarbuzzCoffeeThirdDecorator();

        }

        static public void StarbuzzCoffeeFirst()
        {
            Console.WriteLine("StarbuzzCoffee 1st");
            List<StarbuzzCoffee.FirstDesign.Beverage> beverages = new();
            beverages.Add(new StarbuzzCoffee.FirstDesign.DarkRoast());
            beverages.Add(new StarbuzzCoffee.FirstDesign.DarkRoastWithMilk());
            beverages.Add(new StarbuzzCoffee.FirstDesign.HouseBlend());
            foreach (StarbuzzCoffee.FirstDesign.Beverage beverage in beverages)
            {
                Console.WriteLine($"{beverage.Title}: {beverage.Description}, cost: {beverage.Cost()}");
            }
            Console.WriteLine();
        }
        static public void StarbuzzCoffeeSecond()
        {
            Console.WriteLine("StarbuzzCoffee 2nd");
            List<StarbuzzCoffee.SecondDesign.Beverage> beverages = new();
            beverages.Add(new StarbuzzCoffee.SecondDesign.DarkRoast());
            beverages.Add(new StarbuzzCoffee.SecondDesign.DarkRoast() { Milk = true, Whip=true});
            beverages.Add(new StarbuzzCoffee.SecondDesign.HouseBlend());
            foreach (StarbuzzCoffee.SecondDesign.Beverage beverage in beverages)
            {
                Console.WriteLine($"{beverage.Title}: {beverage.Description}, cost: {beverage.Cost()}");
            }
            Console.WriteLine();
        }
        static public void StarbuzzCoffeeThirdDecorator()
        {
            Console.WriteLine("StarbuzzCoffee 3rd - Decorator");
            List<StarbuzzCoffee.ThirdDesignDecorator.Beverage> beverages = new();
            beverages.Add(new StarbuzzCoffee.ThirdDesignDecorator.Espresso() 
                { 
                    Size = StarbuzzCoffee.ThirdDesignDecorator.Beverage.ESize.GRANDE 
                }
            );

            StarbuzzCoffee.ThirdDesignDecorator.Beverage beverage1 = new StarbuzzCoffee.ThirdDesignDecorator.Espresso();
            beverage1 = new StarbuzzCoffee.ThirdDesignDecorator.Mocha(beverage1);
            beverage1 = new StarbuzzCoffee.ThirdDesignDecorator.Mocha(beverage1);
            beverage1 = new StarbuzzCoffee.ThirdDesignDecorator.Whip(beverage1);
            beverages.Add(beverage1);

            beverages.Add(new StarbuzzCoffee.ThirdDesignDecorator.HouseBlend()
            {
                Size = StarbuzzCoffee.ThirdDesignDecorator.Beverage.ESize.VENTI
            }
            );

            StarbuzzCoffee.ThirdDesignDecorator.Beverage beverage2 = 
                new StarbuzzCoffee.ThirdDesignDecorator.HouseBlend()
            {
                Size = StarbuzzCoffee.ThirdDesignDecorator.Beverage.ESize.VENTI
            };
            beverage2 = new StarbuzzCoffee.ThirdDesignDecorator.Mocha(beverage2);
            //beverage2 = new StarbuzzCoffee.ThirdDesignDecorator.Soy(beverage2);
            //beverage2 = new StarbuzzCoffee.ThirdDesignDecorator.Whip(beverage2);
            beverages.Add(beverage2);

            foreach (StarbuzzCoffee.ThirdDesignDecorator.Beverage beverage in beverages)
            {
                Console.WriteLine($"{beverage.Description}> Cost: {beverage.Cost}");
            }
            Console.WriteLine();
        }
    }
}
