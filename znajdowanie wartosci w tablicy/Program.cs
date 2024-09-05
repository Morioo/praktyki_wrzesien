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
        {                                               //Metoda add  oraz operator new!

            List<Producer> Prods = new List<Producer>();
            Prods.Add(
                new Producer()
                {
                    ProducerName = "Jan", ProducerId = 23                     //dodawanie elementu do listy

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