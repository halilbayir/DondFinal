namespace Dond.Models
{
    public class HighScore:BaseEntity
    {
        public int UserId { get; set; }
        public float Score { get; set; } 
    }
}
