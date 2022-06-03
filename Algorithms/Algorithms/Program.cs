// See https://aka.ms/new-console-template for more information
using System;
namespace AlgorithamProblems
{
    class program
    {
        public static void Main(String[] args)
        {
            String s;
            String answer = "";

            Console.Write("Enter the string: ");
            s = Console.ReadLine();

            Console.Write("\nAll possible strings are : ");
            Algorithms.Permetuation value = new Algorithms.Permetuation();
            value.Permute(s, answer);

        }
    }
}
