using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            int[] inputArray;
            int inputArrayLength;
            
            Console.Write("Enter the length of array to be sorted: ");
            inputArrayLength = int.Parse(Console.ReadLine());
            
            inputArray = new int[inputArrayLength];

            Console.WriteLine("Enter the array elements in separate lines:");
            for(int i =0; i < inputArrayLength; i++)
            {
                inputArray[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Your input Array is:");
            for (int i = 0; i < inputArrayLength; i++)
            {
                Console.Write($"{inputArray[i]} ");
            }

            // Calling the BubbleSort method with input array as the argument (default: pass by reference)
            Console.WriteLine("\nRunning Bubble Sort on the input array:");
            BubbleSort(inputArray);

            for (int i = 0; i < inputArrayLength; i++)
            {
                Console.Write($"{inputArray[i]} ");
            }

            Console.ReadLine();
        }

        // Declaring and Defining BubbleSort method ; takes integer array as parameter
        // Compares neighbouring elements for greater value and swaps them
        // In one pass over the array, only the highest value reaches the end of the unsorted array, so multiple loops are needed 
        public static void BubbleSort(int[] unsortedArray)
        {
            // A swapped variable keeps track whether no swap is needed ; array is already sorted; saves time
            int swapped = 0;

            // Looping over the array N-1 times, since Nth element will be already sorted in (N-1)th pass 
            for (int i = 0; i < unsortedArray.Length -1 ; i++)
            {
                // Looping over the elements which are not yet sorted; last (i+1) elements are already sorted in the last pass
                for (int j = 0; j < (unsortedArray.Length - i - 1); j++)
                {
                    // Performing comparison and swapping only if next element is lower; higher value bubbles up
                    if (unsortedArray[j] > unsortedArray[j + 1])
                    {
                        swapped = 1;
                        // Calling another function for swapping and passing reference for the elements
                        // In absence of reference, elements are copied, then swapped - no change in original array (pass by value default)
                        swapElements(ref unsortedArray[j], ref unsortedArray[j + 1]);
                    }
                    else
                    {
                        swapped = 0;
                    }
                }


                // If the elements are already sorted, it will never enter the comaprison 'if' block in any one complete pass over the array
                if (swapped == 0)
                {
                    Console.WriteLine("No further pass needed. Array already sorted in Ascending order\n");
                    break;
                }

                // Printing state of the array after every pass
                Console.Write($"Pass {i+1} :");
                for (int k = 0; k < unsortedArray.Length; k++)
                {
                    Console.Write($"{unsortedArray[k]} ");
                }
                Console.Write('\n');
            }
        }
         
        public static void swapElements(ref int first, ref int second)
        {
            first = second + first;
            second = first - second;
            first = first - second;
        }

    }
}
