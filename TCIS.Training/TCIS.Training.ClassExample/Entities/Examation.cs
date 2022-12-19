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
        public decimal Score { get; set; }
        public DateTime ExamDate { get; set; }

        public Examation(int id, decimal score,Student student, Subject subject)
        {
          
            Id = id; 
            student.Class = student.
            Score = score;
            
        }
        public override string ToString()
        {
            return $"{Id}-{Score}";
        }
    }
}
