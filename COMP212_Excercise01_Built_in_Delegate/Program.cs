using System;

/*This Assignment is for COMP 212- Prof Sujeet Lohan
 * TASKS:
 * Create a C# app in which you are required to create the following methods using built-in delegates
 * predicates and lambdas.
 * 1- string Minimum(string1,string2,string3) which returns the smallest of three string values. To test
 * this method, you need to use built-in Func<> delegate predicate
 * 2- void AvgGrade(value1, value2, value3)which displays the average of three grades. To test this method,
 * you need to use built-in Action<> delegate predicate
 */

namespace COMP212_Excercise01_Built_in_Delegate
{
    class Program
    {
        //Task1-- Creating method
        public static string Minimum(string small, string smallest, string smallers)
        {
            if(small.Length>smallest.Length)
            {
                return smallest;
            }
            else if (small.Length > smallers.Length)
            {
                return smallers;
            }
            else
            {
                return small;
            }
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
