using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    public partial class PersonaSumarioDictaman
    {
        public PersonaSumarioDictaman()
        {
            SumarioDictamenServicios = new HashSet<SumarioDictamenServicio>();
        }

        public int IdPersonaSumarioDictamen { get; set; }
        public int IdPersonaSumario { get; set; }
        public DateTime FechaDictamen { get; set; }
        public int IdTipoDictamen { get; set; }
        public string? DescripcionDictamen { get; set; }
        public int? IdSancion { get; set; }
        public int? Cantidad { get; set; }
        public DateTime? FechaNotificacion { get; set; }
        public DateTime? FechaRegistroNotificacion { get; set; }
        public int? IdSumarioAlcance { get; set; }
        public bool? EstaActivo { get; set; }
        public DateTime? FechaEliminacion { get; set; }
        public int IdSumarioEtapa { get; set; }
        public int? IdUnidadTemporal { get; set; }

        public virtual PersonaSumario IdPersonaSumarioNavigation { get; set; } = null!;
        public virtual RefSumarioSancion? IdSancionNavigation { get; set; }
        public virtual RefSumarioAlcance? IdSumarioAlcanceNavigation { get; set; }
        public virtual RefTipoDictaman IdTipoDictamenNavigation { get; set; } = null!;
        public virtual RefUnidadTemporal? IdUnidadTemporalNavigation { get; set; }
        public virtual ICollection<SumarioDictamenServicio> SumarioDictamenServicios { get; set; }
    }
}
