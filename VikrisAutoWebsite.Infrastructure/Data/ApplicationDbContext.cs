using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using VikrisAutoWebsite.Infrastructure.Data.Configuration;
using VikrisAutoWebsite.Infrastructure.Data.Entities;

namespace VikrisAutoWebsite.Infrastructure.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        private bool seedDb;
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options, bool seed = true)
            : base(options)

        {
            if (Database.IsRelational())
            {
                Database.Migrate();
            }
            else
            {
                Database.EnsureCreated();
            }

            seedDb = seed;
        }

        public DbSet<Car> Cars { get; set; }

        public DbSet<Engine> Engines { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Gearbox> Gearboxes { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            if (seedDb)
            {
                builder.ApplyConfiguration(new EngineConfig());
                builder.ApplyConfiguration(new CategoryConfig());
                builder.ApplyConfiguration(new GearboxConfig());
            }
            

            base.OnModelCreating(builder);
        }

    }
}