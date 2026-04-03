using System;

// Interface
public interface ICollectable
{
    bool isCollected { get; set; }
    void Collect();
}

// Base class
public class Base
{
    protected string name;

    public string Name
    {
        get { return name; }
        set
        {
            if (value == "")
                name = "Unnamed Object";
            else
                name = value;
        }
    }

    public Base(string name = "Unnamed Object")
    {
        Name = name;
    }

    public override string ToString()
    {
        return $"{name} is a {this.GetType().Name}";
    }
}

// Key class
public class Key : Base, ICollectable
{
    public bool isCollected { get; set; }

    // Constructor
    public Key(string name = "Key", bool isCollected = false) : base(name)
    {
        this.isCollected = isCollected;
    }

    // Collect method
    public void Collect()
    {
        if (!isCollected)
        {
            isCollected = true;
            Console.WriteLine($"You pick up the {name}.");
        }
        else
        {
            Console.WriteLine($"You have already picked up the {name}.");
        }
    }
}
