using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VikrisAutoWebsite.Infrastructure.Data.Entities;

namespace VikrisAutoWebsite.Infrastructure.Data.Configuration
{
    internal class GearboxConfig : IEntityTypeConfiguration<Gearbox>
    {
        public void Configure(EntityTypeBuilder<Gearbox> builder)
        {
            builder.HasData(CreateGearboxes());
        }

        private List<Gearbox> CreateGearboxes()
        {
            List<Gearbox> gearboxes = new List<Gearbox>()
            {
                new Gearbox()
                {
                    Id = 1,
                    Name = "Автоматична"
                },

                new Gearbox()
                {
                    Id = 2,
                    Name = "Ръчна"
                },

                new Gearbox()
                {
                    Id = 3,
                    Name = "Полуавтоматична"
                }

            };

            return gearboxes;
        }
    
    }
}
