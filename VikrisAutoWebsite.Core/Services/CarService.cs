using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VikrisAutoWebsite.Core.Contracts;
using VikrisAutoWebsite.Core.Models;
using VikrisAutoWebsite.Infrastructure.Data.Entities;

namespace VikrisAutoWebsite.Core.Services
{
    public class CarService : ICarService
    {
        public Task AddCarAsync(AddCarViewModel car)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<CarViewModel>> GetAllCarsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Category>> GetCategoriesAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Engine>> GetEnginesAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Gearbox>> GetGearboxesAsync()
        {
            throw new NotImplementedException();
        }
    }
}
