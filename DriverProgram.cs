using System;
public abstract class DriverProgram
{
    static void Main(string[] args)
    {
        // Creating instances of SavingsAccount and CheckAccount
        SavingsAccount savingsAccount = new SavingsAccount();
        CheckAccount checkAccount = new CheckAccount();

        // Testing SavingsAccount
        Console.WriteLine("Savings Account:");
        savingsAccount.deposit(1000);
        savingsAccount.withdraw(500);

        // Testing CheckAccount
        Console.WriteLine("\nCheck Account:");
        checkAccount.deposit(2000);
        checkAccount.withdraw(100);

        Console.WriteLine($"Current Balance: R{checkAccount.GetBalance()}");
    }
    }