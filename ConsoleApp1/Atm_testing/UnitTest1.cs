using System;
using Xunit;
using ATM;
using static ATM.Program;

namespace Atm_testing
{
    public class UnitTest1
    {
      

        [Theory]
        [InlineData(100, 100)]
        [InlineData(1000,1000)]
        [InlineData(3500, 3500)]
        [InlineData(500, 500)]
        [InlineData(300, 300)]
        [InlineData(35, 35)]
        [InlineData(10,10)]
        [InlineData(50,50)]


        public void CanViewBalance(decimal testBalance, decimal testResult)

        {
            Assert.Equal(testResult, ViewBalance(testBalance));
        }


        [Theory]
        [InlineData(500, 500, 1000)]
        [InlineData(100,100, 200)]
        public void CanDepositMoney(decimal testAmount, decimal testBalance, decimal testResult)
        {
            Assert.Equal(testResult, MakeDeposit(testAmount, testBalance));
        }

    }
}
