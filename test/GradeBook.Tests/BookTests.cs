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
            var book = new InMemoryBook("");
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
            var book = new InMemoryBook("");

            // assert
            Assert.Throws<ArgumentException>(() => book.AddGrade(101.0));
        }
    }
}
