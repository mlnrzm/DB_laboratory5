using System.Collections.Generic;
using HardwareStoreContracts.BindingModels;
using HardwareStoreContracts.ViewModels;

namespace HardwareStoreContracts.BusinessLogicContracts
{
    public interface IContentLogic
    {
        List<ContentVM> Read(ContentBM model);
        void CreateOrUpdate(ContentBM model);
        void Delete(ContentBM model);
    }
}
