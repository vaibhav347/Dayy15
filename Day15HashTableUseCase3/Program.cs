using System;
using System.Collections;

namespace Day15HashTableUseCase3
{
    class Program
    {
        public static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();

            ht.Add("001", "To");
            ht.Add("002", "Be");
            ht.Add("003", "Or");
            ht.Add("004", "Not");
            ht.Add("005", "To");
            ht.Add("006", "Be");

            // Get a collection of the keys.
            ICollection key = ht.Keys;

            foreach (string k in key)
            {
                Console.WriteLine(k + ": " + ht[k]);
            }
            Console.ReadKey();
        }
    }
}

    




