using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VikrisAutoWebsite.Infrastructure.Data.Entities;
using VikrisAutoWebsite.Infrastructure.Validations;

namespace VikrisAutoWebsite.Core.Models
{
    public class AddCarViewModel
    {

        [Required]
        [StringLength(30, MinimumLength = 3)]
        public string Make { get; set; }


        [Required]
        [StringLength(30, MinimumLength = 2)]
        public string Model { get; set; }


        [StringLength(20)]
        public string ShortInfo { get; set; }

        [Required]
        public int Price { get; set; }

        [Required]
        [MaxLength(999999)]
        public int Mileage { get; set; }

        [Required]
        [YearValidation(1930, ErrorMessage = "Please enter a valid year")]
        public int Year { get; set; }

        [Required]
        [Range(0, 2000)]
        public int HorsePower { get; set; }

        [Required]
        public int CubicCapacity { get; set; }

        [Required]
        [StringLength(30, MinimumLength = 3)]
        public string Color { get; set; }

        [Required]
        [MaxLength(9999)]
        public string Features { get; set; }

        public int ImageId { get; set; }
        public List<Image> Images { get; set; } = new List<Image>();

        public int EngineId { get; set; }
        public IEnumerable<Engine> Engines { get; set; } = new List<Engine>();

        public int GearboxId { get; set; }
        public IEnumerable<Gearbox> Gearboxes { get; set; } = new List<Gearbox>();

        public int CategoryId { get; set; }
        public IEnumerable<Category> Categories { get; set; } = new List<Category>();

        public List<IFormFile> ImageFiles { get; set; }
    }
}
