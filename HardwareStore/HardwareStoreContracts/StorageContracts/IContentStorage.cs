using System.Collections.Generic;
using HardwareStoreContracts.ViewModels;
using HardwareStoreContracts.BindingModels;

namespace HardwareStoreContracts.StorageContracts
{
    public interface IContentStorage
    {
        List<ContentVM> GetFullList();
        List<ContentVM> GetFilteredList(ContentBM model);
        ContentVM GetElement(ContentBM model);
        void Insert(ContentBM model);
        void Update(ContentBM model);
        void Delete(ContentBM model);
    }
}
