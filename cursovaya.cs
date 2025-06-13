using System;
using System.Collections.Generic;
using System.Linq;

class Coffee
{
    public string Name { get; }
    public decimal Price { get; }

    public Coffee(string name, decimal price)
    {
        Name = name;
        Price = price;
    }
}

class Order
{
    private List<Coffee> items = new List<Coffee>();

    public void AddItem(Coffee coffee)
    {
        items.Add(coffee);
        Console.WriteLine($"Добавлено: {coffee.Name}");
    }

    public void DisplayOrder()
    {
        Console.WriteLine("\nВаш заказ:");
        foreach (var item in items)
        {
            Console.WriteLine($"- {item.Name}: {item.Price:C}");
        }
        Console.WriteLine($"ИТОГО: {CalculateTotal():C}\n");
    }

    public decimal CalculateTotal() => items.Sum(item => item.Price);
}

class Program
{
    static void Main()
    {
        // Инициализация меню
        List<Coffee> menu = new List<Coffee>
        {
            new Coffee("Эспрессо", 150),
            new Coffee("Капучино", 200),
            new Coffee("Латте", 220),
            new Coffee("Американо", 170),
            new Coffee("Мокко", 250)
        };

        Order currentOrder = new Order();
        bool isOrdering = true;

        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("Добро пожаловать в кофейню!\n");

        while (isOrdering)
        {
            DisplayMenu(menu);
            Console.Write("\nВыберите кофе (1-5), 'view' - заказ, 'checkout' - итог, 'exit' - выход: ");
            string input = Console.ReadLine().Trim().ToLower();

            switch (input)
            {
                case "1":
                case "2":
                case "3":
                case "4":
                case "5":
                    int index = int.Parse(input) - 1;
                    currentOrder.AddItem(menu[index]);
                    break;
                case "view":
                    currentOrder.DisplayOrder();
                    break;
                case "checkout":
                    Console.WriteLine("\n=== Оформление заказа ===");
                    currentOrder.DisplayOrder();
                    Console.WriteLine("Спасибо за заказ!");
                    currentOrder = new Order();
                    break;
                case "exit":
                    isOrdering = false;
                    break;
                default:
                    Console.WriteLine("Ошибка: введите цифру 1-5 или команду\n");
                    break;
            }
        }
        Console.WriteLine("\nДо свидания!");
    }

    static void DisplayMenu(List<Coffee> menu)
    {
        Console.WriteLine("===== МЕНЮ =====");
        for (int i = 0; i < menu.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {menu[i].Name} - {menu[i].Price:C}");
        }
    }
}
