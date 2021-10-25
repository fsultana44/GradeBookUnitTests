using System;
using Xunit;

namespace GradeBook.Tests
{
    public class BookTests
    {
        [Fact]
        public void Test1()
        {
            // arranged 
            var x = 5;
            var y = 5;
            var expected = 20;

            //act section
            var actual = x + y + 10;

            //assert section
            Assert.Equal(expected, actual);

        }
    }
}
