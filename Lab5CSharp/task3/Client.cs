namespace pro100user.task3;

public abstract class Client
{
    protected DateTime createdAt;
    protected double amount;

    protected Client()
    {
        createdAt = DateTime.Now;
    }

    protected Client(double amount)
    {
        createdAt = DateTime.Now;
        this.amount = amount;
    }

    public abstract void Print(); 
}