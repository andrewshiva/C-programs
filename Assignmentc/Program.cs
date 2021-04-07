using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int i = 0;
        int j = 0;

        int[] arr1 = new int[5] {
         3,
         27,
         4,
         99,
         54
      };
        int[] arr2 = new int[5] {
         105,
         55,
         1,
         77,
         95
      };
        Array.Sort(arr1);
        Array.Sort(arr2);
        int[] merged = new int[10];
        int k = 0;
        for (i = 0; i < 10; i++)
        {
            if (arr1[j] > arr2[k])
            {
                merged[i] = arr2[k];
                k = k + 1;
            }
            else
            {
                merged[i] = arr1[j];
                if (j != 4)
                {
                    j = j + 1;
                }
            }
        }
        Console.WriteLine("Elements of merged array = ");
        for (i = 0; i < 10; i++)
        {
            Console.WriteLine("merged[" + (i) + "]: " + merged[i]);
        }
        Console.WriteLine();
    }
}

