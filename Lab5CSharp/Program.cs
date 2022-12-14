using System;
using pro100user.task2;
using pro100user.task3;

namespace fanatic 
{
    /*
     * Лабараторна робота №5
     * Скуратовського Вадима група 341ск
     * Варіант 19
     */
    public class Lab5
    {
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("1. Завдання 1-2");
                Console.WriteLine("2. Завдання 3");
                Console.WriteLine("3. Вихід");
                Console.Write("Введіть вибране число: ");
                try
                {
                    int number = int.Parse(Console.ReadLine());
                    if (number == 3)
                    {
                        Console.WriteLine("Вихід...");
                        return;
                    }

                    switch (number)
                    {
                        case 1:
                            Task1AndTask2();
                            break;
                        case 2:
                            Task2();
                            break;
                        default:
                            Console.WriteLine("Ви ввели не те число. Повторіть спробу");
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("\nВи не правильно ввели число. Повторіть спробу");
                }
                Console.WriteLine();
            }
        }
        
        static void Task1AndTask2()
        {
            List<Product> products = new List<Product>()
            {
                new Detail(),
                new Mechanism(),
                new Node()
            };
            products.ForEach(product => product.Show()); 
        }
        
        static void Task2()
        {
            List<Client> clients = new List<Client>()
            {
                new Creditor(500, "Creditor", 10, 550),
                new Investor(10000,"Investor", 10),
                new Organization(100000, "Organization", "UA1234567890")
            };
            clients.ForEach(client => client.Print()); 
        }
    }
}
