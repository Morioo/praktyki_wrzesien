using System;

namespace Lekcja13
{

    class Program
    {

        static void Main(string[] args)
        {


            Array iarr = Array.CreateInstance(typeof(Int32), 5);       //metoda binary search
            iarr.SetValue(8, 0);
            iarr.SetValue(2, 1);
            iarr.SetValue(6, 2);
            iarr.SetValue(3, 3);
            iarr.SetValue(7, 4);
            Array.Sort(iarr);
            Console.WriteLine("Tablica zawiera elementy ");
            DisplayArr(iarr);


            object elementIsNot = 1;
            FindE1(iarr, elementIsNot);
            object elementIs = 6;
            FindE1(iarr, elementIs);

        }
        public static void FindE1(Array arr, object obj)
        {
            int index = Array.BinarySearch(arr, obj);
            if (index < 0)
            {
                Console.WriteLine("element nie znaleziony");
            }
            else
            {
                Console.WriteLine("element został znaleziony");
            }
        }

        public static void DisplayArr(Array arr)
        {

            int i = 0;
            int cols = arr.GetLength(arr.Rank - 1);
            foreach (object o in arr)
            {
                if (i < cols)
                {
                    i++;
                }
                else
                {
                    Console.WriteLine();
                    i = 1;
                }
                Console.WriteLine("\t{0}", o);
            }
            Console.WriteLine();


        }


    }
}