using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        class A
        {

        }
        static void Main(string[] args)
        {
            int data;
            int data2;

            A a = new A();
            data = 1000;
            A a2 = new A();
            data2 = 2000;

            int result2;
            int v = data++;
            result2 = v;
            Console.WriteLine(result2);

            int result;
            result = ++data + data2--;
            //Console.WriteLine(data);
            //Console.WriteLine(data2);
           
            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}
