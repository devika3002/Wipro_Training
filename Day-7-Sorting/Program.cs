using System;
using System.Linq;

namespace Sorting_and_searching_techniques
{
    internal class Program
    {
      
           //COUNT SORT
          

        static void CountSort(int[] arr, int maxVal)
        {
            // Create count array
            int[] count = new int[maxVal + 1];

            // Store frequency of each element
            foreach (int num in arr)
            {
                count[num]++;
            }

            int index = 0;

            // Rebuild the original array in sorted order
            for (int i = 0; i <= maxVal; i++)
            {
                while (count[i] > 0)
                {
                    arr[index] = i;
                    index++;
                    count[i]--;
                }
            }
        }

          // RADIX SORT
         

        static void RadixSort(int[] arr, int max)
        {
            // Apply counting sort for each digit (1s, 10s, 100s...)
            for (int exp = 1; max / exp > 0; exp *= 10)
            {
                CountingSortByDigit(arr, exp);
            }
        }

        // Counting sort based on a specific digit (exp)
        static void CountingSortByDigit(int[] arr, int exp)
        {
            int n = arr.Length;
            int[] output = new int[n];   // Output array
            int[] count = new int[10];   // Digits 0–9

            // Count digit frequency
            for (int i = 0; i < n; i++)
            {
                count[(arr[i] / exp) % 10]++;
            }

            // Prefix sum (cumulative count)
            for (int i = 1; i < 10; i++)
            {
                count[i] += count[i - 1];
            }

            // Build output array (stable sort)
            for (int i = n - 1; i >= 0; i--)
            {
                int digit = (arr[i] / exp) % 10;
                output[count[digit] - 1] = arr[i];
                count[digit]--;
            }

            // Copy output back to original array
            for (int i = 0; i < n; i++)
            {
                arr[i] = output[i];
            }
        }

       
           //PRINT ARRAY
        static void PrintArray(int[] arr)
        {
            foreach (int num in arr)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }

        // MAIN METHOD
        static void Main(string[] args)
        {
            //  COUNT SORT 
            int[] marks = { 78, 95, 45, 30, 60, 95, 99, 95 };

            Console.WriteLine("Original marks array for Count Sort:");
            PrintArray(marks);

            int maxMark = marks.Max();
            CountSort(marks, maxMark);

            Console.WriteLine("Sorted marks array using Count Sort:");
            PrintArray(marks);

            Console.WriteLine();

            // RADIX SORT DEMO 
            int[] regnum = { 170, 155, 999, 990, 802, 204, 1000, 166 };

            Console.WriteLine("Original regnum array for Radix Sort:");
            PrintArray(regnum);

            int maxVal = regnum.Max();
            RadixSort(regnum, maxVal);

            Console.WriteLine("Sorted regnum array using Radix Sort:");
            PrintArray(regnum);

            Console.ReadKey();
        }
    }
}
