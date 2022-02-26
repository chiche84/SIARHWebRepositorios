using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    public partial class PlazaView
    {
        public int IdPlaza { get; set; }
        public int IdCargoFuncional { get; set; }
        public int? IdPlanAsignatura { get; set; }
        public int? CantidadHs { get; set; }
        public int? IdDivision { get; set; }
        public int? IdOrganizacionTurno { get; set; }
        public int IdTemporalidad { get; set; }
        public bool BajaAutomatica { get; set; }
        public DateTime? FechaTermino { get; set; }
        public DateTime FechaHabilitacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public int IdMotivoCreacion { get; set; }
        public int? IdInstrumentoLegalBaja { get; set; }
        public int IdRegimenLaboral { get; set; }
        public int IdSistemaEducativo { get; set; }
        public int? IdMotivoBaja { get; set; }
        public int IdRegimenSalarial { get; set; }
        public int IdFinanciamiento { get; set; }
        public int IdEducacionDiferencial { get; set; }
        public bool AdmiteSuplente { get; set; }
        public bool CobraIncentivo { get; set; }
        public int IdAfectacion { get; set; }
        public string? Observacion { get; set; }
        public int? IdPaquete { get; set; }
        public bool? EsCabeceraDePaquete { get; set; }
        public string OrganizacionDesc { get; set; } = null!;
        public string CargoFuncionalDesc { get; set; } = null!;
        public string TemporalidadDesc { get; set; } = null!;
        public string MotivoCreacionDesc { get; set; } = null!;
        public bool EstaActivo { get; set; }
        public DateTime? FechaEliminacion { get; set; }
        public int? IdSolicitudPlaza { get; set; }
        public int? IdExpteCreacion { get; set; }
        public int? IdInstrumentoLegalCreacion { get; set; }
        public string? InstrumentoLegalBajaDesc { get; set; }
        public string? InstrumentoLegalCreacionDesc { get; set; }
        public string SistemaEducativoDesc { get; set; } = null!;
        public string FinanciamientoDesc { get; set; } = null!;
        public string AfectacionDesc { get; set; } = null!;
        public string RegimenLaboralDesc { get; set; } = null!;
        public string RegimenSalarialDesc { get; set; } = null!;
        public int IdPresupuesto { get; set; }
        public bool GeneraPresupuesto { get; set; }
        public byte IdEstadoPlaza { get; set; }
        public string? Curso { get; set; }
        public string? DivisionDesc { get; set; }
        public string TurnoDesc { get; set; } = null!;
        public string? PlanEstudioDesc { get; set; }
        public string? AsignaturaDesc { get; set; }
        public int? IdSolicitudPlazaDetalle { get; set; }
        public int? IdOrganizacionNivelEduc { get; set; }
        public string? EstadoPlazaDesc { get; set; }
        public int? IdTerminoLectivo { get; set; }
        public int IdEjercicio { get; set; }
        public int IdPlazaPresupuesto { get; set; }
        public DateTime FechaHabilitacionPlazaPresup { get; set; }
        public DateTime FechaTerminoPlazaPresup { get; set; }
        public int IdPlazaHistoria { get; set; }
        public DateTime FechaHabilitacionPlazaHistoria { get; set; }
        public DateTime? FechaTerminoPlazaHistoria { get; set; }
        public int? IdTerminoLectivoPlazaHistoria { get; set; }
        public int IdCargoSalarial { get; set; }
        public string CargoSalarialDesc { get; set; } = null!;
        public int IdOrganizacion { get; set; }
        public int IdHistoriaOrg { get; set; }
        public int? MaxPlazaHistoria { get; set; }
        public int IdNivelEducativo { get; set; }
        public int IdTurno { get; set; }
        public byte? IdSubEstadoPlaza { get; set; }
        public string Subestado { get; set; } = null!;
        public int? IdPartida { get; set; }
        public string? Partida { get; set; }
        public short? CodigoPartida { get; set; }
        public string? InstrumentoLegalDescCohorte { get; set; }
        public int? IdInstumentoLegalCohorte { get; set; }
        public int? IdPlanUnidad { get; set; }
        public int? IdPlanEstudioCohorte { get; set; }
    }
}
