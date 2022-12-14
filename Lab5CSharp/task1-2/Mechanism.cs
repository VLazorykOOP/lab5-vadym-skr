namespace pro100user.task2;

//Механізм
public class Mechanism : Product
{
    private int time;
    
    public Mechanism()
    {
        time = 30;
        Console.WriteLine("Constructor \"Mechanism\"");
    }
    
    public Mechanism(int time) : base("mechanism")
    {
        this.time = time;
        Console.WriteLine("Constructor \"Mechanism\"");
    }
    
    public Mechanism(string name, int time) : base(name)
    {
        this.time = time;
        Console.WriteLine("Constructor \"Mechanism\"");
    }
    
    ~Mechanism()
    {
        Console.WriteLine("Destructor \"Mechanism\"");
    }
    
    public override void Show()
    {
        Console.WriteLine("It's " + name + ", time of work = " + time);
    }
}