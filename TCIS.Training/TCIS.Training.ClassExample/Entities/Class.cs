using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCIS.Training.ClassExample
{
    public class Class : IClass
    {
        public string Majors { get; set; }     
        public DateTime   YearTo { get; set; }
        public string Name { get; set; }
    }
}
