// See https://aka.ms/new-console-template for more information
using System;
namespace AlgorithamProblems
{
    class program
    {

        public static void Main(String[] args)
        {

            string[] names = { "Harini Lekkala", "Ojaswi Bandaru", "Vineela Bandaru", "Shanthi Lekkala" };
            Algorithms.Insertion value = new Algorithms.Insertion();
            value.InsertionSort(names);
            foreach (var item in names)
            {
                Console.WriteLine(item);
            }



        }


    }
}