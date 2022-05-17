using System;
using System.Collections.Generic;

namespace WCS_1_list
{
    class Program
    {
        static void Main()
        {
            List<string> stringCollection = new List<string>();
            stringCollection.Add("one");
            stringCollection.Add("two");
            stringCollection.Add("three");

            foreach (string item in stringCollection)
            {
                Console.WriteLine(item);
            }

            stringCollection.RemoveAt(0);
            stringCollection.Remove("three");
            stringCollection[0] = "Viva l'Algérie";

            foreach (string item in stringCollection)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
