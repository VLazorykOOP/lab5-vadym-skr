namespace pro100user.task2;

//Виріб
public abstract class Product
{
    protected string name;
    
    public Product()
    {
        name = "product";
        Console.WriteLine("Constructor \"Product\"");
    }
    
    public Product(string name)
    {
        this.name = name;
        Console.WriteLine("Constructor \"Product\"");
    }

    ~Product()
    {
        Console.WriteLine("Destructor \"Product\"");
    }

    public abstract void Show();
}