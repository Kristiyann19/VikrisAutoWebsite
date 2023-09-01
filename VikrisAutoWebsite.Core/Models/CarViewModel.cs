using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VikrisAutoWebsite.Infrastructure.Data.Entities;

namespace VikrisAutoWebsite.Core.Models
{
    public class CarViewModel
    {     
        public int Id { get; set; }
        public string Make { get; set; }      
        public string Model { get; set; }       
        public string ShortInfo { get; set; }
        public int Price { get; set; }

        public List<IFormFile> ImageFiles { get; set; }
        public List<Image> Images { get; set; } = new List<Image>();
        public int Mileage { get; set; }
        public int Year { get; set; }
        public int HorsePower { get; set; }
        public int CubicCapacity { get; set; }
        public string Color { get; set; }
        public string Features { get; set; }
        public string? Engine { get; set; }   
        public string? Gearbox { get; set; } 
        public string? Category { get; set; }
    }
}
