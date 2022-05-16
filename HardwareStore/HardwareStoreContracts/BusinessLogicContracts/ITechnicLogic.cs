using System.Collections.Generic;
using HardwareStoreContracts.BindingModels;
using HardwareStoreContracts.ViewModels;

namespace HardwareStoreContracts.BusinessLogicContracts
{
    public interface ITechnicLogic
    {
        List<TechnicVM> Read(TechnicBM model);
        void CreateOrUpdate(TechnicBM model);
        void Delete(TechnicBM model);
    }
}
