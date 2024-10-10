using System;
/* Create another class called SavingsAccount, SavingsAccount is a type of BankAccount. Thus, it inherits all the properties of BankAccount
 * and implement all abstract methods. (10)*/
public  class SavingsAccount : BankAccount
{
    public override void deposit(double amount)
    {
        // Apply bank charges
        amount -= 8;
        Balance += amount;
        Console.WriteLine($"Deposited: R{amount}");
    }

    // Implementing withdraw method
    public override void withdraw(double amount)
    {
        // Apply bank charges
        amount += 8;
        Balance -= amount;
        Console.WriteLine($"Withdrawn: R{amount}");
    }




}
