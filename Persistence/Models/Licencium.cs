using System;
using System.Collections.Generic;

namespace SIARH.Persistence.Models
{
    public partial class Licencium
    {
        public Licencium()
        {
            LicenciaPorSituacionDeRevista = new HashSet<LicenciaPorSituacionDeRevistum>();
            LicenciaValidacionLicencia = new HashSet<LicenciaValidacionLicencium>();
            SolicitudTurnos = new HashSet<SolicitudTurno>();
        }

        /// <summary>
        /// Clave primaria, autoincrementable.Codigo identificador de la licencia.
        /// </summary>
        public int IdLicencia { get; set; }
        /// <summary>
        /// Describe el numero de articulo de la licencia, ej.: 12B, 16D, 12-BIS, etc.
        /// </summary>
        public string NumeroArticulo { get; set; } = null!;
        /// <summary>
        /// Clave foranea de la tabla InstrumentoLegal, guarda el inst.legal/ley de creacion de la licencia.
        /// </summary>
        public int IdInstrumentoLegal { get; set; }
        /// <summary>
        /// Clave foranea de la tabla RefCategoriaLicencia, guarda la identificacion de la categoria de la licencia.
        /// </summary>
        public int IdCategoriaLicencia { get; set; }
        /// <summary>
        /// Clave foranea de la tabla RefTipoGoceHaber, guarda el identificador del tipo de goce de haberes de la licencia.
        /// </summary>
        public int IdTipoGoceHaber { get; set; }
        /// <summary>
        /// Almacena la cantidad minima de dias que requiere la licencia.
        /// </summary>
        public int? DuracionMinima { get; set; }
        /// <summary>
        /// Clave foranea de la tabla RefUnidadTemporal, guarda el tipo de unidad temporal de la duracion minima de dias.
        /// </summary>
        public int? IdUtduracion { get; set; }
        /// <summary>
        /// Clave foranea de la tabla RefUnidadTemporalContexto, guarda el tipo de unidad temporal contexto de la duracion minima de dias.
        /// </summary>
        public int? IdUtcduracion { get; set; }
        /// <summary>
        /// Almacena la cantidad maxima de dias que permite la licencia.
        /// </summary>
        public int? DuracionMaxima { get; set; }
        /// <summary>
        /// Guarda la antiguedad en años que requiere la licencia para poder ser otorgada.
        /// </summary>
        public int? AntiguedadMinimaAnios { get; set; }
        /// <summary>
        /// Guarda la antiguedad en meses que requiere la licencia para poder ser otorgada.
        /// </summary>
        public int? AntiguedadMinimaMeses { get; set; }
        /// <summary>
        /// Indica si la licencia hace que el agente pierda presentismo.  (1 = SI, 0 = NO)
        /// </summary>
        public bool PierdePresentismo { get; set; }
        /// <summary>
        /// Indica si la licencia es tenida en cuenta para la incompatibilidad horaria.  (1 = SI, 0 = NO)
        /// </summary>
        public bool CuentaIncompatibilidad { get; set; }
        /// <summary>
        /// Indica si la licencia requiere una fecha de baja obligatoria.  (1 = SI, 0 = NO)
        /// </summary>
        public bool? RequiereFechaBajaObligatoria { get; set; }
        /// <summary>
        /// Almacena la fecha de alta de la licencia.
        /// </summary>
        public DateTime FechaAlta { get; set; }
        /// <summary>
        /// Si es una licencia con goce de haber, indica el porcentaje que le corresponde.  
        /// </summary>
        public int? Porcentaje { get; set; }
        /// <summary>
        /// Nivel educativo agrupado. Ejemplo: Secundario (Secundario, polimodal, EGBIII)
        /// </summary>
        public int IdGrupoNivel { get; set; }
        public string? Inciso { get; set; }
        public int? MaximoPeriodoEnMes { get; set; }
        public int? CantidadPeriodos { get; set; }
        public int? MaximoDiasEnPeriodo { get; set; }
        public bool EsAcumulable { get; set; }
        public bool TipoControl { get; set; }
        public bool AEjercicioVencido { get; set; }

        public virtual RefCategoriaLicencium IdCategoriaLicenciaNavigation { get; set; } = null!;
        public virtual RefGrupoNivel IdGrupoNivelNavigation { get; set; } = null!;
        public virtual InstrumentoLegal IdInstrumentoLegalNavigation { get; set; } = null!;
        public virtual RefMovimiento IdLicenciaNavigation { get; set; } = null!;
        public virtual RefTipoGoceHaber IdTipoGoceHaberNavigation { get; set; } = null!;
        public virtual RefUnidadTemporalContexto? IdUtcduracionNavigation { get; set; }
        public virtual RefUnidadTemporal? IdUtduracionNavigation { get; set; }
        public virtual ICollection<LicenciaPorSituacionDeRevistum> LicenciaPorSituacionDeRevista { get; set; }
        public virtual ICollection<LicenciaValidacionLicencium> LicenciaValidacionLicencia { get; set; }
        public virtual ICollection<SolicitudTurno> SolicitudTurnos { get; set; }
    }
}
