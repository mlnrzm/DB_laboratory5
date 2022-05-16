using System;

namespace HardwareStoreContracts.BindingModels
{
    public class MovementBM
    {
        public int? Id { get; set; }
        public int MovementTypeId { get; set; }
        public int CounterpartyId { get; set; }
        public DateTime Date { get; set; }
    }
}
