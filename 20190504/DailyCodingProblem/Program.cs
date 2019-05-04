using System;
using System.Collections.Generic;

namespace DailyCodingProblem
{
    class Program
    {
        static private ICollection<int> Problem(ICollection<int> a)
        {
            List<int> l = new List<int>();

            for (int i = 0; i < a.Count; i++)
            {
                List<int> x = new List<int>((List<int>)a);

                x[i] = 1;
                int product = 1;

                foreach (var e in x)
                {
                    product *= e;
                }

                l.Add(product);
            }

            return l;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            List<int> a = new List<int> { 1, 2, 3, 4, 5 };

            foreach (var e in Problem(a))
            {
                Console.WriteLine(e);
            }

            Console.Read();
        }
    }
}
