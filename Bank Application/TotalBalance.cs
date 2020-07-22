using System;
using System.Collections.Generic;
using System.Text;
//Using Delegates
namespace Bank_Application
{
    class TotalBalance
    {
       
        public delegate  void TotalBalances(double amount);
       
        
        public void TotalBalancess(double amount)
        {
            if(amount==0 && amount <= 100)
            {
                Console.WriteLine("Your Amount is Lessthan minimum Balance" + amount);
            }
            else
            {
                Console.WriteLine("Your Balane is" + amount);
            }
        }
    }
}
