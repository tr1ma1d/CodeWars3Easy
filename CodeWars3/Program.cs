using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word1 = "world";
            string word2 = "word";

            char[] arr = word1.Reverse().ToArray();
            Console.WriteLine(arr);
            char[] barr = word2.Reverse().ToArray();
            Console.WriteLine(barr);
        }
    }
}
