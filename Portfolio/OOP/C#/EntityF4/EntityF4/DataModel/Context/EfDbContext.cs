using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using EntityF4.DataModel.Entities;

namespace EntityF4.DataModel.Context
{
    public class EfDbContext : DbContext
    {
        //:base representa DbContext. 
        public EfDbContext()
            :base("name = myConn")
        {

        }
 
        public DbSet<Suplidores> Suplidores { get; set; }
        
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Suplidores>()
                .ToTable("Suplidores")
                .HasKey(p => p.EmpresaId);

            modelBuilder.Entity<Suplidores>()
                .Property(p => p.NombreEmpresa)
                .HasMaxLength(100)
                .HasColumnType("varchar")
                .IsRequired();


            modelBuilder.Entity<Suplidores>()
                .Property(p => p.PersonaRepresentante)
                .HasMaxLength(100)
                .HasColumnType("varchar")
                .IsRequired();

            modelBuilder.Entity<Suplidores>()
                .Property(p => p.RNC)
                .HasMaxLength(15)
                .HasColumnType("varchar")
                .IsRequired();

            modelBuilder.Entity<Suplidores>()
                .Property(p => p.Direccion)
                .HasMaxLength(500)
                .HasColumnType("varchar")
                .IsRequired();

            modelBuilder.Entity<Suplidores>()
                .Property(p => p.Telefono)
                .HasColumnType("varchar")
                .HasMaxLength(15);

            modelBuilder.Entity<Suplidores>()
                .Property(p => p.ProveedorEstado)
                .HasColumnType("bit")
                .IsRequired();

            modelBuilder.Entity<Suplidores>()
                .Property(p => p.RegistroProveedor)
                .HasColumnType("varchar")
                .HasMaxLength(50);

            modelBuilder.Entity<Suplidores>()
                .Property(p => p.Estado)
                .HasColumnType("bit")
                .IsRequired();

        }
      
    }
}
