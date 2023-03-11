using System;
using System.Collections.Generic;

namespace MoreLinq
{
    public class Program
    {
        static void Main(string[] args)
        {
            var list = new List<Func<int>>
            {
                () => 2 + 2,
                () => 2 * 5,
                () => 4 * 4,
                () => (int)Math.Pow(8, 2)
            };

            foreach (var item in list.Evaluate())
                Console.WriteLine(item);

            Console.ReadLine();
        }
    }
}
