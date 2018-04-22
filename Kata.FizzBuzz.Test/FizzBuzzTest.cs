using System;
using Xunit;

namespace Kata.FizzBuzz.Test
{
    public class FizzBuzzTest
    {
        private readonly FizzBuzz _fizzBuzz = new FizzBuzz();

        [Fact]
        public void Should_Thorw_ArgumentOutOfRangeException()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => _fizzBuzz.Calculate(0));
        }

        [Theory]
        [InlineData("1", 1)]
        [InlineData("76", 76)]
        [InlineData("98", 98)]
        public void Should_return_one(string expected, int input)
        {
            Assert.Equal(expected, _fizzBuzz.Calculate(input));
        }

        [Theory]
        [InlineData(ConstFizzBuzz.FIZZ, 3)]
        [InlineData(ConstFizzBuzz.FIZZ, 12)]
        public void Should_return_FIZZ_When_Input_Is_Three_Or_Multiple(string expected, int input)
        {
            Assert.Equal(expected, _fizzBuzz.Calculate(input));
        }

        [Theory]
        [InlineData(ConstFizzBuzz.BUZZ, 5)]
        [InlineData(ConstFizzBuzz.BUZZ, 55)]
        public void Should_return_BUZZ_When_Input_Is_Five_Or_Multiple(string expected, int input)
        {
            Assert.Equal(expected, _fizzBuzz.Calculate(input));
        }

        [Theory]
        [InlineData(ConstFizzBuzz.FIZZBUZZ, 15)]
        [InlineData(ConstFizzBuzz.FIZZBUZZ, 255)]
        public void Should_return_FIZZBUZZ_When_Input_Is_Multiple_Five_And_Three(string expected, int input)
        {
            Assert.Equal(expected, _fizzBuzz.Calculate(input));
        }
    }
}
