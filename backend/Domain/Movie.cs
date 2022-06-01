using System.Collections.Generic;

namespace backend.Domain
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public double Score { get; set; }
        public int Count { get; set; }
        public string Image { get; set; }
        public ICollection<Score> Scores { get; set; }
    }
}
