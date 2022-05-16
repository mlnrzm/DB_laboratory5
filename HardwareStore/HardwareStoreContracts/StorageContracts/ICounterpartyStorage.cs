using System.Collections.Generic;
using HardwareStoreContracts.ViewModels;
using HardwareStoreContracts.BindingModels;

namespace HardwareStoreContracts.StorageContracts
{
    public interface ICounterpartyStorage
    {
        List<CounterpartyVM> GetFullList();
        List<CounterpartyVM> GetFilteredList(CounterpartyBM model);
        CounterpartyVM GetElement(CounterpartyBM model);
        void Insert(CounterpartyBM model);
        void Update(CounterpartyBM model);
        void Delete(CounterpartyBM model);
    }
}
