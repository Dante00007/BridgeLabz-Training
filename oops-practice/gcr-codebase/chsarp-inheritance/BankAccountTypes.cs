using System;

public class BankAccount
{
    public string AccountNumber { get; set; }
    public double Balance { get; set; }

    public BankAccount(string accountNumber, double balance)
    {
        AccountNumber = accountNumber;
        Balance = balance;
    }
    public virtual void DisplayAccountType()
    {
        Console.WriteLine($"Account {AccountNumber} is a General Bank Account.");
    }
}

public class SavingsAccount : BankAccount
{
    public double InterestRate { get; set; }

    public SavingsAccount(string accNum, double bal, double rate) : base(accNum, bal)
    {
        InterestRate = rate;
    }

    public override void DisplayAccountType()
    {
        Console.WriteLine($"Account {AccountNumber} is a Savings Account with {InterestRate}% interest.");
    }
}

public class CheckingAccount : BankAccount
{
    public double WithdrawalLimit { get; set; }

    public CheckingAccount(string accNum, double bal, double limit) : base(accNum, bal)
    {
        WithdrawalLimit = limit;
    }

    public override void DisplayAccountType()
    {
        Console.WriteLine($"Account {AccountNumber} is a Checking Account. Daily limit: ${WithdrawalLimit}.");
    }
}

public class FixedDepositAccount : BankAccount
{
    public int TenureMonths { get; set; }

    public FixedDepositAccount(string accNum, double bal, int months) : base(accNum, bal)
    {
        TenureMonths = months;
    }

    public override void DisplayAccountType()
    {
        Console.WriteLine($"Account {AccountNumber} is a Fixed Deposit for {TenureMonths} months.");
    }
}

class BankAccountTypes
{
    static void Main()
    {
        SavingsAccount savingsAcc = new SavingsAccount("SA123", 5000, 4.5);
        CheckingAccount checkingAcc = new CheckingAccount("CA456", 7000, 1000);
        FixedDepositAccount fixedDepositsAcc = new FixedDepositAccount("FD789", 10000, 12);

        savingsAcc.DisplayAccountType();
        checkingAcc.DisplayAccountType();
        fixedDepositsAcc.DisplayAccountType();
        Console.WriteLine();
        Console.WriteLine("Interest Rate: {0}", savingsAcc.InterestRate);
        Console.WriteLine("Withdrawal Limit: {0}", checkingAcc.WithdrawalLimit);
        Console.WriteLine("Tenure Months:  {0}", fixedDepositsAcc.TenureMonths);
    }
}