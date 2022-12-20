using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;


namespace TCIS.Training.Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Fridge fridge = new Fridge();
            fridge.Print();

            var data = new Faker<Fridge>();
            var output = data.Generate(3);
            Console.ReadKey();
        }
    }
}
