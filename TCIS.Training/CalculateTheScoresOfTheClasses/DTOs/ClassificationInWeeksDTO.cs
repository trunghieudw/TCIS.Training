using CalculateTheScoresOfTheClasses.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateTheScoresOfTheClasses
{
    public class ClassificationInWeeksDTO
    {
        public string Classification { get; set; } //Xếp loại thi đua
        public ScoreBoard ScoreBoard { get; set; }

        //// thuộc tính tổng điểm
        public double TotalPoint { get; set; } //tính tổng điểm       
        public double ViolationError { get; set; } //điểm trừ
        public double PlusMark { get; set; }//điểm cộng

        public override string ToString()
        {
            return $"Lop: {ScoreBoard.Class.Name} - Diem cong: {PlusMark}\n" +
                $"Diem tru: {ViolationError}" + $"Tong diem: {TotalPoint}" +
                $" Xep hang: {Classification}";
        }
    }
}
