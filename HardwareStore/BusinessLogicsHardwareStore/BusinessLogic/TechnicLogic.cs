using System;
using System.Collections.Generic;
using HardwareStoreContracts.StorageContracts;
using HardwareStoreContracts.BindingModels;
using HardwareStoreContracts.ViewModels;
using HardwareStoreContracts.BusinessLogicContracts;

namespace BusinessLogicsHardwareStore.BusinessLogic
{
    public class TechnicLogic : ITechnicLogic
    {
        private readonly ITechnicStorage _technicStorage;

        public TechnicLogic(ITechnicStorage technicStorage)
        {
            _technicStorage = technicStorage;
        }

        public List<TechnicVM> Read(TechnicBM model)
        {
            if (model == null) return _technicStorage.GetFullList();
            if (model.Id.HasValue) return new List<TechnicVM> { _technicStorage.GetElement(model) };
            return _technicStorage.GetFilteredList(model);
        }

        public void CreateOrUpdate(TechnicBM model)
        {
            if (model.Id.HasValue) _technicStorage.Update(model);
            else _technicStorage.Insert(model);
        }

        public void Delete(TechnicBM model)
        {
            var assign = _technicStorage.GetElement(new TechnicBM { Id = model.Id });
            if (assign == null) throw new Exception("Техника не найдена");

            _technicStorage.Delete(model);
        }

    }
}
