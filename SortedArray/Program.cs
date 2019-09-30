using System;

namespace SortedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = RandomIntArray.Generate(5, 10, 5);
            Sorter.SortArray(array);
            Console.Read();

            
        }
    }
}
