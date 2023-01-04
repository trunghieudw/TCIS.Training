namespace CalculateTheScoresOfTheClasses.Entities
{
    public class Class
    {
        public int Id { get; set; }
        public string Name { get; set; }        
        public override string ToString()
        {
            return $"{Id}-{Name}";

        }
    }
}
