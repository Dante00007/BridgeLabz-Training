using System;


public interface ILoanable
{
    void ApplyForLoan(double amount);
    double CalculateLoanEligibility();
}


public abstract class BankAccount
{
    private string accountNumber;
    private string holderName;
    private double balance;

    public string AccountNumber
    {
        get { return accountNumber; }
        set { accountNumber = value; }
    }

    public string HolderName
    {
        get { return holderName; }
        set { holderName = value; }
    }

    public double Balance
    {
        get { return balance; }
    }

    public BankAccount(string accNum, string name, double initialBalance)
    {
        this.accountNumber = accNum;
        this.holderName = name;
        this.balance = initialBalance;
    }

    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            balance = balance + amount;
        }
    }

    public void Withdraw(double amount)
    {
        if (amount > 0 && amount <= balance)
        {
            balance = balance - amount;
        }
    }


    public abstract double CalculateInterest();
}
public class SavingsAccount : BankAccount, ILoanable
{
    private double interestRate = 0.04; 

    public SavingsAccount(string accNum, string name, double bal) : base(accNum, name, bal) { }

    public override double CalculateInterest()
    {
        return Balance * interestRate;
    }

    public double CalculateLoanEligibility()
    {
       
        return Balance * 5;
    }

    public void ApplyForLoan(double amount)
    {
        Console.WriteLine("Loan application of $" + amount + " submitted for " + HolderName);
    }
}

public class CurrentAccount : BankAccount
{
    public CurrentAccount(string accNum, string name, double bal) : base(accNum, name, bal) { }

    public override double CalculateInterest()
    {
        return Balance * 0.01; 
    }
}
 class BankingSystem
{
     static void Main()
    {
        
        BankAccount[] accounts = new BankAccount[2];

        accounts[0] = new SavingsAccount("SAV-001", "Alice Smith", 2000.0);
        accounts[1] = new CurrentAccount("CUR-002", "Bob Jones", 5000.0);

        Console.WriteLine("--- Daily Banking Report ---");
        Console.WriteLine();

        for (int i = 0; i < accounts.Length; i++)
        {
            BankAccount acc = accounts[i];
            double interest = acc.CalculateInterest();

            Console.WriteLine("Account Holder: " + acc.HolderName);
            Console.WriteLine("Account Number: " + acc.AccountNumber);
            Console.WriteLine("Current Balance: $" + acc.Balance);
            Console.WriteLine("Interest Earned: $" + interest);

            if (acc is ILoanable loanableAcc)
            {
                double limit = loanableAcc.CalculateLoanEligibility();
                Console.WriteLine("Status: Eligible for loan up to $" + limit);
            }
            else
            {
                Console.WriteLine("Status: Not eligible for loans.");
            }

            Console.WriteLine("------------------------------------------");
        }
    }
}