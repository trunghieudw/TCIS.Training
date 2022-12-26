using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateTheScoresOfTheClasses.Entities
{
    public class RedStarSchedule
    {
        public int Id { get; set; }
        public string AssignedClass { get; set; } //Lớp bị trực
        public Class Class { get; set; } // Lớp trực
        public int Week { get; set; } // số tuần

        public string ToString()
        {
            return $"{Id}-Tuần số: {Week}-Lớp trực: {Class.Name}-Lớp bị trực: {AssignedClass} ";

        }
    }
}
