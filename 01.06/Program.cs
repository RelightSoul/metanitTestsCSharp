using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 3; i++)
            {
                switch (i)
                {
                    default:
                        Console.WriteLine($"i = {i++}");
                        break;
                }

            }
            // Сколько раз выполнится?
            Console.ReadLine();
        }
    }
}
