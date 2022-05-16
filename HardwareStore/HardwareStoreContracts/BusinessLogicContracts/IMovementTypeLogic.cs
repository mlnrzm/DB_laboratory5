using System.Collections.Generic;
using HardwareStoreContracts.BindingModels;
using HardwareStoreContracts.ViewModels;

namespace HardwareStoreContracts.BusinessLogicContracts
{
    public interface IMovementTypeLogic
    {
        List<MovementTypeVM> Read(MovementTypeBM model);
        void CreateOrUpdate(MovementTypeBM model);
        void Delete(MovementTypeBM model);
    }
}
