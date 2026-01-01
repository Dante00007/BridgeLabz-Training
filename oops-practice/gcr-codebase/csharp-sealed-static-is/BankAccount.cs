

class BankAccount
{
    public static string bankName = "ABC Bank";
    private static int totalAccounts;
    private string accountHolderName;
    public readonly int accountNumber;

    public BankAccount(string accountHolderName, int accountNumber)
    {
        this.accountHolderName = accountHolderName;
        this.accountNumber = accountNumber;
        totalAccounts++;
    }

    public void DisplayDetails()
    {
        Console.WriteLine("Bank Name: {0}", bankName);
        Console.WriteLine("Account Holder Name: {0}", accountHolderName);
        Console.WriteLine("Account Number: {0}", accountNumber);
    }

    public static void GetTotalAccounts()
    {
        Console.WriteLine("Total Accounts: {0}", totalAccounts);
    }

    static void Main()
    {
        BankAccount account = new BankAccount("John Doe", 123456789);
        if(account is BankAccount)
            account.DisplayDetails();
    }
}