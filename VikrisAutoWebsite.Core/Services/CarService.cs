using Microsoft.EntityFrameworkCore;

using VikrisAutoWebsite.Core.Contracts;
using VikrisAutoWebsite.Core.Models;
using VikrisAutoWebsite.Infrastructure.Data;
using VikrisAutoWebsite.Infrastructure.Data.Entities;

namespace VikrisAutoWebsite.Core.Services
{
    public class CarService : ICarService
    {
        private readonly ApplicationDbContext context;
       
        public CarService(ApplicationDbContext context_)
        {
            context = context_;
        }

        public async Task AddCarAsync(AddCarViewModel car)
        {
            var entity = new Car()
            {
                Make = car.Make,
                Model = car.Model,
                Year = car.Year,
                Color = car.Color,
                HorsePower = car.HorsePower,
                CategoryId = car.CategoryId,
                CubicCapacity = car.CubicCapacity,
                ShortInfo = car.ShortInfo,
                EngineId = car.EngineId,
                Features = car.Features,
                GearboxId = car.GearboxId,
                Mileage = car.Mileage,
                Images = car.Images,
                Price = car.Price
            };

            if (car.ImageFiles != null && car.ImageFiles.Any())
            {
                foreach (var imageFile in car.ImageFiles)
                {
                    if (imageFile != null && imageFile.Length > 0)
                    {
                        string fileName = Path.GetFileName(imageFile.FileName);
                        string filePath = Path.Combine("wwwroot/css", fileName);
                        using (var stream = new FileStream(filePath, FileMode.Create))
                        {
                            await imageFile.CopyToAsync(stream);
                        }

                        var image = new Image
                        {
                            FileName = fileName,
                            FilePath = "~/css/" + fileName
                        };

                        car.Images.Add(image);
                    }
                }
            }

            await context.Cars.AddAsync(entity);
            await context.SaveChangesAsync();
        }

        public async Task<IEnumerable<CarViewModel>> GetAllCarsAsync()
        {
            var entities = await context.Cars
                .Include(c => c.Engine)
                .Include(c => c.Category)
                .Include(c => c.Gearbox)
                .Include(c => c.Images)
                .ToListAsync();

            return entities
                .Select(c => new CarViewModel
                {
                    Id = c.Id,
                    Make = c.Make,
                    Model = c.Model,    
                    Year = c.Year,
                    Color = c.Color,
                    HorsePower = c.HorsePower,
                    Category = c.Category.Name,
                    CubicCapacity = c.CubicCapacity,
                    ShortInfo = c.ShortInfo,
                    Engine = c.Engine.Name,
                    Features = c.Features,
                    Gearbox = c.Gearbox.Name,
                    Mileage = c.Mileage,
                    Images = c.Images,
                    Price = c.Price

                });

        }

        public async Task<CarViewModel> GetCarByIdAsync(int carId)
        {
            return await context.Cars
                .Include(c => c.Engine)
                .Include(c => c.Category)
                .Include(c => c.Gearbox)
                .Include(c => c.Images)
                .Where(c => c.Id == carId)
                .Select(c => new CarViewModel
                {
                    Id = c.Id,
                    Make = c.Make,
                    Model = c.Model,
                    Year = c.Year,
                    Color = c.Color,
                    HorsePower = c.HorsePower,
                    Category = c.Category.Name,
                    CubicCapacity = c.CubicCapacity,
                    ShortInfo = c.ShortInfo,
                    Engine = c.Engine.Name,
                    Features = c.Features,
                    Gearbox = c.Gearbox.Name,
                    Mileage = c.Mileage,
                    Images = c.Images,
                    Price = c.Price

                }).FirstAsync();

        }

        public async Task<IEnumerable<Category>> GetCategoriesAsync()
        {
            return await context.Categories.ToListAsync();
        }

        public async Task<IEnumerable<Engine>> GetEnginesAsync()
        {
            return await context.Engines.ToListAsync();
        }

        public async Task<IEnumerable<Gearbox>> GetGearboxesAsync()
        {
            return await context.Gearboxes.ToListAsync();
        }
    }
}
