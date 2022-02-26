using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    /// <summary>
    /// Representa  el anuario escolar
    /// </summary>
    public partial class TerminoLectivo
    {
        public TerminoLectivo()
        {
            PlazaHistoria = new HashSet<PlazaHistorium>();
            PlazaTransferida = new HashSet<PlazaTransferidum>();
            Plazas = new HashSet<Plaza>();
            SolicitudDetalleDesignacions = new HashSet<SolicitudDetalleDesignacion>();
            SolicitudDetalleLicencia = new HashSet<SolicitudDetalleLicencium>();
            SolicitudDetalleSitExts = new HashSet<SolicitudDetalleSitExt>();
            SolicitudDetalleSuplentes = new HashSet<SolicitudDetalleSuplente>();
            SolicitudPlazaDetalles = new HashSet<SolicitudPlazaDetalle>();
            SubServicios = new HashSet<SubServicio>();
            TerminoLectivoRegistros = new HashSet<TerminoLectivoRegistro>();
        }

        /// <summary>
        /// Clave primari de termino lectivo, autoincrementable
        /// </summary>
        public int IdTerminoLectivo { get; set; }
        /// <summary>
        /// Identificador de grupo de nivel educativo. Ejemplo: grupo Primaria abarca niveles inicial y primaria, Secundaria, abarca niveles secundaria, egb, polimodal, etc. 
        /// </summary>
        public int IdGrupoNivel { get; set; }
        /// <summary>
        /// Tipo de periodo escolar. Ejemplo: Común, especial
        /// </summary>
        public int IdTipoPeriodoEscolar { get; set; }
        /// <summary>
        /// Organización del término lectivo. Ejemplo: bimestre, treimestre, cuatrimestre
        /// </summary>
        public string Organizacion { get; set; } = null!;
        /// <summary>
        /// Fecha de inicio del ciclo lectivo completo. Ejemplo: nivel superiro 14 de marzo de 2017
        /// </summary>
        public DateTime FechaInicio { get; set; }
        /// <summary>
        /// Fecha de fin del ciclo lectivo completo. Ejemplo: nivel superiro 25 de noviembre de 2017
        /// </summary>
        public DateTime FechaFinalizacion { get; set; }
        public bool? EstaActivo { get; set; }
        public DateTime? FechaEliminación { get; set; }
        public int? IdEjercicio { get; set; }

        public virtual RefEjercicio? IdEjercicioNavigation { get; set; }
        public virtual RefGrupoNivel IdGrupoNivelNavigation { get; set; } = null!;
        public virtual RefTipoPeriodoEscolar IdTipoPeriodoEscolarNavigation { get; set; } = null!;
        public virtual ICollection<PlazaHistorium> PlazaHistoria { get; set; }
        public virtual ICollection<PlazaTransferidum> PlazaTransferida { get; set; }
        public virtual ICollection<Plaza> Plazas { get; set; }
        public virtual ICollection<SolicitudDetalleDesignacion> SolicitudDetalleDesignacions { get; set; }
        public virtual ICollection<SolicitudDetalleLicencium> SolicitudDetalleLicencia { get; set; }
        public virtual ICollection<SolicitudDetalleSitExt> SolicitudDetalleSitExts { get; set; }
        public virtual ICollection<SolicitudDetalleSuplente> SolicitudDetalleSuplentes { get; set; }
        public virtual ICollection<SolicitudPlazaDetalle> SolicitudPlazaDetalles { get; set; }
        public virtual ICollection<SubServicio> SubServicios { get; set; }
        public virtual ICollection<TerminoLectivoRegistro> TerminoLectivoRegistros { get; set; }
    }
}
