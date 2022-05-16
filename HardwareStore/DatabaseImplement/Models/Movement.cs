using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace DatabaseImplement.Models
{
    public class Movement
    {
        public int Id { get; set; }
        public int MovementTypeId { get; set; }
        public int CounterpartyId { get; set; }
        [Required]
        public DateTime Date { get; set; }
        public virtual MovementType MovementType { get; set; }
        public virtual Counterparty Counterparty { get; set; }
        [ForeignKey("MovementId")]
        public virtual List<Content> Contents { get; set; }
    }
}
