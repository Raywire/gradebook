using System;
using System.Collections.Generic;

namespace GradeBook
{
      public class Book
    {
      //constructor
      public Book(string name)
      {
        grades = new List<double>();
        this.name = name;
      }
      public void AddGrade(double grade)
      {
        grades.Add(grade);
      }

      public void ShowStatistics()
      {
            var result = 0.0;
            var highestGrade = double.MinValue;
            var lowestGrade = double.MaxValue;
            foreach(var number in grades) 
            {
                lowestGrade = Math.Min(number, lowestGrade);
                highestGrade = Math.Max(number, highestGrade);
                result += number;
            }
            result /= grades.Count;
            System.Console.WriteLine($"The lowest grade is {lowestGrade:N2}");
            System.Console.WriteLine($"The highest grade is {highestGrade:N2}");
            System.Console.WriteLine($"The average grade is {result:N2}");
      }

      private List<double> grades;
      private string name;
    }
}