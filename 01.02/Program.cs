using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 4;
            int num2 = 5;   
            int num3 = 15;   
            int num4 = 10;
            int num5 = 5;
            int result = 12;
            result += num1 * num2 + num3 % num4 / num5; //Посчитать                                                        //
            #region Описание ответа
            // x * y, x / y, x % у одинаковый приоритет
            int a = num1 * num2; //20
            int b = num3 % num4; //5
            int c = b / num5; //1
            int d = a + c; //20
            int e = result + d; //33
            Console.WriteLine(result);
            #endregion

            Console.ReadLine();
        }
    }
}
