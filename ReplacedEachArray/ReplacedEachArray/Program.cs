using System;
using System.Linq;

namespace ReplacedEachArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 10, 8, 15, 12, 6, 20, 1 };

           
            int[] sortedArray = array.OrderBy(x => x).ToArray();

            var rankDict = sortedArray.Select((value, index) => new { value, index })
                                      .ToDictionary(pair => pair.value, pair => pair.index + 1);

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rankDict[array[i]];
            }

            Console.WriteLine("Answer: " + string.Join(", ", array));
            Console.ReadLine();
        }

    }
}
