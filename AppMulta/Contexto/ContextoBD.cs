using AppMulta.Models;
using Microsoft.EntityFrameworkCore;

namespace AppMulta.Contexto
{
    public class ContextoBD : DbContext
    {
        public ContextoBD(DbContextOptions<ContextoBD> options) : base(options)
            {
            }

        public DbSet<Veiculo> Veiculos { get; set;}
        public DbSet<Multa> Multas { get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure the Veiculo entity
            modelBuilder.Entity<Veiculo>()
                .ToTable("veiculo")
                .HasKey(v => v.Id)
                .HasName("id_vei");

            modelBuilder.Entity<Veiculo>()
                .Property(v => v.Id)
                .HasColumnName("id_vei")
                .ValueGeneratedOnAdd(); // Auto-increment for Veiculo Id

            // Configure the Multa entity
            modelBuilder.Entity<Multa>()
                .ToTable("multa")
                .HasKey(m => m.Id)
                .HasName("id");

            modelBuilder.Entity<Multa>()
                .Property(m => m.Id)
                .HasColumnName("id")
                .ValueGeneratedOnAdd(); // Auto-increment for Multa Id

            // Configure the relationship between Multa and Veiculo
            modelBuilder.Entity<Multa>()
                .HasOne(m => m.Veiculo)
                .WithMany(v => v.Multas)
                .HasForeignKey(m => m.IdVeiculo)
                .HasConstraintName("FK_multa_veiculo");

            base.OnModelCreating(modelBuilder);
        }       
    }
}