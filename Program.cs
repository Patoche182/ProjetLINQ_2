using System;
using System.Linq;

namespace ProjetLINQ_2
{
    internal class Program
    {
        public static Program p = new Program();

        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 2, 2, 4, 2, 6, 7, 8, 8, 9, 0, 3 };

            var myQuery = from nb in numbers where nb > 2 select nb; // requete type MySQL

            Console.WriteLine("------");
            foreach (var nb in numbers.Distinct()) // Distinct (pas en double)
            {
                Console.WriteLine(nb);
            }

            Console.WriteLine("------");
            foreach (var nb in myQuery)
            {
                Console.WriteLine(nb);
            }

            Console.WriteLine("------");
            // Console.WriteLine(myQuery.First());
            Console.WriteLine("First = " + myQuery.FirstOrDefault());
            //Console.WriteLine(myQuery.Last());
            Console.WriteLine("Last = " + myQuery.LastOrDefault());
            Console.WriteLine("Element position 3 = " + myQuery.ElementAt(3));
            Console.WriteLine("Element position 12 dans numbers = " + numbers.ElementAt(12));
        }
    }
}
