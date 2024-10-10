using System;
public  class CheckAccount : BankAccount
{
    private int transactions = 0;
    private const double monthlyFee = 200;
    private const int freeTransactions = 10;

    // Implementing deposit method
    public override void deposit(double amount)
    {
        // Apply bank charges
        amount -= 8;
        Balance += amount;
        Console.WriteLine($"Deposited: R{amount}");
        transactions++;

        // Check for free transactions limit
        if (transactions > freeTransactions)
        {
            // Apply additional bank charges after free transactions
            Balance -= 8;
        }
    }

    // Implementing withdraw method
    public override void withdraw(double amount)
    {
        // Apply bank charges
        amount += 8;
        Balance -= amount;
        Console.WriteLine($"Withdrawn: R{amount}");
        transactions++;

        // Check for free transactions limit
        if (transactions > freeTransactions)
        {
            // Apply additional bank charges after free transactions
            Balance -= 8;
        }
    }

    // Method to get balance
    public double GetBalance()
    {
        // Deduct monthly fee
        Balance -= monthlyFee;
        return Balance;
    }









}