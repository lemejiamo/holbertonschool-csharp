using System;

namespace Enemies
{
    /// <sumary>
    /// empty class Zombie
    /// </sumary>
    public class Zombie
    {
        /// <summary>
        /// Field Zombie Health .
        /// </summary>
        public int health;

        /// <summary>
        /// constructor for a Zombie.
        /// </summary>
        public Zombie()
        {
            health = 0;
        }

        /// <summary>
        /// constructor for a Zombie with Health args.
        /// </summary>
        public Zombie(int value)
        {

            if(value < 0)
                throw new System.ArgumentException("Health must be greater than or equal to 0");
            else
                health = value;
        }
    }
}
