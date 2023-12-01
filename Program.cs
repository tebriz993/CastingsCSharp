using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkCastingTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] basket = new string[] { "Apple", "Pinapple", "Orange" };
            foreach (var fruits in basket)
            {
                Console.WriteLine(fruits);
            }
        }
    }


    abstract class Fruit
    {
        public int Price { get; set; }
        public string Sort { get; set; }

        public abstract void Taste();



    }

    class Apple : Fruit
    {
        public int vitaminA = 27;
        public int vitaminB = 33;



        public override void Taste()
        {
            Console.WriteLine();
        }


    }

    class Pineapple : Fruit
    {
        public int vitaminE = 56;
        public int vitaminD = 19;

        public override void Taste()
        {
            Console.WriteLine();
        }
    }

    class Orange : Fruit
    {
        public int vitaminC = 88;

        public override void Taste()
        {
            Console.WriteLine();
        }

    }
}
