using System;

public class Human
{
    private string firstName;
    private string lastName;
    private byte age;
    private string personalNumber;
    private string phoneNumber;
    private string email;

    public string FirstName
    {
        get { return firstName; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("First name is necessary");
            else if (value.Length > 50)
                throw new ArgumentException("Max symbol length should be 50");
            firstName = value;
        }
    }

    public string LastName
    {
        get { return lastName; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Last name is necessary");
            else if (value.Length > 50)
                throw new ArgumentException("Max symbol length should be 50");
            lastName = value;
        }
    }

    public byte Age
    {
        get { return age; }
        set
        {
            if (value <= 0)
                throw new ArgumentException("Age must be positive.");
            age = value;
        }
    }

    public string PersonalNumber
    {
        get { return personalNumber; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Personal number is necessary");
            else if (value.Length != 11)
                throw new ArgumentException("Personal number should be exactly 11 symbols");
            personalNumber = value;
        }
    }

    public string PhoneNumber
    {
        get { return phoneNumber; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Phone number is necessary");
            else if (value.Length != 9)
                throw new ArgumentException("Phone number should be exactly 9 symbols");
            phoneNumber = value;
        }
    }

    public string Email
    {
        get { return email; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Email is necessary");
            else if (!value.Contains("@"))
                throw new ArgumentException("Email must contain '@'");
            else if (value.StartsWith("@"))
                throw new ArgumentException("Email cannot start with '@'");
            else if (value.EndsWith("@"))
                throw new ArgumentException("Email cannot end with '@'");
            else if (value.Contains(".@") || value.Contains("@."))
                throw new ArgumentException("'.' cannot be placed before or after '@'");
            email = value;
        }
    }

    public Human() { }

    public Human(string firstName, string lastName, byte age, string personalNumber, string phoneNumber, string email)
    {
        FirstName = firstName;
        LastName = lastName;
        Age = age;
        PersonalNumber = personalNumber;
        PhoneNumber = phoneNumber;
        Email = email;
    }

    public void DisplayInfoInConsole()
    {
        Console.WriteLine($"{FirstName} {LastName} {Age} {PersonalNumber} {PhoneNumber} {Email}");
    }
}

public class Account
{
    private string accountNumber;
    private string currency;
    private decimal balance;

    public string AccountNumber
    {
        get { return accountNumber; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Cannot be null");
            else if (value.Length != 22)
                throw new ArgumentException("Account number should be exactly 22 symbols");
            accountNumber = value;
        }
    }

    public string Currency
    {
        get { return currency; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Cannot be null");
            else if (value.Length != 3)
                throw new ArgumentException("Currency should be exactly 3 symbols");
            currency = value;
        }
    }

    public decimal Balance
    {
        get { return balance; }
        set
        {
            if (value < 0)
                throw new ArgumentException("Balance cannot be negative");
            balance = value;
        }
    }

    public Account() { }

    public Account(string accountNumber, string currency, decimal balance)
    {
        AccountNumber = accountNumber;
        Currency = currency;
        Balance = balance;
    }

    public void Deposit(decimal amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Amount cannot be zero or less than zero");
            return;
        }
        Balance += amount;
        Console.WriteLine($"Balance after deposit: {Balance}");
    }

    public void Withdraw(decimal amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Amount cannot be zero or less than zero");
            return;
        }
        if (Balance < amount)
        {
            Console.WriteLine("Not enough money in your account");
            return;
        }
        Balance -= amount;
        Console.WriteLine($"Balance after withdrawal: {Balance}");
    }

    public void Transfer(Account someone, decimal amount)
    {
        if (Currency != someone.Currency)
        {
            Console.WriteLine("Currencies should match");
            return;
        }
        if (amount > Balance)
        {
            Console.WriteLine("Not enough money in your account");
            return;
        }
        Balance -= amount;
        someone.Balance += amount;
        Console.WriteLine($"{AccountNumber} Balance after transfer: {Balance}");
    }

    public void Display()
    {
        Console.WriteLine($"Account: {AccountNumber}, \nCurrency: {Currency}, \nBalance: {Balance}");
    }
}

public class Client
{
    private string firstName;
    private string lastName;
    private string personalNumber;

    public Account Account { get; set; }

    public string FirstName
    {
        get { return firstName; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("First name is necessary");
            else if (value.Length > 50)
                throw new ArgumentException("Max symbol length should be 50");
            firstName = value;
        }
    }

    public string LastName
    {
        get { return lastName; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Last name is necessary");
            else if (value.Length > 50)
                throw new ArgumentException("Max symbol length should be 50");
            lastName = value;
        }
    }

    public string PersonalNumber
    {
        get { return personalNumber; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Personal number is necessary");
            else if (value.Length != 11)
                throw new ArgumentException("Personal number should be exactly 11 symbols");
            personalNumber = value;
        }
    }

    public Client() { }

    public Client(string firstName, string lastName, string personalNumber, Account account)
    {
        FirstName = firstName;
        LastName = lastName;
        PersonalNumber = personalNumber;
        Account = account;
    }

    public void Display()
    {
        Console.WriteLine($"Client: {FirstName} {LastName} \nPersonal number: {PersonalNumber}");
        Account.Display();
    }
}

public class Program
{
    public static void Main()
    {
        Human human = new Human();
        try
        {
            Console.Write("Enter first name: ");
            human.FirstName = Console.ReadLine();

            Console.Write("Enter last name: ");
            human.LastName = Console.ReadLine();

            Console.Write("Enter age: ");
            human.Age = byte.Parse(Console.ReadLine());

            Console.Write("Enter personal number (11 digits): ");
            human.PersonalNumber = Console.ReadLine();

            Console.Write("Enter phone number (9 digits): ");
            human.PhoneNumber = Console.ReadLine();

            Console.Write("Enter email: ");
            human.Email = Console.ReadLine();

            human.DisplayInfoInConsole();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"\nValidation error: {ex.Message}");
        }
        Console.WriteLine();
        try
        {
            Account acc1 = new Account("GE123RR123897459EW2651", "GEL", 8796.36m);
            Account acc2 = new Account("GE123RR123897459T89563", "GEL", 7452.74m);
            Client client1 = new Client("John", "Doe", "00011100011", acc1);
            Client client2 = new Client("Marie", "Doe", "12345678959", acc2);

            client1.Display();
            Console.WriteLine();
            client2.Display();
            Console.WriteLine();
            client1.Account.Transfer(client2.Account, 568.00m);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"\nValidation error: {ex.Message}");
        }
    }
}
