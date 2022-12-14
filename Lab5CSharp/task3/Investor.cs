namespace pro100user.task3;

public class Investor : Client
{
    private string surname;
    private double procent;

    public Investor()
    {
    }

    public Investor(string surname, double procent)
    {
        this.surname = surname;
        this.procent = procent;
    }

    public Investor(double amount, string surname, double procent) : base(amount)
    {
        this.surname = surname;
        this.procent = procent;
    }

    public override void Print()
    {
        Console.WriteLine($"Investor {surname}, amount - {amount}, procent - {procent}, created at {createdAt}");
    }
    
    public void AddAmount(double amount)
    {
        this.amount += amount;
        createdAt = DateTime.Now;
    }
    
    public void MinusAmount(double amount)
    {
        this.amount -= amount;
    }
}