using System;
interface IFlyable
{
    void Fly();
}
interface ISwimmable
{
    void Swim();
}
class Bird
{
    string name;
    public Bird(string name)
    {
        this.name=name;
    }
    public void DisplayInfo()
    {
        Console.WriteLine("Name: " + this.name);
    }
    
}
class Eagle : Bird, IFlyable
{
    public Eagle(string name) : base(name){}
    public void Fly()
    {
        Console.WriteLine("Eagle is flying.");

    }

}
class Sparrow : Bird, IFlyable
{
    public Sparrow(string name) : base(name) { }
    public void Fly()
    {
        Console.WriteLine("Sparrow is flying.");
    }

}
class Duck : Bird, ISwimmable
{
    public Duck(string name) : base(name) { }
    public void Swim()
    {
        Console.WriteLine("Duck is swimming.");

    }
}
class Penguin : Bird, ISwimmable
{
    public Penguin(string name) : base(name) { }
    public void Swim()
    {
        Console.WriteLine("Penguin is swimming.");
    }
}
class Seagull : Bird, IFlyable, ISwimmable
{
    public Seagull(string name) : base(name){}
    public void Fly()
    {
        Console.WriteLine("Seagull is fly");
    }
    public void Swim()
    {
        Console.WriteLine("Seagull is swimming.");
    }
}
class BirdSanctuary
{
    static void Main()
    {
        Bird[] birds = new Bird[5];
        birds[0] = new Eagle("Eagle");
        birds[1] = new Sparrow("Sparrow");
        birds[2] = new Duck("Duck");
        birds[3] = new Penguin("Penguin");
        birds[4] = new Seagull("Seagull");
        foreach (Bird bird in birds)
        {
            Console.WriteLine("Bird Details:");
            Console.WriteLine("----------------");
            bird.DisplayInfo();
        
            if (bird is IFlyable )
            {
                IFlyable flyable=(IFlyable)bird;
                flyable.Fly();
            }
            if (bird is ISwimmable )
            {
                ISwimmable swimmable=(ISwimmable)bird;
                swimmable.Swim();
            }
            Console.WriteLine();
        }
    }
}