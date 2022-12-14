namespace pro100user.task2;

//Вузол
public class Node : Product
{
    private int amount;
    
    public Node()
    {
        amount = 5;
        Console.WriteLine("Constructor \"Node\"");
    }
    
    public Node(int amount) : base("node")
    {
        this.amount = amount;
        Console.WriteLine("Constructor \"Node\"");
    }
    
    public Node(string name, int amount) : base(name)
    {
        this.amount = amount;
        Console.WriteLine("Constructor \"Node\"");
    }
    
    ~Node()
    {
        Console.WriteLine("Destructor \"Node\"");
    }
    
    public override void Show()
    {
        Console.WriteLine("It's " + name + ", amount = " + amount);
    }
}