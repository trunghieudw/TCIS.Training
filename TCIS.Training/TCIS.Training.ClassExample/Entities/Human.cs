using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCIS.Training.ClassExample
{
    public abstract class Human
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set;}
        public virtual void Add()
        {
            Console.WriteLine("Ten : ");
            Name = Console.ReadLine();
            Console.WriteLine("Tuoi: ");
            Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dia chi: ");
            Address = Console.ReadLine();
        }
    }
}
