﻿using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    public partial class SolicitudPlazaDetalleBk
    {
        public int IdSolicitudPlazaDetalle { get; set; }
        public int IdSolicitudPlaza { get; set; }
        public int IdTipoPlaza { get; set; }
        public int? IdPlaza { get; set; }
        public int IdCargoSalarial { get; set; }
        public int IdCargoFuncional { get; set; }
        public string? FuncionExtra { get; set; }
        public int? IdPlanUnidad { get; set; }
        public int? IdPlanAsignatura { get; set; }
        public int? IdDivision { get; set; }
        public int? IdOrganizacionTurno { get; set; }
        public int? CantidadHs { get; set; }
        public int IdTemporalidad { get; set; }
        public bool? BajaAutomatica { get; set; }
        public DateTime FechaHabilitacion { get; set; }
        public DateTime? FechaTermino { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public int? IdMotivoCreacion { get; set; }
        public int? IdInstrumentoLegalCreacion { get; set; }
        public int? IdInstrumentoLegalBaja { get; set; }
        public int? IdMotivoBaja { get; set; }
        public int? IdSistemaEducativo { get; set; }
        public int? IdRegimenLaboral { get; set; }
        public int? IdRegimenSalarial { get; set; }
        public int? IdFinanciamiento { get; set; }
        public bool? AdmiteSuplente { get; set; }
        public bool? CobraIncentivo { get; set; }
        public int? IdAfectacion { get; set; }
        public string? Observacion { get; set; }
        public bool EstaActivo { get; set; }
        public DateTime? FechaEliminacion { get; set; }
        public int? IdPaquete { get; set; }
        public bool? EsCabeceraDePaquete { get; set; }
        public int? IdEstadoPlaza { get; set; }
        public string? ObsEstadoPlaza { get; set; }
        public int? IdCircuitoSol { get; set; }
        public string? AccionPlaza { get; set; }
        public int? IdUsuarioModificacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
    }
}
