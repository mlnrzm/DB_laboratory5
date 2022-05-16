using System;
using System.ComponentModel;

namespace HardwareStoreContracts.ViewModels
{
    public class CategoryVM
    {
        public int Id { get; set; }
        [DisplayName("Категория")]
        public string CategoryName { get; set; }
    }
}
