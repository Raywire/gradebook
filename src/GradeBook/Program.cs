﻿namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Ryan's Grade Book");
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.5);

            var stats = book.GetStatistics();

            System.Console.WriteLine($"The lowest grade is {stats.Lowest}");
            System.Console.WriteLine($"The highest grade is {stats.Highest}");
            System.Console.WriteLine($"The average grade is {stats.Average:N1}");
        }
    }
}
