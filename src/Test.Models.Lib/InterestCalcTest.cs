using System;
using Test.Models.Lib;
using Xunit;

namespace IO.Swagger.test
{
    public class InterestCalcTest
    {
        [Fact]
        public void ConstrutorVazio()
        {
            InterestCalc oi = new InterestCalc();
        }

        [Fact]
        public void ConstrutorCompleto()
        {
            InterestCalc oi = new InterestCalc(100M, 5);
            Assert.Equal(100M, oi.Initial);
            Assert.Equal(5, oi.Months);
            Assert.Equal(0.01M, oi.Interest);
        }

        [Fact]
        public void Calcula100Com5Meses()
        {
            InterestCalc oi = new InterestCalc(100M, 5);
            Assert.Equal(105.1M, oi.Calc());
        }
    }
}
