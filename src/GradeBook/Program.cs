using System;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 34.1;
            double y = 10.3;

            var result = x + y;
            System.Console.WriteLine(result);

            var numbers = new [] { 12.7, 10.3, 6.11, 4.1 };

            var result2 = 0.0;
            foreach(var number in numbers) 
            {
                result2 += number;
            }
            System.Console.WriteLine(result2);
            if (args.Length > 0)
            {
                Console.WriteLine($"Hello {args[0]}!");
            }
            else
            {
                Console.WriteLine("Hello!");
            }
        }
    }
}
