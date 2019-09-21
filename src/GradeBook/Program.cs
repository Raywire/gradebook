using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Ryan's Grade Book");
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.5);
            // Book.AddGrade(77.5); in order for this to work you need to change the AddGrade method to static and then the grades to static. NOTE that this is not advisable as it negates all the benefits of OOP.

            var grades = new List<double>() { 12.7, 10.3, 6.11, 4.1 };
            grades.Add(56.1);

            var result = 0.0;
            var highestGrade = double.MinValue;
            var lowestGrade = double.MaxValue;
            foreach(var number in grades) 
            {
                // if(number > highestGrade)
                // {
                //     highestGrade = number;
                // }
                lowestGrade = Math.Min(number, lowestGrade);
                highestGrade = Math.Max(number, highestGrade);
                result += number;
            }
            result /= grades.Count;
            System.Console.WriteLine($"The lowest grade is {lowestGrade:N2}");
            System.Console.WriteLine($"The highest grade is {highestGrade:N2}");
            System.Console.WriteLine($"The average grade is {result:N2}");
        }
    }
}
