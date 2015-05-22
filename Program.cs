using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueryingFruit
{
    class Program
    {

        static void newLine()
        {
            Console.WriteLine("\n");
        }

        static Fruit[] loadFruits()
        {
            var fruits = new[] { new Fruit("apple", 4),
                                 new Fruit("grape", 1), 
                                 new Fruit("kiwi", 2), 
                                 new Fruit("watermelon",8),
                                 new Fruit("Gum Gum", "Rubber-man", PowerLevel.SUPERNOVA),
                                 new Fruit("Fire Fire", "Fire", PowerLevel.DIVISION_COMMANDER),
                                 new Fruit("Quake Quake", "Earthquake", PowerLevel.YONKO),
                                 new Fruit("Ice Ice", "Ice", PowerLevel.ADMIRAL),
                                 new Fruit("strawberry", 2),
                                 new Fruit("Magma Magma", "Magma", PowerLevel.ADMIRAL),
                                 new Fruit("Smoke Smoke", "Smoke", PowerLevel.CAPTAIN),
                                 new Fruit("watermelon",8),
                                 new Fruit("banana", 2),
                                 new Fruit("blueberry", 1)
                               };
            return fruits;
        }

        static void queryFruitByNameAscending(Fruit[] fruits)
        {
            IEnumerable<Fruit> query =
                    from fruit in fruits
                    orderby fruit.Name ascending
                    select fruit;

            foreach(var fruit in query)
            {                
                if (fruit.Name.Length >= 10)
                    Console.WriteLine("Fruit: " + fruit.Name + "\tDiam: " + fruit.Diameter);
                else
                    Console.WriteLine("Fruit: " + fruit.Name + "\t\tDiam: " + fruit.Diameter);              
            }
        }

        static void queryFruitByDiameterAscending(Fruit[] fruits)
        {
            IEnumerable<Fruit> query =
                    from fruit in fruits
                    orderby fruit.Diameter ascending
                    select fruit;

            foreach (var fruit in query)
            {
                if (fruit.Name.Length >= 10)
                    Console.WriteLine("Fruit: " + fruit.Name + "\tDiam: " + fruit.Diameter);
                else
                    Console.WriteLine("Fruit: " + fruit.Name + "\t\tDiam: " + fruit.Diameter);
            }
        }

        static void Main()
        {           
            /* Using Anonymous data types */
            var austin = new { lastName = "Vazquez\n", color = "blue", number = 4 };
            Console.WriteLine("\n\t\t\tAustin " + austin.lastName);

            var fruits = loadFruits();

            /* Querying by properties */
            var DevilFruitsNames =
                from fruit in fruits
                where !fruit.normalFruit()
                orderby fruit.PowerLevel ascending
                select fruit.PowerLevel;

            var NonDevilFruitsNames =
                from fruit in fruits
                where fruit.normalFruit() && fruit.Name.StartsWith("b")
                orderby fruit.Name ascending
                select fruit.Name;

            foreach (var fruit in NonDevilFruitsNames)
            {
                Console.WriteLine(fruit);
            }
        }
    }
}
