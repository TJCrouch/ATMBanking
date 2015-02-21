using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;


namespace Banking
{
    [TestFixture]
    class UnitTests
    {      
      
      
            

       [Test]
        public void DepositChecking()
        {
            Account myAccount = new Account() { AccountID = 1, checkingBalance = 1000, savingsBalance = 1000 };
            int x;
            x=1350;
            myAccount.Deposit(350, "checkingbalance");
            Assert.AreEqual(myAccount.checkingBalance, x);

        }
        [Test]
        public void WithdrawChecking()
        {
            Account myAccount = new Account() { AccountID = 1, checkingBalance = 1000, savingsBalance = 1000 };
            int x = 650;
            myAccount.Withdraw(350, "checkingbalance");
            Assert.AreEqual(myAccount.checkingBalance, x);
        }
      
        [Test]
        public void DepositSavings()
        {
            Account myAccount = new Account() { AccountID = 2, checkingBalance = 1000, savingsBalance = 1000 };
            int x = 1350;
            myAccount.Deposit(350, "savingsbalance");
            Assert.AreEqual(myAccount.savingsBalance, x);

        }
        [Test]
        public void WithdrawSavings()
        {
            Account myAccount = new Account() { AccountID = 2, checkingBalance = 1000, savingsBalance = 1000 };
           int x = 650;
           myAccount.Withdraw(350, "savingsbalance");
            Assert.AreEqual(myAccount.savingsBalance, x);
        }
        [Test]
        public void ViewCheckingBalance()
        {
            Account myAccount = new Account() { AccountID = 1, checkingBalance = 1000, savingsBalance = 1000 };
            string x, yString;
            int y =1000;
            yString = y.ToString();
            
           x = myAccount.checkingBalance.ToString();
            Assert.AreEqual(x, yString);
        }

      [Test]
        public void ViewSavingsBalance()
        {
            Account myAccount = new Account() { AccountID = 1, checkingBalance = 1000, savingsBalance = 1000 };
            string x, yString;
            int y =1000;
            yString = y.ToString();
            
           x = myAccount.savingsBalance.ToString();
            Assert.AreEqual(x, yString);
        }


    }


  }
    

