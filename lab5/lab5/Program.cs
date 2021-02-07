using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    class Account
    {
        private String Name;
        private String id;
        private int balance;

        public Account()
        {

        }
        public Account(String Name, String id, int balance)
        {
            this.Name = Name;
            this.id = id;
            this.balance = balance;
            }

        public void Deposit(int amount)
        {
            balance = balance + amount;
            Console.WriteLine("Account name :" + Name);
            Console.WriteLine("ID:" + id);
            Console.WriteLine("Deposited amount :" + amount);
            Console.WriteLine(" updated balance is:" + balance);
        }
        public void Withdraw(int amount)
        {
            balance = balance - amount;
            Console.WriteLine("Account name :" + Name);
            Console.WriteLine("ID:" + id);
            Console.WriteLine("Withdrawn amount :" + amount);
            Console.WriteLine(" the new balance is:" + balance);
        }


        static void Main(string[] args)
        {
            Account a = new Account("jannat", "18-38302-2", 10000);
            a.Deposit(3000);
            a.Withdraw(1000);

        }
    }
}
