using System;
using System.Text;

namespace TCIS.Training.Class
{
    public class Fridge : Electric
    {
        public string Door { get; set; }
        public Fridge()
        {
            Id = 1;
            Name = "Tu lanh";
            Price = 1000;
            Door = "1 Canh";
        }

        public void Print()
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("Thông tin tủ lạnh\n**************************************************************************");
            Console.WriteLine($"Tên tủ lạnh: {Name}\nDanh mục: \nGiá Thành: {Price}\nSố cửa: {Door}");
        }

        //public double Invoice()
        //{
        //    //return;
        //}
        
    }
}
