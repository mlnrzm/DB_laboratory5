using System.Collections.Generic;
using HardwareStoreContracts.ViewModels;
using HardwareStoreContracts.BindingModels;

namespace HardwareStoreContracts.StorageContracts
{
    public interface ITechnicStorage
    {
        List<TechnicVM> GetFullList();
        List<TechnicVM> GetFilteredList(TechnicBM model);
        TechnicVM GetElement(TechnicBM model);
        void Insert(TechnicBM model);
        void Update(TechnicBM model);
        void Delete(TechnicBM model);
    }
}
