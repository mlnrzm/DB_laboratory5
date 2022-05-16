using System.Collections.Generic;
using HardwareStoreContracts.ViewModels;
using HardwareStoreContracts.BindingModels;

namespace HardwareStoreContracts.StorageContracts
{
    public interface IMovementTypeStorage
    {
        List<MovementTypeVM> GetFullList();
        List<MovementTypeVM> GetFilteredList(MovementTypeBM model);
        MovementTypeVM GetElement(MovementTypeBM model);
        void Insert(MovementTypeBM model);
        void Update(MovementTypeBM model);
        void Delete(MovementTypeBM model);
    }
}
