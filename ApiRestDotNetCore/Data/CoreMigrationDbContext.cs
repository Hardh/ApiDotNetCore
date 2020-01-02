using ApiRestDotNetCore.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiRestDotNetCore.Data
{
    public class CoreMigrationDbContext : DbContext
    {
        public CoreMigrationDbContext(DbContextOptions<CoreMigrationDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PessoasCursos>()
                .HasKey(bc => new { bc.PessoaId, bc.CursoId });

            modelBuilder.Entity<PessoasCursos>()
                .HasOne(bc => bc.Curso)
                .WithMany(b => b.PessoasCursos)
                .HasForeignKey(bc => bc.CursoId);

            modelBuilder.Entity<PessoasCursos>()
                .HasOne(bc => bc.Pessoa)
                .WithMany(c => c.PessoasCursos)
                .HasForeignKey(bc => bc.PessoaId);
        }

        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<Curso> Cursos { get; set; }
        public DbSet<PessoasCursos> PessoasCursos { get; set; }



    }

}
