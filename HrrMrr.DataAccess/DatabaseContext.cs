using HrrMrr.Entities;
using Microsoft.EntityFrameworkCore;
using Utilities;

namespace HrrMrr.DataAccess
{
    public class DatabaseContext:DbContext
    {
        public DbSet<Users> Users { get; set; }
        public DbSet<PetTypes> PetTypes { get; set; }
        public DbSet<PetAdverts> PetAdverts { get; set; }
        public DbSet<Roles> Roles { get; set; }
        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(connectionString: GlobalSettings.ConnectionString);
        }

}
}
