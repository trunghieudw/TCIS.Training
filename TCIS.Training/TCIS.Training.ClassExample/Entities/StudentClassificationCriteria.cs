namespace TCIS.Training.ClassExample.Entities
{
    public class StudentClassificationCriteria
    {
        public int Id { get; set; }
        public string Classification { get; set; }
        public double AvgScoreFrom { get; set; }
        public double AvgScoreTo { get; set; }
        //public Student Student { get; set; }
        //public Examation Examation { get; set; }

        //public string AvgClassification()
        //{

        //    double avg = Examation.Score / 3;
        //    if (avg > AvgScoreTo)
        //    {
        //        return Classification = "Gioi";
        //    }
        //    else if (avg >= 7 && avg >= 8)
        //    {
        //        return Classification = "Kha";
        //    }
        //    else
        //    {
        //        return Classification = "Trung Binh";
        //    }

        //}

        //public string ClassificationStudent()
        //{

        //    return $"{Id}-{Student.StudentName}-{Examation.Score}-{Classification}";

        //}
    }
}
