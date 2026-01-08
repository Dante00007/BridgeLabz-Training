

class InventoryNode
{
    public string ItemName { get; set; }
    public int ItemId { get; set; }
    public int Quantity { get; set; }
    public double Price { get; set; }
    public InventoryNode? Next { get; set; }

    public InventoryNode(string itemName, int itemId, int quantity, double price)
    {
        this.ItemName = itemName;
        this.ItemId = itemId;
        this.Quantity = quantity;
        this.Price = price;
        this.Next = null;
    }
    public override string ToString()
    {
        return $"Item Name: {this.ItemName}, Item ID: {this.ItemId}, Quantity: {this.Quantity}, Price: {this.Price}";
    }
}

class InventoryLinkedList
{
    public InventoryNode Head { get; set; }

    private InventoryNode CreateNode()
    {
        Console.Write("Enter item name: ");
        string itemName = Console.ReadLine();

        Console.Write("Enter item ID: ");
        int itemId = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter quantity: ");
        int quantity = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter price: ");
        double price = Convert.ToDouble(Console.ReadLine());

        return new InventoryNode(itemName, itemId, quantity, price);
    }

    public void AddItem()
    {
        InventoryNode node = CreateNode();
        if (Head == null)
        {
            Head = node;
        }
        else
        {
            InventoryNode temp = Head;
            while (temp.Next != null)
            {
                temp = temp.Next;
            }
            temp.Next = node;
        }
    }

    public void RemoveItem()
    {
        Console.Write("Enter item ID to remove: ");
        int itemId = Convert.ToInt32(Console.ReadLine());
        if (Head == null) return;
        if (Head.ItemId == itemId)
        {
            Head = Head.Next;
        }
        else
        {
            InventoryNode temp = Head;
            while (temp.Next != null && temp.Next.ItemId != itemId)
            {
                temp = temp.Next;
            }
            if (temp.Next != null)
            {
                temp.Next = temp.Next.Next;
            }
            else if (temp.Next == null)
            {
                Console.WriteLine("Item not found");
            }
        }
    }
    public void UpdateQuantity()
    {
        if (Head == null)
        {
            Console.WriteLine("Inventory is empty.");
            return;
        }
        Console.Write("Enter item ID to update quantity: ");
        int itemId = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter new quantity: ");
        int newQuantity = Convert.ToInt32(Console.ReadLine());
        InventoryNode temp = Head;
        while (temp != null)
        {
            if (temp.ItemId == itemId)
            {
                temp.Quantity = newQuantity;
                break;
            }
            temp = temp.Next;
        }
    }
    public void SearchItemById()
    {
        if (Head == null)
        {
            Console.WriteLine("Inventory is empty.");
            return;
        }
        Console.Write("Enter item ID to search: ");
        int itemId = Convert.ToInt32(Console.ReadLine());
        InventoryNode temp = Head;
        while (temp != null)
        {
            if (temp.ItemId == itemId)
            {
                Console.WriteLine(temp);
                return;
            }
            temp = temp.Next;
        }
        Console.WriteLine("Item not found.");
        return;
    }
    public void SearchItemByName()
    {
        if (Head == null)
        {
            Console.WriteLine("Inventory is empty.");
            return;
        }
        Console.Write("Enter item name to search: ");
        string itemName = Console.ReadLine();
        InventoryNode temp = Head;
        while (temp != null)
        {
            if (temp.ItemName == itemName)
            {
                Console.WriteLine(temp);
                return;
            }
            temp = temp.Next;
        }
        Console.WriteLine("Item not found.");
    }
    public void CalculateTotalValue()
    {
        double totalValue = 0;
        InventoryNode temp = Head;
        while (temp != null)
        {
            totalValue += temp.Price * temp.Quantity;
            temp = temp.Next;
        }
        Console.WriteLine(totalValue);
    }
    public void SortByPriceAscending()
    {
        if (Head == null)
        {
            Console.WriteLine("Inventory is empty.");
            return;
        }
        // Bubble sort implementation
        bool swapped;
        do
        {
            swapped = false;
            InventoryNode current = Head;
            while (current.Next != null)
            {
                if (current.Price > current.Next.Price)
                {
                    Swap(current, current.Next);
                    swapped = true;
                }
                current = current.Next;
            }
        } while (swapped);
    }
    private void Swap(InventoryNode node1, InventoryNode node2)
    {
        string tempName = node1.ItemName;
        int tempId = node1.ItemId;
        int tempQuantity = node1.Quantity;
        double tempPrice = node1.Price;

        node1.ItemName = node2.ItemName;
        node1.ItemId = node2.ItemId;
        node1.Quantity = node2.Quantity;
        node1.Price = node2.Price;

        node2.ItemName = tempName;
        node2.ItemId = tempId;
        node2.Quantity = tempQuantity;
        node2.Price = tempPrice;
    }
    public void DisplayInventory()
    {
        InventoryNode temp = Head;
        Console.WriteLine("Inventory:");
        while (temp != null)
        {
            Console.WriteLine(temp);
            temp = temp.Next;
        }
    }
}
class InventoryManagementSystem
{
    static void Main()
    {
        InventoryLinkedList invLs = new InventoryLinkedList();
        Console.Clear();
        while (true)
        {
            Console.WriteLine("----------------------");
            Console.WriteLine("\nMenu");
            Console.WriteLine("1. Add Item");
            Console.WriteLine("2. Remove Item");
            Console.WriteLine("3. Update Quantity");
            Console.WriteLine("4. Search By Id");
            Console.WriteLine("5. Search By Name");
            Console.WriteLine("6. Calculate Total Value");
            Console.WriteLine("7. Sort by Price Ascending");
            Console.WriteLine("8. Display Inventory");
            Console.WriteLine("9. Exit");

            Console.Write("Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("-----Processing------");
            switch (choice)
            {
                case 1:
                    invLs.AddItem();
                    break;
                case 2:
                    invLs.RemoveItem();
                    break;
                case 3:
                    invLs.UpdateQuantity();
                    break;
                case 4:
                    invLs.SearchItemById();
                    break;
                case 5:
                    invLs.SearchItemByName();
                    break;
                case 6:
                    invLs.CalculateTotalValue();
                    break;
                case 7:
                    invLs.SortByPriceAscending();
                    break;
                case 8:
                    invLs.DisplayInventory();
                    break;
                case 9:
                    Console.WriteLine("Exiting...");
                    return;
                default:
                    Console.WriteLine("Invalid Choice!");
                    break;
            }
        }

    }
}