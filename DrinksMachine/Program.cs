using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinksMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Collections and Linq

            Hashtable prices = new Hashtable();

            prices.Add("Café au Lait", 1.99M);
            prices.Add("Café Americano", 1.89M);
            prices.Add("Café Mocha", 2.99M);
            prices.Add("Cappuccino", 2.49M);
            prices.Add("Espresso", 1.49M);
            prices.Add("Espresso Romano", 1.59M);
            prices.Add("English Tea", 1.99M);
            prices.Add("Juice", 1.99M);

            Console.Write("Press any key:");
            Console.ReadKey();

            #endregion

            #region Drinks Struct
            Drinks.Coffee coffee = new Drinks.Coffee(0, "Arabica", "Kenya");

            Console.WriteLine("Country of orgin: {0}", coffee.CountryOfOrigin);
            Console.WriteLine("Bean:             {0}", coffee.Bean);
            Console.WriteLine("Strength:         {0}", coffee.Strength);

            Console.Write("Press any key:");
            Console.ReadKey();

            Drinks.Coffee coffee1 = new Drinks.Coffee()
            {
                Strength = 3,
                Bean = "Ingen",
                CountryOfOrigin = "Kina",
                Temperature = 20
            };

            coffee.Strength = 7;

            Console.WriteLine("Country of orgin: {0}", coffee.CountryOfOrigin);
            Console.WriteLine("Bean:             {0}", coffee.Bean);
            Console.WriteLine("Strength:         {0}", coffee.Strength);

            Console.Write("Press any key:");
            Console.ReadKey();
            #endregion
        }
    }
}
