using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 8;
            int y = 9;
            int z = x++ + ++y;  //Посчитать
            #region Описание ответа
            int a = ++y; // 10
            int b = x++; // 8
            int c = a + b; //18
            Console.WriteLine(z);
            #endregion

            Console.ReadLine();
        }
    }
}
