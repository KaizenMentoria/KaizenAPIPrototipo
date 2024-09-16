using Microsoft.EntityFrameworkCore;
using KaizenAPI.Models;

namespace KaizenAPI.Data
{
    public class KaizenContext : DbContext
    {
        public KaizenContext(DbContextOptions<KaizenContext> options) : base(options)
        {
        }

        public DbSet<Aluno> Alunos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Aluno>(entity =>
            {
                entity.OwnsOne(a => a.Endereco);
            });

            base.OnModelCreating(modelBuilder);
        }
    }
}