using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

using SistemaPrueba.Model;

namespace SistemaPrueba.DAL.DBContext;

public partial class PRUEBA_YEMINUSContext : DbContext
{
    public PRUEBA_YEMINUSContext()
    {
    }

    public PRUEBA_YEMINUSContext(DbContextOptions<PRUEBA_YEMINUSContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Encriptado> Encriptados { get; set; } = null!;
    public virtual DbSet<Producto> Productos { get; set; } = null!;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Encriptado>(entity =>
        {
            entity.HasKey(e => e.idEncriptado)
                .HasName("PK__Encripta__B4C0D5F1E774A162");

            entity.Property(e => e.idEncriptado)
                .ValueGeneratedNever()
                .HasColumnName("idEncriptado");

            entity.Property(e => e.clave).HasColumnName("clave");

            entity.Property(e => e.frase)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("frase");
        });

        modelBuilder.Entity<Producto>(entity =>
        {
            entity.HasKey(e => e.Codigo)
                .HasName("PK__Producto__40F9A2073339C8B2");

            entity.Property(e => e.Codigo)
                .ValueGeneratedNever()
                .HasColumnName("codigo");

            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("descripcion");

            entity.Property(e => e.Imagen)
                .HasMaxLength(70)
                .IsUnicode(false)
                .HasColumnName("imagen");

            entity.Property(e => e.ListaPrecios).HasColumnName("listaPrecios");

            entity.Property(e => e.PermiteVenta)
                .HasColumnName("permiteVenta")
                .HasDefaultValueSql("((1))");

            entity.Property(e => e.PorcentajeIva).HasColumnName("porcentajeIva");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
