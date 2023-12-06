using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Net;
using TARpe22ShopRohusaar.ApplicationServices.Services;
using TARpe22ShopRohusaar.Core.Dto;
using TARpe22ShopRohusaar.Core.ServiceInterface;
using TARpe22ShopRohusaar.Data;
using TARpe22ShopRohusaar.Models.Car;
using TARpe22ShopRohusaar.Models.RealEstate;
using FileToApiViewModel = TARpe22ShopRohusaar.Models.Car.FileToApiViewModel;

namespace TARpe22ShopRohusaar.Controllers
{
    public class CarsController : Controller
    {
        private readonly ICarsServices _carsServices;
        private readonly TARpe22ShopRohusaarContext _context;
        private readonly IFilesServices _filesServices;
        public CarsController(ICarsServices carsServices, TARpe22ShopRohusaarContext context, IFilesServices filesServices)
        {
            _carsServices = carsServices;
            _context = context;
            _filesServices = filesServices;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var result = _context.Cars
                .OrderByDescending(y => y.CreatedAt)
                .Select(x => new CarIndexViewModel
                {
                    Id = x.Id,
                    Make = x.Make,
                    Model = x.Model,
                    Price = x.Price,
                    Year = x.Year,

                });
            return View(result);
        }


        [HttpGet]
        public IActionResult Create()
        {

            CarCreateUpdateViewModel vm = new();
            return View("CreateUpdate", vm);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CarCreateUpdateViewModel vm)
        {
            var dto = new CarDto()
            {
                Id = Guid.NewGuid(),
                Type = vm.Type,
                Price = vm.Price,
                Make = vm.Make,
                Model = vm.Model,
                Year = vm.Year,
                Color = vm.Color,
                CreatedAt = DateTime.Now,
                ModifiedAt = DateTime.Now,
                Files = vm.Files,
                FileToApiDtos = vm.FileToApiViewModels
                .Select(x => new FileToApiDto
                {
                    Id = x.ImageId,
                    ExistingFilePath = x.FilePath,
                    CarId = x.CarId,
                }).ToArray()
            };
            var result = await _carsServices.Create(dto);
            if (result == null)
            {
                return RedirectToAction(nameof(Index));
            }
            return RedirectToAction("Index", vm);

        }

        [HttpGet]
        public async Task<IActionResult> Update(Guid id)
        {
            var car = await _carsServices.GetAsync(id);
            if (car == null)
            {
                return NotFound();
            }
            var images = await _context.FilesToApi
                .Where(x => x.CarId == id)
                .Select(y => new FileToApiViewModel
                {
                    FilePath = y.ExistingFilePath,
                    ImageId = y.Id
                }).ToArrayAsync();
            var vm = new CarCreateUpdateViewModel();
            vm.Id = car.Id;
            vm.Type = car.Type;
            vm.Price = car.Price;
            vm.Make = car.Make;
            vm.Model = car.Model;
            vm.Year = car.Year;
            vm.Color = car.Color;
            vm.CreatedAt = car.CreatedAt;
            vm.ModifiedAt = DateTime.Now;
            vm.FileToApiViewModels.AddRange(images);

            return View("CreateUpdate", vm);

        }

        [HttpPost]
        public async Task<IActionResult> Update(CarCreateUpdateViewModel vm)
        {
            var dto = new CarDto()
            {
                Id = (Guid)vm.Id,
                Type = vm.Type,
                Price = vm.Price,
                Make = vm.Make,
                Model = vm.Model,
                Year = vm.Year,
                Color = vm.Color,
                CreatedAt = DateTime.Now,
                ModifiedAt = DateTime.Now,
                Files = vm.Files,
                FileToApiDtos = vm.FileToApiViewModels
                .Select(x => new FileToApiDto
                {
                    Id = x.ImageId,
                    ExistingFilePath = x.FilePath,
                    CarId = x.CarId,
                }).ToArray()
            };
            var result = await _carsServices.Update(dto);
            if (result == null)
            {
                return RedirectToAction(nameof(Index));
            }
            return RedirectToAction(nameof(Index), vm);
        }

        [HttpGet]
        public async Task<IActionResult> Details(Guid id)
        {
            var car = await _carsServices.GetAsync(id);
            if (car == null)
            {
                return NotFound();
            }
            var images = await _context.FilesToApi
            .Where(x => x.CarId == id)
            .Select(y => new FileToApiViewModel
            {
                FilePath = y.ExistingFilePath,
                ImageId = y.Id
            }).ToArrayAsync();
            var vm = new CarDetailsViewModel(); //todo: details viewmodel
            vm.Id = car.Id;
            vm.Type = car.Type;
            vm.Price = car.Price;
            vm.Make = car.Make;
            vm.Model = car.Model;
            vm.Year = car.Year;
            vm.Color = car.Color;
            vm.CreatedAt = car.CreatedAt;
            vm.ModifiedAt = car.ModifiedAt;
            vm.FileToApiViewModels.AddRange(images);

            return View(vm);
        }

        [HttpGet]
        public async Task<IActionResult> Delete(Guid id)
        {
            var car = await _carsServices.GetAsync(id);

            if (car == null)
            {
                return NotFound();
            }
            var images = await _context.FilesToApi
            .Where(x => x.CarId == id)
            .Select(y => new FileToApiViewModel
            {
                FilePath = y.ExistingFilePath,
                ImageId = y.Id
            }).ToArrayAsync();
            var vm = new CarDeleteViewModel();
            vm.Id = car.Id;
            vm.Type = car.Type;
            vm.Price = car.Price;
            vm.Make = car.Make;
            vm.Model = car.Model;
            vm.Year = car.Year;
            vm.Color = car.Color;
            vm.CreatedAt = car.CreatedAt;
            vm.ModifiedAt = car.ModifiedAt;
            vm.FileToApiViewModels.AddRange(images);
            return View(vm);
        }

        [HttpPost]
        public async Task<IActionResult> DeleteConfirmation(Guid id)
        {
            var car = await _carsServices.Delete(id);
            if (car != null)
            {
                return RedirectToAction(nameof(Index));
            }
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public async Task<IActionResult> RemoveImage(FileToApiViewModel vm)
        {
            var dto = new FileToApiDto()
            {
                Id = vm.ImageId
            };
            var image = await _filesServices.RemoveImageFromApi(dto);
            if (image == null)
            {
                return RedirectToAction(nameof(Index));
            }
            return RedirectToAction(nameof(Index));
        }

    }
}
