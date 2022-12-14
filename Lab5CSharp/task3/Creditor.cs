namespace pro100user.task3;

public class Creditor : Client
{
    private string surname;
    private double procent;
    private double dept;

    public Creditor()
    {
    }

    public Creditor(string surname, double procent, double dept)
    {
        this.surname = surname;
        this.procent = procent;
        this.dept = dept;
    }

    public Creditor(double amount, string surname, double procent, double dept) : base(amount)
    {
        this.surname = surname;
        this.procent = procent;
        this.dept = dept;
    }

    public override void Print()
    {
        Console.WriteLine($"Creditor {surname}, amount - {amount}, procent - {procent}, dept - {dept}, created at {createdAt}");
    }

    public void OpenCredit(double amount)
    {
        this.amount += amount;
        dept += amount + (amount * procent)/100;
        createdAt = DateTime.Now;
    }
    
    public void CloseCredit(double amount)
    {
        this.amount -= amount;
        dept -= amount;
    }
}