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
    
    }

      
}
