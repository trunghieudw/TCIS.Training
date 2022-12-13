using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace TCIS.Training.LoopFor
{

    public class Person
    {
        public int Id {get;set;}
        public string Name {get;set;}

        public Person(int id, string name)
        {
            Id = id;
            Name = name;
        }


        public override string ToString()
        {
            return  $"{Id} - {Name}";
        }
    }














    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            List<Person> persons = new List<Person>();

            persons.Add(new Person(1,"Nguyen Van A1"));
            persons.Add(new Person(2,"Nguyen Van A2"));
            persons.Add(new Person(3,"Nguyen Van A3"));
            persons.Add(new Person(4,"Nguyen Van A4"));


            int count =  persons.Count();  
            foreach(var person in persons)
            {
                Console.Write(person.ToString())
            }

            for(int i = 1; i <= count; i++)
            {
                var person = persons[i] ;
                Console.Write(person.ToString());
            }

            for(int i = count; i>=0; i--)
            {
                if(i%2==0)
                {
                    var person = persons[i] ;
                    Console.Write(person.ToString());
                }

            }

            for(int i = 0; i <= count; i+=2)
            {
                var person = persons[i] ;
                Console.Write(person.ToString());
            }

            for(int i = 0; i < count; ++i )
            {
                var person = persons[i] ;
                Console.Write(person.ToString());
            }


            int n = 10;
            for(int i = 0; i< n)
            {
                Console.Write("A");
            }


            string [] arr = ["A","B","C","D","E"];
            int len = arr.length;

            for(int i = 0; i < len; i++ )
            {
                var ele = arr[i] ;
                Console.Write(ele);
            }

            string [] newArr = new string[len];

            int newIdx = 0;
            for(int i = len; i>=0; i--)
            {
               newArr[newIdx] = arr[i];
               newIdx++;
            }

            /*
                i = 5
                    -> arr[5] = "E";
                       newIdx = 0 
                       newArr[0] = "E"
                i =  4
                    > arr[4] = "D";
                       newIdx = 1 
                       newArr[1] = "D"



            */
            
            for(int i = 0; i < len; i++ )
            {
                var ele = newArr[i] ;
                Console.Write(ele);
            }

            // Vòng lặp
            // FOR (<Khởi tạo giá trị đầu cho vòng lặp; Điều kiện lặp; giá trị sau khi thực hiện>)
            // Console.WriteLine("CHƯƠNG TRÌNH THỰC HIỆN IN RA DÒNG CHỮ (TCIS-SSC) ");

            // Console.WriteLine("Thực hiện nhập số lần bạn muốn in ra dòng chữ này");
            // int number = 0;
            // Console.WriteLine("Nhập số lần: ");
            // number = Convert.ToInt32(Console.ReadLine()); //100


            // Console.WriteLine("\nSử dụng For\n");
            // for (int i = 1; i < number; i++) // điều kiện lặp đến khi i< số đầu vào
            // {
            //     Console.WriteLine($" Lần thứ {i} in ra: TCIS-SSC {number[i]}");
            // }

            // foreach(var x in  number)
            // {
            //     Console.WriteLine($"TCIS-SSC {x}");
            // }


            // int sum = 0;
            
            // for (int i = 1; i < number; i++) // điều kiện lặp đến khi i< số đầu vào
            // {
            //    sum += number[i];
            // }


            // sum = 0;
            // foreach(var x in  number)
            // {
            //     sum += x;
            // }

            // // Do while: khi thực hiện vòng lặp sẽ thực hiện lệnh phía trong Do trước
            // // Sau đó quay lại kiểm tra điều kiện tại while nếu điều kiện true thì thực hiện lặp tiếp ngược lại fasle thì dừng.

            // Console.WriteLine("\nSử dụng do while\n");
            // do
            // {
            //     Console.WriteLine($"Lần thứ {++number}: TCIS-SSC");
            // } while (10 < number); // lặp vô tận nếu điều kiện là true 


            // // while: Kiểm tra điều kiện nếu true thực hiện false dừng

            // Console.WriteLine("\n Sử dụng vòng lặp while");
            // while (10<number)
            // {
            //     Console.WriteLine($"Lần thứ {number}: TCIS-SSC");
            //     number++; // lặp vô tận nếu điều kiện là true 
            // }
            Console.ReadKey();
        }

      
    }
}
