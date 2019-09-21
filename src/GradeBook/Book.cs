using System.Collections.Generic;

namespace GradeBook
{
      class Book
    {
      //constructor
      public Book()
      {
        grades = new List<double>();
      }
      public void AddGrade(double grade)
      {
        grades.Add(grade);
      }

      List<double> grades;
    }
}