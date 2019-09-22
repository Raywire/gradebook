using System;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Ryan's Grade Book");

            while(true)
            {
                System.Console.WriteLine("Enter a grade or 'q' to quit");
                var input = Console.ReadLine();
                if(input == "q")
                {
                    break;
                }
                var grade = double.Parse(input);
                book.AddGrade(grade);
            }

            var stats = book.GetStatistics();

            Console.WriteLine($"The lowest grade is {stats.Lowest}");
            Console.WriteLine($"The highest grade is {stats.Highest}");
            Console.WriteLine($"The average grade is {stats.Average:N1}");
            Console.WriteLine($"The letter grade is {stats.Letter}");
        }
    }
}
