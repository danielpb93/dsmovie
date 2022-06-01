using System.Collections.Generic;

namespace backend.Domain
{
    public class User
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public ICollection<Score> Scores { get; set; }
    }
}
