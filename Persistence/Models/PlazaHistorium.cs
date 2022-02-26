using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    public partial class PlazaHistorium
    {
        public PlazaHistorium()
        {
            PlazaPresupuestos = new HashSet<PlazaPresupuesto>();
            Servicios = new HashSet<Servicio>();
            SolicitudDetalleDesignacions = new HashSet<SolicitudDetalleDesignacion>();
        }

        public int IdPlaza { get; set; }
        public int IdPlazaHistoria { get; set; }
        public DateTime FechaHabilitacion { get; set; }
        public DateTime? FechaTermino { get; set; }
        public int? IdTerminoLectivo { get; set; }
        public bool? EstaActivo { get; set; }
        public DateTime? FechaEliminacion { get; set; }
        public int? IdPlanUnidad { get; set; }

        public virtual PlanUnidad? IdPlanUnidadNavigation { get; set; }
        public virtual Plaza IdPlazaNavigation { get; set; } = null!;
        public virtual TerminoLectivo? IdTerminoLectivoNavigation { get; set; }
        public virtual ICollection<PlazaPresupuesto> PlazaPresupuestos { get; set; }
        public virtual ICollection<Servicio> Servicios { get; set; }
        public virtual ICollection<SolicitudDetalleDesignacion> SolicitudDetalleDesignacions { get; set; }
    }
}
