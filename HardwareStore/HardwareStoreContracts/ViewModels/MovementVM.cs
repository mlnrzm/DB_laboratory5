using System.ComponentModel;
using System;

namespace HardwareStoreContracts.ViewModels
{
    public class MovementVM
    {
        public int Id { get; set; }
        public int MovementTypeId { get; set; }
        public int CounterpartyId { get; set; }
        [DisplayName("Вид движения")]
        public string MovementType { get; set; }
        [DisplayName("Контрагент")]
        public string CounterpartyName { get; set; }
        [DisplayName("Дата движения")]
        public DateTime Date { get; set; }
    }
}
