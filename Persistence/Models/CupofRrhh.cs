using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    public partial class CupofRrhh
    {
        public double? CargosId { get; set; }
        public double? IdTipoDocumento { get; set; }
        public double? PersDocumento { get; set; }
        public long? PersCuil { get; set; }
        public string? PersNombre { get; set; }
        public string? PersApellido { get; set; }
        public string? PersSexo { get; set; }
        public double? TabSitRevId { get; set; }
        public double? OcuCargoId { get; set; }
        public string? OcuCargoFechaDesignacion { get; set; }
        public string? OcuCargoFechaTermino { get; set; }
        public double? TabMotivoCreacionId { get; set; }
        public double? CargoAfectacionId { get; set; }
        public string? TabMotivoCreacionDesc { get; set; }
        public string? CargoAfectacionDesc { get; set; }
        public double? TabCategoriaId { get; set; }
        public string? OcuCargoFechaBaja { get; set; }
        public double? OrdenO { get; set; }
    }
}
