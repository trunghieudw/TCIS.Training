using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCIS.Training.VariablesConstants
{
    class Program
    {
        static void Main(string[] args)
        {

            // BIẾN, KIỂU DỮ LIỆU , NHẬP XUẤT MÀN HÌNH CONSOLE
            // kiểu dữ liệu cơ bản được định nghĩa sẵn trong C#: string, int, double, bool 
            // khai báo biến: <kiểu dữ liệu> <tên biến> đặt tên theo convention

            #region Nhập kiểu dữ liệu
            //string studentName; //string: kiểu dữ liệu , StudentName: biến
            //int studentAge; // int: kiểu dữ liệu, StudentAge: biến

            //Console.WriteLine("Nhap so double: ");
            //double number;

            //number = Convert.ToDouble(Console.ReadLine());
            //number = Convert.ToDecimal(number )

            //Console.WriteLine($"So ban vua nhap la: {number}");

            //Console.WriteLine("nhap object name: ");
            //object name;
            //name = Console.ReadLine();
            //Console.WriteLine($"{name}");
            //// gán giá trị cho biến
            //float so = 3;
            //float kq;
            //double sodouble = 3;
            //double kqdouble;
            //Console.WriteLine("Kieu Float");
            //Console.WriteLine($"{kq = so / 2} = {so}/2");     
            //Console.WriteLine("Kieu Double");
            //Console.WriteLine($"{kqdouble = sodouble / 2} = {sodouble}/2");
            //string nameSchool = "Harvard"; // toán tử = cho ta gán giá trị của biến Shool có tên là Harvard
            //Console.WriteLine(nameSchool); // in ra màn hình giá trị của biến School 

            //// nhập dữ liệu từ bàn phím

            //string Class;
            //Console.WriteLine("Nhập thông tin lớp: "); // in ra màn hình 
            //Class = Console.ReadLine(); // đọc dữ liệu được nhập từ bàn phím
            //Console.WriteLine(Class);

            //// Khai báo biến với var (kiểu dữ liệu của biến sẽ được xác định kiểu biểu thức gán vào sau đó)
            //var variable = (4<5); // dữ liệu gán vào sẽ thay đổi kiểu dữ liệu của variable.

            //// Hằng số là những giá trị mặc định bất biến không thay đổi được nữa từ khoá const
            //const string Mo = "Monday";
            //const string Tu = "Tues";
            //const string We = "Wed";
            //Console.WriteLine(Mo,Tu,We);

            //Khai bao object 
            //object studentName = "Hieu";
            //Console.WriteLine(studentName);
            #endregion
            Console.OutputEncoding = Encoding.UTF8;

            // Nhập kiểu dữ liệu vào màn hình thông qua biến var
            Console.WriteLine("CHƯƠNG TRÌNH NHẬP VÀ IN RA MÀN HÌNH");
            Console.WriteLine("Hãy nhập: ...");
            //var input = Console.ReadLine(); // khai báo biến kiểu var khi đầu vào nhập thì dữ liệu của var sẽ thay đổi phù hợp với input
            //decimal myMoney = 5.67M;
            //int intMoney = Convert.ToInt32(myMoney);
            //Console.WriteLine($"IN:  {myMoney}");
            //string chuoi = " le Trung Hieu 123 3 4 1" +
            //    "12321312312314";
            //object objchuoi = chuoi;

            //int pheptinh = 5 + 2 + 3 * 2;

            //Console.WriteLine(pheptinh);
        }
    }
}
