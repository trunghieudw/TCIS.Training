using System;
using System.Linq;

namespace InheritancePolymorphism
{
    class Animal
    {
        public Animal() : this("No Name", "No Sound") { }
        public Animal(string name) : this(name, "No Sound") { }
        public Animal(string name, string sound)
        {
            Name = name;
            Sound = sound;
        }
        private string name;
        protected string sound;


        public string Name
        {
            get { return name; }
            set
            {
                if (!value.Any(char.IsDigit))
                {
                    name = "No Name";
                }
                name = value;
            }
        }
        public string Sound
        {
            get { return sound; }
            set
            {
                if (value.Length > 10)
                {
                    sound = "No Name";
                }
                sound = value;
            }
        }

        public void MakeSound() { Console.WriteLine($"{Name} tieng {Sound}"); }
    }
}
