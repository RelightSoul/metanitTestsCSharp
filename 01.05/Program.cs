using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int j = 2;
            for (int i = 1; i < 100; i = i + 2)
            {
                j = j - 1;
                while (j < 15)
                {
                    j = j + 5;
                }
            }
            // Сколько раз в этом цикле будет выполняться строка j = j - 1;
            #region Answer
            // 50 раз.
            #endregion
        }
    }
}
