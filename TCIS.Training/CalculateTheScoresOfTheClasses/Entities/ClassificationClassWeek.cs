namespace CalculateTheScoresOfTheClasses.Entities
{
    public class ClassificationClassWeek
    {
        public int Id { get; set; }
        //public int Rank { get; set; } //Xếp hạng
        public string Classification { get; set; } //Xếp loại thi đua
        public ScoreBoard ScoreBoard { get; set; }

        //// thuộc tính tổng điểm
        public double TotalPoint { get; set; } //tính tổng điểm       
        public double ViolationError { get; set; } //điểm trừ
        public double PlusMark { get; set; }//điểm cộng
       
    }
}
