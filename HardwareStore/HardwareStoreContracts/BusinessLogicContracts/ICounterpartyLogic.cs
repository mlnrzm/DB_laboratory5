using System.Collections.Generic;
using HardwareStoreContracts.BindingModels;
using HardwareStoreContracts.ViewModels;

namespace HardwareStoreContracts.BusinessLogicContracts
{
    public interface ICounterpartyLogic
    {
        List<CounterpartyVM> Read(CounterpartyBM model);
        void CreateOrUpdate(CounterpartyBM model);
        void Delete(CounterpartyBM model);
    }
}
