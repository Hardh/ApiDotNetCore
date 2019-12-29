using ApiRestDotNetCore.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiRestDotNetCore.Data
{
    public class CoreMigrationDbContext : DbContext
    {
        public CoreMigrationDbContext(DbContextOptions<CoreMigrationDbContext> options) : base(options)
        {
        }

        public DbSet<Pessoa> Pessoas { get; set; }

    }

}
