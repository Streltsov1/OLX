﻿using AutoMapper;
using BusinessLogic.DTOs;
using BusinessLogic.Interfaces;
using DataAccess.Data;
using DataAccess.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Services
{
    internal class AnnouncementService : IAnnouncementService
    {
        private readonly IMapper mapper;
        private readonly OLXDbContext context;

        public AnnouncementService(IMapper mapper, OLXDbContext context)
        {
            this.mapper = mapper;
            this.context = context;
        }

        public void Create(CreateAnnouncementModel model)
        {
            // convert model to entity type
            // 1 - manually
            //var entity = new Product()
            //{
            //    Name = model.Name,
            //    Description = model.Description,
            //    CategoryId = model.CategoryId,
            //    Discount = model.Discount,
            //    ImageUrl = model.ImageUrl,
            //    InStock = model.InStock,
            //    Price = model.Price
            //};
            // 2 - using AutoMapper
            var entity = mapper.Map<Announcement>(model);

            // create product in the db
            context.Announcements.Add(entity);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            // delete by id
            var announcement = context.Announcements.Find(id);
            if (announcement == null) return; // TODO: throw exceptions

            context.Announcements.Remove(announcement);
            context.SaveChanges();

        }

        public void Edit(EditAnnouncementModel model)
        {
            var entity = mapper.Map<Announcement>(model);

            // update product in the db
            context.Announcements.Update(entity);
            context.SaveChanges();
        }

        public AnnouncementDto? Get(int id)
        {
            // with JOIN operators
            //var product = context.Products.Include(x => x.Category).FirstOrDefault(i => i.Id == id);
            // without JOIN operators
            var announcement = context.Announcements.Find(id);
            if (announcement == null) return null;

            // load product related entity
            context.Entry(announcement).Reference(x => x.Category).Load();

            return mapper.Map<AnnouncementDto>(announcement);
        }

        public IEnumerable<AnnouncementDto> Get(IEnumerable<int> ids)
        {
            return mapper.Map<List<AnnouncementDto>>(context.Announcements
                .Include(x => x.Category)
                .Where(x => ids.Contains(x.Id))
                .ToList());
        }

        public IEnumerable<AnnouncementDto> GetAll()
        {
            return mapper.Map<List<AnnouncementDto>>(context.Announcements.Include(x => x.Category).Include(y => y.City).ToList());
        }

        public IEnumerable<CategoryDto> GetAllCategories()
        {
            return mapper.Map<List<CategoryDto>>(context.Categories.ToList());
        }
        public IEnumerable<CityDto> GetAllCities()
        {
            return mapper.Map<List<CityDto>>(context.Cities.ToList());
        }

        public int GetCount()
        {
            return context.Announcements.Count();
        }
    }
}
