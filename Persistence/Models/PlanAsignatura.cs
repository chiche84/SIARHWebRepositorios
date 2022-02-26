using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    public partial class PlanAsignatura
    {
        public PlanAsignatura()
        {
            Plazas = new HashSet<Plaza>();
            SolicitudPlazaDetalles = new HashSet<SolicitudPlazaDetalle>();
            SolicitudPlazaSitExts = new HashSet<SolicitudPlazaSitExt>();
        }

        public int IdPlanAsignatura { get; set; }
        public int IdPlanEspacio { get; set; }
        public int IdAsignatura { get; set; }

        public virtual RefAsignatura IdAsignaturaNavigation { get; set; } = null!;
        public virtual PlanEspacio IdPlanEspacioNavigation { get; set; } = null!;
        public virtual ICollection<Plaza> Plazas { get; set; }
        public virtual ICollection<SolicitudPlazaDetalle> SolicitudPlazaDetalles { get; set; }
        public virtual ICollection<SolicitudPlazaSitExt> SolicitudPlazaSitExts { get; set; }
    }
}
