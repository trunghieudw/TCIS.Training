using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCIS.Training.ClassExample
{
    public interface IClass
    {
         string Majors { get; set; }
         DateTime YearTo { get; set; }
         string Name { get; set; }
    }
}
