namespace Dond.Models
{
    public class UserProgress:BaseEntity
    {
        public int UserId { get; set; }
        public int PuzzleId { get; set; }
        public int Minute { get; set; }
        public int Session { get; set; }

    }
}
