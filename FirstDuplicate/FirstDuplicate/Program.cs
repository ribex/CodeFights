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
            int[] a = {9, 8, 7, 6, 5, 4, 3, 2, 1, 2, 3, 4, 5, 7};
            var lowestIndex = a.Length;

            for (var candidate = 0; candidate < lowestIndex - 1; candidate++)
            {
                for (var testIfDuplicate = candidate + 1; testIfDuplicate < lowestIndex; testIfDuplicate++)
                {
                    if (a[candidate] != a[testIfDuplicate]) continue;
                    if (testIfDuplicate < lowestIndex)
                    {
                        lowestIndex = testIfDuplicate;
                    }
                }
            }
            Console.WriteLine((lowestIndex < a.Length) ? a[lowestIndex] : -1);
        }
    }
}
