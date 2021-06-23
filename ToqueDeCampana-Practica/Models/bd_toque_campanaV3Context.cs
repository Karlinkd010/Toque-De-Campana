using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace ToqueDeCampana_Practica.Models
{
    public partial class bd_toque_campanaV3Context : DbContext
    {
        public bd_toque_campanaV3Context()
        {
        }

        public bd_toque_campanaV3Context(DbContextOptions<bd_toque_campanaV3Context> options)
            : base(options)
        {
        }

        public virtual DbSet<TblAlumno> TblAlumnos { get; set; }
        public virtual DbSet<TblCarrera> TblCarreras { get; set; }
        public virtual DbSet<TblDisertacion> TblDisertacions { get; set; }
        public virtual DbSet<TblKit> TblKits { get; set; }
        public virtual DbSet<TblResidencium> TblResidencia { get; set; }
        public virtual DbSet<TblUniversidad> TblUniversidads { get; set; }
        public virtual DbSet<Tblusuario> Tblusuarios { get; set; }

        // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //  {
        //    if (!optionsBuilder.IsConfigured)
        //    {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        //  optionsBuilder.UseSqlServer("Data Source=DESKTOP-9JG8FU1;Initial Catalog=bd_toque_campanaV3;Persist Security Info=True;User ID=sa;Password=karlin123;");
        //   }
        // }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Modern_Spanish_CI_AS");

            modelBuilder.Entity<TblAlumno>(entity =>
            {
                entity.HasKey(e => e.IdAlumnos)
                    .HasName("Pk_id_alumnos");

                entity.ToTable("tblAlumnos");

                entity.Property(e => e.IdAlumnos).HasColumnName("id_alumnos");

                entity.Property(e => e.BtEstatus).HasColumnName("btEstatus");

                entity.Property(e => e.DtFechaIngreso)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("dtFechaIngreso")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IdCarrera2).HasColumnName("id_carrera2");

                entity.Property(e => e.IdDisertacion).HasColumnName("id_disertacion");

                entity.Property(e => e.IdKit1).HasColumnName("id_kit1");

                entity.Property(e => e.IdKit2).HasColumnName("id_kit2");

                entity.Property(e => e.IdResidencia2).HasColumnName("id_residencia2");

                entity.Property(e => e.IdUniversidad2).HasColumnName("id_universidad2");

                entity.Property(e => e.IntNoExterior).HasColumnName("intNo_exterior");

                entity.Property(e => e.IntNoInterior).HasColumnName("intNo_interior");

                entity.Property(e => e.VchAcompanante1)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("vchAcompanante1");

                entity.Property(e => e.VchAcompanante2)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("vchAcompanante2");

                entity.Property(e => e.VchApellidos)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("vchApellidos");

                entity.Property(e => e.VchAvatar)
                    .IsUnicode(false)
                    .HasColumnName("vchAvatar");

                entity.Property(e => e.VchCPostal)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("vchC_postal");

                entity.Property(e => e.VchCalle)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("vchCalle");

                entity.Property(e => e.VchColonia)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("vchColonia");

                entity.Property(e => e.VchCorreo)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("vchCorreo");

                entity.Property(e => e.VchDisertacion)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("vchDisertacion");

                entity.Property(e => e.VchFoto)
                    .IsUnicode(false)
                    .HasColumnName("vchFoto");

                entity.Property(e => e.VchMaps)
                    .IsUnicode(false)
                    .HasColumnName("vchMaps");

                entity.Property(e => e.VchMatricula)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("vchMatricula");

                entity.Property(e => e.VchNombre)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("vchNombre");

                entity.Property(e => e.VchTalla)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("vchTalla");

                entity.Property(e => e.VchTel1)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("vchTel1");

                entity.Property(e => e.VchTel2)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("vchTel2");

                entity.Property(e => e.Vchtype)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("vchtype");

                entity.HasOne(d => d.IdCarrera2Navigation)
                    .WithMany(p => p.TblAlumnos)
                    .HasForeignKey(d => d.IdCarrera2)
                    .HasConstraintName("FK_tbl_Carrera2");

                entity.HasOne(d => d.IdDisertacionNavigation)
                    .WithMany(p => p.TblAlumnos)
                    .HasForeignKey(d => d.IdDisertacion)
                    .HasConstraintName("FK_tbl_disertacion");

                entity.HasOne(d => d.IdKit1Navigation)
                    .WithMany(p => p.TblAlumnoIdKit1Navigations)
                    .HasForeignKey(d => d.IdKit1)
                    .HasConstraintName("FK_tbl_kit");

                entity.HasOne(d => d.IdKit2Navigation)
                    .WithMany(p => p.TblAlumnoIdKit2Navigations)
                    .HasForeignKey(d => d.IdKit2)
                    .HasConstraintName("FK_tbl_kit2");

                entity.HasOne(d => d.IdResidencia2Navigation)
                    .WithMany(p => p.TblAlumnos)
                    .HasForeignKey(d => d.IdResidencia2)
                    .HasConstraintName("FK_tbl_residencia1");

                entity.HasOne(d => d.IdUniversidad2Navigation)
                    .WithMany(p => p.TblAlumnos)
                    .HasForeignKey(d => d.IdUniversidad2)
                    .HasConstraintName("FK_tbl_universidad2");
            });

            modelBuilder.Entity<TblCarrera>(entity =>
            {
                entity.HasKey(e => e.IdCarrera)
                    .HasName("PK_id_carrera");

                entity.ToTable("tblCarrera");

                entity.Property(e => e.IdCarrera).HasColumnName("id_carrera");

                entity.Property(e => e.BtEstatus).HasColumnName("btEstatus");

                entity.Property(e => e.IdUniversidad1).HasColumnName("id_universidad1");

                entity.Property(e => e.VchCarrera)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("vchCarrera");

                entity.Property(e => e.VchDescripcion)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("vchDescripcion");

                entity.Property(e => e.VchSementre)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("vchSementre");

                entity.HasOne(d => d.IdUniversidad1Navigation)
                    .WithMany(p => p.TblCarreras)
                    .HasForeignKey(d => d.IdUniversidad1)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_universidad1");
            });

            modelBuilder.Entity<TblDisertacion>(entity =>
            {
                entity.HasKey(e => e.IdDisertacion)
                    .HasName("PK_id_disertacion");

                entity.ToTable("tblDisertacion");

                entity.Property(e => e.IdDisertacion).HasColumnName("id_disertacion");

                entity.Property(e => e.VchDescripcion)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("vchDescripcion");

                entity.Property(e => e.VchNombre)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("vchNombre");
            });

            modelBuilder.Entity<TblKit>(entity =>
            {
                entity.HasKey(e => e.IdKit)
                    .HasName("PK_id_kit");

                entity.ToTable("tblKit");

                entity.Property(e => e.IdKit).HasColumnName("id_kit");

                entity.Property(e => e.ImgKit)
                    .IsUnicode(false)
                    .HasColumnName("imgKit");

                entity.Property(e => e.IntCategoria).HasColumnName("intCategoria");

                entity.Property(e => e.VchDescripcion)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("vchDescripcion");

                entity.Property(e => e.VchNombre)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("vchNombre");
            });

            modelBuilder.Entity<TblResidencium>(entity =>
            {
                entity.HasKey(e => e.IdResidencia)
                    .HasName("PK_id_residencia");

                entity.ToTable("tblResidencia");

                entity.Property(e => e.IdResidencia).HasColumnName("id_residencia");

                entity.Property(e => e.VchCPostal)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("vchC_postal");

                entity.Property(e => e.VchCiudad)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("vchCiudad");

                entity.Property(e => e.VchEstado)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("vchEstado");

                entity.Property(e => e.VchMunicipio)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("vchMunicipio");

                entity.Property(e => e.VchPais)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("vchPais");
            });

            modelBuilder.Entity<TblUniversidad>(entity =>
            {
                entity.HasKey(e => e.IdUniversidad);

                entity.ToTable("tblUniversidad");

                entity.Property(e => e.IdUniversidad).HasColumnName("id_universidad");

                entity.Property(e => e.BtEstatus).HasColumnName("btEstatus");

                entity.Property(e => e.IdResidencia1).HasColumnName("id_residencia1");

                entity.Property(e => e.VchTelefono)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("vchTelefono");

                entity.Property(e => e.VchUniversidad)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("vchUniversidad");

                entity.Property(e => e.Vchemail)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("vchemail");

                entity.HasOne(d => d.IdResidencia1Navigation)
                    .WithMany(p => p.TblUniversidads)
                    .HasForeignKey(d => d.IdResidencia1)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_residencia");
            });

            modelBuilder.Entity<Tblusuario>(entity =>
            {
                entity.HasKey(e => e.IntIdusuario);

                entity.ToTable("tblusuario");

                entity.Property(e => e.IntIdusuario).HasColumnName("intIdusuario");

                entity.Property(e => e.VchPassword)
                    .IsUnicode(false)
                    .HasColumnName("vchPassword");

                entity.Property(e => e.VchUsuario)
                    .HasMaxLength(22)
                    .IsUnicode(false)
                    .HasColumnName("vchUsuario");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
