using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCIS.Training.ClassExample
{
    public class Student:Human, IClass
    {
        public int Code { get; set; }
        public string Majors { get ; set ; }
        public DateTime YearTo { get ; set ; }

        public Student()
        {
            Id = 1;
            Name = "Hiếu";
            Age = 2000;
            Address = "Tay Ninh";
            Code = 21143101;
            Majors = "IT";
            YearTo = DateTime.Now.AddYears(+4);
        }

        public void Print()
        {
            Console.WriteLine($"Thông tin của học sinh {Name}");
            Console.WriteLine($"MSSV: {Code}");
            Console.WriteLine($"Dia chi: {Address}");
            Console.WriteLine($"Tuoi: {Age}");
            Console.WriteLine($"Thoi gian dao tao den: {YearTo.Year}");
            Console.WriteLine($"Nganh hoc: {Majors}");
        }



    }
}
