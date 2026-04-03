using System;

/// <summary>Base class</summary>
abstract class Base 
{
    string name { get; set; }

/// <summary>Base class constructor</summary>
    public override string ToString()
    {
        return "" + name + " is a " + GetType();
    }
}


/// <summary>IInteractive interface</summary>
interface IInteractive
{
    void Interact();
}

/// <summary>ICollectable interface</summary>
interface ICollectable
{
    bool isCollected { get; set; }

    void Collect();
}

/// <summary>IBreakable interface</summary>
interface IBreakable
{
    int durability { get; set; }
    void Break();
}

/// <summary>TestObject class</summary>
class TestObject : Base, ICollectable, IBreakable, IInteractive
{
    public int durability { get; set; }
    public bool isCollected { get; set; }
    public string name { get; set; }

    public void Interact(){}
    public void Collect(){}
    public void Break(){}
}
