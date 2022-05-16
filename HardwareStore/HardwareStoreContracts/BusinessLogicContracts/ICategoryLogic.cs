using System.Collections.Generic;
using HardwareStoreContracts.BindingModels;
using HardwareStoreContracts.ViewModels;

namespace HardwareStoreContracts.BusinessLogicContracts
{
    public interface ICategoryLogic
    {
        List<CategoryVM> Read(CategoryBM model);
        void CreateOrUpdate(CategoryBM model);
        void Delete(CategoryBM model);
    }
}
