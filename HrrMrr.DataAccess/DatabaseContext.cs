using HrrMrr.Entities;
using Microsoft.EntityFrameworkCore;
using Utilities;

namespace HrrMrr.DataAccess
{
    public class DatabaseContext:DbContext
    {
        public DbSet<Comments> Comments { get; set; }
        public DbSet<Genders> Genders { get; set; }
        public DbSet<Genuses> Genuses { get; set; }
        public DbSet<Images> Images { get; set; }
        public DbSet<Locations> Locations { get; set; }
        public DbSet<PetAdverts> PetAdverts { get; set; }
        public DbSet<PetTypes> PetTypes { get; set; }
        public DbSet<Roles> Roles { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<Cities> Cities { get; set; }
        public DbSet<Distrincts> Distrincts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(connectionString: GlobalSettings.ConnectionString);
        }

}
}
