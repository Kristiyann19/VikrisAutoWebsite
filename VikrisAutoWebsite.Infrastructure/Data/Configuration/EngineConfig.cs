﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VikrisAutoWebsite.Infrastructure.Data.Entities;

namespace VikrisAutoWebsite.Infrastructure.Data.Configuration
{
    internal class EngineConfig : IEntityTypeConfiguration<Engine>
    {
        public void Configure(EntityTypeBuilder<Engine> builder)
        {
            builder.HasData(CreateEngines());
        }

        private List<Engine> CreateEngines()
        {
            List<Engine> engines = new List<Engine>()
            {
                new Engine()
                {
                    Id = 1,
                    Name = "Дизел"
                },

                new Engine()
                {
                    Id = 2,
                    Name = "Бензин"
                },

                new Engine()
                {
                    Id = 3,
                    Name = "Електрически"
                }

            };

            return engines;
        }
    }
}
