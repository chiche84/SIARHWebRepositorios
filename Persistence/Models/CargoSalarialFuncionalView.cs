using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    public partial class CargoSalarialFuncionalView
    {
        public int IdSalarialFuncional { get; set; }
        public int IdCargoSalarial { get; set; }
        public int IdCargoFuncional { get; set; }
        public bool EstaActivo { get; set; }
        public string CargoFuncionalDesc { get; set; } = null!;
        public bool? EsJerarquico { get; set; }
        public int? IdTipoFuncion { get; set; }
        public string TipoFuncionDesc { get; set; } = null!;
    }
}
