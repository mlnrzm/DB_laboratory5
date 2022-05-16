using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseImplement.Models
{
    public class Technic
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        [Required]
        public string TechnicName { get; set; }
        [Required]
        public string Production { get; set; }
        [Required]
        public string Warranty { get; set; }
        [ForeignKey("TechnicId")]
        public virtual List<Content> Contents { get; set; }
        public virtual Category Category { get; set; }
    }
}
