using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateTheScoresOfTheClasses.Entities
{
    public class RatingBoard // bảng xếp loại thi đua
    {
        public int Id { get; set; }
        public ScoreBoard ScoreBoard { get; set; }
        public string Classification { get; set; }
        public string ToString()
        {
            return $"{Id}-{ScoreBoard.Class}-{Classification}";

        }
    }
}
