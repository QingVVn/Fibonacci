using System;

namespace Test
{
    public class Tests
    {
        [Theory]
        [InlineData(1, "1")]
        [InlineData(3, "Fizz")]
        [InlineData(5, "Buzz")]
        [InlineData(13, "Fizz")]
        [InlineData(75, "FizzBuzz")]
        public void ShouldReturnCorrectValue(int number)
        { 
            
            var actualValue = fizzbuzz.GetValue(number);
            Assert.Equal(expectValue, actualValue);
        }
    }
}