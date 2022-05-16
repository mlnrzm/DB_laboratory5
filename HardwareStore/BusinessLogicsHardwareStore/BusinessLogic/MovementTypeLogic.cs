using System;
using System.Collections.Generic;
using HardwareStoreContracts.StorageContracts;
using HardwareStoreContracts.BindingModels;
using HardwareStoreContracts.ViewModels;
using HardwareStoreContracts.BusinessLogicContracts;

namespace BusinessLogicsHardwareStore.BusinessLogic
{
    public class MovementTypeLogic : IMovementTypeLogic
    {
        private readonly IMovementTypeStorage _movementTypeStorage;

        public MovementTypeLogic(IMovementTypeStorage movementTypeStorage)
        {
            _movementTypeStorage = movementTypeStorage;
        }

        public List<MovementTypeVM> Read(MovementTypeBM model)
        {
            if (model == null) return _movementTypeStorage.GetFullList();
            if (model.Id.HasValue) return new List<MovementTypeVM> { _movementTypeStorage.GetElement(model) };
            return _movementTypeStorage.GetFilteredList(model);
        }

        public void CreateOrUpdate(MovementTypeBM model)
        {
            if (model.Id.HasValue) _movementTypeStorage.Update(model);
            else _movementTypeStorage.Insert(model);
        }

        public void Delete(MovementTypeBM model)
        {
            var assign = _movementTypeStorage.GetElement(new MovementTypeBM { Id = model.Id });
            if (assign == null) throw new Exception("Вид движения не найден");

            _movementTypeStorage.Delete(model);
        }

    }
}
