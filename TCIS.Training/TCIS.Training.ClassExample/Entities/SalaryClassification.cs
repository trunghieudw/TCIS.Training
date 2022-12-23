using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCIS.Training.ClassExample.Entities
{
    public class SalaryClassification
    {
        public int Id { get; set; }
        public int Level { get; set; }
        public double BaseSalary { get; set; }

        public override string ToString()
        {
            return $"{Id}-{Level}-Lương cơ bản : {BaseSalary}";
        }

    }
}
