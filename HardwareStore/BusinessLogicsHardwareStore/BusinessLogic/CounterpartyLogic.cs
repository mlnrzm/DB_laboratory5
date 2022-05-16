using System;
using System.Collections.Generic;
using HardwareStoreContracts.StorageContracts;
using HardwareStoreContracts.BindingModels;
using HardwareStoreContracts.ViewModels;
using HardwareStoreContracts.BusinessLogicContracts;

namespace BusinessLogicsHardwareStore.BusinessLogic
{
    public class CounterpartyLogic : ICounterpartyLogic
    {
        private readonly ICounterpartyStorage _counterpartyStorage;

        public CounterpartyLogic(ICounterpartyStorage counterpartyStorage)
        {
            _counterpartyStorage = counterpartyStorage;
        }

        public List<CounterpartyVM> Read(CounterpartyBM model)
        {
            if (model == null) return _counterpartyStorage.GetFullList();
            if (model.Id.HasValue) return new List<CounterpartyVM> { _counterpartyStorage.GetElement(model) };
            return _counterpartyStorage.GetFilteredList(model);
        }

        public void CreateOrUpdate(CounterpartyBM model)
        {
            if (model.Id.HasValue) _counterpartyStorage.Update(model);
            else _counterpartyStorage.Insert(model);
        }

        public void Delete(CounterpartyBM model)
        {
            var assign = _counterpartyStorage.GetElement(new CounterpartyBM { Id = model.Id });
            if (assign == null) throw new Exception("Контрагент не найден");

            _counterpartyStorage.Delete(model);
        }
    }
}
