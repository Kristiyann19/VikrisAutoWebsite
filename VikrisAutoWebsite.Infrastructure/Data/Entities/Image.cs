﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VikrisAutoWebsite.Infrastructure.Data.Entities
{
    public class Image
    {
        [Key]
        public int Id { get; set; }
        public string FileName { get; set; }
        public string FilePath { get; set; }
        // Other properties...

        public int CarId { get; set; } // Foreign key to associate with the Car
        [ForeignKey(nameof(CarId))]
        public virtual Car Car { get; set; }
    }
}
