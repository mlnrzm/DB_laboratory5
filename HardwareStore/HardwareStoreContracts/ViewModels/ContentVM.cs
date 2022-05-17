using System;
using System.ComponentModel;

namespace HardwareStoreContracts.ViewModels
{
    public class ContentVM
    {
        public int Id { get; set; }
        public int MovementId { get; set; }
        public int TechnicId { get; set; }
        [DisplayName("Вид движения")]
        public string MovementType { get; set; }
        [DisplayName("Дата движения")]
        public DateTime  MovementDate { get; set; }
        [DisplayName("Наименование техники")]
        public string TechnicName { get; set; }
        [DisplayName("Количество")]
        public int Count { get; set; }
        [DisplayName("Стоимость единицы")]
        public int Cost { get; set; }
    }
}
