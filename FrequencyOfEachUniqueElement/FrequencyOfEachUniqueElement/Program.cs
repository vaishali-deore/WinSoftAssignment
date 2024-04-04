using System;
using System.Collections.Generic;

namespace FrequencyOfEachUniqueElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 2, 3, 3, 3, 4,4,4,4 };

            Dictionary<int, int> frequencyMap = new Dictionary<int, int>();

            foreach (int num in array)
            {
                if (frequencyMap.ContainsKey(num))
                    frequencyMap[num]++;
                else
                    frequencyMap[num] = 1;
            }

            Console.WriteLine("Output :: ");
            foreach (var kvp in frequencyMap)
            {
                Console.WriteLine("Element : "+kvp.Key + "\t" + "Frequency : "+ kvp.Value);
            }
                Console.ReadLine(); 

        }
    }
}


/*
 * Input:
int[] numbers = { 1, 2, 2, 3, 3, 3, 4, 4, 4, 4 };

Output ::
Element : 1     Frequency : 1
Element : 2     Frequency : 2
Element : 3     Frequency : 3
Element : 4     Frequency : 4


 
 */