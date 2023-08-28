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
    internal class CategoryConfig : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(CreateCategory());
        }

        private List<Category> CreateCategory()
        {
            List<Category> categories = new List<Category>()
            {
                new Category()
                {
                    Id = 1,
                    Name = "Седан"
                },

                new Category()
                {
                    Id = 2,
                    Name = "Комби"
                },

                new Category()
                {
                    Id = 3,
                    Name = "SUV(джип)"
                },

                new Category()
                {
                    Id = 4,
                    Name = "Купе"
                },

                new Category()
                {
                    Id = 5,
                    Name = "Миниван"
                },

                new Category()
                {
                    Id = 6,
                    Name = "Хечбек"
                }

            };

            return categories;
        }
    
    }
}
