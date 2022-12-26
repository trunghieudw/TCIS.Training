using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateTheScoresOfTheClasses.Entities
{
    public class ClassificationClass
    {
        public int Rank { get; } //Xếp hạng
        public string Classification { get;  } //Xếp loại thi đua
        public ScoreBoard ScoreBoard { get; set; }

        public string ToString()
        {
            return $" Xếp hạng: {Rank}- Xếp loại: {Classification} ";

        }
    }
}
