using System;
using System.Collections.Generic;
using System.Linq;
using HardwareStoreContracts.ViewModels;
using HardwareStoreContracts.BindingModels;
using HardwareStoreContracts.StorageContracts;
using DatabaseImplement.Models;

namespace DatabaseImplement.Implements
{
    public class MovementTypeStorage : IMovementTypeStorage
    {
        public List<MovementTypeVM> GetFullList()
        {
            using var context = new HardwareStorageDatabase();
            return context.MovementTypes
                .Select(CreateModel)
                .ToList();
        }

        public List<MovementTypeVM> GetFilteredList(MovementTypeBM model)
        {
            if (model == null)
            {
                return null;
            }

            using var context = new HardwareStorageDatabase();
            return context.MovementTypes
                .Where(rec => rec.MovementTypeName.Contains(model.MovementTypeName))
                .Select(CreateModel)
                .ToList();
        }

        public MovementTypeVM GetElement(MovementTypeBM model)
        {
            if (model == null)
            {
                return null;
            }

            using var context = new HardwareStorageDatabase();
            var type = context.MovementTypes
                .FirstOrDefault(rec => rec.Id == model.Id);

            return type != null ? CreateModel(type) : null;
        }

        public void Insert(MovementTypeBM model)
        {
            using var context = new HardwareStorageDatabase();

            MovementType typeToAdd = new MovementType
            {
                MovementTypeName = model.MovementTypeName

            };
            context.MovementTypes.Add(typeToAdd);
            context.SaveChanges();
            CreateModel(model, typeToAdd);
            context.SaveChanges();
        }

        public void Update(MovementTypeBM model)
        {
            using var context = new HardwareStorageDatabase();
            var type = context.MovementTypes
                .FirstOrDefault(rec => rec.Id == model.Id);

            if (type == null)
            {
                throw new Exception("Вид движения не найден");
            }

            CreateModel(model, type);
            context.SaveChanges();
        }

        public void Delete(MovementTypeBM model)
        {
            using var context = new HardwareStorageDatabase();
            var type = context.MovementTypes.FirstOrDefault(rec => rec.Id == model.Id);

            if (type == null)
            {
                throw new Exception("Вид движения не найден");
            }

            context.MovementTypes.Remove(type);
            context.SaveChanges();
        }

        private MovementType CreateModel(MovementTypeBM model, MovementType type)
        {
            type.MovementTypeName = model.MovementTypeName;

            return type;
        }
        private static MovementTypeVM CreateModel(MovementType type)
        {
            return new MovementTypeVM
            {
                Id = type.Id,
                MovementTypeName = type.MovementTypeName
            };
        }

    }
}
