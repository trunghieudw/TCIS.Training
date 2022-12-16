namespace TCIS.Training.ClassExample
{
    public class Class
    {
        public int Id { get; set; }     
        public string Name { get; set; }
        public Teacher Teacher { get; set; }

        public Class(int id, string name, Teacher teacher)
        {
            Id = id;
            Name = name;
            Teacher = teacher;
        }


        public override string ToString()
        {
            return $"{Id}-{Name}-Teacher: {Teacher.TeachId} - {Teacher.TeachName}";
        }
    }
}
