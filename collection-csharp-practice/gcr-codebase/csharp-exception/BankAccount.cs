class InsufficientFundsException : Exception { }

class BankAccount
{
    double balance = 1000;
    public void Withdraw(double amount)
    {
        if (amount < 0) throw new ArgumentException();
        if (amount > balance) throw new InsufficientFundsException();
        balance -= amount;
        Console.WriteLine($"Withdrawal successful, new balance: {balance}");
    }

    static void Main(string[] args)
    {
        BankAccount acc = new BankAccount();
        try
        {
            acc.Withdraw(1500);
        }
        catch (InsufficientFundsException)
        {
            Console.WriteLine("Insufficient balance!");
        }
        catch (ArgumentException)
        {
            Console.WriteLine("Invalid amount!");
        }
    }
}