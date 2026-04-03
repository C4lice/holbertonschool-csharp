using System;

// Interfaces
public interface IInteractive
{
    void Interact();
}

public interface IBreakable
{
    int durability { get; set; }
    void Break();
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

// Decoration class
public class Decoration : Base, IInteractive, IBreakable
{
    public int durability { get; set; }
    public bool isQuestItem;

    // Constructor
    public Decoration(string name = "Decoration", int durability = 1, bool isQuestItem = false)
        : base(name)
    {
        if (durability <= 0)
            throw new Exception("Durability must be greater than 0");

        this.durability = durability;
        this.isQuestItem = isQuestItem;
    }

    // Interact method
    public void Interact()
    {
        if (durability <= 0)
        {
            Console.WriteLine($"The {name} has been broken.");
        }
        else if (isQuestItem)
        {
            Console.WriteLine($"You look at the {name}. There's a key inside.");
        }
        else
        {
            Console.WriteLine($"You look at the {name}. Not much to see here.");
        }
    }

    // Break method
    public void Break()
    {
        durability--;

        if (durability > 0)
        {
            Console.WriteLine($"You hit the {name}. It cracks.");
        }
        else if (durability == 0)
        {
            Console.WriteLine($"You smash the {name}. What a mess.");
        }
        else
        {
            Console.WriteLine($"The {name} is already broken.");
        }
    }
}
