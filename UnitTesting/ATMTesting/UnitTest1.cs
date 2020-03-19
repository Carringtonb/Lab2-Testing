using System;
using Xunit;
using UnitTesting;

namespace ATMTesting
{
    public class UnitTest1
    {
        [Fact]
        public void TestToSeeIfWithdrawlOfSufficientFundsWorks()
        {
            Program.balance = 500;
            Program.Withdrawal(420);
            Assert.Equal(80, Program.balance);
        }

        [Fact]
        public void TestToSeeIfWithdrawalOfInsufficientFunds()
        {
            Program.balance = 500;
            Program.Withdrawal(520);
            Assert.Equal(-20, Program.balance);
        }

        [Fact]
        public void TestToSeeIfDepositForPositiveAmount()
        {
            Program.balance = 420;
            Program.DepositFunds(69);
            Assert.Equal(489, Program.balance);
        }
        [Fact]
        public void TestToSeeIfDepositForNegativeAmount()
        {
            Program.balance = 420;
            Program.DepositFunds(-60);
            Assert.Equal(420, Program.balance);
        }

    }

      
}
