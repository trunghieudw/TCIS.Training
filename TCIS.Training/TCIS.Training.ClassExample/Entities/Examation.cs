using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCIS.Training.ClassExample.Entities
{
    public class Examation
    {
        public int Id { get; set; }
        public Student Student { get; set; }
        public Subject Subject { get; set; }
        public double Score { get; set; }
        public DateTime ExamDate { get; set; }
        public string Result { get; set; }

        public string CheckScore()
        {
            if (Score < 3)
            {
                return Result = "Truot";

            }
            else 
                return Result = "Qua";
        }
       
        public override string ToString()
        {
            return $"{Id}-{Student.StudentName}-{ExamDate.Day}-{Subject.Name}={Score}";
        }            

       public string StudentName => Student.StudentName;

    }
}
