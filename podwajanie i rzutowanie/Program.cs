using System;

namespace Lekcja13
{

    class Program
    {

        static void Main(string[] args)
        {


            string[] animals = { "Pantera", "Kot", "Koń", "Żyrafa", "Tygrys" };

            foreach (string animal in animals)
            {
                Console.WriteLine(animals);
            }

            string[] animsClone = (string[])animals.Clone();
            string next_animal = "Żaba";
            animsClone[0] = next_animal;
            Console.WriteLine("Orginalna Tablica");
            DisplayArr(animals);
            Console.WriteLine("Klon naszej tablicy");
            DisplayArr(animsClone);


        }
       public static void DisplayArr(Array arr)
        {
            for(int i = arr.GetLowerBound(0);i<=arr.GetUpperBound(0); i++)
            {
                Console.WriteLine("\t[{0}]:\t{1}", i, arr.GetValue(i));
            }
        }

    }
}