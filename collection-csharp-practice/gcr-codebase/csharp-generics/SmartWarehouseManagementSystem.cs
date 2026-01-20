abstract class WarehouseItem
{
    private string name;
    private int quantity;

    public WarehouseItem(string name, int quantity)
    {
        this.name = name;
        this.quantity = quantity;
    }
    public string Name { get => name; set => name = value; }
    public int Quantity { get => quantity; set => quantity = value; }

    public override string ToString()
    {
        return $"Name: {name}, Quantity: {quantity}";
    }
}

class Electronics : WarehouseItem
{
    public Electronics(string name, int quantity) : base(name, quantity)
    {
    }
}

class Groceries : WarehouseItem
{
    public Groceries(string name, int quantity) : base(name, quantity)
    {
    }
}

class Furniture : WarehouseItem
{
    public Furniture(string name, int quantity) : base(name, quantity)
    {
    }
}

class Storage<T> where T : WarehouseItem
{
    T[] items;
    public Storage(int size)
    {
        items = new T[size];
    }

    public void Add(T item)
    {
        for (int i = 0; i < items.Length; i++)
        {
            if (items[i] == null)
            {
                items[i] = item;
                break;
            }
        }
    }
    public void Remove(T item)
    {
        for (int i = 0; i < items.Length; i++)
        {
            if (items[i] == item)
            {
                items[i] = null;
                break;
            }
        }
    }

    public void Display()
    {
        for (int i = 0; i < items.Length; i++)
        {
            if (items[i] != null)
            {
                Console.WriteLine(items[i]);
            }
        }
    }
}

class SmartWarehouseManagementSystem
{
    static void Main(string[] args)
    {
        Storage<Electronics> electronicsStorage = new Storage<Electronics>(5);
        Storage<Groceries> groceriesStorage = new Storage<Groceries>(5);
        Storage<Furniture> furnitureStorage = new Storage<Furniture>(5);

        electronicsStorage.Add(new Electronics("Laptop", 2));
        electronicsStorage.Add(new Electronics("Mobile", 3));
        electronicsStorage.Add(new Electronics("Tablet", 1));

        groceriesStorage.Add(new Groceries("Rice", 10));
        groceriesStorage.Add(new Groceries("Sugar", 5));
        groceriesStorage.Add(new Groceries("Salt", 2));

        furnitureStorage.Add(new Furniture("Chair", 5));
        furnitureStorage.Add(new Furniture("Table", 3));
        furnitureStorage.Add(new Furniture("Cupboard", 2));

        electronicsStorage.Display();
        groceriesStorage.Display();
        furnitureStorage.Display();
    }
}
