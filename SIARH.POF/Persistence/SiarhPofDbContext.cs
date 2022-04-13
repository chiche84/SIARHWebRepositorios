using Microsoft.EntityFrameworkCore;
using SIARH.POF.Persistence.Models;

namespace SIARH.POF.Persistence
{
    public class SiarhPofDbContext  : DbContext
    {
        public SiarhPofDbContext()
        {

        }

        public SiarhPofDbContext(DbContextOptions<SiarhPofDbContext> options)
           : base(options)
        {
        }

        //public virtual DbSet<RefFuncion> RefFuncions { get; set; } = null!;


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<RefFuncion>(entity =>
            {
                entity.HasKey(e => e.IdFuncion);

                entity.ToTable("RefFuncion");

                entity.HasComment("Propio del presupuesto. Clasificacion de gastos por funcion. Ejemplo: Educacion elemental; media y tecnica");

                entity.Property(e => e.IdFuncion)
                    .HasColumnName("idFuncion")
                    .HasComment("Clave primaria, NO autoincrementable. Identificador de funcion");

                entity.Property(e => e.EstaActivo)
                            .IsRequired()
                            .HasColumnName("estaActivo")
                            .HasDefaultValueSql("((1))")
                            .HasComment("Indica si esta activa la funcion");

                entity.Property(e => e.FechaEliminacion)
                            .HasColumnType("datetime")
                            .HasColumnName("fechaEliminacion")
                            .HasComment("Fecha que deja de estar activa la funcion");

                entity.Property(e => e.FuncionDesc)
                            .HasMaxLength(50)
                            .HasColumnName("funcionDesc")
                            .HasComment("Descripcion de la funcion segun el presupuesto. Ejemplo: Educacion Elemental; Educacion media y tecnica; Educacion superior");
            });
        }
    }
}
