namespace pro100user.task2;

//Деталь
public class Detail : Product
{
    private int weight;

    public Detail()
    {
        weight = 10;
        Console.WriteLine("Constructor \"Detail\"");
    }
    
    public Detail(int weight) : base("detail")
    {
        this.weight = weight;
        Console.WriteLine("Constructor \"Detail\"");
    }
    
    public Detail(string name, int weight) : base(name)
    {
        this.weight = weight;
        Console.WriteLine("Constructor \"Detail\"");
    }
    
    ~Detail()
    {
        Console.WriteLine("Destructor \"Detail\"");
    }
    
    public override void Show()
    {
        Console.WriteLine("It's " + name + ", weight = " + weight);
    }
}