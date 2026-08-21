using System;

class BankAccount
{
    private string accountNumber;
    private string holderName;
    private double balance;
    public BankAccount(string accountNumber, string holderName, double balance)
    {
        this.accountNumber = accountNumber;
        this.holderName = holderName;
        this.balance = balance;
    }
    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            balance = balance + amount;
            Console.WriteLine("Amount deposited successfully.");
        }
        else
        {
            Console.WriteLine("Invalid deposit amount.");
        }
    }
    public void Withdraw(double amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Invalid withdrawal amount.");
        }
        else if (amount > balance)
        {
            Console.WriteLine("Insufficient balance.");
        }
        else
        {
            balance = balance - amount;
            Console.WriteLine("Amount withdrawn successfully.");
        }
    }
    public void DisplayAccountDetails()
    {
        Console.WriteLine("\n--- Account Details ---");
        Console.WriteLine("Account Number: " + accountNumber);
        Console.WriteLine("Holder Name: " + holderName);
        Console.WriteLine("Balance: " + balance);
    }
}

class A3P2
{
    static void Main(string[] args)
    {
        
        BankAccount account = new BankAccount(
            "12584200166",
            "Sagar",
            10000
        );

        account.DisplayAccountDetails();
        account.Deposit(5000);
        account.Withdraw(3000);
        account.DisplayAccountDetails();
    }
}