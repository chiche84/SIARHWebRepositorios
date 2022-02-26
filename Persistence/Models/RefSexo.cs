using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    /// <summary>
    /// Genero
    /// </summary>
    public partial class RefSexo
    {
        public RefSexo()
        {
            Familia = new HashSet<Familium>();
            Personas = new HashSet<Persona>();
            SolicitudDetalleDesignacions = new HashSet<SolicitudDetalleDesignacion>();
            SolicitudPlazaDesignacions = new HashSet<SolicitudPlazaDesignacion>();
        }

        /// <summary>
        /// Clave primaria. Identificador del sexo.
        /// </summary>
        public int IdSexo { get; set; }
        /// <summary>
        /// Descripción del género
        /// </summary>
        public string SexoDesc { get; set; } = null!;
        public string Mnemo { get; set; } = null!;
        public bool EstaActivo { get; set; }
        public DateTime? FechaEliminacion { get; set; }

        public virtual ICollection<Familium> Familia { get; set; }
        public virtual ICollection<Persona> Personas { get; set; }
        public virtual ICollection<SolicitudDetalleDesignacion> SolicitudDetalleDesignacions { get; set; }
        public virtual ICollection<SolicitudPlazaDesignacion> SolicitudPlazaDesignacions { get; set; }
    }
}
