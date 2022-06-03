// See https://aka.ms/new-console-template for more information
using System;
namespace AlgorithamProblems
{
    class program
    {


        public static void Main(String[] args)
        {
            
            int[] arr = { 12, 11, 13, 5, 6, 7 };
            Console.WriteLine("Given Array " );
            Console.WriteLine(arr);
            Algorithms.MergeSort ob = new Algorithms.MergeSort();
            ob.sort(arr, 0, arr.Length - 1);
            Console.WriteLine("\nSorted array");
            ob.printArray(arr);
        }


    }
}
