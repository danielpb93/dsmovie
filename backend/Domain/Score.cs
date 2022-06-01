namespace backend.Domain
{
    public class Score
    {
        public int MovieId { get; set; }
        public Movie Movie { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public double Value { get; set; }
    }
}
