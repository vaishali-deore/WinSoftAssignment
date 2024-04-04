using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonRepeating
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "abacdbe";

            Dictionary<char, int> charCount = new Dictionary<char, int>();

            foreach (char c in str)
            {
                if (charCount.ContainsKey(c))
                    charCount[c]++;
                else
                    charCount[c] = 1;
            }

            Console.WriteLine("Non-repeating characters:");
            foreach (var pair in charCount)
            {
                if (pair.Value == 1)
                    Console.WriteLine(pair.Key);
            }
                    Console.ReadLine();
        }
    }
}
/*
Answer of this ques :: 
input :: str =  "abacdbe";
output :: Non-repeating characters:
c
d
e

 
 */