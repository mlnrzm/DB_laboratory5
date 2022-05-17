using System;
using System.Collections.Generic;
using System.Linq;
using HardwareStoreContracts.ViewModels;
using HardwareStoreContracts.BindingModels;
using HardwareStoreContracts.StorageContracts;
using DatabaseImplement.Models;

namespace DatabaseImplement.Implements
{
    public class TechnicStorage : ITechnicStorage
    {
        public List<TechnicVM> GetFullList()
        {
            using var context = new HardwareStorageDatabase();
            return context.Technics
                .Select(CreateModel).ToList();
        }

        public List<TechnicVM> GetFilteredList(TechnicBM model)
        {
            if (model == null)
            {
                return null;
            }

            using var context = new HardwareStorageDatabase();
            return context.Technics
                .Where(rec => rec.CategoryId == model.CategoryId || rec.Production == model.Production || rec.Warranty == model.Warranty)
                .Select(CreateModel)
                .ToList();
        }

        public TechnicVM GetElement(TechnicBM model)
        {
            if (model == null)
            {
                return null;
            }

            using var context = new HardwareStorageDatabase();
            var content = context.Technics.FirstOrDefault(rec => rec.Id == model.Id);

            return content != null ? CreateModel(content) : null;
        }

        public void Insert(TechnicBM model)
        {
            using var context = new HardwareStorageDatabase();

            Technic technicToAdd = new Technic
            {
                CategoryId = model.CategoryId,
                TechnicName = model.TechnicName,
                Production = model.Production,
                Warranty = model.Warranty
            };
            context.Technics.Add(technicToAdd);
            context.SaveChanges();
            CreateModel(model, technicToAdd, context);
            context.SaveChanges();
        }

        public void Update(TechnicBM model)
        {
            using var context = new HardwareStorageDatabase();
            var technic = context.Technics
                .FirstOrDefault(rec => rec.Id == model.Id);

            if (technic == null)
            {
                throw new Exception("Техника не найдена");
            }

            CreateModel(model, technic, context);
            context.SaveChanges();
        }

        public void Delete(TechnicBM model)
        {
            using var context = new HardwareStorageDatabase();
            var technic = context.Technics
                .FirstOrDefault(rec => rec.Id == model.Id);

            if (technic == null)
            {
                throw new Exception("Техника не найдена");
            }

            context.Technics.Remove(technic);
            context.SaveChanges();
        }

        private Technic CreateModel(TechnicBM model, Technic technic, HardwareStorageDatabase context)
        {
            technic.TechnicName = model.TechnicName;
            technic.Production = model.Production;
            technic.Warranty = model.Warranty;

            Category category = context.Categorys.FirstOrDefault(rec => rec.Id == model.CategoryId);
            if (category != null)
            {
                technic.CategoryId = model.CategoryId;
                if (category.Technics == null)
                {
                    category.Technics = new List<Technic>();
                }
                category.Technics.Add(technic);
                context.Categorys.Update(category);
                context.SaveChanges();
            }
            else
            {
                throw new Exception("Категория не найдена");
            }

            return technic;
        }
        private TechnicVM CreateModel(Technic technic)
        {
            using (var context = new HardwareStorageDatabase())
            {
                string categoryName = context.Categorys.FirstOrDefault(rec => rec.Id == technic.CategoryId).CategoryName;

                return new TechnicVM
                {
                    Id = technic.Id,
                    CategoryId = technic.CategoryId,
                    CategoryName = categoryName,
                    TechnicName = technic.TechnicName,
                    Production = technic.Production,
                    Warranty = technic.Warranty
                };
            }
        }

    }
}
