using System;
using NUnit.Framework;

namespace Bank
{
    public class Account
    {
        public decimal balance;
        public decimal minimumBalance = 10m;

        public void Deposit(decimal amount)
        {
            balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            balance -= amount;
        }

        public void TransferFunds(Account destination, decimal amount)
        {
            if (balance - amount < minimumBalance)
                throw new InsufficientFundsException();

            destination.Deposit(amount);

            Withdraw(amount);
        }

        public decimal Balance
        {
            get { return balance; }
        }

        public decimal MinimumBalance
        {
            get { return minimumBalance; }
        }
    }

    public class Checking : Account
    {
        public decimal ServiceFee()
        {
            balance -= 10;
            return balance;
        }
    }

    public class Savings : Account
    {
        private decimal interest = 0.007m;
        public decimal AddInterest()
        {
            balance += balance * interest;
            return balance;
        }
    }

    public class InsufficientFundsException : ApplicationException
    {
    }

    [TestFixture]
    public class AccountTest
    {
        Account moneyInTheBank;


        [SetUp]
        public void Init()
        {
            moneyInTheBank = new Account();
            moneyInTheBank.Deposit(200m);
        }

        [Test]
        public void Deposit()
        {
            moneyInTheBank.Deposit(350m);

        }
        [Test]
        public void Withdraw()
        {
            moneyInTheBank.Withdraw(200m);
        }
        [Test]
        public void ViewBalance()
        {
            moneyInTheBank.Balance.ToString();
        }
    }

    
}
