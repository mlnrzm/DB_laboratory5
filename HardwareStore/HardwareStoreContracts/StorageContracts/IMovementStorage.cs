using System.Collections.Generic;
using HardwareStoreContracts.ViewModels;
using HardwareStoreContracts.BindingModels;

namespace HardwareStoreContracts.StorageContracts
{
    public interface IMovementStorage
    {
        List<MovementVM> GetFullList();
        List<MovementVM> GetFilteredList(MovementBM model);
        MovementVM GetElement(MovementBM model);
        void Insert(MovementBM model);
        void Update(MovementBM model);
        void Delete(MovementBM model);
    }
}
