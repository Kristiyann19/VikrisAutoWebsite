using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VikrisAutoWebsite.Infrastructure.Data.Entities
{
    public class Car
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(20)]
        public string Make { get; set; }

        [Required]
        [StringLength(30)]
        public string Model { get; set; }

        [Required]
        [StringLength(20)]
        public string ShortInfo { get; set; }

        [Required]
        public int Price { get; set; }

        //[Required]
        //[StringLength(15)]
        //public string Gearbox { get; set; }

        //[Required]
        //[StringLength(15)]
        //public string EngineType { get; set; }

        [Required]
        [MaxLength(999999)]
        public int Mileage { get; set; }

        [Required]
        //Must make <current year
        public int Year { get; set; }

        [Required]
        [Range(0, 2000)]
        public int HorsePower { get; set; }

        [Required]
        public int CubicCapacity { get; set; }

        //[Required]
        //[MaxLength(20)]
        //public string Category { get; set; }

        [Required]
        [MaxLength(50)]
        public string Color { get; set; }

        [Required]
        [MaxLength(9999)]
        public string Features { get; set; }


        [Required]
        public int EngineId { get; set; }
        [ForeignKey(nameof(EngineId))]
        public Engine Engine { get; set; }


        [Required]
        public int GearboxId { get; set; }
        [ForeignKey(nameof(GearboxId))]
        public Gearbox Gearbox { get; set; }


        [Required]
        public int CategoryId { get; set; }

        [ForeignKey(nameof(CategoryId))]
        public Category Category { get; set; }
    }
}
