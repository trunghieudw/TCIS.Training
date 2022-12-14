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
        #region dungnv2
        //public class People
        //{
        //    public Person[] Persons = null;

        //    public People 
        //    {
        //        Persons = new Person[];
        //    }

        //    public void Add(List<Person> person)
        //    {
        //        Persons.AddRange(person);  
        //    } 

        //    public void Add(Person person)
        //    {
        //        Persons.Add(person);  
        //    }

        //    public void Remove(int id) //==> Method parameter
        //    {
        //         var p = Persons.FirstOrDefault(x=>x.Id = id); //variable
        //         Persons.Remove(p);
        //    }

        //    public void Remove(params int[] id)
        //    {
        //         var p = Persons.FirstOrDefault(x=>x.Id = id);
        //         Persons.Remove(p);
        //    }



        //    //Update
        //    //Find
        //    //RemoveMultils


        //}
        #endregion

        public class People2
        {

            // tạo mảng con người có số lượng phần tử truyền vào
            public People2(int number)
            {
                int[] people2 = new int[number];
                for (int i = 0; i < people2.Length; i++)
                {
                    Console.WriteLine($"Danh sách người đã tạo: {i + 1}");
                }
            }
            // thêm đối tượng vào trong mảng
            public void Add(int id, string name)
            {
                Person person = new Person(id,name);
                person.Id = id;
                person.Name = name;
                Console.WriteLine($"Người bạn đã thêm vào có Id: {id} và Name: {name}");
            }

        }


        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            #region dungnv2
            //People people = new People();

            //Person person = new Person(1,"A");
            //people.Add(person);

            //Person person2 = new Person(2, "B");
            //people.Add(person2);

            //people.Remove(1,2,3,4)

            //for (int i = 0; i < people.Persons.Count(); i++)
            //{
            //    Person p = people.Persons[i];

            //    Console.WriteLine(p.ToString());
            //}
            #endregion
            // Thực hiện sử dụng vòng lặp mảng, làm các yêu cầu:
            // Thêm, Xoá, Cập nhật, Tìm kiếm, Xoá nhiều class People
            // khởi tạo mảng con người
            Console.WriteLine("Khởi tạo mảng con người");
            Console.WriteLine("Nhập số lượng con người muốn tạo: ");
            int amount = 0;
            amount = Convert.ToInt32(Console.ReadLine());
            People2 people2 = new People2(amount);
            people2.Add(1, "a");

            Console.ReadKey();
        }


    }
}
