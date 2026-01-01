/*
 Bank Account Management
Create a BankAccount class with:
accountNumber (public)
accountHolder (protected)
balance (private)
Implement methods to:
Access and modify balance using public methods.
Create a subclass SavingsAccount to demonstrate access to accountNumber and accountHolder.
*/


class BankAccount
{
    public int accountNumber;
    protected string accountHolder;
    private double balance;

    BankAccount(int accountNumber, string accountHolder, double balance)
    {
        this.accountNumber = accountNumber;
        this.accountHolder = accountHolder;
        this.balance = balance;
    }
    public double GetBalance()
    {
        return balance;
    }

    public void Deposit(double amount)
    {
        balance += amount;
    }

    public void Withdraw(double amount)
    {
        balance -= amount;
    }
}

class SavingsAccount : BankAccount
{
    
    public SavingsAccount(int accountNumber, string accountHolder, double balance) : base(accountNumber, accountHolder, balance)
    {}
    public void DisplayAccountDetails()
    {
        Console.WriteLine("Account Number: " + accountNumber);
        Console.WriteLine("Account Holder: " + accountHolder);
        Console.WriteLine("Balance: " + balance);
    }

    static void Main()
    {
        SavingsAccount savingsAccount = new SavingsAccount(12345, "John Doe", 1000.0);
        savingsAccount.DisplayAccountDetails();
    }
}
