using System;
using System.ComponentModel.Design;

namespace Lekcja13
{
    public class charSercher
    {
        Char firstchar;
        public charSercher(char ch)
        {
            this.firstchar = Char.ToUpper(ch);
        }
        public bool starts(String str)
        {
            if (String.IsNullOrEmpty(str))
                return false;
            if (str.Substring(0, 1).ToUpper() == firstchar.ToString())
                return true;

            else return false;
        }
        

    }
    class Program
    {

        static void Main(string[] args)
        {

            string[] namestab = { "Jasiek", "Piotrek", "Paweł", "Kaj", "Tadeusz", "Jagoda" };   //tablica string
            char[] charsToFindTab = { 'a', 'k', 'w', 'z' };   //tablica char

            foreach (var charToFind in charsToFindTab)
            {
                Console.WriteLine("Znaleziono: '{0}' : '{1}'",
                charToFind, Array.Exists(namestab, (new charSercher(charToFind)).starts
                ) 
                
                );
            }




        }



    }
}