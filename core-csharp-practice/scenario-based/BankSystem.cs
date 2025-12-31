
using System.Dynamic;

class BankAccount
{
    private int balance;
    private int accountNumber;

    public BankAccount(int balance)
    {
        this.accountNumber = Math.Abs(new Random().Next(100000, 1000000));
        SetBalance(balance);
    }
    public int GetAccountNumber() => accountNumber;
    public int GeBalance() => balance;

    public int SetBalance(int amount) => this.balance = amount;


    public override string ToString()
    {
        return $"Account Number: {accountNumber}, Balance: ${balance}";
    }

}

class BankAccountManager
{


    public BankAccount CreateAccount(int balance)
    {

        if (balance >= 2000)
        {
            BankAccount account = new BankAccount(balance);
            Console.WriteLine($"Account created with Account Number: {account.GetAccountNumber()}");
            return account;
        }
        else
        {
            Console.WriteLine("Maximum number of accounts reached.");
            return null;
        }

    }
    public void Deposit(int amount, BankAccount account)
    {

        if (account != null && amount > 0)
        {
            int balance = account.GeBalance();
            balance += amount;
            account.SetBalance(balance);
         
        }
    }

    public void Withdraw(int amount, BankAccount account)
    {

        int balance = account.GeBalance();
        if (amount <= balance)
        {
            balance -= amount;
            account.SetBalance(balance);
        }

    }
    public void DisplayInfo(BankAccount account)
    {
       Console.WriteLine(account.ToString());
    }
}

class Client
{
    private string name;
    private string address;
    private string phoneNumber;
    private string email;
    private string AadhaarNumber;
    private BankAccount account;
    private BankAccountManager bankAccountManager;

    public Client(
        string name,
        string address,
        string phoneNumber,
        string email,
        string aadharNumber,
        BankAccountManager bankAccountManager
    )
    {
        this.name = name;
        this.address = address;
        this.phoneNumber = phoneNumber;
        this.email = email;
        this.AadhaarNumber = aadharNumber;
        this.bankAccountManager = bankAccountManager;
        this.account = null;
    }

    public void OpenBankAccount(int initialBalance)
    {
        BankAccount account = bankAccountManager.CreateAccount(initialBalance);
        if (account != null)
        {
            this.account = account;
        }
        else
        {
            Console.WriteLine("Unable to create an account");
        }
    }

    public void DepositMoney(int amount)
    {
        bankAccountManager.Deposit(amount, this.account);
    }

    public void WithdrawMoney(int amount)
    {
        bankAccountManager.Withdraw(amount, this.account);
    }
    public void DisplayAccount()
    {
        bankAccountManager.DisplayInfo(this.account);
    }

}


class Bank
{
    private static string name = "Zara Banking System";
    private static string branchAddress = "123 Main Street";
    private static string contactNumber = "876543210";
    private static string ifscCode = "ZARA1234";
    private Client currentClient;
    private static BankAccountManager bankAccountManager;


    static Bank()
    {
        // beacuase this bank has only one manager so we can make it static
        bankAccountManager = new BankAccountManager();
    }

    
    public Bank()
    {
        StartBankingSystem();
    }
    static Client CreateClient()
    {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();
        Console.Write("Enter your address: ");
        string address = Console.ReadLine();
        Console.Write("Enter your phone number: ");
        string phoneNumber = Console.ReadLine();
        Console.Write("Enter your email: ");
        string email = Console.ReadLine();
        Console.Write("Enter your Aadhaar Number: ");
        string aadharNumber = Console.ReadLine();
        Client client = new Client(name, address, phoneNumber, email, aadharNumber, bankAccountManager);
        return client;
    }
    public void StartBankingSystem()
    {
        if (currentClient == null)
        {
            this.currentClient = CreateClient();
        }
        ShowMenu();

    }
    public void  ShowMenu()
    {
        bool running = true;
        while (running)
        {
            Console.WriteLine("\n======= ZARA BANKING SYSTEM =======");
            Console.WriteLine("1. Open Bank Account");
            Console.WriteLine("2. Deposit Money");
            Console.WriteLine("3. Withdraw Money");
            Console.WriteLine("4. Check Balance/Account Info");
            Console.WriteLine("5. Exit");
            Console.Write("Select an option: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Enter initial deposit (Min $2000): ");
                    int initial = int.Parse(Console.ReadLine());
                    currentClient.OpenBankAccount(initial);
                    break;

                case "2":
                    Console.Write("Enter amount to deposit: ");
                    int dAmount = int.Parse(Console.ReadLine());
                    currentClient.DepositMoney(dAmount);
                    break;

                case "3":
                    Console.Write("Enter amount to withdraw: ");
                    int wAmount = int.Parse(Console.ReadLine());
                    currentClient.WithdrawMoney(wAmount);
                    break;

                case "4":
                    currentClient.DisplayAccount();
                    break;

                case "5":
                    running = false;
                    Console.WriteLine("Thank you for banking with us!");
                    break;

                default:
                    Console.WriteLine("Invalid option. Try again.");
                    break;
            }
        }
    }
}

class BankSystem
{
    
    static void Main()
    {
        Bank bank = new Bank();
    }
}