using System;
using Xunit;

namespace GradeBook.Tests
{
    public class BookTests
    {
        [Fact]
        public void BookCalculatesAnAverageGrade()
        {
            // arrange
            var book = new Book("");
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.3);

            // act
            var result = book.GetStatistics();

            // assert
            Assert.Equal(85.6, result.Average, 1);
            Assert.Equal(90.5, result.Highest, 1);
            Assert.Equal(77.3, result.Lowest, 1);
            Assert.Equal('B', result.Letter);
        }

        [Fact]
        public void checkGradeIsBetween0and100()
        {
            // arrange
            var book = new Book("");
            book.AddGrade(101.0);
            book.AddGrade(50.7);
            book.AddGrade(30.3);

            // act
            var result = book.GetStatistics();

            // assert
            Assert.Equal(40.5, result.Average, 1);
            Assert.Equal(50.7, result.Highest, 1);
            Assert.Equal(30.3, result.Lowest, 1);
            Assert.Equal('F', result.Letter);
        }
    }
}
