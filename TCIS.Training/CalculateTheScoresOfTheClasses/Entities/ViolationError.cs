using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateTheScoresOfTheClasses.Entities
{
   public class ViolationError// Lỗi vi phạm
    {
        public int Id { get; set; }
        public string Name { get; set; }// tên lỗi vi phạm
        public double Point { get; set; }// điểm trừ vi phạm

        public string ToString()
        {
            return $"{Id}-Lỗi vi phạm: {Name}-Điểm trừ: {Point}";
        }
    }
}
