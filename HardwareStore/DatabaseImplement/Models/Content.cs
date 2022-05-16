using System.ComponentModel.DataAnnotations;

namespace DatabaseImplement.Models
{
    public class Content
    {
        public int Id { get; set; }
        public int MovementId { get; set; }
        public int TechnicId { get; set; }
        [Required]
        public int Count { get; set; }
        [Required]
        public int Cost { get; set; }
        public virtual Technic Technic { get; set; }
        public virtual Movement Movement { get; set; }
    }
}
