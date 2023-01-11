using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console; // sử dụng console cho lớp dùng chung

namespace TCIS.Training.Polymorphism // TÍNH ĐA HÌNH TRONG LẬP TRÌNH HƯỚNG ĐỐI TƯỢNG
{
    class Program
    {
        class Vehicle // xây dựng lớp chung là phương tiện giao thông
        {
            public virtual void Go()
            {
                // method Go()
               
            }
        }
        class Car: Vehicle // lớp xe kế thừa lại phương tiện giao thông, trong phương tiện giao thông có phương thức là Go()
        {
            // implement lại phương thức Go() trong class Car
            public override void Go()
            {
                // từ khoá base để lấy lại hành động của phương thức cha 
                Console.WriteLine("Di chuyển trên bộ");
            }
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            // Tính đa hình: được hiểu là có nhiều hình thức 
            // Đối tượng được xác định bởi nhiều loại hình thức nhưng dựa trên hình thức chung

            Car car = new Car(); // khởi tạo đối tượng Car
            car.Go();

            ReadKey();
        }
    }
}
