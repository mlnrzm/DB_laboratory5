using System;
using System.Collections.Generic;
using HardwareStoreContracts.StorageContracts;
using HardwareStoreContracts.BindingModels;
using HardwareStoreContracts.ViewModels;
using HardwareStoreContracts.BusinessLogicContracts;

namespace BusinessLogicsHardwareStore.BusinessLogic
{
    public class ContentLogic : IContentLogic
    {
        private readonly IContentStorage _contentStorage;

        public ContentLogic(IContentStorage contentStorage)
        {
            _contentStorage = contentStorage;
        }

        public List<ContentVM> Read(ContentBM model)
        {
            if (model == null) return _contentStorage.GetFullList();
            if (model.Id.HasValue) return new List<ContentVM> { _contentStorage.GetElement(model) };
            return _contentStorage.GetFilteredList(model);
        }

        public void CreateOrUpdate(ContentBM model)
        {
            if (model.Id.HasValue) _contentStorage.Update(model);
            else _contentStorage.Insert(model);
        }

        public void Delete(ContentBM model)
        {
            var assign = _contentStorage.GetElement(new ContentBM { Id = model.Id });
            if (assign == null) throw new Exception("Состав покупки/продажи не найден");

            _contentStorage.Delete(model);
        }
    }
}
