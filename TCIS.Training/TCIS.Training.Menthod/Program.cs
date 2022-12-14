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


        public class People
        {
            public Person[] Persons = null;

            public People 
            {
                Persons = new Person[];
            }

            public void Add(List<Person> person)
            {
                Persons.AddRange(person);  
            } 

            public void Add(Person person)
            {
                Persons.Add(person);  
            }

            public void Remove(int id) //==> Method parameter
            {
                 var p = Persons.FirstOrDefault(x=>x.Id = id); //variable
                 Persons.Remove(p);
            }

            public void Remove(params int[] id)
            {
                 var p = Persons.FirstOrDefault(x=>x.Id = id);
                 Persons.Remove(p);
            }



            //Update
            //Find
            //RemoveMultils


        }


        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            People people = new People();

            Person person = new Person(1,"A");
            people.Add(person);

            Person person2 = new Person(2, "B");
            people.Add(person2);

            people.Remove(1,2,3,4)

            for (int i = 0; i < people.Persons.Count(); i++)
            {
                Person p = people.Persons[i];

                Console.WriteLine(p.ToString());
            }

            Console.ReadKey();
        }


    }
}
