using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCIS.Training.ClassExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // khởi tạo đối tượng student
           
            //int options;
            //options = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Nhap lua chon ");
            //Console.WriteLine("1: Nhap thong tin giao vien ");
            //Console.WriteLine("2: In ra man hinh thong tin giao vien");
            //Student student = new Student();
            //student.Print();
            Teacher teacher = new Teacher();
            teacher.Add();
            teacher.Print();

            Console.ReadKey();
        }
    }
}
