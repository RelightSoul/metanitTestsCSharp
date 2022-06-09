using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._01.MetanitTestsCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 2;
            int n2 = 5;
            int result = n2 * 3 + 20 / 2 * n1--; //Посчитать
            #region Описание ответа
            // Выражение n1-- уменьшит переменную n1 на единицу, но возвратит ее предыдущее значение          
            int a = n1--;   //2
            int b = n2 * 3; // 15
            int c = 20 / 2; // 10
            int d = c * a;  // 20
            int result2 = b + d; //35
            Console.WriteLine(result);            
            #endregion

            Console.ReadLine();
        }
    }
}
