using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDuplicate
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 4, 5, 4, 3, 2, 1 };

            for (var index = 0; index < a.Length; index++)
            {
                var pos = Math.Abs(a[index]) - 1;
                if (a[pos] < 0)
                {
                    Console.WriteLine(Math.Abs(a[index]));
                }
                else
                {
                    a[pos] = -a[pos];
                }
            }
            Console.WriteLine(-1);
        }
    }
}
