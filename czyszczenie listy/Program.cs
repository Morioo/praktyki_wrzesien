using System;
using System.Collections.Generic;

namespace Lekcja13
{

    class Program
    {

        static void Main(string[] args)
        {
            //czyszczenie listy

            List<string> employees = new List<string>();
            employees.Add("Jan");
            employees.Add("Jan1");
            employees.Add("Jan2");
            employees.Add("Jan3");
            employees.Add("Jan4");

            foreach(string emp in employees){
                Console.WriteLine(emp);
            }
            Console.WriteLine("Ilość elementów {0}", employees.Count);

            employees.Clear(); //czyszczenie elementów
            Console.WriteLine("ilość elementów {0}", employees.Count);








        }




        }



    }
