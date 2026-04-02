using System;

// Interface IInteractive
public interface IInteractive
{
    void Interact();
}

// Interface IBreakable
public interface IBreakable
{
    int durability { get; set; }
    void Break();
}

// Interface ICollectable
public interface ICollectable
{
    bool isCollected { get; set; }
    void Collect();
}

// Classe TestObject
public class TestObject : Base, IInteractive, IBreakable, ICollectable
{
    // Implémentation des propriétés
    public int durability { get; set; }
    public bool isCollected { get; set; }

    // Implémentation des méthodes (vides pour cet exercice)
    public void Interact()
    {
    }

    public void Break()
    {
    }

    public void Collect()
    {
    }
}
