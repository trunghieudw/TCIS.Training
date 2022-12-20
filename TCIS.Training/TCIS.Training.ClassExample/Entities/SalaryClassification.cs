using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCIS.Training.ClassExample.Entities
{
    public abstract class SalaryClassification
    {
        public int Id { get; set; }
        public double Coefficients { get; set; }
        public double BaseSalary { get; set; }
    }
}
