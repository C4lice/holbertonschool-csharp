using System;
using System.Linq.Expressions;

namespace Enemies
{
    /// <summary>
    /// This is a class that represent zombie enemy.
    /// </summary>
    public class Zombie
    {
        /// <summary>
        /// Represents the zombie's health.
        /// </summary>
        public int health;

        /// <summary>
        /// Represents the zombie's name.
        /// </summary>
        private string name = "(No name)";

        public Zombie()
        {
            health = 0;
        }

        public Zombie(int value)
        {
            if (value < 0)
            {
                throw new ArgumentException("Health must be greater than or equal to 0");
            }
            health = value;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public int GetHealth()
        {
            return health;
        }
        public override string ToString()
        {
            return $"Zombie Name: {name} / Total Health: {health}";
        }
    }
}
