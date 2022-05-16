using System;
using System.Collections.Generic;
using HardwareStoreContracts.StorageContracts;
using HardwareStoreContracts.BindingModels;
using HardwareStoreContracts.ViewModels;
using HardwareStoreContracts.BusinessLogicContracts;

namespace BusinessLogicsHardwareStore.BusinessLogic
{
    public class CategoryLogic : ICategoryLogic
    {
        private readonly ICategoryStorage _categoryStorage;

        public CategoryLogic(ICategoryStorage categoryStorage)
        {
            _categoryStorage = categoryStorage;
        }

        public List<CategoryVM> Read(CategoryBM model)
        {
            if (model == null) return _categoryStorage.GetFullList();
            if (model.Id.HasValue) return new List<CategoryVM> { _categoryStorage.GetElement(model) };
            return _categoryStorage.GetFilteredList(model);
        }

        public void CreateOrUpdate(CategoryBM model)
        {
            if (model.Id.HasValue) _categoryStorage.Update(model);
            else _categoryStorage.Insert(model);
        }

        public void Delete(CategoryBM model)
        {
            var assign = _categoryStorage.GetElement(new CategoryBM { Id = model.Id });
            if (assign == null) throw new Exception("Категория не найдено");

            _categoryStorage.Delete(model);
        }
    }
}
