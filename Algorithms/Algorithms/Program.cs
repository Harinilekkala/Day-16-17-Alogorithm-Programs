// See https://aka.ms/new-console-template for more information
using System;
namespace AlgorithamProblems
{
    class program
    {

        public static void Main(String[] args)
        {
            String[] input = { "Harini", "Harshini", "Harshitha", "Haritha" };
            String find = "Harshini";
            Algorithms.BinarySearch example = new Algorithms.BinarySearch();
            int result = example.binarySearch(input, find);

            if (result == -1)
                Console.WriteLine("Element not present");
            else
                Console.WriteLine("Element found at " + "index " + result);
        }

    }



}
