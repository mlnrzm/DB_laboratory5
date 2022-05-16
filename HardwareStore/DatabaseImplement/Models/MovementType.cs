using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseImplement.Models
{
    public class MovementType
    {
        public int Id { get; set; }
        [Required]
        public string MovementTypeName { get; set; }
        [ForeignKey("MovementTypeId")]
        public virtual List<Movement> Movements { get; set; }
    }
}
