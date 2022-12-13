using System;
using System.Text;

namespace TCIS.Training.Menthod
{
    class Program
    {
        public class Person
        {
            public int Id { get; set; }
            public string Name { get; set; }

            public Person(int id, string name)
            {
                Id = id;
                Name = name;
            }
            public override string ToString()
            {
                return $"{Id} - {Name}";
            }
        }



        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Person person = new Person(1,"A");
            Person person2 = new Person(2, "B");

            person.ToString();
            person2.ToString();
            Console.ReadKey();
        }


    }
}
