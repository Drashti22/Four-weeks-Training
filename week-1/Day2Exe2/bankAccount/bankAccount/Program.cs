
using System;

namespace bankAccount
{
    internal class Program
    {
        public abstract class BankAccount
        {
            public int AccountNumber { get; }
            public abstract double Balance { get; }

            public abstract void Deposit(double amount);
            public abstract void Withdraw(double amount);


        }
        class SavingsAccount : BankAccount {
            public double InterestRate { get; set; }
            private double balance;
            public override double Balance
            {
                get { return balance; }
            }
            public override void Deposit(double amount)
            {
                balance += amount + (amount * InterestRate);
            }

            public override void Withdraw(double amount)
            {
                if (balance >= amount)
                {
                    balance -= amount;
                }
                else
                {
                    Console.WriteLine("check your Balance !!");
                }
            }
        }
        class CheckingAccount : BankAccount
        {
            public double OverdraftLimit { get; set; }
            private double balance;

            public override double Balance
            {
                get { return balance; }
            }
            public override void Deposit(double amount)
            {
                balance += amount;
            }

            public override void Withdraw(double amount)
            {
                if (balance >= amount || (balance + OverdraftLimit) >= amount)
                {
                    balance -= amount;
                }
                else { 
                    Console.WriteLine("Insufficient funds.");
                }
            }
        }

        static void Main(string[] args)
        {
            SavingsAccount savingsAccount = new SavingsAccount();

            CheckingAccount checkingAccount = new CheckingAccount();

            
            savingsAccount.Deposit(1000);
            savingsAccount.Withdraw(200);

            Console.WriteLine($"Savings Account Balance: {savingsAccount.Balance}");

            checkingAccount.Deposit(500);
            checkingAccount.Withdraw(800);

            Console.WriteLine($"Checking Account Balance: {checkingAccount.Balance}");

            //Console.ReadLine();
        }
    }
}