using System;

namespace TCIS.Training.ClassExample
{
    public class Teacher : Human
    {
        public string Specialize { get; set; }
        public string AcademicLevel { get; set; }
        public Teacher()
        {
            

        }
        public override void Add()
        {
            Console.WriteLine("Nhap thong tin giao vien ");            
            Console.WriteLine("Chuyen mon: ");
            Specialize = Console.ReadLine();
            Console.WriteLine("Trinh do chuyen mon: ");
            AcademicLevel = Console.ReadLine();
        }

        public void Print()
        {
            Console.WriteLine("Thong tin giao vien");
            Console.WriteLine($"Ten giao vien {Name}\nTuoi: {Age}\nDia chi: {Address}\nChuyen mon: {Specialize}\nTrinh do chuyen mon: {AcademicLevel}");

        }
      
    }


}
