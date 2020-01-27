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
        //Task1-- Creating method with three  parameters
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
        //Task 2-- Creating  void method with three parameters
        public static void AvgGrade(int grade1, int grade2, int grade3)
        {
            int averageGrade = (grade1 + grade2 + grade3) / 3;
            Console.WriteLine(averageGrade);
        }
        
        static void Main(string[] args)
        {
            //built-in Func<> Delegate Predicate
            //here the last string is the output or result/
            //the output will be small.
            Func<string, string, string, string> smallestOfAll = Minimum;
            string result = smallestOfAll.Invoke("small", "smallest", "smallers");
            Console.WriteLine(result);

            //the output will be 88
            Action<int, int, int> AvgGrades = AvgGrade;
            AvgGrades.Invoke(79, 90, 95);

            /*It's clear from the instruction that Func<> can be used with return type of methods
             *and Action<> can be use with void or method that doesn't return a value
             * Important to add that Predicate<> delegate can be use with a boolean return type
             * method
             */


        }
    }
}
