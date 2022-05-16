using System;
using System.Collections.Generic;
using HardwareStoreContracts.StorageContracts;
using HardwareStoreContracts.BindingModels;
using HardwareStoreContracts.ViewModels;
using HardwareStoreContracts.BusinessLogicContracts;

namespace BusinessLogicsHardwareStore.BusinessLogic
{
    public class MovementLogic : IMovementLogic
    {
        private readonly IMovementStorage _movementStorage;

        public MovementLogic(IMovementStorage movementStorage)
        {
            _movementStorage = movementStorage;
        }

        public List<MovementVM> Read(MovementBM model)
        {
            if (model == null) return _movementStorage.GetFullList();
            if (model.Id.HasValue) return new List<MovementVM> { _movementStorage.GetElement(model) };
            return _movementStorage.GetFilteredList(model);
        }

        public void CreateOrUpdate(MovementBM model)
        {
            if (model.Id.HasValue) _movementStorage.Update(model);
            else _movementStorage.Insert(model);
        }

        public void Delete(MovementBM model)
        {
            var assign = _movementStorage.GetElement(new MovementBM { Id = model.Id });
            if (assign == null) throw new Exception("Движение не найдено");

            _movementStorage.Delete(model);
        }
    }
}
