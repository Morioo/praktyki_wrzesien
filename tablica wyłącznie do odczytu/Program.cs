using System;
using System.Collections.Generic;
namespace Lekcja13
{

    class Program
    {

        static void Main(string[] args)
        {

            List<string> sportArr = new List<string>(4);
            Console.WriteLine("Pojemnośc {0}", sportArr.Capacity);

            sportArr.Add("Biegi");
            sportArr.Add("Wspinaczka");
            sportArr.Add("Piłka");
            sportArr.Add("Skakanka");
            Console.WriteLine("Wypisanie");

            foreach (string sp in sportArr)
            {
                Console.WriteLine(sp);
            }

            Console.WriteLine("Tylko do odczytu");
            IList<string> isportsArr = sportArr.AsReadOnly();

            foreach (string isp in isportsArr)
            {
                Console.WriteLine(isp);
            }
            Console.WriteLine("Modyfikacja");
            isportsArr[2] = "Lekka Atletyka";

            foreach (string isp in isportsArr)
            {
                Console.WriteLine(isp);
            }
                
            

        }



    }
}