using FibonacciProject;
using Xunit;

namespace FibonacciTest
{
    public class Tests
    {
        [Fact]
        public void ShouldReturnCorrectValueForItem0()
        {
            var actual = Fibonacci.GetFibonacciValues()[0];
            Assert.Equal(1, actual);
        }
        
        [Fact]
        public void ShouldReturnCorrectValueForItem1()
        {
            var actual = Fibonacci.GetFibonacciValues()[1];
            Assert.Equal(1, actual);
        }
        
        [Fact]
        public void ShouldReturnCorrectValueForItem5()
        {
            var actual = Fibonacci.GetFibonacciValues()[5];
            Assert.Equal(8, actual);
        }
    }
}