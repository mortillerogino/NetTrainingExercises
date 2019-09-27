using System;

namespace SortedArray
{
    public static class RandomIntArray
    {
        public static int[] Generate(int lowest, int highest, int size)
        {
            Random r = new Random();
            int[] intArray = new int[size];

            for (int i = 0; i < size; i++)
            {
                intArray[i] = r.Next(lowest, highest + 1);
            }

            return intArray;
        }
    }
}
