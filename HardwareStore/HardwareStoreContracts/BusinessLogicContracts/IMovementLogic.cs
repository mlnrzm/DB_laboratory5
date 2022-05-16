using System.Collections.Generic;
using HardwareStoreContracts.BindingModels;
using HardwareStoreContracts.ViewModels;

namespace HardwareStoreContracts.BusinessLogicContracts
{
    public interface IMovementLogic
    {
        List<MovementVM> Read(MovementBM model);
        void CreateOrUpdate(MovementBM model);
        void Delete(MovementBM model);
    }
}
