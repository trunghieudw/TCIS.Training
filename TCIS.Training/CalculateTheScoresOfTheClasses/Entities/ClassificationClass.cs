namespace CalculateTheScoresOfTheClasses.Entities
{
    public class ClassificationClass
    {
        public int Id { get; set; }
        public int Rank { get; set; } //Xếp hạng
        public string Classification { get; set; } //Xếp loại thi đua
        public ScoreBoard ScoreBoard { get; set; }

        //public string ToString()
        //{
        //    return $" Xếp hạng: {Rank}- Xếp loại: {Classification} ";

        //}
    }
}
