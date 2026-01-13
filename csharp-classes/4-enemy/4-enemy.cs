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
            get => Name;
            set => Name = value;
        }

        public int GetHealth()
        {
            return health;
        }
    }
}
