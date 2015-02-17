using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking
{
    class Account
    {
        public int AccountID { get; set; }
        public int checkingBalance { get; set; }
        public int savingsBalance { get; set; }

     
        
        public void Withdraw(int amount, string type)
        {
            if (type == "checkingbalance")
            {
                if (isValid("checkingbalance", amount))
                {
                    checkingBalance = checkingBalance - amount;
                }
            }
            else
            {
                if (isValid("savingsBalance", amount))
                {
                    savingsBalance = savingsBalance - amount;
                }
            }
        }

        public void Deposit(int amount, string type)
        {
            if(type == "checkingbalance")
            {
                checkingBalance = checkingBalance + amount;
            }
            else
            {
                savingsBalance = savingsBalance + amount;
            }
        }

        public void transfer(int amount, string from, string to)
        {
            if(from == "checkingbalance")
            {
                if(isValid("checkingbalance",amount))
                {
                    checkingBalance = checkingBalance - amount;
                    savingsBalance = savingsBalance + amount;
                }
            }
            else
            {
                if(isValid("savingsBalance", amount))
                {
                    savingsBalance = savingsBalance - amount;
                    checkingBalance = checkingBalance + amount;
                }
            }
        }
        
        public int ViewBalance(string type)
        {
            int a = 0;
            if(type == "checkingbalance")
            {
                a = checkingBalance;
            }
            if(type == "savingsBalance")
            {
                a = savingsBalance;
            }

            return a;
        }

        public bool isValid(string type, int amount)
        {
            
            if(type == "checkingbalance")
            {
                int b = checkingBalance;
                if(b - amount > 10)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                int b = savingsBalance;
                if(b - amount > 10)
                {
                    return true;
                }
                else
                {
                    return true;
                }
            }
            
        }

    }
}
