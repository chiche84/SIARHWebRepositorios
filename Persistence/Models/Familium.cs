using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    /// <summary>
    /// Datos personales de familiares de alumnos
    /// </summary>
    public partial class Familium
    {
        /// <summary>
        /// Clave primaria, autoincrementable. Identificador de familiar
        /// </summary>
        public int IdFamilia { get; set; }
        /// <summary>
        /// Clave foranea. Identificador de tipo de documento. Ejemplo: DNI, LC
        /// </summary>
        public int IdTipoDocumento { get; set; }
        /// <summary>
        /// Numero de documento
        /// </summary>
        public int? NroDocumento { get; set; }
        /// <summary>
        /// Prefijo de cuil
        /// </summary>
        public int? PreCuil { get; set; }
        /// <summary>
        /// Sufijo de cuil
        /// </summary>
        public int? SufCuil { get; set; }
        /// <summary>
        /// Apellido/s del familiar
        /// </summary>
        public string Apellido { get; set; } = null!;
        /// <summary>
        /// Nombre/s del familiar
        /// </summary>
        public string Nombre { get; set; } = null!;
        /// <summary>
        /// Clave foranea. Identificador de genero del familiar
        /// </summary>
        public int IdSexo { get; set; }
        /// <summary>
        /// Clave foranea. Identificador de estado civil
        /// </summary>
        public int? IdEstadoCivil { get; set; }
        /// <summary>
        /// Fecha de nacimiento del familiar
        /// </summary>
        public DateTime? FechaNac { get; set; }
        /// <summary>
        /// Clave foranea. Identificador de nacionalidad
        /// </summary>
        public int? IdPaisNacionalidad { get; set; }
        /// <summary>
        /// Clave foranea. Identificador de nivel educativo maximo alcanzado por el familiar. Ejemplo: Secundario; Terciario
        /// </summary>
        public int? IdNivelEducativo { get; set; }
        /// <summary>
        /// Numero de telefono
        /// </summary>
        public string? Telefono { get; set; }
        public int? Celular { get; set; }
        /// <summary>
        /// Indica si el familiar actualmente vive. Valor 0 iguala falso, valor 1 iguala verdadero
        /// </summary>
        public bool? Vive { get; set; }
        /// <summary>
        /// Indica si el familiar trabaja. Valor 0 igual a falso, valor 1 iguala verdadero
        /// </summary>
        public bool? Trabaja { get; set; }
        /// <summary>
        /// Indica si el familiar es jubilado
        /// </summary>
        public bool? Jubilado { get; set; }
        /// <summary>
        /// Indica si el familiar es pensionado
        /// </summary>
        public bool? Pensionado { get; set; }
        public bool? EstaActivo { get; set; }

        public virtual RefEstadoCivil? IdEstadoCivilNavigation { get; set; }
        public virtual RefNivelEducativo? IdNivelEducativoNavigation { get; set; }
        public virtual RefPaisNacionalidad? IdPaisNacionalidadNavigation { get; set; }
        public virtual RefSexo IdSexoNavigation { get; set; } = null!;
        public virtual RefTipoDocumento IdTipoDocumentoNavigation { get; set; } = null!;
    }
}
