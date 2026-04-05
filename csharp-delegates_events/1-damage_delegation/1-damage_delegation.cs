using System;

public class Player
{
    // Delegate
    public delegate void CalculateHealth(float amount);

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

    // Méthode PrintHealth (optionnel mais souvent gardée)
    public void PrintHealth()
    {
        Console.WriteLine($"{name} has {hp} / {maxHp} health");
    }

    // TakeDamage
    public void TakeDamage(float damage)
    {
        if (damage < 0)
            damage = 0;

        Console.WriteLine($"{name} takes {damage} damage!");
    }

    // HealDamage
    public void HealDamage(float heal)
    {
        if (heal < 0)
            heal = 0;

        Console.WriteLine($"{name} heals {heal} HP!");
    }
}
