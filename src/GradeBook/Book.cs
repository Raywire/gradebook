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
        Name = name;
      }
      public void AddGrade(double grade)
      {
        if(grade <= 100 && grade >= 0)
        {
          grades.Add(grade);
        }
        else
        {
            {
              Console.WriteLine("Invalid Value");
            }
        }
      }

      public Statistics GetStatistics()
      {
        var result = new Statistics();
        result.Average = 0.0;
        result.Highest = double.MinValue;
        result.Lowest = double.MaxValue;

        for (var index = 0; index < grades.Count; index += 1)
        {
          result.Lowest = Math.Min(grades[index], result.Lowest);
          result.Highest = Math.Max(grades[index], result.Highest);
          result.Average += grades[index];
        }

        result.Average /= grades.Count;

        return result;
      }

      private List<double> grades;
      public string Name;
    }
}