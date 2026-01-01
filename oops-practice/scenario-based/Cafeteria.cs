
using System;
class Cafeteria
{
    private static string[] menu = { "Pasta", "Salad", "Soda", "Tea", "Coffee", "Juice", "Pizza", "Burger", "Dessert", "Soup" };

    private int[] orderQuantity;

    public Cafeteria()
    {
        this.orderQuantity = new int[10];
    }
    public void AddOrder(int itemIndex, int orderQuantity)
    {
        this.orderQuantity[itemIndex] = orderQuantity;
    }

    private void Choose()
    {
        Console.WriteLine("======Wlecome to Cafeteria====");
        int input = -1;
        do
        {
            Console.WriteLine("PLEASE SELECT OPTION");
            Console.WriteLine("1. DISPLAY MENU");
            Console.WriteLine("2. ORDERED MENU");
            Console.WriteLine("3. EXIT MENU");
            input = Convert.ToInt32(Console.ReadLine());
            switch (input)
            {
                case 1:
                    DisplayMenu();
                    break;
                case 2:
                    GetMenuByIndex();
                    break;
                case 3:
                    Console.WriteLine("Thanks you! Come again");
                    break;
                case 4:
                    Console.WriteLine("Invalid Input");
                    break;
            }
        } while (input != 3);
    }

    private void ShowOrderList()
    {
        Console.WriteLine("\nYOUR ORDERED LIST");
        for (int i = 0; i < orderQuantity.Length; i++)
        {
            if (orderQuantity[i] > 0)
            {
                Console.WriteLine(menu[i] + "-" + orderQuantity[i]);
            }
        }
    }
    private void GetMenuByIndex()
    {
        Console.WriteLine("\nPLEASE ORDERED MENU BY ENTER INDEX AND QUANTITY");
        DisplayMenu();
        Console.WriteLine("Enter '0' to exit");
        Console.WriteLine("Give your orders");

        int orderIndex = -1;
        do
        {
            string[] order = Console.ReadLine().Split(' ');
            orderIndex = Convert.ToInt32(order[0]);
            int orderQuantity = orderIndex == 0 ? 1 : Convert.ToInt32(order[1]);
            if (orderIndex < 1 && orderIndex > 10)
            {
                Console.WriteLine("YOU HAVE ENTERED INVALID INDEX");
                continue;
            }
            if (orderIndex >= 1 && orderIndex <= 9)
            {
                AddOrder(orderIndex - 1, orderQuantity);
            }
            else
            {
                break;
            }
        } while (orderIndex != 0);

        ShowOrderList();
    }

    public void DisplayMenu()
    {
        Console.WriteLine("MENU LIST");
        for (int i = 0; i < menu.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {menu[i]}");
        }
        Console.WriteLine();
    }

    static void Main()
    {
        Cafeteria caf = new Cafeteria();
        caf.Choose();
    }

}