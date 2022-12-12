using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace TCIS.Training.LoopFor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            // Vòng lặp
            // FOR (<Khởi tạo giá trị đầu cho vòng lặp; Điều kiện lặp; giá trị sau khi thực hiện>)
            Console.WriteLine("CHƯƠNG TRÌNH THỰC HIỆN IN RA DÒNG CHỮ (TCIS-SSC) ");

            Console.WriteLine("Thực hiện nhập số lần bạn muốn in ra dòng chữ này");
            int number = 0;
            Console.WriteLine("Nhập số lần: ");
            number = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("\nSử dụng For\n");
            for (int i = 1; i < number; i++) // điều kiện lặp đến khi i< số đầu vào
            {
                Console.WriteLine($" Lần thứ {i} in ra: TCIS-SSC");
            }

            // Do while: khi thực hiện vòng lặp sẽ thực hiện lệnh phía trong Do trước
            // Sau đó quay lại kiểm tra điều kiện tại while nếu điều kiện true thì thực hiện lặp tiếp ngược lại fasle thì dừng.

            Console.WriteLine("\nSử dụng do while\n");
            do
            {
                Console.WriteLine($"Lần thứ {++number}: TCIS-SSC");
            } while (10 < number); // lặp vô tận nếu điều kiện là true 


            // while: Kiểm tra điều kiện nếu true thực hiện false dừng

            Console.WriteLine("\n Sử dụng vòng lặp while");
            while (10<number)
            {
                Console.WriteLine($"Lần thứ {number}: TCIS-SSC");
                number++; // lặp vô tận nếu điều kiện là true 
            }
            Console.ReadKey();
        }

      
    }
}
