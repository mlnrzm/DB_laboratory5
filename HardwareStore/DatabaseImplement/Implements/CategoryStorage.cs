using System;
using System.Collections.Generic;
using System.Linq;
using HardwareStoreContracts.ViewModels;
using HardwareStoreContracts.BindingModels;
using HardwareStoreContracts.StorageContracts;
using DatabaseImplement.Models;

namespace DatabaseImplement.Implements
{
    public class CategoryStorage : ICategoryStorage
    {
        public List<CategoryVM> GetFullList()
        {
            using var context = new HardwareStorageDatabase();
            return context.Categorys
                .Select(CreateModel)
                .ToList();
        }

        public List<CategoryVM> GetFilteredList(CategoryBM model)
        {
            if (model == null)
            {
                return null;
            }

            using var context = new HardwareStorageDatabase();
            return context.Categorys
                .Where(rec => rec.CategoryName.Contains(model.CategoryName))
                .Select(CreateModel)
                .ToList();
        }

        public CategoryVM GetElement(CategoryBM model)
        {
            if (model == null)
            {
                return null;
            }

            using var context = new HardwareStorageDatabase();
            var category = context.Categorys
                .FirstOrDefault(rec => rec.Id == model.Id);

            return category != null ? CreateModel(category) : null;
        }

        public void Insert(CategoryBM model)
        {
            using var context = new HardwareStorageDatabase();

            Category categoryToAdd = new Category
            {
                CategoryName = model.CategoryName

            };
            context.Categorys.Add(categoryToAdd);
            context.SaveChanges();
            CreateModel(model, categoryToAdd);
            context.SaveChanges();
        }

        public void Update(CategoryBM model)
        {
            using var context = new HardwareStorageDatabase();
            var category = context.Categorys
                .FirstOrDefault(rec => rec.Id == model.Id);

            if (category == null)
            {
                throw new Exception("Категория не найдена");
            }

            CreateModel(model, category);
            context.SaveChanges();
        }

        public void Delete(CategoryBM model)
        {
            using var context = new HardwareStorageDatabase();
            var category = context.Categorys.FirstOrDefault(rec => rec.Id == model.Id);

            if (category == null)
            {
                throw new Exception("Категория не найдена");
            }

            context.Categorys.Remove(category);
            context.SaveChanges();
        }

        private Category CreateModel(CategoryBM model, Category category)
        {
            category.CategoryName = model.CategoryName;

            return category;
        }
        private static CategoryVM CreateModel(Category category)
        {
            return new CategoryVM
            {
                Id = category.Id,
                CategoryName = category.CategoryName
            };
        }
    }
}
