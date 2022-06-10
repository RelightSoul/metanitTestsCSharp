using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 5;
            while (i > 0) 
            {
                i *= 3;
                i *= -1;
            }
            //Сколько раз выполнится следующий цикл и почему?
            #region Answer
            // Цикл выполнится один раз. При первой же итерации значение переменной
            // i умножается на 3 и - 1, то есть оно будет равно - 15.Посколько цикл
            // продолжается, пока значение переменной i больше 0, то после первой
            // итерации произойдет выход из цикла.
            #endregion
        }
    }
}
