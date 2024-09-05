using System;
using System.Collections.Generic;

namespace Lekcja13
{
    public class ReverseComparer : IComparer<string>
    {
        public int IComparer( string x, string y)
        {
            return y.CompareTo(x);
        }
    }
    class Program
    {

        static void Main(string[] args)
        {                                                           //method bin search 2!
            string[] animals = { "Słoń", "Papuga", "Lew", "Ptasznik", "Królik" }; //array

            foreach (string animal in animals)
            {                                               //array display
                Console.WriteLine(animal);
            }

            ReverseComparer revComp = new ReverseComparer(); //createing class
            Console.WriteLine("Sortowanie");
            Array.Sort(animals, revComp);
            foreach (string animal in animals )
            {
                Console.WriteLine(animal);
            }
            Console.WriteLine("Wyszukiwanie żaby");
            int i = Array.BinarySearch(animals, "Papuga", revComp);
            ShowArr(animals, i);
            Console.WriteLine("Wyszukiwanie słonia");
            i = Array.BinarySearch(animals, "Słoń", revComp);
            ShowArr(animals, i);

        }
        public static void ShowArr<T>(T[] arr, int index)
        {
            if (index < 0)
            {
                index = ~index;
                Console.WriteLine("Nie znaleziono Papugi");
        if (index == 0)
                {
                    Console.WriteLine("Początek tablicy");
                }
                else
                {
                    Console.WriteLine("Odnaleziono {0} oraz", arr[index - 1]);
                }
        if (index == arr.Length)
                {
                    Console.WriteLine("Zakończenie tablicy");
                }
                else
                {
                    Console.WriteLine("Oraz odnaleziono {0}", arr[index]);
                }
            }
            else
            {
                Console.WriteLine("Znalezono element przy indeksie {0}", index);
            }
        }


    }
}
