﻿using System;

namespace SortedArray
{
    public static class Sorter
    {
        public static int[] SortArray(int[] unsortedArray)
        {
            for (int i = 0; i < unsortedArray.Length - 1; i++)
            {
                for (int j = 0; j < unsortedArray.Length - i - 1; j++)
                {
                    Console.WriteLine(string.Join(',', unsortedArray));
                    if (unsortedArray[j] > unsortedArray[j + 1])
                    {
                        int temp = unsortedArray[j];
                        unsortedArray[j] = unsortedArray[j + 1];
                        unsortedArray[j + 1] = temp;
                    }
                    
                }
            }
            
            return unsortedArray;
        }

        
    }
}
