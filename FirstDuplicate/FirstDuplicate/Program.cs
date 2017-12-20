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
//        static void Main(string[] args)
//        {
//            int[] a = {9, 8, 7, 6, 5, 4, 3, 2, 1, 2, 3, 4, 5, 7};
//
//            var lowestIndex = a.Length;
//
//            for (var candidate = 0; candidate < lowestIndex - 1; candidate++)
//            {
//                for (var testIfDuplicate = candidate + 1; testIfDuplicate < lowestIndex; testIfDuplicate++)
//                {
//                    if (a[candidate] != a[testIfDuplicate]) continue;
//                    if (testIfDuplicate < lowestIndex)
//                    {
//                        lowestIndex = testIfDuplicate;
//                    }
//                }
//            }
//            Console.WriteLine((lowestIndex < a.Length) ? a[lowestIndex] : -1);
//        }

        static void Main(string[] args)
        {
            //int[] a = { 9, 8, 7, 6, 5, 4, 3, 2, 1, 2, 3, 4, 5, 7, 9 };
            int[] a = { 1, 2, 3, 4, 5, 4, 3, 2, 1 };
            int[] dupInts = new int[a.Length];
            var count = 0;
            var lowestIndex = a.Length;


            for (var candidate = 0; candidate < lowestIndex - 1; candidate++)
            {
                if (Array.IndexOf(dupInts, a[candidate]) != -1)
                {
                    break;
                }
                var index = Array.IndexOf(a, a[candidate], candidate + 1);
                if (index < lowestIndex && index != -1)
                {
                    lowestIndex = index;
                }
                dupInts[count] = a[candidate];
            }
            Console.WriteLine((lowestIndex < a.Length) ? a[lowestIndex] : -1);
        }
    }
}
