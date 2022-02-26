using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    public partial class Usuario
    {
        public Usuario()
        {
            AplicacionUsuarios = new HashSet<AplicacionUsuario>();
            SolicitudPlazaDetalles = new HashSet<SolicitudPlazaDetalle>();
            UsuarioOrganizacions = new HashSet<UsuarioOrganizacion>();
        }

        public int IdUsuario { get; set; }
        public string Usuario1 { get; set; } = null!;
        public bool? EstaActivo { get; set; }
        public DateTime FechaAlta { get; set; }
        public DateTime? FechaEliminacion { get; set; }
        public Guid? UserId { get; set; }
        public int? IdPersona { get; set; }

        public virtual Persona? IdPersonaNavigation { get; set; }
        public virtual ICollection<AplicacionUsuario> AplicacionUsuarios { get; set; }
        public virtual ICollection<SolicitudPlazaDetalle> SolicitudPlazaDetalles { get; set; }
        public virtual ICollection<UsuarioOrganizacion> UsuarioOrganizacions { get; set; }
    }
}
