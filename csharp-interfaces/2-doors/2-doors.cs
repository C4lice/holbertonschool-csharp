using System;

// Interface
public interface IInteractive
{
    void Interact();
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

// Door class
public class Door : Base, IInteractive
{
    public Door(string name = "Door") : base(name)
    {
    }

    public void Interact()
    {
        Console.WriteLine($"You try to open the {name}. It's locked.");
    }
}
