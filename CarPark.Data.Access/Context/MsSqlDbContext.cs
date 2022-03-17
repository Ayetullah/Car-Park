using CarPark.Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace CarPark.Data.Access.Context
{
    public class MsSqlDbContext: DbContext
    {
        public MsSqlDbContext(DbContextOptions<MsSqlDbContext> options): base(options) { }

        public DbSet<Personel> Personels { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<County> Counties { get; set; }
    }
}
