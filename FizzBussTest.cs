using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace First_TDD_Demo.Test
{
    public class FizzBussTest
    {
        [Fact]
        public void ReturnedNumberAsString()
        {
            var ourTest = new First_TDD_Demo.FizzBuzzLogic();
            string answer = ourTest.DoTheThing(1);

            Assert.Equal("1", answer);
        }
        [Fact]
        public void NumberDividedByThree()
        {
            var ourTest = new First_TDD_Demo.FizzBuzzLogic();
            string answer = ourTest.DoTheThing(3);

            Assert.Equal("Fizz", answer);
        }
        
    }
}
