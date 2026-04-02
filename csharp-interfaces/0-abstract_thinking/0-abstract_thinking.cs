using System;

public abstract class Base
{
    // Propriété publique
    public string name { get; set; }

    // Override de ToString()
    public override string ToString()
    {
        return $"{name} is a {this.GetType().Name}";
    }
}
