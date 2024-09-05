using System;
using System.Collections.Generic;

namespace Lekcja13
{
    public class Producer
    {
        public string ProducerName { get; set; } 
        public int ProducerId { get; set; }

    }


    class Program
    {

        static void Main(string[] args)
        {                                               //The add method and the new operator

            List<Producer> Prods = new List<Producer>();
            Prods.Add(
                new Producer()
                {
                    ProducerName = "Jan", ProducerId = 23                     //adding an item to the list

                }
            );
            Prods.Add(
                new Producer()
                {
                    ProducerName = "Tomasz",
                    ProducerId = 43
                });
            Prods.Add(
                new Producer()
                {
                    ProducerName = "Nogers",
                    ProducerId = 88
                });

            Console.WriteLine("*******");
            foreach (Producer prod in Prods)
            {
                Console.WriteLine(prod.ProducerName);
            }






        }



    }
}
