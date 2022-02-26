using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    public partial class OrganizacionFinalView
    {
        public int IdOrganizacion { get; set; }
        public int IdHistoriaOrg { get; set; }
        public string OrganizacionDesc { get; set; } = null!;
        public string? NumeroOrganizacion { get; set; }
        public int? Cue { get; set; }
        public int? Anexo { get; set; }
        public bool EsEducativo { get; set; }
        public int? IdTipoOrganizacion { get; set; }
        public string? EmailIntitucional { get; set; }
        public bool EstaActivo { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public DateTime? FechaAlta { get; set; }
        public DateTime? FechaBaja { get; set; }
        public DateTime? FechaEliminacion { get; set; }
        public string? Observaciones { get; set; }
        public int? IdDependenciaFuncional { get; set; }
        public int? IdZona { get; set; }
        public string? Telefono { get; set; }
        public int? IdJornada { get; set; }
        public int? IdCategoriaOrganizacion { get; set; }
        public DateTime? FechaChequeo { get; set; }
        public bool EstaChequeada { get; set; }
        public int? IdAmbito { get; set; }
        public int? IdTipoEducacion { get; set; }
        public int? IdRegion { get; set; }
        public int? IdTipoPeriodoEscolar { get; set; }
        public int? IdSubvencion { get; set; }
        public int? IdModalidadAlimentaria { get; set; }
        public bool EsConfesional { get; set; }
        public bool EsArancelado { get; set; }
        public bool? EsInterna { get; set; }
        public bool? ParaGdocs { get; set; }
        public bool? EsEducacionDiferencial { get; set; }
        public string? CodigoLiquidacion { get; set; }
        public decimal? PorcSubvencion { get; set; }
    }
}
