﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TARpe22ShopRohusaar.Core.Domain;
using TARpe22ShopRohusaar.Core.Dto;
using TARpe22ShopRohusaar.Core.ServiceInterface;
using TARpe22ShopRohusaar.Data;

namespace TARpe22ShopRohusaar.ApplicationServices.Services
{
    public class CarsServices : ICarsServices
    {
        private readonly TARpe22ShopRohusaarContext _context;
        private readonly IFilesServices _filesServices;
        public CarsServices
            (
            TARpe22ShopRohusaarContext context,
            IFilesServices filesServices
            )
        {
            _context = context;
            _filesServices = filesServices;
        }
        public async Task<Car> GetAsync(Guid id)
        {
            var result = await _context.Cars
                .FirstOrDefaultAsync(x => x.Id == id);
            return result;
        }
        public async Task<Car> Create(CarDto dto)
        {
            Car car = new();

            //var realEstateProps = typeof(RealEstate).GetProperties();
            //var realEstateDtoProps = typeof(RealEstateDto).GetProperties();
            //for (int i = 0; i < realEstateProps.Length; i++)
            //{
            //    var realEstateProp = realEstateProps[i];
            //    for (int j = 0; j < realEstateDtoProps.Length; j++)
            //    {
            //        var realEstateDtoProp = realEstateDtoProps[j];
            //        if (realEstateProp.Name == realEstateDtoProp.Name)
            //        {
            //            realEstateProp.SetValue(realEstate, realEstateDtoProp.GetValue(dto));
            //        }
            //    }
            //}
            car.Id = Guid.NewGuid();
            car.Type = dto.Type;
            car.Price = dto.Price;
            car.Make = dto.Make;
            car.Model = dto.Model;
            car.Year = dto.Year;
            car.Color = dto.Color;

            car.CreatedAt = DateTime.Now;
            car.ModifiedAt = DateTime.Now;
            _filesServices.FilesToApi(dto, car);

            await _context.Cars.AddAsync(car);
            await _context.SaveChangesAsync();
            return car;

            
        }
        public async Task<Car> Delete(Guid id)
        {
            var carId = await _context.Cars
                .Include(x => x.FilesToApi)
                .FirstOrDefaultAsync(x => x.Id == id);
            var images = await _context.FilesToApi
                .Where(x => x.CarId == id)
                .Select(y => new FileToApiDto
                {
                    Id = y.Id,
                    CarId = y.CarId,
                    ExistingFilePath = y.ExistingFilePath
                }).ToArrayAsync();
            await _filesServices.RemoveImagesFromApi(images);
            _context.Cars.Remove(carId);
            await _context.SaveChangesAsync();
            return carId;
        }

        public async Task<Car> Update(CarDto dto)
        {
            Car car = new Car();

            car.Id = dto.Id;
            car.Type = dto.Type;
            car.Price = dto.Price;
            car.Make = dto.Make;
            car.Model = dto.Model;
            car.Year = dto.Year;
            car.Color = dto.Color;
            _context.Cars.Update(car);
            await _context.SaveChangesAsync();
            return car;
        }
    }
}
