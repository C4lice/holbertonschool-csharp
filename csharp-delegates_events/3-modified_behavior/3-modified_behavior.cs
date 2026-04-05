using System;

// Enum
public enum Modifier
{
    Weak,
    Base,
    Strong
}

// Delegate
public delegate float CalculateModifier(float baseValue, Modifier modifier);

public class Player
{
    // Propriétés privées
    private string name;
    private float maxHp;
    private float hp;

    // Constructeur
    public Player(string name = "Player", float maxHp = 100f)
    {
        this.name = name;

        if (maxHp <= 0)
        {
            Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
            this.maxHp = 100f;
        }
        else
        {
            this.maxHp = maxHp;
        }

        this.hp = this.maxHp;
    }

    public void PrintHealth()
    {
        Console.WriteLine($"{name} has {hp} / {maxHp} health");
    }

    public void TakeDamage(float damage)
    {
        if (damage < 0)
            damage = 0;

        Console.WriteLine($"{name} takes {damage} damage!");

        ValidateHP(hp - damage);
    }

    public void HealDamage(float heal)
    {
        if (heal < 0)
            heal = 0;

        Console.WriteLine($"{name} heals {heal} HP!");

        ValidateHP(hp + heal);
    }

    public void ValidateHP(float newHp)
    {
        if (newHp < 0)
            hp = 0;
        else if (newHp > maxHp)
            hp = maxHp;
        else
            hp = newHp;
    }

    // 🔹 Méthode demandée
    public float ApplyModifier(float baseValue, Modifier modifier)
    {
        switch (modifier)
        {
            case Modifier.Weak:
                return baseValue * 0.5f;

            case Modifier.Base:
                return baseValue;

            case Modifier.Strong:
                return baseValue * 1.5f;

            default:
                return baseValue;
        }
    }
}
