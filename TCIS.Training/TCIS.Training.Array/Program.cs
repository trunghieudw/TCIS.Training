using System;
using System.Text;
using System.Linq;


namespace TCIS.Training.Array
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
            // khai báo mảng kiểu int
            int[] array = { 1, 2, 3, 4, 5,12,31,123,123441,12333,23 };
            // khai báo vị trí phần tử muốn truy cập
            int number;
            Console.WriteLine($"Danh sách phần tử trong mảng: {array.Length}");
            Console.WriteLine("Nhập số thứ tự phần tử muốn truy cập: ");
            number = Convert.ToInt32(Console.ReadLine());
            // thực hiện gán giá trị phần tử truy cập vào trong mảng 
            int selectarray = array[number];
            Console.WriteLine($"Giá trị của phần tử thứ {number} trong mảng là: {selectarray}");

            // Duyệt phần tử mảng dùng ForEach
            // Duyệt phần tử mảng dùng for
            for(int amount = 0; amount< array.Length; amount++)
            {
                Console.WriteLine(array[amount]); 
            }


            Person [] persons = 
            {
               new   Person(1,"A"),  
               new   Person(2,"B"),  
            };


            Console.ReadKey();


        }
    }
}
