using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VikrisAutoWebsite.Core.Models;
using VikrisAutoWebsite.Infrastructure.Data.Entities;

namespace VikrisAutoWebsite.Core.Contracts
{
    public interface ICarService
    {
        Task<IEnumerable<CarViewModel>> GetAllCarsAsync();

        Task<CarViewModel> RemoveCarByIdAsync(int carId);

        Task<CarViewModel> GetCarByIdAsync(int carId);

        Task<IEnumerable<Engine>> GetEnginesAsync();

        Task<IEnumerable<Category>> GetCategoriesAsync();

        Task<IEnumerable<Gearbox>> GetGearboxesAsync();

        Task AddCarAsync(AddCarViewModel car);

    }
}
