using System.ComponentModel;

namespace HardwareStoreContracts.ViewModels
{
    public class CounterpartyVM
    {
        public int Id { get; set; }
        [DisplayName("Название")]
        public string Name { get; set; }
        [DisplayName("Телефон")]
        public string Phone { get; set; }
        [DisplayName("Адрес")]
        public string Address { get; set; }
    }
}
