namespace pro100user.task3;

public class Organization : Client
{
    private string name;
    private string number;

    public Organization() { }

    public Organization(string name, string number)
    {
        this.name = name;
        this.number = number;
    }

    public Organization(double amount, string name, string number) : base(amount)
    {
        this.name = name;
        this.number = number;
    }

    public override void Print()
    {
        Console.WriteLine($"Organization {name}, balance number - {number}, balnce amount - {amount}, created at {createdAt}");
    }
    
    public void AddAmount(double amount)
    {
        this.amount += amount;
    }
    
    public void MinusAmount(double amount)
    {
        this.amount -= amount;
    }
}