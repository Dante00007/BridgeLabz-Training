

class Animal {
    private string name;
    private int age;

    public Animal(string name, int age)
    {
        SetName(name);
        SetAge(age);
    }
    
    public void SetName(string name) { 
        this.name=name;
    }
    public void SetAge(int age) {
        this.age=age;
    }
    public string GetName() {
        return name;
    }
    public int GetAge() {
        return age;
    }
 
    public virtual void MakeSound() {
        Console.WriteLine("Animal makes a sound.");
    }
}

class Dog : Animal {
    public Dog(): base("dog", 2){}
    public override void MakeSound() {
        Console.WriteLine("Dog barks.");
    }
}

class Cat : Animal {
    public Cat(): base("cat", 3){}
    public override void MakeSound() {
        Console.WriteLine("Cat meows.");
    }
}

class Bird : Animal {
    public Bird(): base("bird", 1){}
    public override void MakeSound() {
        Console.WriteLine("Bird chirps.");
    }
}

class AnimalHierarchy {
    static void Main() {
        Animal dog = new Dog();
        Animal cat = new Cat();
        Animal bird = new Bird();
        
        dog.MakeSound();
        cat.MakeSound(); 
        bird.MakeSound();
        
    }
}