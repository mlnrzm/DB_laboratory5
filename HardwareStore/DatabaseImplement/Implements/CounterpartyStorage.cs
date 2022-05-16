using System;
using System.Collections.Generic;
using System.Linq;
using HardwareStoreContracts.ViewModels;
using HardwareStoreContracts.BindingModels;
using HardwareStoreContracts.StorageContracts;
using DatabaseImplement.Models;

namespace DatabaseImplement.Implements
{
    public class CounterpartyStorage : ICounterpartyStorage
    {
        public List<CounterpartyVM> GetFullList()
        {
            using var context = new HardwareStorageDatabase();
            return context.Counterpartys
                .Select(CreateModel)
                .ToList();
        }

        public List<CounterpartyVM> GetFilteredList(CounterpartyBM model)
        {
            if (model == null)
            {
                return null;
            }

            using var context = new HardwareStorageDatabase();
            return context.Counterpartys
                .Where(rec => rec.Name.Contains(model.Name))
                .Select(CreateModel)
                .ToList();
        }

        public CounterpartyVM GetElement(CounterpartyBM model)
        {
            if (model == null)
            {
                return null;
            }

            using var context = new HardwareStorageDatabase();
            var counterparty = context.Counterpartys
                .FirstOrDefault(rec => rec.Id == model.Id);

            return counterparty != null ? CreateModel(counterparty) : null;
        }

        public void Insert(CounterpartyBM model)
        {
            using var context = new HardwareStorageDatabase();

            Counterparty counterpartyToAdd = new Counterparty
            {
                Name = model.Name,
                Phone = model.Phone,
                Address = model.Address
            };
            context.Counterpartys.Add(counterpartyToAdd);
            context.SaveChanges();
            CreateModel(model, counterpartyToAdd);
            context.SaveChanges();
        }

        public void Update(CounterpartyBM model)
        {
            using var context = new HardwareStorageDatabase();
            var counterparty = context.Counterpartys
                .FirstOrDefault(rec => rec.Id == model.Id);

            if (counterparty == null)
            {
                throw new Exception("Контрагент не найден");
            }

            CreateModel(model, counterparty);
            context.SaveChanges();
        }

        public void Delete(CounterpartyBM model)
        {
            using var context = new HardwareStorageDatabase();
            var counterparty = context.Counterpartys.FirstOrDefault(rec => rec.Id == model.Id);

            if (counterparty == null)
            {
                throw new Exception("Контрагент не найден");
            }

            context.Counterpartys.Remove(counterparty);
            context.SaveChanges();
        }

        private Counterparty CreateModel(CounterpartyBM model, Counterparty counterparty)
        {
            counterparty.Name = model.Name;
            counterparty.Address = model.Address;
            counterparty.Phone = model.Phone;

            return counterparty;
        }
        private static CounterpartyVM CreateModel(Counterparty counterparty)
        {
            return new CounterpartyVM
            {
                Id = counterparty.Id,
                Name = counterparty.Name,
                Address = counterparty.Address,
                Phone = counterparty.Phone
            };
        }
    }
}
