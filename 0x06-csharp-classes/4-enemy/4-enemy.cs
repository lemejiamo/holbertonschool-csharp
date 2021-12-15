using System;

namespace Enemies
{
    public class Zombie
    {
        public int health;
        private string name = "(No name)";
        public Zombie()
        {
            health = 0;
        }
        public Zombie(int value)
        {
            if(value < 0)
                throw new System.ArgumentException("Health must be greater than or equal to 0");
            else
                health = value;
        }
        public int GetHealth()
        {
            return health;
        }
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
    }
}
