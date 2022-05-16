using System.ComponentModel;

namespace HardwareStoreContracts.ViewModels
{
    public class MovementTypeVM
    {
        public int Id { get; set; }
        [DisplayName("Вид движения")]
        public string MovementTypeName { get; set; }
    }
}
