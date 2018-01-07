using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstNotRepeatingCharacter
{
    class Program
    {
        //      Write a solution that only iterates over the string once and uses O(1) additional memory.
        //      Given a string s, find and return the first instance of a non-repeating character in it.
        //      If there is no such character, return '_'.
        static void Main(string[] args)
        {
            var s = "abacabad";

            var len = s.Length;

            var hash = new Hashtable()[len - 1];

            // hash table for each letter of the alphabet

            for (var i = 0; i < len; i++)
            {
                // if character exists in hash
                // note that
                // else
                // do something
            }
            // no such character
            Console.WriteLine("_");
        }
    }
}
