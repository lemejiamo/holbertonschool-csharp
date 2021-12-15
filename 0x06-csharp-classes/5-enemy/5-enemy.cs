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

        /// private attribute to set name of the zombie
        private string name = "(No name)";

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

        /// <summary>
        /// Method to get Healt stat from a zombie
        /// </summary>
        public int GetHealth()
        {
            return health;
        }

        /// <summary>
        /// Method to set & get  name to  a zombie
        /// </summary>
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        /// <summary>
        /// Override toString Method with a perzonalice output
        /// </summary>
        public override string ToString()
        {
            return ($"Zombie Name: {name} / Total Health: {health}");
        }
    }
}
