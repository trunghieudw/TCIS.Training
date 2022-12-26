using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateTheScoresOfTheClasses.Entities
{
    public class PlusMark
    {
        public int Id { get; set; }
        public int Name { get; set; }
        public double Point { get; set; }
        public string ToString()
        {
            return $"{Id}-{Name}-{Point}";

        }
    }
}
