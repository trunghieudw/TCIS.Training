using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateTheScoresOfTheClasses.Entities
{
    public class ScoreBoard // bảng tổng kết điểm
    {
        public int Id { get; set; }      
        public Class Class { get; set; } 
        public double TotalPoint { get; set; } //tổng điểm
        public int Rank { get; set; } //Bảng xếp hạng
        public ViolationError ViolationError { get; set; }
        public PlusMark PlusMark { get; set; }

        public string ToString()
        {
            return $"{Id}-{Class.Name}-Điểm trừ: {ViolationError}-Điểm cộng: {PlusMark}- Tổng điểm: {TotalPoint}- Xếp hạng: {Rank} ";

        }
    }
}
