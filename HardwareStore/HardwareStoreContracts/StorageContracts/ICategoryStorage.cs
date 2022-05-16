using System.Collections.Generic;
using HardwareStoreContracts.ViewModels;
using HardwareStoreContracts.BindingModels;

namespace HardwareStoreContracts.StorageContracts
{
    public interface ICategoryStorage
    {
        List<CategoryVM> GetFullList();
        List<CategoryVM> GetFilteredList(CategoryBM model);
        CategoryVM GetElement(CategoryBM model);
        void Insert(CategoryBM model);
        void Update(CategoryBM model);
        void Delete(CategoryBM model);
    }
}
