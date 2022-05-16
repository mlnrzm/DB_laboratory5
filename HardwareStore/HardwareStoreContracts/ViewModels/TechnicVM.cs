using System.ComponentModel;
using System;

namespace HardwareStoreContracts.ViewModels
{
    public class TechnicVM
    {
        public int Id { get; set; }
        public int CategoryTd { get; set; }
        [DisplayName("Наименование категории")]
        public string CategoryName { get; set; }
        [DisplayName("Наименование техники")]
        public string TechnicName { get; set; }
        [DisplayName("Производство")]
        public string Production { get; set; }
        [DisplayName("Гарантия")]
        public string Warranty { get; set; }
    }
}
