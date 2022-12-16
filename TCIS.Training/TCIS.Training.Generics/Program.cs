using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCIS.Training.Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            //Generic = không dành riêng cho một loại dữ liệu cụ thể
            //          thêm <T> cho: class, method, ...
            //          cho phép sử dụng lại code cho các kiểu dữ liệu khác nhau
            //

            int[] intArray = { 1, 2, 3 };
            double[] doubleArray = { 1.1, 2.2, 3.3 };
            String[] stringArray = { "1", "2", "3" };

            displayElements(intArray);
            displayElements(doubleArray);
            displayElements(stringArray);
            Console.ReadKey();

        }
        public static void displayElements <T>(T[] array)
        {
            foreach (T item in array)
            {
                Console.Write(item + "");
            }
        }

    }
}
