using System;
using System.Collections.Generic;
using System.Linq;
using HardwareStoreContracts.ViewModels;
using HardwareStoreContracts.BindingModels;
using HardwareStoreContracts.StorageContracts;
using DatabaseImplement.Models;

namespace DatabaseImplement.Implements
{
    public class MovementStorage : IMovementStorage
    {
        public List<MovementVM> GetFullList()
        {
            using var context = new HardwareStorageDatabase();
            return context.Movements
                .Select(CreateModel).ToList();
        }

        public List<MovementVM> GetFilteredList(MovementBM model)
        {
            if (model == null)
            {
                return null;
            }

            using var context = new HardwareStorageDatabase();
            return context.Movements
                .Where(rec => rec.CounterpartyId == model.CounterpartyId || rec.MovementTypeId == model.MovementTypeId)
                .Select(CreateModel)
                .ToList();
        }

        public MovementVM GetElement(MovementBM model)
        {
            if (model == null)
            {
                return null;
            }

            using var context = new HardwareStorageDatabase();
            var movement = context.Movements.FirstOrDefault(rec => rec.Id == model.Id);

            return movement != null ? CreateModel(movement) : null;
        }

        public void Insert(MovementBM model)
        {
            using var context = new HardwareStorageDatabase();

            Movement movementToAdd = new Movement
            {
                MovementTypeId = model.MovementTypeId,
                CounterpartyId = model.CounterpartyId,
                Date = model.Date
            };
            context.Movements.Add(movementToAdd);
            context.SaveChanges();
            CreateModel(model, movementToAdd, context);
            context.SaveChanges();
        }

        public void Update(MovementBM model)
        {
            using var context = new HardwareStorageDatabase();
            var movement = context.Movements
                .FirstOrDefault(rec => rec.Id == model.Id);

            if (movement == null)
            {
                throw new Exception("Движение не найдено");
            }

            CreateModel(model, movement, context);
            context.SaveChanges();
        }

        public void Delete(MovementBM model)
        {
            using var context = new HardwareStorageDatabase();
            var movement = context.Movements
                .FirstOrDefault(rec => rec.Id == model.Id);

            if (movement == null)
            {
                throw new Exception("Движение не найдено");
            }

            context.Movements.Remove(movement);
            context.SaveChanges();
        }

        private Movement CreateModel(MovementBM model, Movement movement, HardwareStorageDatabase context)
        {
            movement.Date = model.Date;

            Counterparty counterparty = context.Counterpartys.FirstOrDefault(rec => rec.Id == model.CounterpartyId);
            if (counterparty != null)
            {
                movement.CounterpartyId = model.CounterpartyId;
                if (counterparty.Movements == null)
                {
                    counterparty.Movements = new List<Movement>();
                }
                counterparty.Movements.Add(movement);
                context.Counterpartys.Update(counterparty);
                context.SaveChanges();
            }
            else
            {
                throw new Exception("Контрагент не найден");
            }

            MovementType movement_type = context.MovementTypes.FirstOrDefault(rec => rec.Id == model.MovementTypeId);
            if (movement_type != null)
            {
                movement.MovementTypeId = model.MovementTypeId;
                if (movement_type.Movements == null)
                {
                    movement_type.Movements = new List<Movement>();
                }
                movement_type.Movements.Add(movement);
                context.MovementTypes.Update(movement_type);
                context.SaveChanges();
            }
            else
            {
                throw new Exception("Вид движения не найден");
            }

            return movement;
        }
        private MovementVM CreateModel(Movement movement)
        {
            return new MovementVM
            {
                Id = movement.Id,
                MovementTypeId = movement.MovementTypeId,
                CounterpartyId = movement.CounterpartyId,
                CounterpartyName = movement.Counterparty.Name,
                MovementTypeName = movement.MovementType.MovementTypeName,
                Date = movement.Date
            };
        }
    }
}
