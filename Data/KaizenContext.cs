using Microsoft.EntityFrameworkCore;
using KaizenAPIPrototipo.Models;
using System;

namespace KaizenAPIPrototipo.Data
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
                entity.HasKey(a => a.Id);

                // Use OwnsMany for the collection of Enderecos
                entity.OwnsMany(a => a.Enderecos, enderecoBuilder =>
                {
                    // Configure the foreign key to Aluno
                    enderecoBuilder.WithOwner().HasForeignKey("AlunoId");

                    // Configure a primary key for Endereco
                    enderecoBuilder.Property<Guid>("Id");
                    enderecoBuilder.HasKey("Id");

                    // Optionally configure properties
                    // enderecoBuilder.Property(e => e.CEP).IsRequired();
                });
            });

            base.OnModelCreating(modelBuilder);
        }
    }
}