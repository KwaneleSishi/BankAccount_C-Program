The Bank offers two types of accounts namely, SavingsAccount, and CheckAccount. In this question you are required to create three classes

1. Create an abstract class, called BankAccount. This class has two abstract methods, deposit () and withdraw (). (5)
When the method is implemented by the child class will increase the balance.
When the method is implemented by the child class should decrease the balance by the withdrawal amount.
NB: Note that there is R8 bank charges for every deposit and withdrawal made. 

2. Create another class called SavingsAccount, SavingsAccount is a type of BankAccount. Thus, it inherits all the properties of BankAccount and implement all abstract methods. (10)

3. Create another class called CheckAccount, this class is also another type of BankAccount. Thus implement all the method of bank account. However, CheckAccount has a method called getBal() this method returns the balance. The Bank charges R200 monthly fee for the check account. No additional Bank charges for the first 10 transactions other than the monthly fee, then after, the normal R8 bank charges apply for all transactions. (15)

4. Design a driver class that instantiates the instances of the classes, call the relevant methods to test your program. (5) 
