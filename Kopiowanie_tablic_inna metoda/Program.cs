using System;

namespace Lekcja13
{

    class Program
    {

        static void Main(string[] args)
        {

            //metoda na kopiowanie tablicy
            Array sourceArr = Array.CreateInstance(typeof(string), 6);   //array, array type, number of elements

            sourceArr.SetValue("To", 0);                          //array elements
            sourceArr.SetValue("jest", 1);
            sourceArr.SetValue("bardzo", 2);
            sourceArr.SetValue("bardzo", 3);
            sourceArr.SetValue("fajny", 4);
            sourceArr.SetValue("czajnik", 5);

            Array targetArr = Array.CreateInstance(typeof(String), 15);
            targetArr.SetValue("A to ", 0);
            targetArr.SetValue("nie", 1);
            targetArr.SetValue("jest", 2);
            targetArr.SetValue("bardzo bardzo", 3);
            targetArr.SetValue("fajny", 4);
            targetArr.SetValue("czajnik", 5);
            targetArr.SetValue("bo", 6);
            targetArr.SetValue("jest", 7);
            targetArr.SetValue("zepsuty", 8);
            Console.WriteLine("Tablica źródłowa");

            DisplayArr(sourceArr, ' ');       //method\
            Console.WriteLine("Tablica docelowa przed kopiowaniem");
           DisplayArr(targetArr, ' ');
            sourceArr.CopyTo(targetArr, 6);   //Copy
            Console.WriteLine("Po kopiowaniu !");
            DisplayArr(targetArr, ' ');

        }
        public static void DisplayArr(Array arr, char sep)
        {

            System.Collections.IEnumerator e = arr.GetEnumerator();
            int i = 0;
            int cols = arr.GetLength(arr.Rank - 1);
            while (e.MoveNext())
            {
                if (i < cols)
                {
                    i++;
                }
                else
                {
                    Console.WriteLine("******");
                    i = 1;
                }

                Console.WriteLine("{0}{1}", sep, e.Current);
            }
            Console.WriteLine("***********");

        }
    }
}
