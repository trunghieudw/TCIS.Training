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
    }
}
