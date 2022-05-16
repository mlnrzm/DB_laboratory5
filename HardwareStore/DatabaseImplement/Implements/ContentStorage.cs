using System;
using System.Collections.Generic;
using System.Linq;
using HardwareStoreContracts.ViewModels;
using HardwareStoreContracts.BindingModels;
using HardwareStoreContracts.StorageContracts;
using DatabaseImplement.Models;

namespace DatabaseImplement.Implements
{
    public class ContentStorage : IContentStorage
    {
        public List<ContentVM> GetFullList()
        {
            using var context = new HardwareStorageDatabase();
            return context.Contents
                .Select(CreateModel).ToList();
        }

        public List<ContentVM> GetFilteredList(ContentBM model)
        {
            if (model == null)
            {
                return null;
            }

            using var context = new HardwareStorageDatabase();
            return context.Contents
                .Where(rec => rec.MovementId == model.MovementId || rec.TechnicId == model.TechnicId)
                .Select(CreateModel)
                .ToList();
        }

        public ContentVM GetElement(ContentBM model)
        {
            if (model == null)
            {
                return null;
            }

            using var context = new HardwareStorageDatabase();
            var content = context.Contents.FirstOrDefault(rec => rec.Id == model.Id);

            return content != null ? CreateModel(content) : null;
        }

        public void Insert(ContentBM model)
        {
            using var context = new HardwareStorageDatabase();

            Content contentToAdd = new Content
            {
                MovementId = model.MovementId,
                TechnicId = model.TechnicId,
                Count = model.Count,
                Cost = model.Cost
            };
            context.Contents.Add(contentToAdd);
            context.SaveChanges();
            CreateModel(model, contentToAdd, context);
            context.SaveChanges();
        }

        public void Update(ContentBM model)
        {
            using var context = new HardwareStorageDatabase();
            var content = context.Contents
                .FirstOrDefault(rec => rec.Id == model.Id);

            if (content == null)
            {
                throw new Exception("Состав не найден");
            }

            CreateModel(model, content, context);
            context.SaveChanges();
        }

        public void Delete(ContentBM model)
        {
            using var context = new HardwareStorageDatabase();
            var content = context.Contents
                .FirstOrDefault(rec => rec.Id == model.Id);

            if (content == null)
            {
                throw new Exception("Состав не найден");
            }

            context.Contents.Remove(content);
            context.SaveChanges();
        }

        private Content CreateModel(ContentBM model, Content content, HardwareStorageDatabase context)
        {
            content.Count = model.Count;
            content.Cost = model.Cost;

            Technic technic = context.Technics.FirstOrDefault(rec => rec.Id == model.TechnicId);
            if (technic != null)
            {
                content.TechnicId = model.TechnicId;
                if (technic.Contents == null)
                {
                    technic.Contents = new List<Content>();
                }
                technic.Contents.Add(content);
                context.Technics.Update(technic);
                context.SaveChanges();
            }
            else
            {
                throw new Exception("Техника не найдена");
            }

            Movement movement = context.Movements.FirstOrDefault(rec => rec.Id == model.MovementId);
            if (movement != null)
            {
                content.TechnicId = model.TechnicId;
                if (movement.Contents == null)
                {
                    movement.Contents = new List<Content>();
                }
                movement.Contents.Add(content);
                context.Movements.Update(movement);
                context.SaveChanges();
            }
            else
            {
                throw new Exception("Движение не найдено");
            }

            return content;
        }
        private ContentVM CreateModel(Content content)
        {
            return new ContentVM
            {
                Id = content.Id,
                TechnicId = content.TechnicId,
                MovementId = content.MovementId,
                Count = content.Count,
                Cost = content.Cost
            };
        }
    }
}
