using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace SIARH.Persistence.Models
{
    public partial class RRHH_V2Context : DbContext
    {
        public RRHH_V2Context()
        {
        }

        public RRHH_V2Context(DbContextOptions<RRHH_V2Context> options)
            : base(options)
        {
        }

        public virtual DbSet<AplicacionUsuario> AplicacionUsuarios { get; set; } = null!;
        public virtual DbSet<Calendario> Calendarios { get; set; } = null!;
        public virtual DbSet<CargoFuncional> CargoFuncionals { get; set; } = null!;
        public virtual DbSet<CargoSalarial> CargoSalarials { get; set; } = null!;
        public virtual DbSet<CargoSalarialFuncional> CargoSalarialFuncionals { get; set; } = null!;
        public virtual DbSet<CargoSalarialFuncionalView> CargoSalarialFuncionalViews { get; set; } = null!;
        public virtual DbSet<CargoSalarialView> CargoSalarialViews { get; set; } = null!;
        public virtual DbSet<CircuitoEtapaLegajo> CircuitoEtapaLegajos { get; set; } = null!;
        public virtual DbSet<CircuitoEtapaLegajoEnUsoActualView> CircuitoEtapaLegajoEnUsoActualViews { get; set; } = null!;
        public virtual DbSet<CircuitoSolicitudLegajo> CircuitoSolicitudLegajos { get; set; } = null!;
        public virtual DbSet<CircuitoSolicitudPlaza> CircuitoSolicitudPlazas { get; set; } = null!;
        public virtual DbSet<CupofRrhh> CupofRrhhs { get; set; } = null!;
        public virtual DbSet<Departamento> Departamentos { get; set; } = null!;
        public virtual DbSet<Dependencium> Dependencia { get; set; } = null!;
        public virtual DbSet<DetalleTabla> DetalleTablas { get; set; } = null!;
        public virtual DbSet<Division> Divisions { get; set; } = null!;
        public virtual DbSet<DivisionAcrear> DivisionAcrears { get; set; } = null!;
        public virtual DbSet<DivisionView> DivisionViews { get; set; } = null!;
        public virtual DbSet<Edificio> Edificios { get; set; } = null!;
        public virtual DbSet<EdificioOrganizacion> EdificioOrganizacions { get; set; } = null!;
        public virtual DbSet<EscNivel2RegionV> EscNivel2RegionVs { get; set; } = null!;
        public virtual DbSet<EspacioAsignatura> EspacioAsignaturas { get; set; } = null!;
        public virtual DbSet<EspacioCurricular> EspacioCurriculars { get; set; } = null!;
        public virtual DbSet<Familium> Familia { get; set; } = null!;
        public virtual DbSet<GrupoDivision> GrupoDivisions { get; set; } = null!;
        public virtual DbSet<GrupoDivisionView> GrupoDivisionViews { get; set; } = null!;
        public virtual DbSet<InstrumentoLegal> InstrumentoLegals { get; set; } = null!;
        public virtual DbSet<InstrumentoLegalAdjunto> InstrumentoLegalAdjuntos { get; set; } = null!;
        public virtual DbSet<LicenciaPorSituacionDeRevistum> LicenciaPorSituacionDeRevista { get; set; } = null!;
        public virtual DbSet<LicenciaValidacionLicencium> LicenciaValidacionLicencia { get; set; } = null!;
        public virtual DbSet<LicenciaView> LicenciaViews { get; set; } = null!;
        public virtual DbSet<Licencium> Licencia { get; set; } = null!;
        public virtual DbSet<Localidad> Localidads { get; set; } = null!;
        public virtual DbSet<MenuPlaza> MenuPlazas { get; set; } = null!;
        public virtual DbSet<MigracionOrganizacionCue> MigracionOrganizacionCues { get; set; } = null!;
        public virtual DbSet<MigracionOrganizacionCue2> MigracionOrganizacionCue2s { get; set; } = null!;
        public virtual DbSet<MovimientosPresupuesto> MovimientosPresupuestos { get; set; } = null!;
        public virtual DbSet<NivelEducativoByIdOrganizacionIdHistoriaOrgView> NivelEducativoByIdOrganizacionIdHistoriaOrgViews { get; set; } = null!;
        public virtual DbSet<NodosOrg> NodosOrgs { get; set; } = null!;
        public virtual DbSet<Novedad> Novedads { get; set; } = null!;
        public virtual DbSet<NovedadView> NovedadViews { get; set; } = null!;
        public virtual DbSet<NumeracionSolicitud> NumeracionSolicituds { get; set; } = null!;
        public virtual DbSet<Organizacion> Organizacions { get; set; } = null!;
        public virtual DbSet<OrganizacionFinalView> OrganizacionFinalViews { get; set; } = null!;
        public virtual DbSet<OrganizacionNivelEducativo> OrganizacionNivelEducativos { get; set; } = null!;
        public virtual DbSet<OrganizacionResponsable> OrganizacionResponsables { get; set; } = null!;
        public virtual DbSet<OrganizacionTurno> OrganizacionTurnos { get; set; } = null!;
        public virtual DbSet<OrganizacionTurnoView> OrganizacionTurnoViews { get; set; } = null!;
        public virtual DbSet<OrganizacionUsuarioOrganizacionView> OrganizacionUsuarioOrganizacionViews { get; set; } = null!;
        public virtual DbSet<OrganizacionUsuarioView> OrganizacionUsuarioViews { get; set; } = null!;
        public virtual DbSet<OrganizacionView> OrganizacionViews { get; set; } = null!;
        public virtual DbSet<OrganizacionxInstrumentoLegal> OrganizacionxInstrumentoLegals { get; set; } = null!;
        public virtual DbSet<PaquetePlaza> PaquetePlazas { get; set; } = null!;
        public virtual DbSet<PaquetePlazaHistorica> PaquetePlazaHistoricas { get; set; } = null!;
        public virtual DbSet<PartidaView> PartidaViews { get; set; } = null!;
        public virtual DbSet<Partidum> Partida { get; set; } = null!;
        public virtual DbSet<PerSumarioOrganizacion> PerSumarioOrganizacions { get; set; } = null!;
        public virtual DbSet<PermisoRol> PermisoRols { get; set; } = null!;
        public virtual DbSet<PermutaServicio> PermutaServicios { get; set; } = null!;
        public virtual DbSet<Permutum> Permuta { get; set; } = null!;
        public virtual DbSet<Persona> Personas { get; set; } = null!;
        public virtual DbSet<PersonaSumario> PersonaSumarios { get; set; } = null!;
        public virtual DbSet<PersonaSumarioDictaman> PersonaSumarioDictamen { get; set; } = null!;
        public virtual DbSet<PersonaSumarioInstLegal> PersonaSumarioInstLegals { get; set; } = null!;
        public virtual DbSet<PersonaTitulo> PersonaTitulos { get; set; } = null!;
        public virtual DbSet<PersonaView> PersonaViews { get; set; } = null!;
        public virtual DbSet<PlanAsignatura> PlanAsignaturas { get; set; } = null!;
        public virtual DbSet<PlanAsignaturaBk> PlanAsignaturaBks { get; set; } = null!;
        public virtual DbSet<PlanEspacio> PlanEspacios { get; set; } = null!;
        public virtual DbSet<PlanEspacioBk> PlanEspacioBks { get; set; } = null!;
        public virtual DbSet<PlanEspacioCurricular> PlanEspacioCurriculars { get; set; } = null!;
        public virtual DbSet<PlanEstudio> PlanEstudios { get; set; } = null!;
        public virtual DbSet<PlanEstudioCohorte> PlanEstudioCohortes { get; set; } = null!;
        public virtual DbSet<PlanUnidad> PlanUnidads { get; set; } = null!;
        public virtual DbSet<PlanUnidadView> PlanUnidadViews { get; set; } = null!;
        public virtual DbSet<PlanillaNovedade> PlanillaNovedades { get; set; } = null!;
        public virtual DbSet<Plaza> Plazas { get; set; } = null!;
        public virtual DbSet<PlazaHistorium> PlazaHistoria { get; set; } = null!;
        public virtual DbSet<PlazaPresupuesto> PlazaPresupuestos { get; set; } = null!;
        public virtual DbSet<PlazaTransferidaView> PlazaTransferidaViews { get; set; } = null!;
        public virtual DbSet<PlazaTransferidum> PlazaTransferida { get; set; } = null!;
        public virtual DbSet<PlazaView> PlazaViews { get; set; } = null!;
        public virtual DbSet<Presupuesto> Presupuestos { get; set; } = null!;
        public virtual DbSet<PresupuestoView> PresupuestoViews { get; set; } = null!;
        public virtual DbSet<Provincium> Provincia { get; set; } = null!;
        public virtual DbSet<RefAdicional> RefAdicionals { get; set; } = null!;
        public virtual DbSet<RefAfectacion> RefAfectacions { get; set; } = null!;
        public virtual DbSet<RefAmbito> RefAmbitos { get; set; } = null!;
        public virtual DbSet<RefAplicacion> RefAplicacions { get; set; } = null!;
        public virtual DbSet<RefAsignatura> RefAsignaturas { get; set; } = null!;
        public virtual DbSet<RefCalendarioFeriado> RefCalendarioFeriados { get; set; } = null!;
        public virtual DbSet<RefCargoTipo> RefCargoTipos { get; set; } = null!;
        public virtual DbSet<RefCategoriaLicencium> RefCategoriaLicencia { get; set; } = null!;
        public virtual DbSet<RefCategoriaOrganizacion> RefCategoriaOrganizacions { get; set; } = null!;
        public virtual DbSet<RefCuenta> RefCuentas { get; set; } = null!;
        public virtual DbSet<RefDependenciaFuncional> RefDependenciaFuncionals { get; set; } = null!;
        public virtual DbSet<RefDescanso> RefDescansos { get; set; } = null!;
        public virtual DbSet<RefDiaDescansoAnual> RefDiaDescansoAnuals { get; set; } = null!;
        public virtual DbSet<RefDiaSemana> RefDiaSemanas { get; set; } = null!;
        public virtual DbSet<RefEducacionDiferencial> RefEducacionDiferencials { get; set; } = null!;
        public virtual DbSet<RefEjercicio> RefEjercicios { get; set; } = null!;
        public virtual DbSet<RefEntidadOtorgante> RefEntidadOtorgantes { get; set; } = null!;
        public virtual DbSet<RefEscalafon> RefEscalafons { get; set; } = null!;
        public virtual DbSet<RefEspecialidad> RefEspecialidads { get; set; } = null!;
        public virtual DbSet<RefEstado> RefEstados { get; set; } = null!;
        public virtual DbSet<RefEstadoCivil> RefEstadoCivils { get; set; } = null!;
        public virtual DbSet<RefEstadoEdificio> RefEstadoEdificios { get; set; } = null!;
        public virtual DbSet<RefEstadoPlaza> RefEstadoPlazas { get; set; } = null!;
        public virtual DbSet<RefEstadoSolicitud> RefEstadoSolicituds { get; set; } = null!;
        public virtual DbSet<RefEstadosSolicitudLegajo> RefEstadosSolicitudLegajos { get; set; } = null!;
        public virtual DbSet<RefFinalidad> RefFinalidads { get; set; } = null!;
        public virtual DbSet<RefFinalidadxEjer> RefFinalidadxEjers { get; set; } = null!;
        public virtual DbSet<RefFinanciamiento> RefFinanciamientos { get; set; } = null!;
        public virtual DbSet<RefFuncion> RefFuncions { get; set; } = null!;
        public virtual DbSet<RefFuncionxEjer> RefFuncionxEjers { get; set; } = null!;
        public virtual DbSet<RefGrupoNivel> RefGrupoNivels { get; set; } = null!;
        public virtual DbSet<RefJornadum> RefJornada { get; set; } = null!;
        public virtual DbSet<RefMe> RefMes { get; set; } = null!;
        public virtual DbSet<RefModalidadAlimentarium> RefModalidadAlimentaria { get; set; } = null!;
        public virtual DbSet<RefModalidadDia> RefModalidadDias { get; set; } = null!;
        public virtual DbSet<RefMotivoBaja> RefMotivoBajas { get; set; } = null!;
        public virtual DbSet<RefMotivoCreacion> RefMotivoCreacions { get; set; } = null!;
        public virtual DbSet<RefMotivoInstLegalPe> RefMotivoInstLegalPes { get; set; } = null!;
        public virtual DbSet<RefMotivoMovimientoPre> RefMotivoMovimientoPres { get; set; } = null!;
        public virtual DbSet<RefMovimiento> RefMovimientos { get; set; } = null!;
        public virtual DbSet<RefNivelEducativo> RefNivelEducativos { get; set; } = null!;
        public virtual DbSet<RefPaisNacionalidad> RefPaisNacionalidads { get; set; } = null!;
        public virtual DbSet<RefParentesco> RefParentescos { get; set; } = null!;
        public virtual DbSet<RefPermiso> RefPermisos { get; set; } = null!;
        public virtual DbSet<RefRegimenEspCu> RefRegimenEspCus { get; set; } = null!;
        public virtual DbSet<RefRegimenLaboral> RefRegimenLaborals { get; set; } = null!;
        public virtual DbSet<RefRegimenSalarial> RefRegimenSalarials { get; set; } = null!;
        public virtual DbSet<RefRegion> RefRegions { get; set; } = null!;
        public virtual DbSet<RefRol> RefRols { get; set; } = null!;
        public virtual DbSet<RefSexo> RefSexos { get; set; } = null!;
        public virtual DbSet<RefSistemaEducativo> RefSistemaEducativos { get; set; } = null!;
        public virtual DbSet<RefSituacionExtraordinarium> RefSituacionExtraordinaria { get; set; } = null!;
        public virtual DbSet<RefSituacionRevistum> RefSituacionRevista { get; set; } = null!;
        public virtual DbSet<RefSubEstadoPlaza> RefSubEstadoPlazas { get; set; } = null!;
        public virtual DbSet<RefSubvencion> RefSubvencions { get; set; } = null!;
        public virtual DbSet<RefSumarioAlcance> RefSumarioAlcances { get; set; } = null!;
        public virtual DbSet<RefSumarioEtapa> RefSumarioEtapas { get; set; } = null!;
        public virtual DbSet<RefSumarioSancion> RefSumarioSancions { get; set; } = null!;
        public virtual DbSet<RefTemporalidad> RefTemporalidads { get; set; } = null!;
        public virtual DbSet<RefTipoAsignaturaPrevium> RefTipoAsignaturaPrevia { get; set; } = null!;
        public virtual DbSet<RefTipoDescanso> RefTipoDescansos { get; set; } = null!;
        public virtual DbSet<RefTipoDictaman> RefTipoDictamen { get; set; } = null!;
        public virtual DbSet<RefTipoDocumento> RefTipoDocumentos { get; set; } = null!;
        public virtual DbSet<RefTipoEdificio> RefTipoEdificios { get; set; } = null!;
        public virtual DbSet<RefTipoEducacion> RefTipoEducacions { get; set; } = null!;
        public virtual DbSet<RefTipoEfectoInstLegal> RefTipoEfectoInstLegals { get; set; } = null!;
        public virtual DbSet<RefTipoEspacioCurricular> RefTipoEspacioCurriculars { get; set; } = null!;
        public virtual DbSet<RefTipoFuncion> RefTipoFuncions { get; set; } = null!;
        public virtual DbSet<RefTipoGoceHaber> RefTipoGoceHabers { get; set; } = null!;
        public virtual DbSet<RefTipoInasistencium> RefTipoInasistencia { get; set; } = null!;
        public virtual DbSet<RefTipoInstrumentoLegal> RefTipoInstrumentoLegals { get; set; } = null!;
        public virtual DbSet<RefTipoJuridiccion> RefTipoJuridiccions { get; set; } = null!;
        public virtual DbSet<RefTipoMovimiento> RefTipoMovimientos { get; set; } = null!;
        public virtual DbSet<RefTipoNovedad> RefTipoNovedads { get; set; } = null!;
        public virtual DbSet<RefTipoNovedadLua> RefTipoNovedadLuas { get; set; } = null!;
        public virtual DbSet<RefTipoOrganizacion> RefTipoOrganizacions { get; set; } = null!;
        public virtual DbSet<RefTipoPaquetePlaza> RefTipoPaquetePlazas { get; set; } = null!;
        public virtual DbSet<RefTipoPeriodoEscolar> RefTipoPeriodoEscolars { get; set; } = null!;
        public virtual DbSet<RefTipoPlaza> RefTipoPlazas { get; set; } = null!;
        public virtual DbSet<RefTipoServicio> RefTipoServicios { get; set; } = null!;
        public virtual DbSet<RefTipoSolicitud> RefTipoSolicituds { get; set; } = null!;
        public virtual DbSet<RefTipoSumario> RefTipoSumarios { get; set; } = null!;
        public virtual DbSet<RefTipoTablero> RefTipoTableros { get; set; } = null!;
        public virtual DbSet<RefTipoTenencium> RefTipoTenencia { get; set; } = null!;
        public virtual DbSet<RefTitulo> RefTitulos { get; set; } = null!;
        public virtual DbSet<RefTituloHabilitante> RefTituloHabilitantes { get; set; } = null!;
        public virtual DbSet<RefTurno> RefTurnos { get; set; } = null!;
        public virtual DbSet<RefUdeO> RefUdeOs { get; set; } = null!;
        public virtual DbSet<RefUdeOxEjer> RefUdeOxEjers { get; set; } = null!;
        public virtual DbSet<RefUnidadTemporal> RefUnidadTemporals { get; set; } = null!;
        public virtual DbSet<RefUnidadTemporalContexto> RefUnidadTemporalContextos { get; set; } = null!;
        public virtual DbSet<RefValidacionLicencium> RefValidacionLicencia { get; set; } = null!;
        public virtual DbSet<RefZona> RefZonas { get; set; } = null!;
        public virtual DbSet<ReqSolicitudPrimarium> ReqSolicitudPrimaria { get; set; } = null!;
        public virtual DbSet<RespDependencium> RespDependencia { get; set; } = null!;
        public virtual DbSet<Servicio> Servicios { get; set; } = null!;
        public virtual DbSet<ServicioExterno> ServicioExternos { get; set; } = null!;
        public virtual DbSet<ServicioView> ServicioViews { get; set; } = null!;
        public virtual DbSet<SolicitudDetalle> SolicitudDetalles { get; set; } = null!;
        public virtual DbSet<SolicitudDetalleBaja> SolicitudDetalleBajas { get; set; } = null!;
        public virtual DbSet<SolicitudDetalleCambioSr> SolicitudDetalleCambioSrs { get; set; } = null!;
        public virtual DbSet<SolicitudDetalleDesignacion> SolicitudDetalleDesignacions { get; set; } = null!;
        public virtual DbSet<SolicitudDetalleDesignacionView> SolicitudDetalleDesignacionViews { get; set; } = null!;
        public virtual DbSet<SolicitudDetalleFrenteAlumno> SolicitudDetalleFrenteAlumnos { get; set; } = null!;
        public virtual DbSet<SolicitudDetalleLicenciaView> SolicitudDetalleLicenciaViews { get; set; } = null!;
        public virtual DbSet<SolicitudDetalleLicencium> SolicitudDetalleLicencia { get; set; } = null!;
        public virtual DbSet<SolicitudDetalleSitExt> SolicitudDetalleSitExts { get; set; } = null!;
        public virtual DbSet<SolicitudDetalleSitExtView> SolicitudDetalleSitExtViews { get; set; } = null!;
        public virtual DbSet<SolicitudDetalleSuplente> SolicitudDetalleSuplentes { get; set; } = null!;
        public virtual DbSet<SolicitudDetalleSuplenteView> SolicitudDetalleSuplenteViews { get; set; } = null!;
        public virtual DbSet<SolicitudDetalleSuspension> SolicitudDetalleSuspensions { get; set; } = null!;
        public virtual DbSet<SolicitudEstado> SolicitudEstados { get; set; } = null!;
        public virtual DbSet<SolicitudEstadosLegajo> SolicitudEstadosLegajos { get; set; } = null!;
        public virtual DbSet<SolicitudEstadosTurno> SolicitudEstadosTurnos { get; set; } = null!;
        public virtual DbSet<SolicitudEstadosUltimoEstado> SolicitudEstadosUltimoEstados { get; set; } = null!;
        public virtual DbSet<SolicitudEstadosUltimoIdSolicitudEstadosView> SolicitudEstadosUltimoIdSolicitudEstadosViews { get; set; } = null!;
        public virtual DbSet<SolicitudEstadosView> SolicitudEstadosViews { get; set; } = null!;
        public virtual DbSet<SolicitudLegajo> SolicitudLegajos { get; set; } = null!;
        public virtual DbSet<SolicitudPlaza> SolicitudPlazas { get; set; } = null!;
        public virtual DbSet<SolicitudPlazaBorrar> SolicitudPlazaBorrars { get; set; } = null!;
        public virtual DbSet<SolicitudPlazaDesignacion> SolicitudPlazaDesignacions { get; set; } = null!;
        public virtual DbSet<SolicitudPlazaDetalle> SolicitudPlazaDetalles { get; set; } = null!;
        public virtual DbSet<SolicitudPlazaDetalleBk> SolicitudPlazaDetalleBks { get; set; } = null!;
        public virtual DbSet<SolicitudPlazaDetallePresupuestoView> SolicitudPlazaDetallePresupuestoViews { get; set; } = null!;
        public virtual DbSet<SolicitudPlazaDetalleView> SolicitudPlazaDetalleViews { get; set; } = null!;
        public virtual DbSet<SolicitudPlazaListview> SolicitudPlazaListviews { get; set; } = null!;
        public virtual DbSet<SolicitudPlazaSitExt> SolicitudPlazaSitExts { get; set; } = null!;
        public virtual DbSet<SolicitudTurno> SolicitudTurnos { get; set; } = null!;
        public virtual DbSet<SolicitudTurnoView> SolicitudTurnoViews { get; set; } = null!;
        public virtual DbSet<SubServicio> SubServicios { get; set; } = null!;
        public virtual DbSet<SubServicioView> SubServicioViews { get; set; } = null!;
        public virtual DbSet<SumarioDictamenServicio> SumarioDictamenServicios { get; set; } = null!;
        public virtual DbSet<TableroBase> TableroBases { get; set; } = null!;
        public virtual DbSet<TableroOrganizacion> TableroOrganizacions { get; set; } = null!;
        public virtual DbSet<TableroOrganizacionDetalle> TableroOrganizacionDetalles { get; set; } = null!;
        public virtual DbSet<TableroOrganizacionView> TableroOrganizacionViews { get; set; } = null!;
        public virtual DbSet<TableroPlaza> TableroPlazas { get; set; } = null!;
        public virtual DbSet<TerminoLectivo> TerminoLectivos { get; set; } = null!;
        public virtual DbSet<TerminoLectivoRegistro> TerminoLectivoRegistros { get; set; } = null!;
        public virtual DbSet<UdeOxEjerView> UdeOxEjerViews { get; set; } = null!;
        public virtual DbSet<Usuario> Usuarios { get; set; } = null!;
        public virtual DbSet<UsuarioOrganizacion> UsuarioOrganizacions { get; set; } = null!;
        public virtual DbSet<UsuarioOrganizacionPermiso> UsuarioOrganizacionPermisos { get; set; } = null!;
        public virtual DbSet<UsuarioOrganizacionRol> UsuarioOrganizacionRols { get; set; } = null!;
        public virtual DbSet<UsuarioOrganizacionView> UsuarioOrganizacionViews { get; set; } = null!;
        public virtual DbSet<VwCircuitoSolicitudLegajo> VwCircuitoSolicitudLegajos { get; set; } = null!;
        public virtual DbSet<VwCircuitoSolictudPlaza> VwCircuitoSolictudPlazas { get; set; } = null!;
        public virtual DbSet<_23MigracionSolicitudestado> _23MigracionSolicitudestados { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-5J76I7I;Initial Catalog=RRHH_V2;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AplicacionUsuario>(entity =>
            {
                entity.HasKey(e => e.IdAplicacionUsuario);

                entity.ToTable("AplicacionUsuario");

                entity.Property(e => e.IdAplicacionUsuario)
                    .ValueGeneratedNever()
                    .HasColumnName("idAplicacionUsuario");

                entity.Property(e => e.EstaActivo).HasColumnName("estaActivo");

                entity.Property(e => e.FechaAlta)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaAlta");

                entity.Property(e => e.FechaEliminacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaEliminacion");

                entity.Property(e => e.IdAplicacion).HasColumnName("idAplicacion");

                entity.Property(e => e.IdUsuario).HasColumnName("idUsuario");

                entity.HasOne(d => d.IdAplicacionNavigation)
                    .WithMany(p => p.AplicacionUsuarios)
                    .HasForeignKey(d => d.IdAplicacion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AplicacionUsuario_RefAplicacion");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.AplicacionUsuarios)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AplicacionUsuario_Usuario");
            });

            modelBuilder.Entity<Calendario>(entity =>
            {
                entity.HasKey(e => e.IdCalendario);

                entity.ToTable("Calendario");

                entity.Property(e => e.IdCalendario).HasColumnName("idCalendario");

                entity.Property(e => e.CalendarioDesc)
                    .HasMaxLength(64)
                    .HasColumnName("calendarioDesc");

                entity.Property(e => e.EstaActivo)
                    .IsRequired()
                    .HasColumnName("estaActivo")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Fecha)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha");

                entity.Property(e => e.FechaEliminacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaEliminacion");

                entity.Property(e => e.IdDescanso).HasColumnName("idDescanso");

                entity.Property(e => e.IdEjercicio).HasColumnName("idEjercicio");

                entity.HasOne(d => d.IdDescansoNavigation)
                    .WithMany(p => p.Calendarios)
                    .HasForeignKey(d => d.IdDescanso)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Calendario_RefDescanso");

                entity.HasOne(d => d.IdEjercicioNavigation)
                    .WithMany(p => p.Calendarios)
                    .HasForeignKey(d => d.IdEjercicio)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Calendario_RefEjercicio");
            });

            modelBuilder.Entity<CargoFuncional>(entity =>
            {
                entity.HasKey(e => e.IdCargoFuncional)
                    .HasName("PK__CargoFuncional");

                entity.ToTable("CargoFuncional");

                entity.HasComment("Funciones que puede desempeñar un agente, independientemente del cargo salarial asignado (cargo para liquidacion).");

                entity.Property(e => e.IdCargoFuncional)
                    .HasColumnName("idCargoFuncional")
                    .HasComment("Clave primaria, autoincrementable. Identificador de la funcion que podría cumplir un agente");

                entity.Property(e => e.CargoFuncionalDesc)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("cargoFuncionalDesc")
                    .HasComment("Descripción del cargo funcional");

                entity.Property(e => e.EsJerarquico)
                    .HasColumnName("esJerarquico")
                    .HasDefaultValueSql("((0))")
                    .HasComment("Indica si se trata de un cargo funcional directivo. Valor 0 es igual a falso, valor 1 igual a verdadero. Ejemplo: Cargo funcional Director de primera categoria es Jerarquico = 1");

                entity.Property(e => e.EstaActivo)
                    .IsRequired()
                    .HasColumnName("estaActivo")
                    .HasDefaultValueSql("((1))")
                    .HasComment("Campo para eliminación lógica. Valor 0 es igual a falso, valor 1 es igual a verdadero");

                entity.Property(e => e.FechaEliminacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaEliminacion")
                    .HasComment("Fecha en la que deja de estar activo el cargo funcional");

                entity.Property(e => e.IdTipoFuncion)
                    .HasColumnName("idTipoFuncion")
                    .HasComment("Clave foranea. Identificador de tipo de funcion. Las funciones son agrupadas por tipo");

                entity.Property(e => e.OrdenVisual).HasColumnName("ordenVisual");

                entity.HasOne(d => d.IdTipoFuncionNavigation)
                    .WithMany(p => p.CargoFuncionals)
                    .HasForeignKey(d => d.IdTipoFuncion)
                    .HasConstraintName("FK_CargoFuncional_RefTipoFuncion");
            });

            modelBuilder.Entity<CargoSalarial>(entity =>
            {
                entity.HasKey(e => e.IdCargoSalarial);

                entity.ToTable("CargoSalarial");

                entity.HasComment("Categoria que puede ser asignada a un agente y por el cual se liquidara");

                entity.Property(e => e.IdCargoSalarial)
                    .HasColumnName("idCargoSalarial")
                    .HasComment("Clave primaria, autoincrementable.Codigo identificador del cargo salarial.");

                entity.Property(e => e.CargoSalarialDesc)
                    .HasMaxLength(100)
                    .HasColumnName("cargoSalarialDesc")
                    .HasComment("Descripcion del cargo salarial");

                entity.Property(e => e.EquivalenciaHoraria)
                    .HasColumnName("equivalenciaHoraria")
                    .HasComment("Equivalencia del cargo salarial en horas");

                entity.Property(e => e.EstaActivo)
                    .IsRequired()
                    .HasColumnName("estaActivo")
                    .HasDefaultValueSql("((1))")
                    .HasComment("Identifica si el registro esta activo.");

                entity.Property(e => e.FechaAlta)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaAlta")
                    .HasComment("Almacena la fecha de alta del cargo salarial.");

                entity.Property(e => e.FechaEliminacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaEliminacion")
                    .HasComment("Almacena la fecha de baja del cargo salarial.");

                entity.Property(e => e.IdJornada)
                    .HasColumnName("idJornada")
                    .HasComment("Clave foranea de la tabla RefJornada. ");

                entity.Property(e => e.Nuevo).HasColumnName("nuevo");

                entity.Property(e => e.OrdenVisual).HasColumnName("ordenVisual");

                entity.HasOne(d => d.IdJornadaNavigation)
                    .WithMany(p => p.CargoSalarials)
                    .HasForeignKey(d => d.IdJornada)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CargoSalarial_RefJornada");
            });

            modelBuilder.Entity<CargoSalarialFuncional>(entity =>
            {
                entity.HasKey(e => e.IdSalarialFuncional);

                entity.ToTable("CargoSalarialFuncional");

                entity.HasComment("Relacion entre CargoSalarial y CargoFuncional. Funciones por Cargo salarial (categoria)");

                entity.Property(e => e.EstaActivo)
                    .IsRequired()
                    .HasColumnName("estaActivo")
                    .HasDefaultValueSql("((1))")
                    .HasComment("Campo para eliminación lógica. Valor 0 es igual a falso, valor 1 es igual a verdadero.");

                entity.Property(e => e.FechaAlta)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaAlta")
                    .HasComment("Almacena la fecha de alta de la relacion entre el cargo funcional y el cargo salarial.");

                entity.Property(e => e.FechaEliminacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaEliminacion")
                    .HasComment("Almacena la fecha de baja de la relacion entre el cargo funcional y el cargo salarial.");

                entity.Property(e => e.IdCargoFuncional)
                    .HasColumnName("idCargoFuncional")
                    .HasComment("Clave foranea de la tabla CargoFuncional. Identificador del cargo funcional.");

                entity.Property(e => e.IdCargoSalarial)
                    .HasColumnName("idCargoSalarial")
                    .HasComment("Clave foranea de la tabla CargoSalarial. Identificador del cargo salarial.");

                entity.HasOne(d => d.IdCargoFuncionalNavigation)
                    .WithMany(p => p.CargoSalarialFuncionals)
                    .HasForeignKey(d => d.IdCargoFuncional)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CargoSalarialFuncional_CargoFuncional");

                entity.HasOne(d => d.IdCargoSalarialNavigation)
                    .WithMany(p => p.CargoSalarialFuncionals)
                    .HasForeignKey(d => d.IdCargoSalarial)
                    .HasConstraintName("FK_CargoSalarialFuncional_CargoSalarial");
            });

            modelBuilder.Entity<CargoSalarialFuncionalView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("CargoSalarialFuncionalView");

                entity.Property(e => e.CargoFuncionalDesc)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("cargoFuncionalDesc");

                entity.Property(e => e.EsJerarquico).HasColumnName("esJerarquico");

                entity.Property(e => e.EstaActivo).HasColumnName("estaActivo");

                entity.Property(e => e.IdCargoFuncional).HasColumnName("idCargoFuncional");

                entity.Property(e => e.IdCargoSalarial).HasColumnName("idCargoSalarial");

                entity.Property(e => e.IdTipoFuncion).HasColumnName("idTipoFuncion");

                entity.Property(e => e.TipoFuncionDesc)
                    .HasMaxLength(100)
                    .HasColumnName("tipoFuncionDesc");
            });

            modelBuilder.Entity<CargoSalarialView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("CargoSalarialView");

                entity.Property(e => e.CargoSalarialDesc)
                    .HasMaxLength(100)
                    .HasColumnName("cargoSalarialDesc");

                entity.Property(e => e.EjercicioFinalidad).HasMaxLength(4);

                entity.Property(e => e.EjercicioFuncion).HasMaxLength(4);

                entity.Property(e => e.EjercicioUdeo).HasMaxLength(4);

                entity.Property(e => e.EscalafonDesc)
                    .HasMaxLength(100)
                    .HasColumnName("escalafonDesc");

                entity.Property(e => e.EstaActivo).HasColumnName("estaActivo");

                entity.Property(e => e.FinalidadDesc)
                    .HasMaxLength(50)
                    .HasColumnName("finalidadDesc");

                entity.Property(e => e.FuncionDesc)
                    .HasMaxLength(50)
                    .HasColumnName("funcionDesc");

                entity.Property(e => e.IdCargoSalarial).HasColumnName("idCargoSalarial");

                entity.Property(e => e.IdEscalafon).HasColumnName("idEscalafon");

                entity.Property(e => e.IdFinalidad).HasColumnName("idFinalidad");

                entity.Property(e => e.IdFuncion).HasColumnName("idFuncion");

                entity.Property(e => e.IdJornada).HasColumnName("idJornada");

                entity.Property(e => e.IdUdeO).HasColumnName("idUdeO");

                entity.Property(e => e.UdeoDesc)
                    .HasMaxLength(100)
                    .HasColumnName("udeoDesc");
            });

            modelBuilder.Entity<CircuitoEtapaLegajo>(entity =>
            {
                entity.HasKey(e => e.IdCircuitoEtapaLegajo);

                entity.ToTable("CircuitoEtapaLegajo");

                entity.Property(e => e.IdCircuitoEtapaLegajo).HasColumnName("idCircuitoEtapaLegajo");

                entity.Property(e => e.CircuitoEtapaLegajoDesc)
                    .HasMaxLength(100)
                    .HasColumnName("circuitoEtapaLegajoDesc");

                entity.Property(e => e.EstaActivo)
                    .IsRequired()
                    .HasColumnName("estaActivo")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.EstaHabilitado)
                    .IsRequired()
                    .HasColumnName("estaHabilitado")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.FechaEliminacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaEliminacion");

                entity.Property(e => e.IdCircuitoSolicitudLegajo).HasColumnName("idCircuitoSolicitudLegajo");

                entity.Property(e => e.IdHistoriaOrg).HasColumnName("idHistoriaOrg");

                entity.Property(e => e.IdOrganizacion).HasColumnName("idOrganizacion");

                entity.Property(e => e.Orden).HasColumnName("orden");

                entity.HasOne(d => d.IdCircuitoSolicitudLegajoNavigation)
                    .WithMany(p => p.CircuitoEtapaLegajos)
                    .HasForeignKey(d => d.IdCircuitoSolicitudLegajo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CircuitoEtapaLegajo_CircuitoSolicitudLegajo");

                entity.HasOne(d => d.Id)
                    .WithMany(p => p.CircuitoEtapaLegajos)
                    .HasForeignKey(d => new { d.IdOrganizacion, d.IdHistoriaOrg })
                    .HasConstraintName("FK_CircuitoEtapaLegajo_Organizacion");
            });

            modelBuilder.Entity<CircuitoEtapaLegajoEnUsoActualView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("CircuitoEtapaLegajoEnUsoActualView");

                entity.Property(e => e.CircuitoEtapaLegajoDesc)
                    .HasMaxLength(100)
                    .HasColumnName("circuitoEtapaLegajoDesc");

                entity.Property(e => e.EstaActivo).HasColumnName("estaActivo");

                entity.Property(e => e.EstaHabilitado).HasColumnName("estaHabilitado");

                entity.Property(e => e.FechaEliminacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaEliminacion");

                entity.Property(e => e.IdCircuitoEtapaLegajo).HasColumnName("idCircuitoEtapaLegajo");

                entity.Property(e => e.IdCircuitoSolicitudLegajo).HasColumnName("idCircuitoSolicitudLegajo");

                entity.Property(e => e.IdHistoriaOrg).HasColumnName("idHistoriaOrg");

                entity.Property(e => e.IdOrganizacion).HasColumnName("idOrganizacion");

                entity.Property(e => e.Orden).HasColumnName("orden");
            });

            modelBuilder.Entity<CircuitoSolicitudLegajo>(entity =>
            {
                entity.HasKey(e => e.IdCircuitoSolicitudLegajo);

                entity.ToTable("CircuitoSolicitudLegajo");

                entity.Property(e => e.IdCircuitoSolicitudLegajo).HasColumnName("idCircuitoSolicitudLegajo");

                entity.Property(e => e.CircuitoSolicitudLegajoDesc)
                    .HasMaxLength(100)
                    .HasColumnName("circuitoSolicitudLegajoDesc");

                entity.Property(e => e.EstaActivo)
                    .IsRequired()
                    .HasColumnName("estaActivo")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.FechaEliminacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaEliminacion");

                entity.Property(e => e.IdGrupoNivel).HasColumnName("idGrupoNivel");

                entity.Property(e => e.IdTipoSolicitud).HasColumnName("idTipoSolicitud");

                entity.HasOne(d => d.IdGrupoNivelNavigation)
                    .WithMany(p => p.CircuitoSolicitudLegajos)
                    .HasForeignKey(d => d.IdGrupoNivel)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CircuitoSolicitudLegajo_RefGrupoNivel");

                entity.HasOne(d => d.IdTipoSolicitudNavigation)
                    .WithMany(p => p.CircuitoSolicitudLegajos)
                    .HasForeignKey(d => d.IdTipoSolicitud)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CircuitoSolicitudLegajo_RefTipoSolicitud");
            });

            modelBuilder.Entity<CircuitoSolicitudPlaza>(entity =>
            {
                entity.HasKey(e => e.IdCircuitoSol);

                entity.ToTable("CircuitoSolicitudPlaza");

                entity.Property(e => e.IdCircuitoSol).HasColumnName("idCircuitoSol");

                entity.Property(e => e.CircuitoSolDesc)
                    .HasMaxLength(100)
                    .HasComment("Descripción de parte interviniente del circuito de solicitud de cargos. Ejemplo: Supervision regional, dirección de nivel");

                entity.Property(e => e.EstaActivo)
                    .HasColumnName("estaActivo")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.FechaEliminacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaEliminacion");

                entity.Property(e => e.IdGrupoNivel)
                    .HasColumnName("idGrupoNivel")
                    .HasComment("Identificador de nivel educativo agrupado. Ejemplo: Nivel inicial y primaria, Secundaria, terciaria");

                entity.Property(e => e.IdTipoSolicitud)
                    .HasColumnName("idTipoSolicitud")
                    .HasComment("Tipo de solicitud: Ejemplo: Plaza, designación, licencia, etc.");

                entity.Property(e => e.Orden)
                    .HasColumnName("orden")
                    .HasComment("Orden dentro del circuito. Ejemplo la solicitud inicia en la Organizacion, 2. Supervisión regional, 3 Dirección de nivel");

                entity.HasOne(d => d.IdTipoSolicitudNavigation)
                    .WithMany(p => p.CircuitoSolicitudPlazas)
                    .HasForeignKey(d => d.IdTipoSolicitud)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CircuitoSolicitudPlaza_RefTipoSolicitud");
            });

            modelBuilder.Entity<CupofRrhh>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CUPOF_RRHH");

                entity.Property(e => e.CargoAfectacionDesc)
                    .HasMaxLength(255)
                    .HasColumnName("cargo_afectacion_desc");

                entity.Property(e => e.CargoAfectacionId).HasColumnName("cargo_afectacion_id");

                entity.Property(e => e.CargosId).HasColumnName("cargos_id");

                entity.Property(e => e.IdTipoDocumento).HasColumnName("idTipoDocumento");

                entity.Property(e => e.OcuCargoFechaBaja)
                    .HasMaxLength(255)
                    .HasColumnName("ocu_cargo_fecha_baja");

                entity.Property(e => e.OcuCargoFechaDesignacion)
                    .HasMaxLength(255)
                    .HasColumnName("ocu_cargo_fecha_designacion");

                entity.Property(e => e.OcuCargoFechaTermino)
                    .HasMaxLength(255)
                    .HasColumnName("ocu_cargo_fecha_termino");

                entity.Property(e => e.OcuCargoId).HasColumnName("ocu_cargo_id");

                entity.Property(e => e.PersApellido)
                    .HasMaxLength(255)
                    .HasColumnName("pers_apellido");

                entity.Property(e => e.PersCuil).HasColumnName("pers_cuil");

                entity.Property(e => e.PersDocumento).HasColumnName("pers_documento");

                entity.Property(e => e.PersNombre)
                    .HasMaxLength(255)
                    .HasColumnName("pers_nombre");

                entity.Property(e => e.PersSexo)
                    .HasMaxLength(255)
                    .HasColumnName("pers_sexo");

                entity.Property(e => e.TabCategoriaId).HasColumnName("Tab_categoria_id");

                entity.Property(e => e.TabMotivoCreacionDesc)
                    .HasMaxLength(255)
                    .HasColumnName("tab_motivo_creacion_desc");

                entity.Property(e => e.TabMotivoCreacionId).HasColumnName("tab_motivo_creacion_id");

                entity.Property(e => e.TabSitRevId).HasColumnName("tab_sit_rev_id");
            });

            modelBuilder.Entity<Departamento>(entity =>
            {
                entity.HasKey(e => e.IdDepartamento);

                entity.ToTable("Departamento");

                entity.HasComment("Departamentos de provincia");

                entity.Property(e => e.IdDepartamento)
                    .HasColumnName("idDepartamento")
                    .HasComment("Clave primaria, autoincrementable. Identificador de departamento");

                entity.Property(e => e.DepartamentoDesc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("departamentoDesc")
                    .HasComment("Nombre del departamento");

                entity.Property(e => e.EstaActivo)
                    .IsRequired()
                    .HasColumnName("estaActivo")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.FechaEliminacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaEliminacion");

                entity.Property(e => e.IdProvincia)
                    .HasColumnName("idProvincia")
                    .HasComment("Clave foranea. Identificador de la provincia a la que pertenece el departamento");

                entity.HasOne(d => d.IdProvinciaNavigation)
                    .WithMany(p => p.Departamentos)
                    .HasForeignKey(d => d.IdProvincia)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Departamento_Provincia");
            });

            modelBuilder.Entity<Dependencium>(entity =>
            {
                entity.HasKey(e => e.IdDependencia)
                    .HasName("PK_tb_Dependencia");

                entity.Property(e => e.IdDependencia).HasColumnName("idDependencia");

                entity.Property(e => e.DependenciaDesc)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("dependenciaDesc");

                entity.Property(e => e.Direccion)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("direccion");

                entity.Property(e => e.EsInterna).HasColumnName("esInterna");

                entity.Property(e => e.EstaActivo)
                    .IsRequired()
                    .HasColumnName("estaActivo")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.FechaAlta)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaAlta");

                entity.Property(e => e.FechaEliminacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaEliminacion");

                entity.Property(e => e.IdDependenciaPadre).HasColumnName("idDependenciaPadre");

                entity.Property(e => e.IdHistoriaOrg).HasColumnName("idHistoriaOrg");

                entity.Property(e => e.IdOrganizacion).HasColumnName("idOrganizacion");

                entity.Property(e => e.ParaGdocs).HasColumnName("paraGdocs");

                entity.Property(e => e.TieneHijo)
                    .HasColumnName("tieneHijo")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<DetalleTabla>(entity =>
            {
                entity.HasKey(e => e.IdDetalleTabla);

                entity.ToTable("DetalleTabla");

                entity.Property(e => e.IdDetalleTabla).HasColumnName("idDetalleTabla");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(50)
                    .HasColumnName("descripcion")
                    .HasComment("Descripcion larga de los valores que contiene la tabla");

                entity.Property(e => e.EstaActivo)
                    .HasColumnName("estaActivo")
                    .HasDefaultValueSql("((1))")
                    .HasComment("Identifica si el registro esta activo o no");

                entity.Property(e => e.FechaEliminacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaEliminacion")
                    .HasComment("Almacena la fecha de baja del registro.");

                entity.Property(e => e.Tabla)
                    .HasMaxLength(50)
                    .HasColumnName("tabla")
                    .HasComment("Nombre de la tabla");

                entity.Property(e => e.Vinculado)
                    .HasColumnName("vinculado")
                    .HasComment("Indica si el registro esta o no vinculado a una tabla determinada de la base de datos");
            });

            modelBuilder.Entity<Division>(entity =>
            {
                entity.HasKey(e => e.IdDivision);

                entity.ToTable("Division");

                entity.Property(e => e.IdDivision)
                    .HasColumnName("idDivision")
                    .HasComment("Clave primaria, autoincrementable.Codigo identificador de division.");

                entity.Property(e => e.Curso)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("curso")
                    .HasComment("Curso, año o nombre de grupo. Ejemplo: 1, 2, Educacion fisica mujeres, etc.");

                entity.Property(e => e.DivisionDesc)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("divisionDesc")
                    .HasComment("Descripcion de la division. Ejemplo: A, B, etc.");

                entity.Property(e => e.EsGrupo).HasColumnName("esGrupo");

                entity.Property(e => e.EstaActivo)
                    .IsRequired()
                    .HasColumnName("estaActivo")
                    .HasDefaultValueSql("((1))")
                    .HasComment("Identifica si el registro esta activo.");

                entity.Property(e => e.FechaAlta)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaAlta")
                    .HasComment("Almacena la fecha de alta de la division.");

                entity.Property(e => e.FechaEliminacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaEliminacion")
                    .HasComment("Almacena la fecha de baja de la division.");

                entity.Property(e => e.IdOrganizacionTurno)
                    .HasColumnName("idOrganizacionTurno")
                    .HasComment("Clave foranea de la tabla organizacion-turno");

                entity.Property(e => e.IdPlanUnidad)
                    .HasColumnName("idPlanUnidad")
                    .HasComment("Clave foranea de Plan Unidad");

                entity.HasOne(d => d.IdOrganizacionTurnoNavigation)
                    .WithMany(p => p.Divisions)
                    .HasForeignKey(d => d.IdOrganizacionTurno)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Division_OrganizacionTurno");

                entity.HasOne(d => d.IdPlanUnidadNavigation)
                    .WithMany(p => p.Divisions)
                    .HasForeignKey(d => d.IdPlanUnidad)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Division_PlanUnidad");
            });

            modelBuilder.Entity<DivisionAcrear>(entity =>
            {
                entity.HasKey(e => e.IdDivisionAcrear);

                entity.ToTable("DivisionACrear");

                entity.HasComment("Registra las divisiones a crear, solicitidas por los establecimientos educativos en la solicitud de cargos");

                entity.Property(e => e.IdDivisionAcrear)
                    .HasColumnName("idDivisionACrear")
                    .HasComment("Clave primaria, autoincrementable.Codigo identificador de division.");

                entity.Property(e => e.Curso)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("curso")
                    .HasComment("Descripción del curso (año o grupo)");

                entity.Property(e => e.DivisionDesc)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("divisionDesc")
                    .HasComment("Descripcion de la division (sección)");

                entity.Property(e => e.EsGrupo)
                    .HasColumnName("esGrupo")
                    .HasComment("Identifica si la division es un grupo. (1 = SI, 0 = NO)");

                entity.Property(e => e.EstaActivo)
                    .IsRequired()
                    .HasColumnName("estaActivo")
                    .HasDefaultValueSql("((1))")
                    .HasComment("Identifica si el registro esta activo.");

                entity.Property(e => e.FechaAlta)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaAlta")
                    .HasComment("Almacena la fecha de alta de la division.");

                entity.Property(e => e.FechaEliminacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaEliminacion")
                    .HasComment("Almacena la fecha de baja de la division.");

                entity.Property(e => e.IdOrganizacionTurno)
                    .HasColumnName("idOrganizacionTurno")
                    .HasComment("Clave foranea de la tabla organizacion-turno");

                entity.Property(e => e.IdPlanUnidad)
                    .HasColumnName("idPlanUnidad")
                    .HasComment("Clave foranea de Plan Unidad");

                entity.HasOne(d => d.IdOrganizacionTurnoNavigation)
                    .WithMany(p => p.DivisionAcrears)
                    .HasForeignKey(d => d.IdOrganizacionTurno)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DivisionACrear_OrganizacionTurno");

                entity.HasOne(d => d.IdPlanUnidadNavigation)
                    .WithMany(p => p.DivisionAcrears)
                    .HasForeignKey(d => d.IdPlanUnidad)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DivisionACrear_PlanUnidad");
            });

            modelBuilder.Entity<DivisionView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("DivisionView");

                entity.Property(e => e.Curso)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("curso");

                entity.Property(e => e.DivisionDesc)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("divisionDesc");

                entity.Property(e => e.EsGrupo).HasColumnName("esGrupo");

                entity.Property(e => e.EstaActivo).HasColumnName("estaActivo");

                entity.Property(e => e.IdDivision).HasColumnName("idDivision");

                entity.Property(e => e.IdOrganizacionTurno).HasColumnName("idOrganizacionTurno");

                entity.Property(e => e.IdPlanUnidad).HasColumnName("idPlanUnidad");

                entity.Property(e => e.IdTurno).HasColumnName("idTurno");

                entity.Property(e => e.TurnoDesc)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("turnoDesc");
            });

            modelBuilder.Entity<Edificio>(entity =>
            {
                entity.HasKey(e => e.IdEdificio);

                entity.ToTable("Edificio");

                entity.HasComment("Infraestructuras en donde se desempeñan las organizaciones");

                entity.Property(e => e.IdEdificio)
                    .HasColumnName("idEdificio")
                    .HasComment("Clave primaria, autoincrementable. Identificador del edificio.");

                entity.Property(e => e.BarrioDomicilio)
                    .HasMaxLength(40)
                    .HasColumnName("barrioDomicilio")
                    .HasComment("Barrio (domicilio)");

                entity.Property(e => e.CalleDerecha)
                    .HasMaxLength(40)
                    .HasColumnName("calleDerecha")
                    .HasComment("Referencia de domicilio");

                entity.Property(e => e.CalleDomicilio)
                    .HasMaxLength(100)
                    .HasColumnName("calleDomicilio")
                    .HasComment("Domicilio actual donde se encuentra ubicado el edificio.");

                entity.Property(e => e.CalleFondo)
                    .HasMaxLength(40)
                    .HasColumnName("calleFondo")
                    .HasComment("Referencia de domicilio");

                entity.Property(e => e.CalleIzquierda)
                    .HasMaxLength(40)
                    .HasColumnName("calleIzquierda")
                    .HasComment("Referencia de domicilio");

                entity.Property(e => e.Cui)
                    .HasMaxLength(20)
                    .HasColumnName("cui")
                    .HasComment("Codigo unico de infraestructura. Identifica a cada edificio univocamente a nivel nacional.");

                entity.Property(e => e.EdificioDesc)
                    .HasMaxLength(250)
                    .HasColumnName("edificioDesc")
                    .IsFixedLength()
                    .HasComment("Nombre del edificio.");

                entity.Property(e => e.EstaActivo)
                    .IsRequired()
                    .HasColumnName("estaActivo")
                    .HasDefaultValueSql("((1))")
                    .HasComment("Campo para eliminación lógica. Valor 0 es igual a falso, valor 1 es igual a verdadero.");

                entity.Property(e => e.FechaAlta)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaAlta")
                    .HasComment("Fecha en la que se dio de alta el edificio en el sistema.");

                entity.Property(e => e.FechaBaja)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaBaja")
                    .HasComment("Fecha en la que se dio de baja el edificio en el sistema.");

                entity.Property(e => e.FechaConstruccion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaConstruccion")
                    .HasComment("Registra la fecha de construccion del edificio.");

                entity.Property(e => e.Fraccion)
                    .HasMaxLength(40)
                    .HasColumnName("fraccion")
                    .HasComment("Referencia de domicilio");

                entity.Property(e => e.IdEstadoEdificio)
                    .HasColumnName("idEstadoEdificio")
                    .HasComment("Clave foranea de la tabla RefEstadoEdificio. Describe el estado del edificio (bueno, muy bueno, regular, etc.).");

                entity.Property(e => e.IdLocalidad)
                    .HasColumnName("idLocalidad")
                    .HasComment("Clave foranea de la tabla Localidad. Identificador de la localidad a la que pertenece el edificio.");

                entity.Property(e => e.IdTipoEdificio)
                    .HasColumnName("idTipoEdificio")
                    .HasComment("Clave foranea de la tabla RefTipoEdificio, indica el tipo de edificio (escuela, municipio, hospital, etc.)");

                entity.Property(e => e.IdTipoTenencia)
                    .HasColumnName("idTipoTenencia")
                    .HasComment("Clave foranea de la tabla RefTipoTenencia. Describe el tipo de tenencia del edificio (propio, alquilado, cedido, etc.).");

                entity.Property(e => e.NumeroDomicilio)
                    .HasMaxLength(10)
                    .HasColumnName("numeroDomicilio")
                    .HasComment("Numeración del edificio (domicilio)");

                entity.Property(e => e.Radio)
                    .HasMaxLength(40)
                    .HasColumnName("radio")
                    .HasComment("Referencia de domicilio");

                entity.Property(e => e.Referencia)
                    .HasMaxLength(100)
                    .HasColumnName("referencia")
                    .HasComment("Descripción sobre la ubicación del edificio");

                entity.Property(e => e.Superficie)
                    .HasColumnName("superficie")
                    .HasComment("Almacena la superficie total del edificio en metros cuadrados.");

                entity.Property(e => e.SuperficieAulas)
                    .HasColumnName("superficieAulas")
                    .HasComment("Almacena la superficie que ocupan las aulas del edificio en metros cuadrados.");

                entity.Property(e => e.SuperficieCubierta)
                    .HasColumnName("superficieCubierta")
                    .HasComment("Almacena la superficie cubierta del edificio en metros cuadrados.");

                entity.Property(e => e.SuperficieLibre)
                    .HasColumnName("superficieLibre")
                    .HasComment("Almacena la superficie libre del edificio en metros cuadrados.");

                entity.Property(e => e.XLongitud)
                    .HasColumnName("x_longitud")
                    .HasComment("Coordenada geográfica");

                entity.Property(e => e.YLatitud)
                    .HasColumnName("y_latitud")
                    .HasComment("Coordenada geográfica");

                entity.HasOne(d => d.IdEstadoEdificioNavigation)
                    .WithMany(p => p.Edificios)
                    .HasForeignKey(d => d.IdEstadoEdificio)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Edificio_RefEstadoEdificio");

                entity.HasOne(d => d.IdLocalidadNavigation)
                    .WithMany(p => p.Edificios)
                    .HasForeignKey(d => d.IdLocalidad)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Edificio_Localidad");

                entity.HasOne(d => d.IdTipoEdificioNavigation)
                    .WithMany(p => p.Edificios)
                    .HasForeignKey(d => d.IdTipoEdificio)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Edificio_RefTipoEdificio");

                entity.HasOne(d => d.IdTipoTenenciaNavigation)
                    .WithMany(p => p.Edificios)
                    .HasForeignKey(d => d.IdTipoTenencia)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Edificio_RefTipoTenencia");
            });

            modelBuilder.Entity<EdificioOrganizacion>(entity =>
            {
                entity.HasKey(e => e.IdEdificioOrganizacion)
                    .HasName("PK_EdificioOrganizacion_1");

                entity.ToTable("EdificioOrganizacion");

                entity.HasComment("Organizaciones por edificio");

                entity.Property(e => e.IdEdificioOrganizacion).HasColumnName("idEdificioOrganizacion");

                entity.Property(e => e.EstaActivo)
                    .IsRequired()
                    .HasColumnName("estaActivo")
                    .HasDefaultValueSql("((1))")
                    .HasComment("Identifica si el registro esta activo. 0=FALSO y 1=VERDADERO.");

                entity.Property(e => e.FechaAlta)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaAlta")
                    .HasComment("Almacena la fecha de alta del registro.");

                entity.Property(e => e.FechaBaja)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaBaja")
                    .HasComment("Almacena la fecha de desvinculación del agente como responsable");

                entity.Property(e => e.FechaEliminacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaEliminacion")
                    .HasComment("Fecha de eliminación lógica");

                entity.Property(e => e.IdEdificio)
                    .HasColumnName("idEdificio")
                    .HasComment("Clave foranea de la tabla Edificio, forma parte de la clave combinada que identifica la/s organizacion/es que se encuentran en un edificio.");

                entity.Property(e => e.IdHistoriaOrg).HasColumnName("idHistoriaOrg");

                entity.Property(e => e.IdOrganizacion)
                    .HasColumnName("idOrganizacion")
                    .HasComment("Clave foranea de la tabla Organizacion, forma parte de la clave combinada que identifica la/s organizacion/es que se encuentran en un edificio.");

                entity.Property(e => e.Observaciones).HasMaxLength(200);

                entity.HasOne(d => d.IdEdificioNavigation)
                    .WithMany(p => p.EdificioOrganizacions)
                    .HasForeignKey(d => d.IdEdificio)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EdificioOrganizacion_Edificio");

                entity.HasOne(d => d.Id)
                    .WithMany(p => p.EdificioOrganizacions)
                    .HasForeignKey(d => new { d.IdOrganizacion, d.IdHistoriaOrg })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EdificioOrganizacion_Organizacion");
            });

            modelBuilder.Entity<EscNivel2RegionV>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("EscNivel2RegionV");

                entity.Property(e => e.Cue).HasColumnName("cue");

                entity.Property(e => e.EstadoSolicitudDesc)
                    .HasMaxLength(25)
                    .HasColumnName("estadoSolicitudDesc");

                entity.Property(e => e.IdEstadoSolicitud).HasColumnName("idEstadoSolicitud");

                entity.Property(e => e.IdGrupoNivel).HasColumnName("idGrupoNivel");

                entity.Property(e => e.IdHistoriaOrg).HasColumnName("idHistoriaOrg");

                entity.Property(e => e.IdNivelEducativo).HasColumnName("idNivelEducativo");

                entity.Property(e => e.IdOrganizacion).HasColumnName("idOrganizacion");

                entity.Property(e => e.IdOrganizacionNivelEduc).HasColumnName("idOrganizacionNivelEduc");

                entity.Property(e => e.IdRegion).HasColumnName("idRegion");

                entity.Property(e => e.IdSolicitudPlaza).HasColumnName("idSolicitudPlaza");

                entity.Property(e => e.IdTipoSolicitud).HasColumnName("idTipoSolicitud");

                entity.Property(e => e.NivelEducativoDesc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nivelEducativoDesc");

                entity.Property(e => e.OrganizacionDesc)
                    .HasMaxLength(250)
                    .HasColumnName("organizacionDesc");

                entity.Property(e => e.RegionDesc)
                    .HasMaxLength(50)
                    .HasColumnName("regionDesc");
            });

            modelBuilder.Entity<EspacioAsignatura>(entity =>
            {
                entity.HasKey(e => e.IdEspacioAsignatura)
                    .HasName("PK_tb_EspacioAsignatura");

                entity.ToTable("EspacioAsignatura");

                entity.HasComment("Relacion entre espacio curricular y asignatura. Un espacio curricular puede contener a muchas asignaturas y una asignatura puede pertenecer a varios espacios curriculares\r\n");

                entity.Property(e => e.IdEspacioAsignatura)
                    .HasColumnName("idEspacioAsignatura")
                    .HasComment("Clave primaria, autoincrementable. Identificador de la relacion en tre Espacio curricular y la  Asignatura");

                entity.Property(e => e.EstaActivo)
                    .IsRequired()
                    .HasColumnName("estaActivo")
                    .HasDefaultValueSql("((1))")
                    .HasComment("Campo para eliminación lógica. Valor 0 es igual a falso, valor 1 es igual a verdadero");

                entity.Property(e => e.FechaEliminacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaEliminacion")
                    .HasComment("Fecha en la que deja de estar activa la relación en tre el espacio curricular y la asignatura");

                entity.Property(e => e.IdAsignatura)
                    .HasColumnName("idAsignatura")
                    .HasComment("Clave foranea. Identificador de asignatura. Ejemplo: Ingles, Francés");

                entity.Property(e => e.IdEspacioCurricular)
                    .HasColumnName("idEspacioCurricular")
                    .HasComment("Clave foranea. Identificador de espacio curricular. Ejemplo: Lenguas extranjeras");

                entity.HasOne(d => d.IdAsignaturaNavigation)
                    .WithMany(p => p.EspacioAsignaturas)
                    .HasForeignKey(d => d.IdAsignatura)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EspacioAsignatura_RefAsignatura");

                entity.HasOne(d => d.IdEspacioCurricularNavigation)
                    .WithMany(p => p.EspacioAsignaturas)
                    .HasForeignKey(d => d.IdEspacioCurricular)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EspacioAsignatura_EspacioCurricular");
            });

            modelBuilder.Entity<EspacioCurricular>(entity =>
            {
                entity.HasKey(e => e.IdEspacioCurricular);

                entity.ToTable("EspacioCurricular");

                entity.HasComment("Un espacio curricular organiza y articula un conjunto de contenidos seleccionados para ser enseñados y aprendidos en un tiempo institucional determinado. Puede adoptar distintos formatos: asignatura, taller, seminario, laboratorio, proyecto  (idTipoEspacioCurricular) ");

                entity.Property(e => e.IdEspacioCurricular)
                    .HasColumnName("idEspacioCurricular")
                    .HasComment("Clave primaria, autoincrementable. Identificador del espacio que agrupa un conjunto de asignaturas");

                entity.Property(e => e.EspacioCurricularDesc)
                    .HasMaxLength(60)
                    .HasColumnName("espacioCurricularDesc")
                    .HasComment("Nombre del espacio curricular. Ejemplo: Lenguas extranjeras");

                entity.Property(e => e.EstaActivo)
                    .IsRequired()
                    .HasColumnName("estaActivo")
                    .HasDefaultValueSql("((1))")
                    .HasComment("Campo para eliminación lógica. Valor 0 es igual a falso, valor 1 es igual a verdadero");

                entity.Property(e => e.FechaEliminacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaEliminacion")
                    .HasComment("Fecha en la que deja estar activo el espacio curricular");

                entity.Property(e => e.IdTipoEspacioCurricular)
                    .HasColumnName("idTipoEspacioCurricular")
                    .HasComment("Clave foranea. Identificador del tipo de espacio curricular al que pertenece. Ejemplo: Asignatura, taller");

                entity.HasOne(d => d.IdTipoEspacioCurricularNavigation)
                    .WithMany(p => p.EspacioCurriculars)
                    .HasForeignKey(d => d.IdTipoEspacioCurricular)
                    .HasConstraintName("FK_EspacioCurricular_RefTipoEspacioCurricular");
            });

            modelBuilder.Entity<Familium>(entity =>
            {
                entity.HasKey(e => e.IdFamilia);

                entity.HasComment("Datos personales de familiares de alumnos");

                entity.Property(e => e.IdFamilia)
                    .HasColumnName("idFamilia")
                    .HasComment("Clave primaria, autoincrementable. Identificador de familiar");

                entity.Property(e => e.Apellido)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("apellido")
                    .HasComment("Apellido/s del familiar");

                entity.Property(e => e.Celular).HasColumnName("celular");

                entity.Property(e => e.EstaActivo)
                    .IsRequired()
                    .HasColumnName("estaActivo")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.FechaNac)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaNac")
                    .HasComment("Fecha de nacimiento del familiar");

                entity.Property(e => e.IdEstadoCivil)
                    .HasColumnName("idEstadoCivil")
                    .HasComment("Clave foranea. Identificador de estado civil");

                entity.Property(e => e.IdNivelEducativo)
                    .HasColumnName("idNivelEducativo")
                    .HasComment("Clave foranea. Identificador de nivel educativo maximo alcanzado por el familiar. Ejemplo: Secundario; Terciario");

                entity.Property(e => e.IdPaisNacionalidad)
                    .HasColumnName("idPaisNacionalidad")
                    .HasComment("Clave foranea. Identificador de nacionalidad");

                entity.Property(e => e.IdSexo)
                    .HasColumnName("idSexo")
                    .HasComment("Clave foranea. Identificador de genero del familiar");

                entity.Property(e => e.IdTipoDocumento)
                    .HasColumnName("idTipoDocumento")
                    .HasComment("Clave foranea. Identificador de tipo de documento. Ejemplo: DNI, LC");

                entity.Property(e => e.Jubilado)
                    .HasColumnName("jubilado")
                    .HasDefaultValueSql("((0))")
                    .HasComment("Indica si el familiar es jubilado");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nombre")
                    .HasComment("Nombre/s del familiar");

                entity.Property(e => e.NroDocumento)
                    .HasColumnName("nroDocumento")
                    .HasComment("Numero de documento");

                entity.Property(e => e.Pensionado)
                    .HasColumnName("pensionado")
                    .HasDefaultValueSql("((0))")
                    .HasComment("Indica si el familiar es pensionado");

                entity.Property(e => e.PreCuil)
                    .HasColumnName("preCuil")
                    .HasComment("Prefijo de cuil");

                entity.Property(e => e.SufCuil)
                    .HasColumnName("sufCuil")
                    .HasComment("Sufijo de cuil");

                entity.Property(e => e.Telefono)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("telefono")
                    .HasComment("Numero de telefono");

                entity.Property(e => e.Trabaja)
                    .HasColumnName("trabaja")
                    .HasDefaultValueSql("((0))")
                    .HasComment("Indica si el familiar trabaja. Valor 0 igual a falso, valor 1 iguala verdadero");

                entity.Property(e => e.Vive)
                    .HasColumnName("vive")
                    .HasDefaultValueSql("((1))")
                    .HasComment("Indica si el familiar actualmente vive. Valor 0 iguala falso, valor 1 iguala verdadero");

                entity.HasOne(d => d.IdEstadoCivilNavigation)
                    .WithMany(p => p.Familia)
                    .HasForeignKey(d => d.IdEstadoCivil)
                    .HasConstraintName("FK_Familia_RefEstadoCivil");

                entity.HasOne(d => d.IdNivelEducativoNavigation)
                    .WithMany(p => p.Familia)
                    .HasForeignKey(d => d.IdNivelEducativo)
                    .HasConstraintName("FK_Familia_RefNivelEducativo");

                entity.HasOne(d => d.IdPaisNacionalidadNavigation)
                    .WithMany(p => p.Familia)
                    .HasForeignKey(d => d.IdPaisNacionalidad)
                    .HasConstraintName("FK_Familia_RefPaisNacionalidad");

                entity.HasOne(d => d.IdSexoNavigation)
                    .WithMany(p => p.Familia)
                    .HasForeignKey(d => d.IdSexo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Familia_RefSexo");

                entity.HasOne(d => d.IdTipoDocumentoNavigation)
                    .WithMany(p => p.Familia)
                    .HasForeignKey(d => d.IdTipoDocumento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Familia_RefTipoDocumento");
            });

            modelBuilder.Entity<GrupoDivision>(entity =>
            {
                entity.HasKey(e => e.IdGrupoDivision);

                entity.ToTable("GrupoDivision");

                entity.HasComment("Divisiones que pertenecen a determinado grupo de divisiones. Ejemplo: grupo de divisiones, (1A, 1B, 1D) que integran la asignatura de Educacion fisica");

                entity.Property(e => e.IdGrupoDivision)
                    .HasColumnName("idGrupoDivision")
                    .HasComment("Clave primaria, autoincrementable.Codigo identificador de grupo division.");

                entity.Property(e => e.EstaActivo)
                    .IsRequired()
                    .HasColumnName("estaActivo")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.FechaEliminacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaEliminacion");

                entity.Property(e => e.IdDivision)
                    .HasColumnName("idDivision")
                    .HasComment("Identifica cada una de las divisiones asociadas al grupo.");

                entity.Property(e => e.IdDivisionCabecera).HasColumnName("idDivisionCabecera");

                entity.HasOne(d => d.IdDivisionNavigation)
                    .WithMany(p => p.GrupoDivisionIdDivisionNavigations)
                    .HasForeignKey(d => d.IdDivision)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GrupoDivision_Division");

                entity.HasOne(d => d.IdDivisionCabeceraNavigation)
                    .WithMany(p => p.GrupoDivisionIdDivisionCabeceraNavigations)
                    .HasForeignKey(d => d.IdDivisionCabecera)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GrupoDivision_Grupo");
            });

            modelBuilder.Entity<GrupoDivisionView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("GrupoDivisionView");

                entity.Property(e => e.Curso)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("curso");

                entity.Property(e => e.DivisionDesc)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("divisionDesc");

                entity.Property(e => e.EsGrupo).HasColumnName("esGrupo");

                entity.Property(e => e.EstaActivo).HasColumnName("estaActivo");

                entity.Property(e => e.IdDivision).HasColumnName("idDivision");

                entity.Property(e => e.IdDivisionCabecera).HasColumnName("idDivisionCabecera");

                entity.Property(e => e.IdGrupoDivision).HasColumnName("idGrupoDivision");

                entity.Property(e => e.IdHistoriaOrg).HasColumnName("idHistoriaOrg");

                entity.Property(e => e.IdOrganizacion).HasColumnName("idOrganizacion");

                entity.Property(e => e.IdOrganizacionTurno).HasColumnName("idOrganizacionTurno");

                entity.Property(e => e.IdPlanUnidad).HasColumnName("idPlanUnidad");

                entity.Property(e => e.IdTurno).HasColumnName("idTurno");

                entity.Property(e => e.TurnoDesc)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("turnoDesc");
            });

            modelBuilder.Entity<InstrumentoLegal>(entity =>
            {
                entity.HasKey(e => e.IdInstrumentoLegal);

                entity.ToTable("InstrumentoLegal");

                entity.HasComment("Instrumento legal que avala algun movimiento, por ejemplo la designacion de un docente. En esta tabla se registra el numero del insturmento legal, y la descripcion que explica el movimiento.\r\nCada instrumento legal tiene asociado un tipo (idTipoInstrumentoLegal), pueder ser una resolución, disposicion, norma, etc.");

                entity.Property(e => e.IdInstrumentoLegal)
                    .HasColumnName("idInstrumentoLegal")
                    .HasComment("Clave primaria, autoincrementable. Código identificador de Instrumento legal");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(100)
                    .HasColumnName("descripcion")
                    .HasComment("Detalle del instrumento legal");

                entity.Property(e => e.EstaActivo)
                    .IsRequired()
                    .HasColumnName("estaActivo")
                    .HasDefaultValueSql("((1))")
                    .HasComment("Clave para eliminacion logica. Valor 0 es igual a falso, valor 1 es igual a verdadero");

                entity.Property(e => e.FechaEliminacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaEliminacion")
                    .HasComment("Fecha en la que deja de estar activo el instrumento legal");

                entity.Property(e => e.IdTipoInstrumentoLegal)
                    .HasColumnName("idTipoInstrumentoLegal")
                    .HasComment("Clave foranea, identificador de tipo de Instrumento Legal");

                entity.Property(e => e.InstrumentoLegalDesc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("instrumentoLegalDesc")
                    .HasComment("Número de Instrumento legal");

                entity.HasOne(d => d.IdTipoInstrumentoLegalNavigation)
                    .WithMany(p => p.InstrumentoLegals)
                    .HasForeignKey(d => d.IdTipoInstrumentoLegal)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InstrumentoLegal_RefTipoInstrumentoLegal");
            });

            modelBuilder.Entity<InstrumentoLegalAdjunto>(entity =>
            {
                entity.HasKey(e => e.IdAdjunto);

                entity.ToTable("InstrumentoLegalAdjunto");

                entity.Property(e => e.IdAdjunto)
                    .HasColumnName("idAdjunto")
                    .HasComment("Campo clave. Identificador de archivo adjunto.");

                entity.Property(e => e.EstaActivo).HasColumnName("estaActivo");

                entity.Property(e => e.Fecha)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha")
                    .HasComment("Fecha de subida de archivo");

                entity.Property(e => e.FechaEliminacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaEliminacion");

                entity.Property(e => e.GuidArchivo)
                    .HasMaxLength(50)
                    .HasColumnName("guidArchivo")
                    .HasComment("Identificador global unico de archivo");

                entity.Property(e => e.IdInstrumentoLegal)
                    .HasColumnName("idInstrumentoLegal")
                    .HasComment("Clave foranea. Identificador del instrumento legal al que se encuentra asociado el archivo.");

                entity.Property(e => e.NombreArchivo)
                    .HasMaxLength(250)
                    .HasColumnName("nombreArchivo")
                    .HasComment("Nombre del archivo.");

                entity.Property(e => e.Usuario)
                    .HasMaxLength(250)
                    .HasColumnName("usuario")
                    .HasComment("Usuario responsable de subida de archivo");

                entity.HasOne(d => d.IdInstrumentoLegalNavigation)
                    .WithMany(p => p.InstrumentoLegalAdjuntos)
                    .HasForeignKey(d => d.IdInstrumentoLegal)
                    .HasConstraintName("FK_InstrumentoLegalAdjunto_InstrumentoLegal");
            });

            modelBuilder.Entity<LicenciaPorSituacionDeRevistum>(entity =>
            {
                entity.HasKey(e => new { e.IdLicencia, e.IdSituacionRevista });

                entity.Property(e => e.IdLicencia)
                    .HasColumnName("idLicencia")
                    .HasComment("Clave foranea de la tabla Licencia, forma parte de la clave combinada que identifica la licencia y la situacion de revista permitida para esa licencia.");

                entity.Property(e => e.IdSituacionRevista)
                    .HasColumnName("idSituacionRevista")
                    .HasComment("Clave foranea de la tabla RefSituacionRevista, forma parte de la clave combinada que identifica la licencia y la situacion de revista permitida para esa licencia");

                entity.Property(e => e.EstaActivo)
                    .IsRequired()
                    .HasColumnName("estaActivo")
                    .HasDefaultValueSql("((1))")
                    .HasComment("Identifica si el registro esta activo.");

                entity.Property(e => e.FechaAlta)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaAlta")
                    .HasComment("Almacena la fecha de alta de la licencia por situacion de revista.");

                entity.Property(e => e.FechaEliminacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaEliminacion")
                    .HasComment("Almacena la fecha de baja de la licencia por situacion de revista.");

                entity.HasOne(d => d.IdLicenciaNavigation)
                    .WithMany(p => p.LicenciaPorSituacionDeRevista)
                    .HasForeignKey(d => d.IdLicencia)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LicenciaPorSituacionDeRevista_Licencia");

                entity.HasOne(d => d.IdSituacionRevistaNavigation)
                    .WithMany(p => p.LicenciaPorSituacionDeRevista)
                    .HasForeignKey(d => d.IdSituacionRevista)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LicenciaPorSituacionDeRevista_RefSituacionRevista");
            });

            modelBuilder.Entity<LicenciaValidacionLicencium>(entity =>
            {
                entity.HasKey(e => e.IdLicenciaValidacionLicencia);

                entity.Property(e => e.IdLicenciaValidacionLicencia).HasColumnName("idLicenciaValidacionLicencia");

                entity.Property(e => e.EstaActivo)
                    .IsRequired()
                    .HasColumnName("estaActivo")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.FechaEliminacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaEliminacion");

                entity.Property(e => e.IdLicencia).HasColumnName("idLicencia");

                entity.Property(e => e.IdValidacionLicencia).HasColumnName("idValidacionLicencia");

                entity.HasOne(d => d.IdLicenciaNavigation)
                    .WithMany(p => p.LicenciaValidacionLicencia)
                    .HasForeignKey(d => d.IdLicencia)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LicenciaValidacionLicencia_Licencia");

                entity.HasOne(d => d.IdValidacionLicenciaNavigation)
                    .WithMany(p => p.LicenciaValidacionLicencia)
                    .HasForeignKey(d => d.IdValidacionLicencia)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LicenciaValidacionLicencia_RefValidacionLicencia");
            });

            modelBuilder.Entity<LicenciaView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("LicenciaView");

                entity.Property(e => e.Apellido)
                    .HasMaxLength(50)
                    .HasColumnName("apellido");

                entity.Property(e => e.CategoriaLicenciaDesc)
                    .HasMaxLength(50)
                    .HasColumnName("categoriaLicenciaDesc");

                entity.Property(e => e.EstaActivo).HasColumnName("estaActivo");

                entity.Property(e => e.EstaFrenteAlumno).HasColumnName("estaFrenteAlumno");

                entity.Property(e => e.FechaDesde)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaDesde");

                entity.Property(e => e.FechaHasta)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaHasta");

                entity.Property(e => e.GeneraSuplente).HasColumnName("generaSuplente");

                entity.Property(e => e.IdAdicional).HasColumnName("idAdicional");

                entity.Property(e => e.IdExpteCreacion).HasColumnName("idExpteCreacion");

                entity.Property(e => e.IdHistoriaOrg).HasColumnName("idHistoriaOrg");

                entity.Property(e => e.IdInstrumentoLegal).HasColumnName("idInstrumentoLegal");

                entity.Property(e => e.IdMovimiento).HasColumnName("idMovimiento");

                entity.Property(e => e.IdOrganizacion).HasColumnName("idOrganizacion");

                entity.Property(e => e.IdOrganizacionNivelEduc).HasColumnName("idOrganizacionNivelEduc");

                entity.Property(e => e.IdPersona).HasColumnName("idPersona");

                entity.Property(e => e.IdPlaza).HasColumnName("idPlaza");

                entity.Property(e => e.IdPlazaHistoria).HasColumnName("idPlazaHistoria");

                entity.Property(e => e.IdServicio).HasColumnName("idServicio");

                entity.Property(e => e.IdServicioDestino).HasColumnName("idServicioDestino");

                entity.Property(e => e.IdSituacionRevista).HasColumnName("idSituacionRevista");

                entity.Property(e => e.IdSolicitudDetalle).HasColumnName("idSolicitudDetalle");

                entity.Property(e => e.IdSubServicio).HasColumnName("idSubServicio");

                entity.Property(e => e.IdSubServicioVinculado).HasColumnName("idSubServicioVinculado");

                entity.Property(e => e.IdTerminoLectivo).HasColumnName("idTerminoLectivo");

                entity.Property(e => e.IdTipoMovimiento).HasColumnName("idTipoMovimiento");

                entity.Property(e => e.IdTipoServicio).HasColumnName("idTipoServicio");

                entity.Property(e => e.InstrumentoLegalDesc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("instrumentoLegalDesc");

                entity.Property(e => e.MovimientoDesc)
                    .HasMaxLength(100)
                    .HasColumnName("movimientoDesc");

                entity.Property(e => e.NivelEducativoDesc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nivelEducativoDesc");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .HasColumnName("nombre");

                entity.Property(e => e.NumeroArticulo)
                    .HasMaxLength(15)
                    .HasColumnName("numeroArticulo");

                entity.Property(e => e.Observaciones).HasColumnName("observaciones");

                entity.Property(e => e.OrganizacionDesc)
                    .HasMaxLength(250)
                    .HasColumnName("organizacionDesc");

                entity.Property(e => e.Porcentaje).HasColumnName("porcentaje");

                entity.Property(e => e.TieneSuplente).HasColumnName("tieneSuplente");

                entity.Property(e => e.TituloHabilitanteDesc)
                    .HasMaxLength(50)
                    .HasColumnName("tituloHabilitanteDesc");
            });

            modelBuilder.Entity<Licencium>(entity =>
            {
                entity.HasKey(e => e.IdLicencia);

                entity.Property(e => e.IdLicencia)
                    .ValueGeneratedNever()
                    .HasColumnName("idLicencia")
                    .HasComment("Clave primaria, autoincrementable.Codigo identificador de la licencia.");

                entity.Property(e => e.AEjercicioVencido).HasColumnName("aEjercicioVencido");

                entity.Property(e => e.AntiguedadMinimaAnios)
                    .HasColumnName("antiguedadMinimaAnios")
                    .HasComment("Guarda la antiguedad en años que requiere la licencia para poder ser otorgada.");

                entity.Property(e => e.AntiguedadMinimaMeses)
                    .HasColumnName("antiguedadMinimaMeses")
                    .HasComment("Guarda la antiguedad en meses que requiere la licencia para poder ser otorgada.");

                entity.Property(e => e.CantidadPeriodos).HasColumnName("cantidadPeriodos");

                entity.Property(e => e.CuentaIncompatibilidad)
                    .HasColumnName("cuentaIncompatibilidad")
                    .HasComment("Indica si la licencia es tenida en cuenta para la incompatibilidad horaria.  (1 = SI, 0 = NO)");

                entity.Property(e => e.DuracionMaxima)
                    .HasColumnName("duracionMaxima")
                    .HasComment("Almacena la cantidad maxima de dias que permite la licencia.");

                entity.Property(e => e.DuracionMinima)
                    .HasColumnName("duracionMinima")
                    .HasComment("Almacena la cantidad minima de dias que requiere la licencia.");

                entity.Property(e => e.EsAcumulable).HasColumnName("esAcumulable");

                entity.Property(e => e.FechaAlta)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaAlta")
                    .HasComment("Almacena la fecha de alta de la licencia.");

                entity.Property(e => e.IdCategoriaLicencia)
                    .HasColumnName("idCategoriaLicencia")
                    .HasComment("Clave foranea de la tabla RefCategoriaLicencia, guarda la identificacion de la categoria de la licencia.");

                entity.Property(e => e.IdGrupoNivel)
                    .HasColumnName("idGrupoNivel")
                    .HasComment("Nivel educativo agrupado. Ejemplo: Secundario (Secundario, polimodal, EGBIII)");

                entity.Property(e => e.IdInstrumentoLegal)
                    .HasColumnName("idInstrumentoLegal")
                    .HasComment("Clave foranea de la tabla InstrumentoLegal, guarda el inst.legal/ley de creacion de la licencia.");

                entity.Property(e => e.IdTipoGoceHaber)
                    .HasColumnName("idTipoGoceHaber")
                    .HasComment("Clave foranea de la tabla RefTipoGoceHaber, guarda el identificador del tipo de goce de haberes de la licencia.");

                entity.Property(e => e.IdUtcduracion)
                    .HasColumnName("idUTCDuracion")
                    .HasComment("Clave foranea de la tabla RefUnidadTemporalContexto, guarda el tipo de unidad temporal contexto de la duracion minima de dias.");

                entity.Property(e => e.IdUtduracion)
                    .HasColumnName("idUTDuracion")
                    .HasComment("Clave foranea de la tabla RefUnidadTemporal, guarda el tipo de unidad temporal de la duracion minima de dias.");

                entity.Property(e => e.Inciso)
                    .HasMaxLength(10)
                    .HasColumnName("inciso");

                entity.Property(e => e.MaximoDiasEnPeriodo).HasColumnName("maximoDiasEnPeriodo");

                entity.Property(e => e.MaximoPeriodoEnMes).HasColumnName("maximoPeriodoEnMes");

                entity.Property(e => e.NumeroArticulo)
                    .HasMaxLength(15)
                    .HasColumnName("numeroArticulo")
                    .HasComment("Describe el numero de articulo de la licencia, ej.: 12B, 16D, 12-BIS, etc.");

                entity.Property(e => e.PierdePresentismo)
                    .HasColumnName("pierdePresentismo")
                    .HasComment("Indica si la licencia hace que el agente pierda presentismo.  (1 = SI, 0 = NO)");

                entity.Property(e => e.Porcentaje)
                    .HasColumnName("porcentaje")
                    .HasComment("Si es una licencia con goce de haber, indica el porcentaje que le corresponde.  ");

                entity.Property(e => e.RequiereFechaBajaObligatoria)
                    .IsRequired()
                    .HasColumnName("requiereFechaBajaObligatoria")
                    .HasDefaultValueSql("((1))")
                    .HasComment("Indica si la licencia requiere una fecha de baja obligatoria.  (1 = SI, 0 = NO)");

                entity.Property(e => e.TipoControl).HasColumnName("tipoControl");

                entity.HasOne(d => d.IdCategoriaLicenciaNavigation)
                    .WithMany(p => p.Licencia)
                    .HasForeignKey(d => d.IdCategoriaLicencia)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Licencia_RefCategoriaLicencia");

                entity.HasOne(d => d.IdGrupoNivelNavigation)
                    .WithMany(p => p.Licencia)
                    .HasForeignKey(d => d.IdGrupoNivel)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Licencia_RefGrupoNivel");

                entity.HasOne(d => d.IdInstrumentoLegalNavigation)
                    .WithMany(p => p.Licencia)
                    .HasForeignKey(d => d.IdInstrumentoLegal)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Licencia_InstrumentoLegal");

                entity.HasOne(d => d.IdLicenciaNavigation)
                    .WithOne(p => p.Licencium)
                    .HasForeignKey<Licencium>(d => d.IdLicencia)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Licencia_RefMovimiento");

                entity.HasOne(d => d.IdTipoGoceHaberNavigation)
                    .WithMany(p => p.Licencia)
                    .HasForeignKey(d => d.IdTipoGoceHaber)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Licencia_RefTipoGoceHaber");

                entity.HasOne(d => d.IdUtcduracionNavigation)
                    .WithMany(p => p.Licencia)
                    .HasForeignKey(d => d.IdUtcduracion)
                    .HasConstraintName("FK_Licencia_RefUnidadTemporalContexto");

                entity.HasOne(d => d.IdUtduracionNavigation)
                    .WithMany(p => p.Licencia)
                    .HasForeignKey(d => d.IdUtduracion)
                    .HasConstraintName("FK_Licencia_RefUnidadTemporal");
            });

            modelBuilder.Entity<Localidad>(entity =>
            {
                entity.HasKey(e => e.IdLocalidad);

                entity.ToTable("Localidad");

                entity.HasComment("Localidades por departamento");

                entity.Property(e => e.IdLocalidad)
                    .HasColumnName("idLocalidad")
                    .HasComment("Clave primaria, autoincrementable. Identificador de la localidad");

                entity.Property(e => e.CodigoPostal)
                    .HasColumnName("codigoPostal")
                    .HasComment("Codigo postal de la localidad");

                entity.Property(e => e.EstaActivo)
                    .IsRequired()
                    .HasColumnName("estaActivo")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.FechaEliminacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaEliminacion");

                entity.Property(e => e.IdDepartamento)
                    .HasColumnName("idDepartamento")
                    .HasComment("Clave foranea. Identificador del departamento al que pertenece la localidad");

                entity.Property(e => e.LocalidadDesc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("localidadDesc")
                    .HasComment("Nombre de la localidad");

                entity.HasOne(d => d.IdDepartamentoNavigation)
                    .WithMany(p => p.Localidads)
                    .HasForeignKey(d => d.IdDepartamento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Localidad_Departamento");
            });

            modelBuilder.Entity<MenuPlaza>(entity =>
            {
                entity.HasKey(e => e.IdMenu)
                    .HasName("PK_Menu_1");

                entity.ToTable("MenuPlaza");

                entity.HasComment("Menu dinamico de la aplicacion");

                entity.Property(e => e.IdMenu)
                    .HasColumnName("idMenu")
                    .HasComment("Identificador del item que compone el menu");

                entity.Property(e => e.EstaActivo).HasColumnName("estaActivo");

                entity.Property(e => e.FechaEliminacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaEliminacion");

                entity.Property(e => e.IdDetalleTabla).HasColumnName("idDetalleTabla");

                entity.Property(e => e.IdMenuPadre)
                    .HasColumnName("idMenuPadre")
                    .HasComment("Identificador el Item padre del que depende");

                entity.Property(e => e.MenuImagen)
                    .HasMaxLength(50)
                    .HasColumnName("menuImagen")
                    .HasComment("Imagen o icono que se visualizara en el item del menu");

                entity.Property(e => e.MenuNombre)
                    .HasMaxLength(50)
                    .HasColumnName("menuNombre")
                    .HasComment("Descripcion del item de menu que se visualizara");

                entity.Property(e => e.MenuOrden)
                    .HasColumnName("menuOrden")
                    .HasComment("Orden que se visualizara en el menu");

                entity.Property(e => e.MenuPersonalizado).HasColumnName("menuPersonalizado");

                entity.Property(e => e.MenuSeleccionable)
                    .HasColumnName("menuSeleccionable")
                    .HasComment("Valor que se asigna al campo Value cuando se diseña el menu en tiempo real");

                entity.Property(e => e.MenuTabla)
                    .HasMaxLength(50)
                    .HasColumnName("menuTabla")
                    .HasComment("Nombre de la tabla que esta asociado al item del menu");

                entity.Property(e => e.MenuUrl)
                    .HasMaxLength(50)
                    .HasColumnName("menuUrl")
                    .HasComment("Link a la pagina que realizara la accion del item del menu");

                entity.HasOne(d => d.IdDetalleTablaNavigation)
                    .WithMany(p => p.MenuPlazas)
                    .HasForeignKey(d => d.IdDetalleTabla)
                    .HasConstraintName("FK_Menu_DetalleTabla");

                entity.HasOne(d => d.IdMenuPadreNavigation)
                    .WithMany(p => p.InverseIdMenuPadreNavigation)
                    .HasForeignKey(d => d.IdMenuPadre)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Menu_Menu");
            });

            modelBuilder.Entity<MigracionOrganizacionCue>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MigracionOrganizacionCUE");

                entity.Property(e => e.IdOrganizacion).HasColumnName("idOrganizacion");

                entity.Property(e => e.Usuario).HasColumnName("usuario");
            });

            modelBuilder.Entity<MigracionOrganizacionCue2>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MigracionOrganizacionCUE2");

                entity.Property(e => e.Cue).HasColumnName("CUE");

                entity.Property(e => e.Usuario)
                    .HasMaxLength(256)
                    .HasColumnName("usuario");
            });

            modelBuilder.Entity<MovimientosPresupuesto>(entity =>
            {
                entity.HasKey(e => e.IdMovimiento)
                    .HasName("PK_Ajustes");

                entity.ToTable("MovimientosPresupuesto");

                entity.HasComment("SIAC. Registra modificaciones en el presupuesto\r\n");

                entity.Property(e => e.IdMovimiento)
                    .HasColumnName("idMovimiento")
                    .HasComment("Identificador de movimiento de itmes de presupuesto");

                entity.Property(e => e.Cantidad)
                    .HasColumnName("cantidad")
                    .HasComment("cantidad que se le añade a la cantidad de cargos registrados al inicio del prespuesto del ejercicio actual");

                entity.Property(e => e.EstaActivo)
                    .IsRequired()
                    .HasColumnName("estaActivo")
                    .HasDefaultValueSql("((1))")
                    .HasComment("Campo para eliminación lógica. Valor 1= verdadero, 0=falso");

                entity.Property(e => e.Fecha)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha")
                    .HasComment("Fecha en la que se realiza el movimiento");

                entity.Property(e => e.FechaEliminacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaEliminacion")
                    .HasComment("fecha en la que deja de estar activo el movimiento");

                entity.Property(e => e.IdInstrumentoLegal)
                    .HasColumnName("idInstrumentoLegal")
                    .HasComment("Identificador del instrumento legal que avala el movimiento sobre el presupuesto");

                entity.Property(e => e.IdMotivoMovimientoPres)
                    .HasColumnName("idMotivoMovimientoPres")
                    .HasComment("Clave foranea. Identificador de Motivo de movimiento, puede ser, presupuesto anual, refuerzo, etc.");

                entity.Property(e => e.IdPresupuesto)
                    .HasColumnName("idPresupuesto")
                    .HasComment("Identificador de itemes de presupuesto");

                entity.Property(e => e.Observacion)
                    .HasMaxLength(300)
                    .HasColumnName("observacion")
                    .HasComment("Descripción detallada del movimiento");
            });

            modelBuilder.Entity<NivelEducativoByIdOrganizacionIdHistoriaOrgView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("NivelEducativoByIdOrganizacionIdHistoriaOrgView");

                entity.Property(e => e.IdGrupoNivel).HasColumnName("idGrupoNivel");

                entity.Property(e => e.IdHistoriaOrg).HasColumnName("idHistoriaOrg");

                entity.Property(e => e.IdNeidGn)
                    .HasMaxLength(61)
                    .IsUnicode(false)
                    .HasColumnName("idNEidGN");

                entity.Property(e => e.IdNivelEducativo).HasColumnName("idNivelEducativo");

                entity.Property(e => e.IdOrganizacion).HasColumnName("idOrganizacion");

                entity.Property(e => e.IdOrganizacionNivelEduc).HasColumnName("idOrganizacionNivelEduc");

                entity.Property(e => e.NivelEducativoDesc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nivelEducativoDesc");
            });

            modelBuilder.Entity<NodosOrg>(entity =>
            {
                entity.HasKey(e => e.IdNodo);

                entity.ToTable("NodosOrg");

                entity.Property(e => e.IdNodo).HasColumnName("idNodo");

                entity.Property(e => e.IdHistoriaOrg).HasColumnName("idHistoriaOrg");

                entity.Property(e => e.IdHistoriaOrgPadre).HasColumnName("idHistoriaOrgPadre");

                entity.Property(e => e.IdOrganizacion).HasColumnName("idOrganizacion");

                entity.Property(e => e.IdOrganizacionPadre).HasColumnName("idOrganizacionPadre");

                entity.Property(e => e.TieneHijo).HasColumnName("tieneHijo");

                entity.HasOne(d => d.Id)
                    .WithMany(p => p.NodosOrgIds)
                    .HasForeignKey(d => new { d.IdOrganizacion, d.IdHistoriaOrg })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NodosOrg_Organizacion");

                entity.HasOne(d => d.IdNavigation)
                    .WithMany(p => p.NodosOrgIdNavigations)
                    .HasForeignKey(d => new { d.IdOrganizacionPadre, d.IdHistoriaOrgPadre })
                    .HasConstraintName("FK_NodosOrg_OrganizacionPadre");
            });

            modelBuilder.Entity<Novedad>(entity =>
            {
                entity.HasKey(e => e.IdNovedad);

                entity.ToTable("Novedad");

                entity.Property(e => e.IdNovedad).HasColumnName("idNovedad");

                entity.Property(e => e.EstaActivo)
                    .IsRequired()
                    .HasColumnName("estaActivo")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.EstaProcesado).HasColumnName("estaProcesado");

                entity.Property(e => e.FechaEliminacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaEliminacion");

                entity.Property(e => e.FechaNovedad)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaNovedad");

                entity.Property(e => e.HoraDesde).HasColumnName("horaDesde");

                entity.Property(e => e.HoraHasta).HasColumnName("horaHasta");

                entity.Property(e => e.IdSubservicio).HasColumnName("idSubservicio");

                entity.Property(e => e.IdTableroPlaza).HasColumnName("idTableroPlaza");

                entity.Property(e => e.IdTipoNovedad).HasColumnName("idTipoNovedad");

                entity.HasOne(d => d.IdSubservicioNavigation)
                    .WithMany(p => p.Novedads)
                    .HasForeignKey(d => d.IdSubservicio)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Novedad_SubServicio");

                entity.HasOne(d => d.IdTableroPlazaNavigation)
                    .WithMany(p => p.Novedads)
                    .HasForeignKey(d => d.IdTableroPlaza)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Novedad_TableroPlaza");

                entity.HasOne(d => d.IdTipoNovedadNavigation)
                    .WithMany(p => p.Novedads)
                    .HasForeignKey(d => d.IdTipoNovedad)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Novedad_RefTipoNovedad");
            });

            modelBuilder.Entity<NovedadView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("NovedadView");

                entity.Property(e => e.Apellido)
                    .HasMaxLength(50)
                    .HasColumnName("apellido");

                entity.Property(e => e.CargoSalarialDesc)
                    .HasMaxLength(100)
                    .HasColumnName("cargoSalarialDesc");

                entity.Property(e => e.ConGoceHaber).HasColumnName("conGoceHaber");

                entity.Property(e => e.Curso)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("curso");

                entity.Property(e => e.DiaDesc)
                    .HasMaxLength(10)
                    .HasColumnName("diaDesc");

                entity.Property(e => e.DivisionDesc)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("divisionDesc");

                entity.Property(e => e.EstaActivo).HasColumnName("estaActivo");

                entity.Property(e => e.EstaProcesado).HasColumnName("estaProcesado");

                entity.Property(e => e.FechaNovedad)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaNovedad");

                entity.Property(e => e.HoraDesde).HasColumnName("horaDesde");

                entity.Property(e => e.HoraDesdeTableroPlaza).HasColumnName("horaDesdeTableroPlaza");

                entity.Property(e => e.HoraHasta).HasColumnName("horaHasta");

                entity.Property(e => e.HoraHastaTableroPlaza).HasColumnName("horaHastaTableroPlaza");

                entity.Property(e => e.IdDiaSemana).HasColumnName("idDiaSemana");

                entity.Property(e => e.IdHistoriaOrg).HasColumnName("idHistoriaOrg");

                entity.Property(e => e.IdNovedad).HasColumnName("idNovedad");

                entity.Property(e => e.IdOrganizacion).HasColumnName("idOrganizacion");

                entity.Property(e => e.IdPersona).HasColumnName("idPersona");

                entity.Property(e => e.IdPlaza).HasColumnName("idPlaza");

                entity.Property(e => e.IdServicio).HasColumnName("idServicio");

                entity.Property(e => e.IdSubservicio).HasColumnName("idSubservicio");

                entity.Property(e => e.IdTableroPlaza).HasColumnName("idTableroPlaza");

                entity.Property(e => e.IdTerminoLectivo).HasColumnName("idTerminoLectivo");

                entity.Property(e => e.IdTipoNovedad).HasColumnName("idTipoNovedad");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .HasColumnName("nombre");

                entity.Property(e => e.SituacionRevistaDesc)
                    .HasMaxLength(25)
                    .HasColumnName("situacionRevistaDesc");

                entity.Property(e => e.TipoNovedadDesc)
                    .HasMaxLength(50)
                    .HasColumnName("tipoNovedadDesc");
            });

            modelBuilder.Entity<NumeracionSolicitud>(entity =>
            {
                entity.HasKey(e => e.IdNumeracion);

                entity.ToTable("NumeracionSolicitud");

                entity.Property(e => e.IdNumeracion).HasColumnName("idNumeracion");

                entity.Property(e => e.EstaActivo)
                    .IsRequired()
                    .HasColumnName("estaActivo")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.FechaEliminacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaEliminacion");

                entity.Property(e => e.IdEjercicio).HasColumnName("idEjercicio");

                entity.Property(e => e.NumeracionDesignacion).HasColumnName("numeracionDesignacion");

                entity.Property(e => e.NumeracionLicencia).HasColumnName("numeracionLicencia");

                entity.Property(e => e.NumeracionSituacionExtraordinaria).HasColumnName("numeracionSituacionExtraordinaria");

                entity.Property(e => e.NumeracionSolicitudPlaza).HasColumnName("numeracionSolicitudPlaza");

                entity.Property(e => e.NumeracionSolicitudTurno).HasColumnName("numeracionSolicitudTurno");

                entity.HasOne(d => d.IdEjercicioNavigation)
                    .WithMany(p => p.NumeracionSolicituds)
                    .HasForeignKey(d => d.IdEjercicio)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NumeracionSolicitud_RefEjercicio");
            });

            modelBuilder.Entity<Organizacion>(entity =>
            {
                entity.HasKey(e => new { e.IdOrganizacion, e.IdHistoriaOrg });

                entity.ToTable("Organizacion");

                entity.HasComment("Entidad organizativa: establecimientos, direcciones, reparticciones, etc.");

                entity.Property(e => e.IdOrganizacion)
                    .HasColumnName("idOrganizacion")
                    .HasComment("Clave primaria, autoincrementable. Identificador de la organizacion");

                entity.Property(e => e.IdHistoriaOrg).HasColumnName("idHistoriaOrg");

                entity.Property(e => e.Anexo)
                    .HasColumnName("anexo")
                    .HasComment("Valor numérico de dos dígitos que identifica un anexo de una organizacion ");

                entity.Property(e => e.CodigoLiquidacion)
                    .HasMaxLength(10)
                    .HasColumnName("codigoLiquidacion");

                entity.Property(e => e.Cue)
                    .HasColumnName("cue")
                    .HasComment("Clave Unica de Establecimiento. Es un numero que identifica a cada una de las escuelas de la Argentina");

                entity.Property(e => e.EmailIntitucional)
                    .HasMaxLength(50)
                    .HasColumnName("emailIntitucional")
                    .HasComment("Direccion de correo electronico");

                entity.Property(e => e.EsArancelado)
                    .HasColumnName("esArancelado")
                    .HasComment("Campo booleano. Indica si la organización es arancelada o no");

                entity.Property(e => e.EsConfesional)
                    .HasColumnName("esConfesional")
                    .HasComment("Campo booleano que indica si es religioso o no.");

                entity.Property(e => e.EsEducacionDiferencial).HasColumnName("esEducacionDiferencial");

                entity.Property(e => e.EsInterna)
                    .HasColumnName("esInterna")
                    .HasComment("Indica si la organización es interna o pertence al ministerio de educación como dependencia.  ");

                entity.Property(e => e.EstaActivo)
                    .IsRequired()
                    .HasColumnName("estaActivo")
                    .HasDefaultValueSql("((1))")
                    .HasComment("Campo para eliminación lógica. Valor 0 es igual a falso, valor 1 es igual a verdadero");

                entity.Property(e => e.EstaChequeada)
                    .HasColumnName("estaChequeada")
                    .HasComment("Campo logico, indica si la organizacion fue chequeada, verficada o no. Valor 0 es igual a falso, valor 1 es igual a verdadero");

                entity.Property(e => e.FechaAlta)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaAlta")
                    .HasComment("Fecha en la que el establecimietno da inicio a su funcionamiento.");

                entity.Property(e => e.FechaBaja)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaBaja")
                    .HasComment("Fecha en la que la organización deja de funcionar");

                entity.Property(e => e.FechaChequeo)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaChequeo");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaCreacion")
                    .HasComment("Fecha de asignación de CUE");

                entity.Property(e => e.FechaEliminacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaEliminacion")
                    .HasComment("Fecha en la que deja de estar activa la organizacion (eliminación lógica)");

                entity.Property(e => e.IdAmbito)
                    .HasColumnName("idAmbito")
                    .HasComment("Clave foranea. Identificador de ambito de la organizacion. Ejemplo: privado, publico");

                entity.Property(e => e.IdCategoriaOrganizacion)
                    .HasColumnName("idCategoriaOrganizacion")
                    .HasComment("Clave foranea. Identificador de la categoria de la organizacion. Ejemplo: Primera categoria, segunda categoria");

                entity.Property(e => e.IdDependenciaFuncional)
                    .HasColumnName("idDependenciaFuncional")
                    .HasComment("Clave autoreferencial. Identificador de la organizacion de la cual depende");

                entity.Property(e => e.IdHistoriaOrgPadre).HasColumnName("idHistoriaOrgPadre");

                entity.Property(e => e.IdJornada)
                    .HasColumnName("idJornada")
                    .HasComment("Clave foranea. Identificador de jornada de la organizacion. Ejemplo Jornada simple, jornada completa");

                entity.Property(e => e.IdModalidadAlimentaria)
                    .HasColumnName("idModalidadAlimentaria")
                    .HasComment("Clave foranea. Identificador de la modalidad alimentaria de un establecimiento. Ej: comedor, merienda seca, albergue");

                entity.Property(e => e.IdOrganizacionPadre).HasColumnName("idOrganizacionPadre");

                entity.Property(e => e.IdRegion)
                    .HasColumnName("idRegion")
                    .HasComment("Clave foranea. Identificador de la region educativa a la que pertenece la organizacion en caso de tratarse de un establecimiento educativo. Ejemplo: Region I, region IV");

                entity.Property(e => e.IdSubvencion)
                    .HasColumnName("idSubvencion")
                    .HasComment("Clave foranea. Identificador de tipo de subvención. Ej: Con subvencion privada, gestion social o sin subvencion");

                entity.Property(e => e.IdTipoEducacion)
                    .HasColumnName("idTipoEducacion")
                    .HasComment("Clave foranea. Identificador del tipo de educacion de la organizacion si es que  se trata de un establecimiento. Ejemplo: especial, comun");

                entity.Property(e => e.IdTipoOrganizacion)
                    .HasColumnName("idTipoOrganizacion")
                    .HasComment("Clave foranea. Identificador de tipo de organizacion. Ejemplo:  Organizacion Educativa, organizacion no educativa, área, secretaría, oficina, etc.");

                entity.Property(e => e.IdTipoPeriodoEscolar)
                    .HasColumnName("idTipoPeriodoEscolar")
                    .HasComment("Periodo escolar de la organizacion: comun, especial y de acuerdo al nivel educativo");

                entity.Property(e => e.IdZona)
                    .HasColumnName("idZona")
                    .HasComment("Clave foranea. Identificador de la zona geografica a la que pertenece. Ejemplo. zona 0, zona 1");

                entity.Property(e => e.NumeroOrganizacion)
                    .HasMaxLength(50)
                    .HasColumnName("numeroOrganizacion")
                    .HasComment("En caso de tratarse de un establecimiento educativo a éste se le asocia un numero identificatorio. Ejemplo: ESCUELA Nº \"65\" JOSE QUINTANA");

                entity.Property(e => e.Observaciones)
                    .HasMaxLength(100)
                    .HasColumnName("observaciones")
                    .HasComment("Observaciones");

                entity.Property(e => e.OrganizacionDesc)
                    .HasMaxLength(250)
                    .HasColumnName("organizacionDesc")
                    .HasComment("Nombre o razon social de la organizacion");

                entity.Property(e => e.ParaGdocs)
                    .HasColumnName("paraGdocs")
                    .HasComment("Indica si la organización es creada para su utilizacion en el Sistema de Expedientes");

                entity.Property(e => e.PorcSubvencion)
                    .HasColumnType("numeric(3, 0)")
                    .HasColumnName("porcSubvencion");

                entity.Property(e => e.Telefono)
                    .HasMaxLength(50)
                    .HasColumnName("telefono")
                    .HasComment("Numero de telefono");

                entity.HasOne(d => d.IdAmbitoNavigation)
                    .WithMany(p => p.Organizacions)
                    .HasForeignKey(d => d.IdAmbito)
                    .HasConstraintName("FK_Organizacion_RefAmbito");

                entity.HasOne(d => d.IdCategoriaOrganizacionNavigation)
                    .WithMany(p => p.Organizacions)
                    .HasForeignKey(d => d.IdCategoriaOrganizacion)
                    .HasConstraintName("FK_Organizacion_RefCategoriaOrganizacion");

                entity.HasOne(d => d.IdDependenciaFuncionalNavigation)
                    .WithMany(p => p.Organizacions)
                    .HasForeignKey(d => d.IdDependenciaFuncional)
                    .HasConstraintName("FK_Organizacion_RefDependenciaFuncional1");

                entity.HasOne(d => d.IdJornadaNavigation)
                    .WithMany(p => p.Organizacions)
                    .HasForeignKey(d => d.IdJornada)
                    .HasConstraintName("FK_Organizacion_RefJornada");

                entity.HasOne(d => d.IdModalidadAlimentariaNavigation)
                    .WithMany(p => p.Organizacions)
                    .HasForeignKey(d => d.IdModalidadAlimentaria)
                    .HasConstraintName("FK_Organizacion_RefModalidadAlimentaria");

                entity.HasOne(d => d.IdRegionNavigation)
                    .WithMany(p => p.Organizacions)
                    .HasForeignKey(d => d.IdRegion)
                    .HasConstraintName("FK_Organizacion_RefRegion");

                entity.HasOne(d => d.IdSubvencionNavigation)
                    .WithMany(p => p.Organizacions)
                    .HasForeignKey(d => d.IdSubvencion)
                    .HasConstraintName("FK_Organizacion_RefSubvencion");

                entity.HasOne(d => d.IdTipoEducacionNavigation)
                    .WithMany(p => p.Organizacions)
                    .HasForeignKey(d => d.IdTipoEducacion)
                    .HasConstraintName("FK_Organizacion_RefTipoEducacion");

                entity.HasOne(d => d.IdTipoOrganizacionNavigation)
                    .WithMany(p => p.Organizacions)
                    .HasForeignKey(d => d.IdTipoOrganizacion)
                    .HasConstraintName("FK_Organizacion_RefTipoOrganizacion");

                entity.HasOne(d => d.IdTipoPeriodoEscolarNavigation)
                    .WithMany(p => p.Organizacions)
                    .HasForeignKey(d => d.IdTipoPeriodoEscolar)
                    .HasConstraintName("FK_Organizacion_RefTipoPeriodoEscolar");

                entity.HasOne(d => d.IdZonaNavigation)
                    .WithMany(p => p.Organizacions)
                    .HasForeignKey(d => d.IdZona)
                    .HasConstraintName("FK_Organizacion_RefZona");

                entity.HasOne(d => d.Id)
                    .WithMany(p => p.InverseId)
                    .HasForeignKey(d => new { d.IdOrganizacionPadre, d.IdHistoriaOrgPadre })
                    .HasConstraintName("FK_Organizacion_Organizacion");
            });

            modelBuilder.Entity<OrganizacionFinalView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("OrganizacionFinalView");

                entity.Property(e => e.Anexo).HasColumnName("anexo");

                entity.Property(e => e.CodigoLiquidacion)
                    .HasMaxLength(10)
                    .HasColumnName("codigoLiquidacion");

                entity.Property(e => e.Cue).HasColumnName("cue");

                entity.Property(e => e.EmailIntitucional)
                    .HasMaxLength(50)
                    .HasColumnName("emailIntitucional");

                entity.Property(e => e.EsArancelado).HasColumnName("esArancelado");

                entity.Property(e => e.EsConfesional).HasColumnName("esConfesional");

                entity.Property(e => e.EsEducacionDiferencial).HasColumnName("esEducacionDiferencial");

                entity.Property(e => e.EsInterna).HasColumnName("esInterna");

                entity.Property(e => e.EstaActivo).HasColumnName("estaActivo");

                entity.Property(e => e.EstaChequeada).HasColumnName("estaChequeada");

                entity.Property(e => e.FechaAlta)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaAlta");

                entity.Property(e => e.FechaBaja)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaBaja");

                entity.Property(e => e.FechaChequeo)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaChequeo");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaCreacion");

                entity.Property(e => e.FechaEliminacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaEliminacion");

                entity.Property(e => e.IdAmbito).HasColumnName("idAmbito");

                entity.Property(e => e.IdCategoriaOrganizacion).HasColumnName("idCategoriaOrganizacion");

                entity.Property(e => e.IdDependenciaFuncional).HasColumnName("idDependenciaFuncional");

                entity.Property(e => e.IdHistoriaOrg).HasColumnName("idHistoriaOrg");

                entity.Property(e => e.IdJornada).HasColumnName("idJornada");

                entity.Property(e => e.IdModalidadAlimentaria).HasColumnName("idModalidadAlimentaria");

                entity.Property(e => e.IdOrganizacion).HasColumnName("idOrganizacion");

                entity.Property(e => e.IdRegion).HasColumnName("idRegion");

                entity.Property(e => e.IdSubvencion).HasColumnName("idSubvencion");

                entity.Property(e => e.IdTipoEducacion).HasColumnName("idTipoEducacion");

                entity.Property(e => e.IdTipoOrganizacion).HasColumnName("idTipoOrganizacion");

                entity.Property(e => e.IdTipoPeriodoEscolar).HasColumnName("idTipoPeriodoEscolar");

                entity.Property(e => e.IdZona).HasColumnName("idZona");

                entity.Property(e => e.NumeroOrganizacion)
                    .HasMaxLength(50)
                    .HasColumnName("numeroOrganizacion");

                entity.Property(e => e.Observaciones)
                    .HasMaxLength(100)
                    .HasColumnName("observaciones");

                entity.Property(e => e.OrganizacionDesc)
                    .HasMaxLength(250)
                    .HasColumnName("organizacionDesc");

                entity.Property(e => e.ParaGdocs).HasColumnName("paraGdocs");

                entity.Property(e => e.PorcSubvencion)
                    .HasColumnType("numeric(3, 0)")
                    .HasColumnName("porcSubvencion");

                entity.Property(e => e.Telefono)
                    .HasMaxLength(50)
                    .HasColumnName("telefono");
            });

            modelBuilder.Entity<OrganizacionNivelEducativo>(entity =>
            {
                entity.HasKey(e => e.IdOrganizacionNivelEduc);

                entity.ToTable("OrganizacionNivelEducativo");

                entity.Property(e => e.IdOrganizacionNivelEduc).HasColumnName("idOrganizacionNivelEduc");

                entity.Property(e => e.EstaActivo)
                    .IsRequired()
                    .HasColumnName("estaActivo")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.FechaEliminacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaEliminacion");

                entity.Property(e => e.IdHistoriaOrg).HasColumnName("idHistoriaOrg");

                entity.Property(e => e.IdNivelEducativo).HasColumnName("idNivelEducativo");

                entity.Property(e => e.IdOrganizacion).HasColumnName("idOrganizacion");

                entity.HasOne(d => d.IdNivelEducativoNavigation)
                    .WithMany(p => p.OrganizacionNivelEducativos)
                    .HasForeignKey(d => d.IdNivelEducativo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrganizacionNivelEducativo_RefNivelEducativo");

                entity.HasOne(d => d.Id)
                    .WithMany(p => p.OrganizacionNivelEducativos)
                    .HasForeignKey(d => new { d.IdOrganizacion, d.IdHistoriaOrg })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrganizacionNivelEducativo_Organizacion");
            });

            modelBuilder.Entity<OrganizacionResponsable>(entity =>
            {
                entity.HasKey(e => e.IdOrganizacionResponsable)
                    .HasName("PK_OrganizacionResponsable_1");

                entity.ToTable("OrganizacionResponsable");

                entity.Property(e => e.IdOrganizacionResponsable).HasColumnName("idOrganizacionResponsable");

                entity.Property(e => e.EstaActivo)
                    .IsRequired()
                    .HasColumnName("estaActivo")
                    .HasDefaultValueSql("((1))")
                    .HasComment("Campo para eliminación lógica");

                entity.Property(e => e.FechaAlta)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaAlta")
                    .HasComment("Fecha en la que se registra el agente resposable de la organizacion");

                entity.Property(e => e.FechaBaja)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaBaja")
                    .HasComment("Fecha en la que el agente deja de ser responsable de la organizacion");

                entity.Property(e => e.FechaEliminacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaEliminacion")
                    .HasComment("Fecha de la eliminaicón lógica");

                entity.Property(e => e.IdHistoriaOrg).HasColumnName("idHistoriaOrg");

                entity.Property(e => e.IdInstrumentoLegal)
                    .HasColumnName("idInstrumentoLegal")
                    .HasComment("Instrumento legal de designación");

                entity.Property(e => e.IdOrganizacion)
                    .HasColumnName("idOrganizacion")
                    .HasComment("Parte de la clave");

                entity.Property(e => e.IdPersona).HasColumnName("idPersona");

                entity.HasOne(d => d.IdInstrumentoLegalNavigation)
                    .WithMany(p => p.OrganizacionResponsables)
                    .HasForeignKey(d => d.IdInstrumentoLegal)
                    .HasConstraintName("FK_OrganizacionResponsable_InstrumentoLegal");

                entity.HasOne(d => d.IdPersonaNavigation)
                    .WithMany(p => p.OrganizacionResponsables)
                    .HasForeignKey(d => d.IdPersona)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrganizacionResponsable_Agente");

                entity.HasOne(d => d.Id)
                    .WithMany(p => p.OrganizacionResponsables)
                    .HasForeignKey(d => new { d.IdOrganizacion, d.IdHistoriaOrg })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrganizacionResponsable_Organizacion");
            });

            modelBuilder.Entity<OrganizacionTurno>(entity =>
            {
                entity.HasKey(e => e.IdOrganizacionTurno);

                entity.ToTable("OrganizacionTurno");

                entity.HasComment("Turnos en los que la organización desarrolla sus actividades. Ejemplo Escuela con turno mañana y tarde");

                entity.Property(e => e.IdOrganizacionTurno)
                    .HasColumnName("idOrganizacionTurno")
                    .HasComment("Clave primaria, autoincrementable.Codigo identificador de la tabla Organizacion Turno.");

                entity.Property(e => e.EstaActivo)
                    .IsRequired()
                    .HasColumnName("estaActivo")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.FechaEliminacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaEliminacion");

                entity.Property(e => e.IdHistoriaOrg).HasColumnName("idHistoriaOrg");

                entity.Property(e => e.IdOrganizacion)
                    .HasColumnName("idOrganizacion")
                    .HasComment("Clave foranea de la tabla Organizacion");

                entity.Property(e => e.IdTurno)
                    .HasColumnName("idTurno")
                    .HasComment("Clave Foranea de la tabla Turno.");

                entity.HasOne(d => d.IdTurnoNavigation)
                    .WithMany(p => p.OrganizacionTurnos)
                    .HasForeignKey(d => d.IdTurno)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrganizacionTurno_RefTurno");

                entity.HasOne(d => d.Id)
                    .WithMany(p => p.OrganizacionTurnos)
                    .HasForeignKey(d => new { d.IdOrganizacion, d.IdHistoriaOrg })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrganizacionTurno_Organizacion");
            });

            modelBuilder.Entity<OrganizacionTurnoView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("OrganizacionTurnoView");

                entity.Property(e => e.EstaActivo).HasColumnName("estaActivo");

                entity.Property(e => e.FechaEliminacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaEliminacion");

                entity.Property(e => e.IdHistoriaOrg).HasColumnName("idHistoriaOrg");

                entity.Property(e => e.IdOrganizacion).HasColumnName("idOrganizacion");

                entity.Property(e => e.IdOrganizacionTurno).HasColumnName("idOrganizacionTurno");

                entity.Property(e => e.IdTurno).HasColumnName("idTurno");

                entity.Property(e => e.TurnoDesc)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("turnoDesc");
            });

            modelBuilder.Entity<OrganizacionUsuarioOrganizacionView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("OrganizacionUsuarioOrganizacionView");

                entity.Property(e => e.Anexo).HasColumnName("anexo");

                entity.Property(e => e.CodigoLiquidacion)
                    .HasMaxLength(10)
                    .HasColumnName("codigoLiquidacion");

                entity.Property(e => e.Cue).HasColumnName("cue");

                entity.Property(e => e.EmailIntitucional)
                    .HasMaxLength(50)
                    .HasColumnName("emailIntitucional");

                entity.Property(e => e.EsArancelado).HasColumnName("esArancelado");

                entity.Property(e => e.EsConfesional).HasColumnName("esConfesional");

                entity.Property(e => e.EsEducacionDiferencial).HasColumnName("esEducacionDiferencial");

                entity.Property(e => e.EsInterna).HasColumnName("esInterna");

                entity.Property(e => e.EstaActivo).HasColumnName("estaActivo");

                entity.Property(e => e.EstaChequeada).HasColumnName("estaChequeada");

                entity.Property(e => e.FechaAlta)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaAlta");

                entity.Property(e => e.FechaBaja)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaBaja");

                entity.Property(e => e.FechaChequeo)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaChequeo");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaCreacion");

                entity.Property(e => e.FechaEliminacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaEliminacion");

                entity.Property(e => e.IdAmbito).HasColumnName("idAmbito");

                entity.Property(e => e.IdCategoriaOrganizacion).HasColumnName("idCategoriaOrganizacion");

                entity.Property(e => e.IdDependenciaFuncional).HasColumnName("idDependenciaFuncional");

                entity.Property(e => e.IdHistoriaOrg).HasColumnName("idHistoriaOrg");

                entity.Property(e => e.IdJornada).HasColumnName("idJornada");

                entity.Property(e => e.IdModalidadAlimentaria).HasColumnName("idModalidadAlimentaria");

                entity.Property(e => e.IdOrganizacion).HasColumnName("idOrganizacion");

                entity.Property(e => e.IdRegion).HasColumnName("idRegion");

                entity.Property(e => e.IdSubvencion).HasColumnName("idSubvencion");

                entity.Property(e => e.IdTipoEducacion).HasColumnName("idTipoEducacion");

                entity.Property(e => e.IdTipoOrganizacion).HasColumnName("idTipoOrganizacion");

                entity.Property(e => e.IdTipoPeriodoEscolar).HasColumnName("idTipoPeriodoEscolar");

                entity.Property(e => e.IdUsuario).HasColumnName("idUsuario");

                entity.Property(e => e.IdZona).HasColumnName("idZona");

                entity.Property(e => e.NumeroOrganizacion)
                    .HasMaxLength(50)
                    .HasColumnName("numeroOrganizacion");

                entity.Property(e => e.Observaciones)
                    .HasMaxLength(100)
                    .HasColumnName("observaciones");

                entity.Property(e => e.OrganizacionDesc)
                    .HasMaxLength(250)
                    .HasColumnName("organizacionDesc");

                entity.Property(e => e.ParaGdocs).HasColumnName("paraGdocs");

                entity.Property(e => e.PorcSubvencion)
                    .HasColumnType("numeric(3, 0)")
                    .HasColumnName("porcSubvencion");

                entity.Property(e => e.Telefono)
                    .HasMaxLength(50)
                    .HasColumnName("telefono");
            });

            modelBuilder.Entity<OrganizacionUsuarioView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("OrganizacionUsuarioView");

                entity.Property(e => e.Anexo).HasColumnName("anexo");

                entity.Property(e => e.CodigoLiquidacion)
                    .HasMaxLength(10)
                    .HasColumnName("codigoLiquidacion");

                entity.Property(e => e.Cue).HasColumnName("cue");

                entity.Property(e => e.EmailIntitucional)
                    .HasMaxLength(50)
                    .HasColumnName("emailIntitucional");

                entity.Property(e => e.EsArancelado).HasColumnName("esArancelado");

                entity.Property(e => e.EsConfesional).HasColumnName("esConfesional");

                entity.Property(e => e.EsEducacionDiferencial).HasColumnName("esEducacionDiferencial");

                entity.Property(e => e.EsInterna).HasColumnName("esInterna");

                entity.Property(e => e.EstaActivo).HasColumnName("estaActivo");

                entity.Property(e => e.EstaChequeada).HasColumnName("estaChequeada");

                entity.Property(e => e.FechaAlta)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaAlta");

                entity.Property(e => e.FechaBaja)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaBaja");

                entity.Property(e => e.FechaChequeo)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaChequeo");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaCreacion");

                entity.Property(e => e.FechaEliminacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaEliminacion");

                entity.Property(e => e.IdAmbito).HasColumnName("idAmbito");

                entity.Property(e => e.IdCategoriaOrganizacion).HasColumnName("idCategoriaOrganizacion");

                entity.Property(e => e.IdDependenciaFuncional).HasColumnName("idDependenciaFuncional");

                entity.Property(e => e.IdHistoriaOrg).HasColumnName("idHistoriaOrg");

                entity.Property(e => e.IdJornada).HasColumnName("idJornada");

                entity.Property(e => e.IdModalidadAlimentaria).HasColumnName("idModalidadAlimentaria");

                entity.Property(e => e.IdOrganizacion).HasColumnName("idOrganizacion");

                entity.Property(e => e.IdRegion).HasColumnName("idRegion");

                entity.Property(e => e.IdSubvencion).HasColumnName("idSubvencion");

                entity.Property(e => e.IdTipoEducacion).HasColumnName("idTipoEducacion");

                entity.Property(e => e.IdTipoOrganizacion).HasColumnName("idTipoOrganizacion");

                entity.Property(e => e.IdTipoPeriodoEscolar).HasColumnName("idTipoPeriodoEscolar");

                entity.Property(e => e.IdZona).HasColumnName("idZona");

                entity.Property(e => e.NumeroOrganizacion)
                    .HasMaxLength(50)
                    .HasColumnName("numeroOrganizacion");

                entity.Property(e => e.Observaciones)
                    .HasMaxLength(100)
                    .HasColumnName("observaciones");

                entity.Property(e => e.OrganizacionDesc)
                    .HasMaxLength(250)
                    .HasColumnName("organizacionDesc");

                entity.Property(e => e.ParaGdocs).HasColumnName("paraGdocs");

                entity.Property(e => e.PorcSubvencion)
                    .HasColumnType("numeric(3, 0)")
                    .HasColumnName("porcSubvencion");

                entity.Property(e => e.Telefono)
                    .HasMaxLength(50)
                    .HasColumnName("telefono");
            });

            modelBuilder.Entity<OrganizacionView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("OrganizacionView");

                entity.Property(e => e.EstaActivo).HasColumnName("estaActivo");

                entity.Property(e => e.IdHistoriaOrg).HasColumnName("idHistoriaOrg");

                entity.Property(e => e.IdOrganizacion).HasColumnName("idOrganizacion");
            });

            modelBuilder.Entity<OrganizacionxInstrumentoLegal>(entity =>
            {
                entity.HasKey(e => e.IdOrganizacionxInsLegal);

                entity.ToTable("OrganizacionxInstrumentoLegal");

                entity.Property(e => e.IdOrganizacionxInsLegal).HasColumnName("idOrganizacionxInsLegal");

                entity.Property(e => e.EstaActivo)
                    .IsRequired()
                    .HasColumnName("estaActivo")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.FechaEliminacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaEliminacion");

                entity.Property(e => e.IdHistoriaOrg).HasColumnName("idHistoriaOrg");

                entity.Property(e => e.IdInstrumentoLegal).HasColumnName("idInstrumentoLegal");

                entity.Property(e => e.IdOrganizacion).HasColumnName("idOrganizacion");

                entity.Property(e => e.IdTipoEfecto).HasColumnName("idTipoEfecto");

                entity.HasOne(d => d.IdInstrumentoLegalNavigation)
                    .WithMany(p => p.OrganizacionxInstrumentoLegals)
                    .HasForeignKey(d => d.IdInstrumentoLegal)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrganizacionxInstrumentoLegal_InstrumentoLegal");

                entity.HasOne(d => d.IdTipoEfectoNavigation)
                    .WithMany(p => p.OrganizacionxInstrumentoLegals)
                    .HasForeignKey(d => d.IdTipoEfecto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrganizacionxInstrumentoLegal_RefTipoEfectoInstLegal");

                entity.HasOne(d => d.Id)
                    .WithMany(p => p.OrganizacionxInstrumentoLegals)
                    .HasForeignKey(d => new { d.IdOrganizacion, d.IdHistoriaOrg })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrganizacionxInstrumentoLegal_Organizacion");
            });

            modelBuilder.Entity<PaquetePlaza>(entity =>
            {
                entity.HasKey(e => e.IdPaquete);

                entity.ToTable("PaquetePlaza");

                entity.HasComment("Plazas agrupadas por paquetes");

                entity.Property(e => e.IdPaquete)
                    .HasColumnName("idPaquete")
                    .HasComment("Clave primaria, autoincrementable.Codigo identificador de un paquete de plazas.");

                entity.Property(e => e.EstaActivo)
                    .IsRequired()
                    .HasColumnName("estaActivo")
                    .HasDefaultValueSql("((1))")
                    .HasComment("Indica si esta activo (1) o no (0) el motivo de Alta");

                entity.Property(e => e.FechaEliminacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaEliminacion")
                    .HasComment("Fecha en la que deja de estar activo el motivo de baja");

                entity.Property(e => e.IdPlazaCabecera)
                    .HasColumnName("idPlazaCabecera")
                    .HasComment("Clave foranea, identifica a la plaza cabecera del paquete.");

                entity.Property(e => e.IdTipoPaquetePlaza)
                    .HasColumnName("idTipoPaquetePlaza")
                    .HasComment("Clave foranea, identifica el tipo de paquete.");

                entity.HasOne(d => d.IdPlazaCabeceraNavigation)
                    .WithMany(p => p.PaquetePlazas)
                    .HasForeignKey(d => d.IdPlazaCabecera)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PaquetePlaza_Plaza");

                entity.HasOne(d => d.IdTipoPaquetePlazaNavigation)
                    .WithMany(p => p.PaquetePlazas)
                    .HasForeignKey(d => d.IdTipoPaquetePlaza)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PaquetePlaza_RefTipoPaquetePlaza");
            });

            modelBuilder.Entity<PaquetePlazaHistorica>(entity =>
            {
                entity.HasKey(e => e.IdPaquetePlazaHistorica);

                entity.ToTable("PaquetePlazaHistorica");

                entity.HasComment("");

                entity.Property(e => e.IdPaquetePlazaHistorica)
                    .HasColumnName("idPaquetePlazaHistorica")
                    .HasComment("Primary key");

                entity.Property(e => e.EstaActivo).HasColumnName("estaActivo");

                entity.Property(e => e.FechaAlta)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaAlta");

                entity.Property(e => e.FechaBaja)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaBaja");

                entity.Property(e => e.IdMotivoBaja)
                    .HasColumnName("idMotivoBaja")
                    .HasComment("Link to RefMotivoBaja table");

                entity.Property(e => e.IdPaquete).HasColumnName("idPaquete");

                entity.Property(e => e.IdPlazaCabecera).HasColumnName("idPlazaCabecera");

                entity.Property(e => e.IdTipoPaquetePlaza).HasColumnName("idTipoPaquetePlaza");

                entity.HasOne(d => d.IdMotivoBajaNavigation)
                    .WithMany(p => p.PaquetePlazaHistoricas)
                    .HasForeignKey(d => d.IdMotivoBaja)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PaquetePlazaHistorica_RefMotivoBaja");
            });

            modelBuilder.Entity<PartidaView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("PartidaView");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("codigo");

                entity.Property(e => e.IdCuenta).HasColumnName("idCuenta");

                entity.Property(e => e.IdEjercicio).HasColumnName("idEjercicio");

                entity.Property(e => e.IdFinalidadxEjer).HasColumnName("idFinalidadxEjer");

                entity.Property(e => e.IdFuncionxEjer).HasColumnName("idFuncionxEjer");

                entity.Property(e => e.IdPartida).HasColumnName("idPartida");

                entity.Property(e => e.IdUdeOxEjer).HasColumnName("idUdeOxEjer");

                entity.Property(e => e.ImportePartida)
                    .HasColumnType("numeric(16, 4)")
                    .HasColumnName("importePartida");

                entity.Property(e => e.Partida)
                    .HasMaxLength(100)
                    .HasColumnName("partida");
            });

            modelBuilder.Entity<Partidum>(entity =>
            {
                entity.HasKey(e => e.IdPartida);

                entity.HasComment("Agrupa finalidad, función, escalafon\r\n");

                entity.Property(e => e.IdPartida).HasColumnName("idPartida");

                entity.Property(e => e.CodigoPartida).HasColumnName("codigoPartida");

                entity.Property(e => e.EstaActivo)
                    .IsRequired()
                    .HasColumnName("estaActivo")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.FechaEliminacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaEliminacion");

                entity.Property(e => e.IdCuenta).HasColumnName("idCuenta");

                entity.Property(e => e.IdEjercicio).HasColumnName("idEjercicio");

                entity.Property(e => e.IdFinalidadxEjer)
                    .HasColumnName("idFinalidadxEjer")
                    .HasComment("Identifica la Finalidad de la Partida");

                entity.Property(e => e.IdFuncionxEjer)
                    .HasColumnName("idFuncionxEjer")
                    .HasComment("Identifica la Funcion de la Partida");

                entity.Property(e => e.IdUdeOxEjer)
                    .HasColumnName("idUdeOxEjer")
                    .HasComment("Identifica el Escalafon de la Partida");

                entity.Property(e => e.ImportePartida)
                    .HasColumnType("numeric(16, 4)")
                    .HasColumnName("importePartida");

                entity.Property(e => e.Partida)
                    .HasMaxLength(100)
                    .HasColumnName("partida");

                entity.HasOne(d => d.IdCuentaNavigation)
                    .WithMany(p => p.Partida)
                    .HasForeignKey(d => d.IdCuenta)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Partida_RefCuentas");

                entity.HasOne(d => d.IdEjercicioNavigation)
                    .WithMany(p => p.Partida)
                    .HasForeignKey(d => d.IdEjercicio)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Partida_RefEjercicio");

                entity.HasOne(d => d.IdFinalidadxEjerNavigation)
                    .WithMany(p => p.Partida)
                    .HasForeignKey(d => d.IdFinalidadxEjer)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Partida_RefFinalidadxEjer");

                entity.HasOne(d => d.IdFuncionxEjerNavigation)
                    .WithMany(p => p.Partida)
                    .HasForeignKey(d => d.IdFuncionxEjer)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Partida_RefFuncionxEjer");

                entity.HasOne(d => d.IdUdeOxEjerNavigation)
                    .WithMany(p => p.Partida)
                    .HasForeignKey(d => d.IdUdeOxEjer)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Partida_RefUdeOxEjer");
            });

            modelBuilder.Entity<PerSumarioOrganizacion>(entity =>
            {
                entity.HasKey(e => e.IdPerSumarioOrganizacion);

                entity.ToTable("PerSumarioOrganizacion");

                entity.Property(e => e.IdPerSumarioOrganizacion).HasColumnName("idPerSumarioOrganizacion");

                entity.Property(e => e.EstaActivo)
                    .IsRequired()
                    .HasColumnName("estaActivo")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.FechaEliminaicon)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaEliminaicon");

                entity.Property(e => e.IdHistoriaOrg).HasColumnName("idHistoriaOrg");

                entity.Property(e => e.IdOrganizacion).HasColumnName("idOrganizacion");

                entity.Property(e => e.IdPersonaSumario).HasColumnName("idPersonaSumario");

                entity.HasOne(d => d.IdPersonaSumarioNavigation)
                    .WithMany(p => p.PerSumarioOrganizacions)
                    .HasForeignKey(d => d.IdPersonaSumario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PerSumarioOrganizacion_PersonaSumario");

                entity.HasOne(d => d.Id)
                    .WithMany(p => p.PerSumarioOrganizacions)
                    .HasForeignKey(d => new { d.IdOrganizacion, d.IdHistoriaOrg })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PerSumarioOrganizacion_Organizacion");
            });

            modelBuilder.Entity<PermisoRol>(entity =>
            {
                entity.HasKey(e => e.IdPermisoRol);

                entity.ToTable("PermisoRol");

                entity.Property(e => e.IdPermisoRol)
                    .HasColumnName("idPermisoRol")
                    .HasComment("Clave primaria, autoincrementable. Identificador de la relacion entre RefPermiso y RefRol.");

                entity.Property(e => e.EstaActivo)
                    .IsRequired()
                    .HasColumnName("estaActivo")
                    .HasDefaultValueSql("((1))")
                    .HasComment("Campo para eliminación lógica. Valor 0 = Falso, Valor 1 = Verdadero.");

                entity.Property(e => e.FechaAlta)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaAlta")
                    .HasComment("Fecha de alta.");

                entity.Property(e => e.FechaEliminacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaEliminacion")
                    .HasComment("Fecha de baja, modifica el estado del campo estaActivo.");

                entity.Property(e => e.IdPermiso)
                    .HasColumnName("idPermiso")
                    .HasComment("Clave foranea. Identificador de permiso. Ejemplo: crear expediente, enviar expediente.");

                entity.Property(e => e.IdPermisoRel).HasColumnName("idPermisoRel");

                entity.Property(e => e.IdRol)
                    .HasColumnName("idRol")
                    .HasComment("Clave foranea. Identificador de rol. Ejemplo: administrador.");

                entity.HasOne(d => d.IdRolNavigation)
                    .WithMany(p => p.PermisoRols)
                    .HasForeignKey(d => d.IdRol)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PermisoRol_RefRol");

                entity.HasOne(d => d.IdPermisoNavigation)
                    .WithMany(p => p.PermisoRols)
                    .HasForeignKey(d => new { d.IdPermiso, d.IdPermisoRel })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PermisoRol_RefPermiso");
            });

            modelBuilder.Entity<PermutaServicio>(entity =>
            {
                entity.HasKey(e => e.IdPermutaServicio);

                entity.Property(e => e.IdPermutaServicio).HasColumnName("idPermutaServicio");

                entity.Property(e => e.EstaActivo)
                    .IsRequired()
                    .HasColumnName("estaActivo")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.FechaEliminacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaEliminacion");

                entity.Property(e => e.IdPermuta).HasColumnName("idPermuta");

                entity.Property(e => e.IdServicioDestino).HasColumnName("idServicioDestino");

                entity.Property(e => e.IdServicioOrigen).HasColumnName("idServicioOrigen");

                entity.HasOne(d => d.IdPermutaNavigation)
                    .WithMany(p => p.PermutaServicios)
                    .HasForeignKey(d => d.IdPermuta)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PermutaServicios_Permuta");

                entity.HasOne(d => d.IdServicioDestinoNavigation)
                    .WithMany(p => p.PermutaServicioIdServicioDestinoNavigations)
                    .HasForeignKey(d => d.IdServicioDestino)
                    .HasConstraintName("FK_PermutaServicios_ServicioDestino");

                entity.HasOne(d => d.IdServicioOrigenNavigation)
                    .WithMany(p => p.PermutaServicioIdServicioOrigenNavigations)
                    .HasForeignKey(d => d.IdServicioOrigen)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PermutaServicios_ServicioOrigen");
            });

            modelBuilder.Entity<Permutum>(entity =>
            {
                entity.HasKey(e => e.IdPermuta);

                entity.Property(e => e.IdPermuta).HasColumnName("idPermuta");

                entity.Property(e => e.EsDefinitiva).HasColumnName("esDefinitiva");

                entity.Property(e => e.EstaActivo)
                    .IsRequired()
                    .HasColumnName("estaActivo")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.EstaFinalizada).HasColumnName("estaFinalizada");

                entity.Property(e => e.FechaDesde)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaDesde");

                entity.Property(e => e.FechaEliminacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaEliminacion");

                entity.Property(e => e.FechaHasta)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaHasta");

                entity.Property(e => e.IdExpteCreacion).HasColumnName("idExpteCreacion");

                entity.Property(e => e.IdHistoriaOrgA).HasColumnName("idHistoriaOrgA");

                entity.Property(e => e.IdHistoriaOrgB).HasColumnName("idHistoriaOrgB");

                entity.Property(e => e.IdInstrumentoLegal).HasColumnName("idInstrumentoLegal");

                entity.Property(e => e.IdOrgNivelEducativoA).HasColumnName("idOrgNivelEducativoA");

                entity.Property(e => e.IdOrgNivelEducativoB).HasColumnName("idOrgNivelEducativoB");

                entity.Property(e => e.IdOrganizacionA).HasColumnName("idOrganizacionA");

                entity.Property(e => e.IdOrganizacionB).HasColumnName("idOrganizacionB");

                entity.Property(e => e.IdPersonaA).HasColumnName("idPersonaA");

                entity.Property(e => e.IdPersonaB).HasColumnName("idPersonaB");

                entity.Property(e => e.IdTerminoLectivo).HasColumnName("idTerminoLectivo");

                entity.HasOne(d => d.IdInstrumentoLegalNavigation)
                    .WithMany(p => p.Permuta)
                    .HasForeignKey(d => d.IdInstrumentoLegal)
                    .HasConstraintName("FK_Permuta_InstrumentoLegal");

                entity.HasOne(d => d.IdOrgNivelEducativoANavigation)
                    .WithMany(p => p.PermutumIdOrgNivelEducativoANavigations)
                    .HasForeignKey(d => d.IdOrgNivelEducativoA)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Permuta_OrganizacionNivelEducativoA");

                entity.HasOne(d => d.IdOrgNivelEducativoBNavigation)
                    .WithMany(p => p.PermutumIdOrgNivelEducativoBNavigations)
                    .HasForeignKey(d => d.IdOrgNivelEducativoB)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Permuta_OrganizacionNivelEducativoB");

                entity.HasOne(d => d.IdPersonaANavigation)
                    .WithMany(p => p.PermutumIdPersonaANavigations)
                    .HasForeignKey(d => d.IdPersonaA)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Permuta_PersonaA");

                entity.HasOne(d => d.IdPersonaBNavigation)
                    .WithMany(p => p.PermutumIdPersonaBNavigations)
                    .HasForeignKey(d => d.IdPersonaB)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Permuta_PersonaB");

                entity.HasOne(d => d.Id)
                    .WithMany(p => p.PermutumIds)
                    .HasForeignKey(d => new { d.IdOrganizacionA, d.IdHistoriaOrgA })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Permuta_OrganizacionA");

                entity.HasOne(d => d.IdNavigation)
                    .WithMany(p => p.PermutumIdNavigations)
                    .HasForeignKey(d => new { d.IdOrganizacionB, d.IdHistoriaOrgB })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Permuta_OrganizacionB");
            });

            modelBuilder.Entity<Persona>(entity =>
            {
                entity.HasKey(e => e.IdPersona);

                entity.ToTable("Persona");

                entity.HasComment("Datos personales");

                entity.Property(e => e.IdPersona)
                    .HasColumnName("idPersona")
                    .HasComment("Clave primaria, autoincrementable.Codigo identificador de persona");

                entity.Property(e => e.AgEsJubilado).HasColumnName("agEsJubilado");

                entity.Property(e => e.AgFechaAlta)
                    .HasColumnType("datetime")
                    .HasColumnName("agFechaAlta");

                entity.Property(e => e.AgFechaBaja)
                    .HasColumnType("datetime")
                    .HasColumnName("agFechaBaja");

                entity.Property(e => e.AgFechaJubilacion)
                    .HasColumnType("datetime")
                    .HasColumnName("agFechaJubilacion");

                entity.Property(e => e.Apellido)
                    .HasMaxLength(50)
                    .HasColumnName("apellido")
                    .HasComment("Apellido de la persona");

                entity.Property(e => e.Cuil)
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("cuil")
                    .HasComment("prefijo del cuil. ej: 27");

                entity.Property(e => e.Documento)
                    .HasColumnName("documento")
                    .HasComment("Numero de documento");

                entity.Property(e => e.DomicilioBarrio)
                    .HasMaxLength(50)
                    .HasColumnName("domicilioBarrio");

                entity.Property(e => e.DomicilioCalle)
                    .HasMaxLength(100)
                    .HasColumnName("domicilioCalle");

                entity.Property(e => e.DomicilioDpto)
                    .HasMaxLength(10)
                    .HasColumnName("domicilioDpto");

                entity.Property(e => e.DomicilioNro)
                    .HasMaxLength(10)
                    .HasColumnName("domicilioNro");

                entity.Property(e => e.DomicilioPiso)
                    .HasMaxLength(10)
                    .HasColumnName("domicilioPiso");

                entity.Property(e => e.EstaActivo)
                    .IsRequired()
                    .HasColumnName("estaActivo")
                    .HasDefaultValueSql("((1))")
                    .HasComment("Campo para eliminación lógica. Valor 0 es igual a falso, valor 1 es igual a verdadero");

                entity.Property(e => e.EstaChequeadoCuil)
                    .HasColumnName("estaChequeadoCuil")
                    .HasComment("Describe si el Cuil del agente esta validado o verificado");

                entity.Property(e => e.EstaVivo).HasColumnName("estaVivo");

                entity.Property(e => e.FechaEliminacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaEliminacion")
                    .HasComment("Fecha en la que se da de baja a la persona");

                entity.Property(e => e.FechaFallecimiento)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaFallecimiento")
                    .HasComment("Fecha de fallecimiento");

                entity.Property(e => e.FechaNacimiento)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaNacimiento")
                    .HasComment("Fecha de nacimiento de la persona");

                entity.Property(e => e.IdEstadoCivil)
                    .HasColumnName("idEstadoCivil")
                    .HasComment("Estado civil");

                entity.Property(e => e.IdLocalidad)
                    .HasColumnName("idLocalidad")
                    .HasComment("Clave foranea, localidad");

                entity.Property(e => e.IdLocalidadNacimiento).HasColumnName("idLocalidadNacimiento");

                entity.Property(e => e.IdNivelEducativo)
                    .HasColumnName("idNivelEducativo")
                    .HasComment("Nivel Académico. Ej: 1. Primario; 2. Secundario, etc.");

                entity.Property(e => e.IdPaisNacionalidad)
                    .HasColumnName("idPaisNacionalidad")
                    .HasComment("Nacionalidad");

                entity.Property(e => e.IdSexo)
                    .HasColumnName("idSexo")
                    .HasComment("Sexo Femenino=F; Masculino=M");

                entity.Property(e => e.IdTipoDocumento)
                    .HasColumnName("idTipoDocumento")
                    .HasComment("Tipo de documento. Ej: 1. DNI, 2. L.C.");

                entity.Property(e => e.Mail)
                    .HasMaxLength(50)
                    .HasColumnName("mail")
                    .HasComment("Dirección de correo electrónico");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .HasColumnName("nombre")
                    .HasComment("Nombre/s de la persona");

                entity.Property(e => e.Observaciones)
                    .HasMaxLength(200)
                    .HasColumnName("observaciones");

                entity.Property(e => e.Telefono)
                    .HasMaxLength(20)
                    .HasColumnName("telefono")
                    .HasComment("Telefono ");

                entity.HasOne(d => d.IdEstadoCivilNavigation)
                    .WithMany(p => p.Personas)
                    .HasForeignKey(d => d.IdEstadoCivil)
                    .HasConstraintName("FK_Persona_RefEstadoCivil");

                entity.HasOne(d => d.IdLocalidadNavigation)
                    .WithMany(p => p.PersonaIdLocalidadNavigations)
                    .HasForeignKey(d => d.IdLocalidad)
                    .HasConstraintName("FK_Persona_Localidad");

                entity.HasOne(d => d.IdLocalidadNacimientoNavigation)
                    .WithMany(p => p.PersonaIdLocalidadNacimientoNavigations)
                    .HasForeignKey(d => d.IdLocalidadNacimiento)
                    .HasConstraintName("FK_Persona_Localidad1");

                entity.HasOne(d => d.IdNivelEducativoNavigation)
                    .WithMany(p => p.Personas)
                    .HasForeignKey(d => d.IdNivelEducativo)
                    .HasConstraintName("FK_Persona_RefNivelEducativo");

                entity.HasOne(d => d.IdPaisNacionalidadNavigation)
                    .WithMany(p => p.Personas)
                    .HasForeignKey(d => d.IdPaisNacionalidad)
                    .HasConstraintName("FK_Persona_RefPaisNacionalidad");

                entity.HasOne(d => d.IdSexoNavigation)
                    .WithMany(p => p.Personas)
                    .HasForeignKey(d => d.IdSexo)
                    .HasConstraintName("FK_Persona_RefSexo");

                entity.HasOne(d => d.IdTipoDocumentoNavigation)
                    .WithMany(p => p.Personas)
                    .HasForeignKey(d => d.IdTipoDocumento)
                    .HasConstraintName("FK_Persona_RefTipoDocumento");
            });

            modelBuilder.Entity<PersonaSumario>(entity =>
            {
                entity.HasKey(e => e.IdPersonaSumario);

                entity.ToTable("PersonaSumario");

                entity.Property(e => e.IdPersonaSumario).HasColumnName("idPersonaSumario");

                entity.Property(e => e.AsuntoSumario).HasColumnName("asuntoSumario");

                entity.Property(e => e.EstaActivo)
                    .IsRequired()
                    .HasColumnName("estaActivo")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.EstadoFinalizado).HasColumnName("estadoFinalizado");

                entity.Property(e => e.FechaEliminacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaEliminacion");

                entity.Property(e => e.FechaInicioSumario)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaInicioSumario");

                entity.Property(e => e.IdHistoriaOrgSumariante).HasColumnName("idHistoriaOrgSumariante");

                entity.Property(e => e.IdOrganizacionSumariante).HasColumnName("idOrganizacionSumariante");

                entity.Property(e => e.IdPersona).HasColumnName("idPersona");

                entity.Property(e => e.IdTipoSumario).HasColumnName("idTipoSumario");

                entity.HasOne(d => d.IdPersonaNavigation)
                    .WithMany(p => p.PersonaSumarios)
                    .HasForeignKey(d => d.IdPersona)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PersonaSumario_Persona");

                entity.HasOne(d => d.IdTipoSumarioNavigation)
                    .WithMany(p => p.PersonaSumarios)
                    .HasForeignKey(d => d.IdTipoSumario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PersonaSumario_RefTipoSumario");

                entity.HasOne(d => d.Id)
                    .WithMany(p => p.PersonaSumarios)
                    .HasForeignKey(d => new { d.IdOrganizacionSumariante, d.IdHistoriaOrgSumariante })
                    .HasConstraintName("FK_PersonaSumario_Organizacion");
            });

            modelBuilder.Entity<PersonaSumarioDictaman>(entity =>
            {
                entity.HasKey(e => e.IdPersonaSumarioDictamen);

                entity.Property(e => e.IdPersonaSumarioDictamen)
                    .ValueGeneratedNever()
                    .HasColumnName("idPersonaSumarioDictamen");

                entity.Property(e => e.Cantidad).HasColumnName("cantidad");

                entity.Property(e => e.DescripcionDictamen).HasColumnName("descripcionDictamen");

                entity.Property(e => e.EstaActivo)
                    .IsRequired()
                    .HasColumnName("estaActivo")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.FechaDictamen)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaDictamen");

                entity.Property(e => e.FechaEliminacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaEliminacion");

                entity.Property(e => e.FechaNotificacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaNotificacion");

                entity.Property(e => e.FechaRegistroNotificacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaRegistroNotificacion");

                entity.Property(e => e.IdPersonaSumario).HasColumnName("idPersonaSumario");

                entity.Property(e => e.IdSancion).HasColumnName("idSancion");

                entity.Property(e => e.IdSumarioAlcance).HasColumnName("idSumarioAlcance");

                entity.Property(e => e.IdSumarioEtapa).HasColumnName("idSumarioEtapa");

                entity.Property(e => e.IdTipoDictamen).HasColumnName("idTipoDictamen");

                entity.Property(e => e.IdUnidadTemporal).HasColumnName("idUnidadTemporal");

                entity.HasOne(d => d.IdPersonaSumarioNavigation)
                    .WithMany(p => p.PersonaSumarioDictamen)
                    .HasForeignKey(d => d.IdPersonaSumario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PersonaSumarioDictamen_PersonaSumario");

                entity.HasOne(d => d.IdSancionNavigation)
                    .WithMany(p => p.PersonaSumarioDictamen)
                    .HasForeignKey(d => d.IdSancion)
                    .HasConstraintName("FK_PersonaSumarioDictamen_RefSancion");

                entity.HasOne(d => d.IdSumarioAlcanceNavigation)
                    .WithMany(p => p.PersonaSumarioDictamen)
                    .HasForeignKey(d => d.IdSumarioAlcance)
                    .HasConstraintName("FK_PersonaSumarioDictamen_RefSumarioAlcance");

                entity.HasOne(d => d.IdTipoDictamenNavigation)
                    .WithMany(p => p.PersonaSumarioDictamen)
                    .HasForeignKey(d => d.IdTipoDictamen)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PersonaSumarioDictamen_RefTipoDictamen");

                entity.HasOne(d => d.IdUnidadTemporalNavigation)
                    .WithMany(p => p.PersonaSumarioDictamen)
                    .HasForeignKey(d => d.IdUnidadTemporal)
                    .HasConstraintName("FK_PersonaSumarioDictamen_RefUnidadTemporal");
            });

            modelBuilder.Entity<PersonaSumarioInstLegal>(entity =>
            {
                entity.HasKey(e => e.IdPersonaSumarioIl);

                entity.ToTable("PersonaSumarioInstLegal");

                entity.Property(e => e.IdPersonaSumarioIl).HasColumnName("idPersonaSumarioIL");

                entity.Property(e => e.EsRecurso).HasColumnName("esRecurso");

                entity.Property(e => e.EstaActivo)
                    .IsRequired()
                    .HasColumnName("estaActivo")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.FechaEliminacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaEliminacion");

                entity.Property(e => e.IdExpediente).HasColumnName("idExpediente");

                entity.Property(e => e.IdInstrumentoLegal).HasColumnName("idInstrumentoLegal");

                entity.Property(e => e.IdPersonaSumario).HasColumnName("idPersonaSumario");

                entity.Property(e => e.IdSumarioEtapa).HasColumnName("idSumarioEtapa");

                entity.HasOne(d => d.IdInstrumentoLegalNavigation)
                    .WithMany(p => p.PersonaSumarioInstLegals)
                    .HasForeignKey(d => d.IdInstrumentoLegal)
                    .HasConstraintName("FK_PersonaSumarioInstLegal_InstrumentoLegal");

                entity.HasOne(d => d.IdPersonaSumarioNavigation)
                    .WithMany(p => p.PersonaSumarioInstLegals)
                    .HasForeignKey(d => d.IdPersonaSumario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PersonaSumarioInstLegal_PersonaSumario");

                entity.HasOne(d => d.IdSumarioEtapaNavigation)
                    .WithMany(p => p.PersonaSumarioInstLegals)
                    .HasForeignKey(d => d.IdSumarioEtapa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PersonaSumarioInstLegal_RefSumarioEtapa");
            });

            modelBuilder.Entity<PersonaTitulo>(entity =>
            {
                entity.HasKey(e => e.IdPersonaTitulo);

                entity.Property(e => e.IdPersonaTitulo).HasColumnName("idPersonaTitulo");

                entity.Property(e => e.EstaActivo).HasColumnName("estaActivo");

                entity.Property(e => e.FechaEliminacion)
                    .HasColumnType("date")
                    .HasColumnName("fechaEliminacion");

                entity.Property(e => e.FechaEmision)
                    .HasColumnType("date")
                    .HasColumnName("fechaEmision");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("date")
                    .HasColumnName("fechaRegistro");

                entity.Property(e => e.IdEntidadOtorgante).HasColumnName("idEntidadOtorgante");

                entity.Property(e => e.IdPersona).HasColumnName("idPersona");

                entity.Property(e => e.IdTitulo).HasColumnName("idTitulo");

                entity.HasOne(d => d.IdEntidadOtorganteNavigation)
                    .WithMany(p => p.PersonaTitulos)
                    .HasForeignKey(d => d.IdEntidadOtorgante)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PersonaTitulos_RefEntidadOtorgante");

                entity.HasOne(d => d.IdPersonaNavigation)
                    .WithMany(p => p.PersonaTitulos)
                    .HasForeignKey(d => d.IdPersona)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PersonaTitulos_Persona");

                entity.HasOne(d => d.IdTituloNavigation)
                    .WithMany(p => p.PersonaTitulos)
                    .HasForeignKey(d => d.IdTitulo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PersonaTitulos_RefTitulo");
            });

            modelBuilder.Entity<PersonaView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("PersonaView");

                entity.Property(e => e.Apellido)
                    .HasMaxLength(50)
                    .HasColumnName("apellido");

                entity.Property(e => e.Cuil)
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("cuil");

                entity.Property(e => e.Documento).HasColumnName("documento");

                entity.Property(e => e.EstaActivo).HasColumnName("estaActivo");

                entity.Property(e => e.EstaVivo).HasColumnName("estaVivo");

                entity.Property(e => e.IdPersona).HasColumnName("idPersona");

                entity.Property(e => e.IdSexo).HasColumnName("idSexo");

                entity.Property(e => e.IdTipoDocumento).HasColumnName("idTipoDocumento");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .HasColumnName("nombre");

                entity.Property(e => e.SexoDesc)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("sexoDesc");

                entity.Property(e => e.TipoDocumentoDesc)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("tipoDocumentoDesc");
            });

            modelBuilder.Entity<PlanAsignatura>(entity =>
            {
                entity.HasKey(e => e.IdPlanAsignatura);

                entity.ToTable("PlanAsignatura");

                entity.Property(e => e.IdPlanAsignatura).HasColumnName("idPlanAsignatura");

                entity.Property(e => e.IdAsignatura).HasColumnName("idAsignatura");

                entity.Property(e => e.IdPlanEspacio).HasColumnName("idPlanEspacio");

                entity.HasOne(d => d.IdAsignaturaNavigation)
                    .WithMany(p => p.PlanAsignaturas)
                    .HasForeignKey(d => d.IdAsignatura)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PlanAsignatura_RefAsignatura");

                entity.HasOne(d => d.IdPlanEspacioNavigation)
                    .WithMany(p => p.PlanAsignaturas)
                    .HasForeignKey(d => d.IdPlanEspacio)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PlanAsignatura_PlanEspacio");
            });

            modelBuilder.Entity<PlanAsignaturaBk>(entity =>
            {
                entity.HasKey(e => e.IdPlanAsignatura);

                entity.ToTable("PlanAsignaturaBK");

                entity.Property(e => e.IdPlanAsignatura).HasColumnName("idPlanAsignatura");

                entity.Property(e => e.IdAsignatura).HasColumnName("idAsignatura");

                entity.Property(e => e.IdPlanEspacio).HasColumnName("idPlanEspacio");
            });

            modelBuilder.Entity<PlanEspacio>(entity =>
            {
                entity.HasKey(e => e.IdPlanEspacio);

                entity.ToTable("PlanEspacio");

                entity.HasComment("Relacion entre plan de estudio y espacio curricular. Un plan de estudio puede contener varios espacios curriculares y un espacio curricular puede pertenecer a varios planes de estudio");

                entity.Property(e => e.IdPlanEspacio)
                    .HasColumnName("idPlanEspacio")
                    .HasComment("Clave primaria, autoincrementable. Identificador de la relacion entre plan de estudioy espacio curricular");

                entity.Property(e => e.Anio)
                    .HasColumnName("anio")
                    .HasComment("Año o grado en donde se dictará el espacio curricular");

                entity.Property(e => e.CargaHoraria)
                    .HasColumnName("cargaHoraria")
                    .HasComment("Cantidad de horas que se dictan para un año y espacio curricular en particular ");

                entity.Property(e => e.EstaActivo)
                    .HasColumnName("estaActivo")
                    .HasDefaultValueSql("((1))")
                    .HasComment("Clave para eliminación lógica. Valor 0 es igual a falso, valor 1 es igual a verdadero");

                entity.Property(e => e.FechaEliminacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaEliminacion")
                    .HasComment("Fecha en la que deja de estar activa la relación entre el plan de estudio y el espacio curricular");

                entity.Property(e => e.IdEspacioCurricular)
                    .HasColumnName("idEspacioCurricular")
                    .HasComment("Clave foranea. Identificador del espacio curricular");

                entity.Property(e => e.IdPlanEstudio)
                    .HasColumnName("idPlanEstudio")
                    .HasComment("Clave foranea. Identificador de plan de estudio");

                entity.Property(e => e.IdRegimen)
                    .HasColumnName("idRegimen")
                    .HasComment("Identificador de régimen de espacio curricular. Ej: Anual, 1er. cuatrimestre, 2do. cuatrimestre");

                entity.Property(e => e.PlanEspacioDesc)
                    .HasMaxLength(200)
                    .HasColumnName("planEspacioDesc");

                entity.HasOne(d => d.IdEspacioCurricularNavigation)
                    .WithMany(p => p.PlanEspacios)
                    .HasForeignKey(d => d.IdEspacioCurricular)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PlanEspacio_EspacioCurricular");

                entity.HasOne(d => d.IdPlanEstudioNavigation)
                    .WithMany(p => p.PlanEspacios)
                    .HasForeignKey(d => d.IdPlanEstudio)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PlanEspacio_PlanEstudio");

                entity.HasOne(d => d.IdRegimenNavigation)
                    .WithMany(p => p.PlanEspacios)
                    .HasForeignKey(d => d.IdRegimen)
                    .HasConstraintName("FK_PlanEspacio_RefRegimenEspCu");
            });

            modelBuilder.Entity<PlanEspacioBk>(entity =>
            {
                entity.HasKey(e => e.IdPlanEspacio)
                    .HasName("PK_PlanEspaciobk");

                entity.ToTable("PlanEspacioBK");

                entity.Property(e => e.IdPlanEspacio).HasColumnName("idPlanEspacio");

                entity.Property(e => e.Anio).HasColumnName("anio");

                entity.Property(e => e.CargaHoraria).HasColumnName("cargaHoraria");

                entity.Property(e => e.EstaActivo).HasColumnName("estaActivo");

                entity.Property(e => e.FechaEliminacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaEliminacion");

                entity.Property(e => e.IdEspacioCurricular).HasColumnName("idEspacioCurricular");

                entity.Property(e => e.IdPlanEstudio).HasColumnName("idPlanEstudio");

                entity.Property(e => e.IdRegimen).HasColumnName("idRegimen");

                entity.Property(e => e.PlanEspacioDesc)
                    .HasMaxLength(200)
                    .HasColumnName("planEspacioDesc");
            });

            modelBuilder.Entity<PlanEspacioCurricular>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("PlanEspacioCurricular");

                entity.Property(e => e.Anio).HasColumnName("anio");

                entity.Property(e => e.CargaHoraria).HasColumnName("cargaHoraria");

                entity.Property(e => e.EspacioCurricularDesc)
                    .HasMaxLength(60)
                    .HasColumnName("espacioCurricularDesc");

                entity.Property(e => e.EstaActivo).HasColumnName("estaActivo");

                entity.Property(e => e.FechaEliminacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaEliminacion");

                entity.Property(e => e.IdEspacioCurricular).HasColumnName("idEspacioCurricular");

                entity.Property(e => e.IdPlanEspacio).HasColumnName("idPlanEspacio");

                entity.Property(e => e.IdPlanEstudio).HasColumnName("idPlanEstudio");

                entity.Property(e => e.IdRegimen).HasColumnName("idRegimen");

                entity.Property(e => e.PlanEspacioDesc)
                    .HasMaxLength(200)
                    .HasColumnName("planEspacioDesc");

                entity.Property(e => e.RegimenDesc)
                    .HasMaxLength(20)
                    .HasColumnName("regimenDesc");
            });

            modelBuilder.Entity<PlanEstudio>(entity =>
            {
                entity.HasKey(e => e.IdPlanEstudio);

                entity.ToTable("PlanEstudio");

                entity.HasComment("Diseño curricular de enseñanza ");

                entity.Property(e => e.IdPlanEstudio)
                    .HasColumnName("idPlanEstudio")
                    .HasComment("Clave primaria, autoincrementable.Codigo identificador de plan de estudio");

                entity.Property(e => e.Duracion)
                    .HasColumnName("duracion")
                    .HasComment("Duración en años del plan de estudio");

                entity.Property(e => e.EstaActivo)
                    .IsRequired()
                    .HasColumnName("estaActivo")
                    .HasDefaultValueSql("((1))")
                    .HasComment("Campo para eliminación lógica");

                entity.Property(e => e.EstaVigente).HasColumnName("estaVigente");

                entity.Property(e => e.FechaEliminacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaEliminacion")
                    .HasComment("Fecha en la que deja de estar activo el registro");

                entity.Property(e => e.IdEspecialidad)
                    .HasColumnName("idEspecialidad")
                    .HasComment("Clave foranea, especialidad del plan de estudio. Ej: computación, orientación docente, electrónica, etc.");

                entity.Property(e => e.IdNivelEducativo).HasColumnName("idNivelEducativo");

                entity.Property(e => e.IdPlanEstudioBase).HasColumnName("idPlanEstudioBase");

                entity.Property(e => e.PlanEstudioDesc)
                    .HasMaxLength(100)
                    .HasColumnName("planEstudioDesc")
                    .HasComment("Nombre del plan de Estudio. Ej: BACHILLER CON ORIENTACION EN COMPUTACION");

                entity.HasOne(d => d.IdEspecialidadNavigation)
                    .WithMany(p => p.PlanEstudios)
                    .HasForeignKey(d => d.IdEspecialidad)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PlanEstudio_RefEspecialidad");

                entity.HasOne(d => d.IdNivelEducativoNavigation)
                    .WithMany(p => p.PlanEstudios)
                    .HasForeignKey(d => d.IdNivelEducativo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PlanEstudio_RefNivelEducativo");

                entity.HasOne(d => d.IdPlanEstudioBaseNavigation)
                    .WithMany(p => p.InverseIdPlanEstudioBaseNavigation)
                    .HasForeignKey(d => d.IdPlanEstudioBase)
                    .HasConstraintName("FK_PlanEstudio_PlanEstudio");
            });

            modelBuilder.Entity<PlanEstudioCohorte>(entity =>
            {
                entity.HasKey(e => e.IdPlanEstudioCohorte)
                    .HasName("PK_OrganizacionInstrumentoLegal");

                entity.ToTable("PlanEstudioCohorte");

                entity.Property(e => e.IdPlanEstudioCohorte).HasColumnName("idPlanEstudioCohorte");

                entity.Property(e => e.EstaActivo)
                    .IsRequired()
                    .HasColumnName("estaActivo")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.FechaDesde)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaDesde");

                entity.Property(e => e.FechaEliminacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaEliminacion");

                entity.Property(e => e.FechaHasta)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaHasta");

                entity.Property(e => e.IdExpte).HasColumnName("idExpte");

                entity.Property(e => e.IdInstrumentoLegal).HasColumnName("idInstrumentoLegal");

                entity.Property(e => e.IdMotivoInsLegal).HasColumnName("idMotivoInsLegal");

                entity.Property(e => e.IdPlanEstudio).HasColumnName("idPlanEstudio");

                entity.HasOne(d => d.IdInstrumentoLegalNavigation)
                    .WithMany(p => p.PlanEstudioCohortes)
                    .HasForeignKey(d => d.IdInstrumentoLegal)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PlanEstudioInstrumentoLegal_InstrumentoLegal");

                entity.HasOne(d => d.IdMotivoInsLegalNavigation)
                    .WithMany(p => p.PlanEstudioCohortes)
                    .HasForeignKey(d => d.IdMotivoInsLegal)
                    .HasConstraintName("FK_PlanEstudioInstrumentoLegal_RefMotivoInstLegal");

                entity.HasOne(d => d.IdPlanEstudioNavigation)
                    .WithMany(p => p.PlanEstudioCohortes)
                    .HasForeignKey(d => d.IdPlanEstudio)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PlanEstudioInstrumentoLegal_PlanEstudio");
            });

            modelBuilder.Entity<PlanUnidad>(entity =>
            {
                entity.HasKey(e => e.IdPlanUnidad);

                entity.ToTable("PlanUnidad");

                entity.HasComment("Relacion entre plan de estudio y la organizacion. Una organización puede tener varios planes de estudio");

                entity.Property(e => e.IdPlanUnidad)
                    .HasColumnName("idPlanUnidad")
                    .HasComment("Clave primaria, autoincrementable. Identificador de plan unidad");

                entity.Property(e => e.EstaActivo)
                    .IsRequired()
                    .HasColumnName("estaActivo")
                    .HasDefaultValueSql("((1))")
                    .HasComment("Campo para eliminación logica");

                entity.Property(e => e.FechaEliminacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaEliminacion")
                    .HasComment("Fecha en la que deja de estar activa la relación entre organización, plan de estudio y nivel de escolaridad");

                entity.Property(e => e.IdOrganizacionNivelEduc)
                    .HasColumnName("idOrganizacionNivelEduc")
                    .HasComment("Clave foranea. Identificador del nivel de escolaridad relacionado");

                entity.Property(e => e.IdPlanEstudioCohorte).HasColumnName("idPlanEstudioCohorte");

                entity.HasOne(d => d.IdOrganizacionNivelEducNavigation)
                    .WithMany(p => p.PlanUnidads)
                    .HasForeignKey(d => d.IdOrganizacionNivelEduc)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PlanUnidad_OrganizacionNivelEducativo");

                entity.HasOne(d => d.IdPlanEstudioCohorteNavigation)
                    .WithMany(p => p.PlanUnidads)
                    .HasForeignKey(d => d.IdPlanEstudioCohorte)
                    .HasConstraintName("FK_PlanUnidad_PlanEstudioCohorte");
            });

            modelBuilder.Entity<PlanUnidadView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("PlanUnidadView");

                entity.Property(e => e.EstaActivo).HasColumnName("estaActivo");

                entity.Property(e => e.IdHistoriaOrg).HasColumnName("idHistoriaOrg");

                entity.Property(e => e.IdNivelEducativo).HasColumnName("idNivelEducativo");

                entity.Property(e => e.IdOrganizacion).HasColumnName("idOrganizacion");

                entity.Property(e => e.IdOrganizacionNivelEduc).HasColumnName("idOrganizacionNivelEduc");

                entity.Property(e => e.IdPlanEstudio).HasColumnName("idPlanEstudio");

                entity.Property(e => e.IdPlanUnidad).HasColumnName("idPlanUnidad");

                entity.Property(e => e.NivelEducativoDesc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nivelEducativoDesc");

                entity.Property(e => e.PlanEstudioDesc)
                    .HasMaxLength(100)
                    .HasColumnName("planEstudioDesc");
            });

            modelBuilder.Entity<PlanillaNovedade>(entity =>
            {
                entity.HasKey(e => e.IdPlanillaNov);

                entity.Property(e => e.IdPlanillaNov).HasColumnName("idPlanillaNov");

                entity.Property(e => e.Año).HasColumnName("año");

                entity.Property(e => e.EstaActivo)
                    .IsRequired()
                    .HasColumnName("estaActivo")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.EstaFinalizada).HasColumnName("estaFinalizada");

                entity.Property(e => e.FechaEliminacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaEliminacion");

                entity.Property(e => e.FechaGeneracion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaGeneracion");

                entity.Property(e => e.IdHistoriaOrg).HasColumnName("idHistoriaOrg");

                entity.Property(e => e.IdOrganizacion).HasColumnName("idOrganizacion");

                entity.Property(e => e.IdOrganizacionNivelEduc).HasColumnName("idOrganizacionNivelEduc");

                entity.Property(e => e.MatriculaMujeres).HasColumnName("matriculaMujeres");

                entity.Property(e => e.MatriculaVarones).HasColumnName("matriculaVarones");

                entity.Property(e => e.Mes).HasColumnName("mes");

                entity.HasOne(d => d.IdOrganizacionNivelEducNavigation)
                    .WithMany(p => p.PlanillaNovedades)
                    .HasForeignKey(d => d.IdOrganizacionNivelEduc)
                    .HasConstraintName("FK_PlanillaNovedades_OrganizacionNivelEducativo");

                entity.HasOne(d => d.MesNavigation)
                    .WithMany(p => p.PlanillaNovedades)
                    .HasForeignKey(d => d.Mes)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PlanillaNovedades_RefMes");

                entity.HasOne(d => d.Id)
                    .WithMany(p => p.PlanillaNovedades)
                    .HasForeignKey(d => new { d.IdOrganizacion, d.IdHistoriaOrg })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PlanillaNovedades_Organizacion");
            });

            modelBuilder.Entity<Plaza>(entity =>
            {
                entity.HasKey(e => e.IdPlaza)
                    .HasName("PK_Plazas");

                entity.ToTable("Plaza");

                entity.HasComment("Plaza o cargo");

                entity.Property(e => e.IdPlaza)
                    .HasColumnName("idPlaza")
                    .HasComment("Es el numero de CUPOF, representa de forma univoca a la plaza");

                entity.Property(e => e.AdmiteSuplente)
                    .IsRequired()
                    .HasColumnName("admiteSuplente")
                    .HasDefaultValueSql("((1))")
                    .HasComment("Clave foranea, identifica si la plaza permite suplentes.");

                entity.Property(e => e.BajaAutomatica).HasColumnName("bajaAutomatica");

                entity.Property(e => e.CantidadHs).HasComment("Almacena la cantidad de horas de la plaza.");

                entity.Property(e => e.CobraIncentivo).HasColumnName("cobraIncentivo");

                entity.Property(e => e.EsCabeceraDePaquete)
                    .HasColumnName("esCabeceraDePaquete")
                    .HasComment("Indica si la plaza es la cabecera de un paquete de plazas. (0=No, 1=Si) ACTUALMENTE NO ESTÁ EN USO");

                entity.Property(e => e.EstaActivo)
                    .IsRequired()
                    .HasColumnName("estaActivo")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaCreacion");

                entity.Property(e => e.FechaEliminacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaEliminacion");

                entity.Property(e => e.FechaHabilitacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaHabilitacion")
                    .HasComment("Fecha de alta de la habilitación presupuestaria de la plaza.");

                entity.Property(e => e.FechaTermino)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaTermino")
                    .HasComment("Fecha de baja de la habilitación presupuestaria de la plaza.");

                entity.Property(e => e.GeneraPresupuesto)
                    .HasColumnName("generaPresupuesto")
                    .HasComment("Indica si la plaza genera gastos. Para un traslado transitorio, este campo podría ser falso.");

                entity.Property(e => e.IdAfectacion)
                    .HasColumnName("idAfectacion")
                    .HasComment("Clave foranea, identificador de afectación presupuestaria, Ej: intra presupuestario, extrapresupuestario");

                entity.Property(e => e.IdCargoFuncional)
                    .HasColumnName("idCargoFuncional")
                    .HasComment("Clave foranea, identifica la funcion a desempeñar en la plaza (tentativa o por defecto).");

                entity.Property(e => e.IdDivision)
                    .HasColumnName("idDivision")
                    .HasComment("Clave foranea, almacena la division actual de la plaza.");

                entity.Property(e => e.IdEducacionDiferencial).HasColumnName("idEducacionDiferencial");

                entity.Property(e => e.IdEstadoPlaza).HasColumnName("idEstadoPlaza");

                entity.Property(e => e.IdExpteCreacion)
                    .HasColumnName("idExpteCreacion")
                    .HasComment("Clave foranea, guarda el expediente de creacion de la plaza.");

                entity.Property(e => e.IdFinanciamiento)
                    .HasColumnName("idFinanciamiento")
                    .HasComment("Clave foranea, identifica el financiamiento prespuestario de la plaza.");

                entity.Property(e => e.IdHistoriaOrg).HasColumnName("idHistoriaOrg");

                entity.Property(e => e.IdInstrumentoLegalBaja)
                    .HasColumnName("idInstrumentoLegalBaja")
                    .HasComment("Clave foranea, guarda el instrumento legal de baja de la plaza.");

                entity.Property(e => e.IdInstrumentoLegalCreacion)
                    .HasColumnName("idInstrumentoLegalCreacion")
                    .HasComment("Clave foranea, guarda el inst.legal de creacion de la plaza.");

                entity.Property(e => e.IdMotivoBaja)
                    .HasColumnName("idMotivoBaja")
                    .HasComment("Motivo de baja. Vinculado con RefMovimiento (tipo motivo: baja)");

                entity.Property(e => e.IdMotivoCreacion)
                    .HasColumnName("idMotivoCreacion")
                    .HasComment("Clave foranea, permite indicar el motivo de creacion de la plaza, POF, NO POF.");

                entity.Property(e => e.IdOrganizacion).HasColumnName("idOrganizacion");

                entity.Property(e => e.IdOrganizacionNivelEduc)
                    .HasColumnName("idOrganizacionNivelEduc")
                    .HasComment("Nivel educativo para el que se crea la plaza");

                entity.Property(e => e.IdOrganizacionTurno).HasColumnName("idOrganizacionTurno");

                entity.Property(e => e.IdPaquete)
                    .HasColumnName("idPaquete")
                    .HasComment("Clave foranea. Si la plaza pertenece a un paquete de plazas, identifica a la plaza cabecera. ACTUALMENTE NO ESTÁ EN USO");

                entity.Property(e => e.IdPlanAsignatura).HasColumnName("idPlanAsignatura");

                entity.Property(e => e.IdRegimenLaboral)
                    .HasColumnName("idRegimenLaboral")
                    .HasComment("Clave foranea, indica si es docente, no docente.");

                entity.Property(e => e.IdRegimenSalarial)
                    .HasColumnName("idRegimenSalarial")
                    .HasComment("Clave foranea, identifica si la plaza esta conformada por Horas o Cargos.");

                entity.Property(e => e.IdSistemaEducativo)
                    .HasColumnName("idSistemaEducativo")
                    .HasComment("Clave foranea, indica si pertenece o no al sistema educativo (ej: cargo por Planes Sociales).");

                entity.Property(e => e.IdSolicitudPlazaDetalle)
                    .HasColumnName("idSolicitudPlazaDetalle")
                    .HasComment("Vincula la solicitud y detalle de la solicitud por la cuál se generó la plaza");

                entity.Property(e => e.IdSubEstadoPlaza).HasColumnName("idSubEstadoPlaza");

                entity.Property(e => e.IdTemporalidad).HasColumnName("idTemporalidad");

                entity.Property(e => e.IdTerminoLectivo).HasColumnName("idTerminoLectivo");

                entity.Property(e => e.Observacion)
                    .HasMaxLength(255)
                    .HasColumnName("observacion")
                    .HasComment("Observaciones de la plaza.");

                entity.HasOne(d => d.IdAfectacionNavigation)
                    .WithMany(p => p.Plazas)
                    .HasForeignKey(d => d.IdAfectacion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Plaza_RefAfectacion");

                entity.HasOne(d => d.IdCargoFuncionalNavigation)
                    .WithMany(p => p.Plazas)
                    .HasForeignKey(d => d.IdCargoFuncional)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Plaza_CargoFuncional");

                entity.HasOne(d => d.IdDivisionNavigation)
                    .WithMany(p => p.Plazas)
                    .HasForeignKey(d => d.IdDivision)
                    .HasConstraintName("FK_Plaza_Division");

                entity.HasOne(d => d.IdEducacionDiferencialNavigation)
                    .WithMany(p => p.Plazas)
                    .HasForeignKey(d => d.IdEducacionDiferencial)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Plaza_RefEducacionDiferencial");

                entity.HasOne(d => d.IdEstadoPlazaNavigation)
                    .WithMany(p => p.Plazas)
                    .HasForeignKey(d => d.IdEstadoPlaza)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Plaza_RefEstadoPlaza");

                entity.HasOne(d => d.IdFinanciamientoNavigation)
                    .WithMany(p => p.Plazas)
                    .HasForeignKey(d => d.IdFinanciamiento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Plaza_RefFinanciamiento");

                entity.HasOne(d => d.IdInstrumentoLegalBajaNavigation)
                    .WithMany(p => p.PlazaIdInstrumentoLegalBajaNavigations)
                    .HasForeignKey(d => d.IdInstrumentoLegalBaja)
                    .HasConstraintName("FK_Plaza_InstrumentoLegal1");

                entity.HasOne(d => d.IdInstrumentoLegalCreacionNavigation)
                    .WithMany(p => p.PlazaIdInstrumentoLegalCreacionNavigations)
                    .HasForeignKey(d => d.IdInstrumentoLegalCreacion)
                    .HasConstraintName("FK_Plaza_InstrumentoLegal");

                entity.HasOne(d => d.IdMotivoBajaNavigation)
                    .WithMany(p => p.Plazas)
                    .HasForeignKey(d => d.IdMotivoBaja)
                    .HasConstraintName("FK_Plaza_RefMotivoBaja");

                entity.HasOne(d => d.IdMotivoCreacionNavigation)
                    .WithMany(p => p.Plazas)
                    .HasForeignKey(d => d.IdMotivoCreacion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Plaza_RefMotivoCreacion");

                entity.HasOne(d => d.IdOrganizacionNivelEducNavigation)
                    .WithMany(p => p.Plazas)
                    .HasForeignKey(d => d.IdOrganizacionNivelEduc)
                    .HasConstraintName("FK_Plaza_OrganizacionNivelEducativo");

                entity.HasOne(d => d.IdOrganizacionTurnoNavigation)
                    .WithMany(p => p.Plazas)
                    .HasForeignKey(d => d.IdOrganizacionTurno)
                    .HasConstraintName("FK_Plaza_OrganizacionTurno");

                entity.HasOne(d => d.IdPaqueteNavigation)
                    .WithMany(p => p.Plazas)
                    .HasForeignKey(d => d.IdPaquete)
                    .HasConstraintName("FK_Plaza_PaquetePlaza");

                entity.HasOne(d => d.IdPlanAsignaturaNavigation)
                    .WithMany(p => p.Plazas)
                    .HasForeignKey(d => d.IdPlanAsignatura)
                    .HasConstraintName("FK_Plaza_PlanAsignatura");

                entity.HasOne(d => d.IdRegimenLaboralNavigation)
                    .WithMany(p => p.Plazas)
                    .HasForeignKey(d => d.IdRegimenLaboral)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Plaza_RefRegimenLaboral");

                entity.HasOne(d => d.IdRegimenSalarialNavigation)
                    .WithMany(p => p.Plazas)
                    .HasForeignKey(d => d.IdRegimenSalarial)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Plaza_RefRegimenSalarial");

                entity.HasOne(d => d.IdSistemaEducativoNavigation)
                    .WithMany(p => p.Plazas)
                    .HasForeignKey(d => d.IdSistemaEducativo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Plaza_RefSistemaEducativo");

                entity.HasOne(d => d.IdSolicitudPlazaDetalleNavigation)
                    .WithMany(p => p.Plazas)
                    .HasForeignKey(d => d.IdSolicitudPlazaDetalle)
                    .HasConstraintName("FK_Plaza_SolicitudPlazaDetalle");

                entity.HasOne(d => d.IdSubEstadoPlazaNavigation)
                    .WithMany(p => p.Plazas)
                    .HasForeignKey(d => d.IdSubEstadoPlaza)
                    .HasConstraintName("FK_Plaza_RefSubEstadoPlaza");

                entity.HasOne(d => d.IdTemporalidadNavigation)
                    .WithMany(p => p.Plazas)
                    .HasForeignKey(d => d.IdTemporalidad)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Plaza_RefTemporalidad");

                entity.HasOne(d => d.IdTerminoLectivoNavigation)
                    .WithMany(p => p.Plazas)
                    .HasForeignKey(d => d.IdTerminoLectivo)
                    .HasConstraintName("FK_Plaza_TerminoLectivo");

                entity.HasOne(d => d.Id)
                    .WithMany(p => p.Plazas)
                    .HasForeignKey(d => new { d.IdOrganizacion, d.IdHistoriaOrg })
                    .HasConstraintName("FK_Plaza_Organizacion");
            });

            modelBuilder.Entity<PlazaHistorium>(entity =>
            {
                entity.HasKey(e => new { e.IdPlaza, e.IdPlazaHistoria });

                entity.Property(e => e.IdPlaza).HasColumnName("idPlaza");

                entity.Property(e => e.IdPlazaHistoria).HasColumnName("idPlazaHistoria");

                entity.Property(e => e.EstaActivo)
                    .IsRequired()
                    .HasColumnName("estaActivo")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.FechaEliminacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaEliminacion");

                entity.Property(e => e.FechaHabilitacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaHabilitacion");

                entity.Property(e => e.FechaTermino)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaTermino");

                entity.Property(e => e.IdPlanUnidad).HasColumnName("idPlanUnidad");

                entity.Property(e => e.IdTerminoLectivo).HasColumnName("idTerminoLectivo");

                entity.HasOne(d => d.IdPlanUnidadNavigation)
                    .WithMany(p => p.PlazaHistoria)
                    .HasForeignKey(d => d.IdPlanUnidad)
                    .HasConstraintName("FK_PlazaHistoria_PlanUnidad");

                entity.HasOne(d => d.IdPlazaNavigation)
                    .WithMany(p => p.PlazaHistoria)
                    .HasForeignKey(d => d.IdPlaza)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PlazaHistoria_Plaza");

                entity.HasOne(d => d.IdTerminoLectivoNavigation)
                    .WithMany(p => p.PlazaHistoria)
                    .HasForeignKey(d => d.IdTerminoLectivo)
                    .HasConstraintName("FK_PlazaHistoria_TerminoLectivo");
            });

            modelBuilder.Entity<PlazaPresupuesto>(entity =>
            {
                entity.HasKey(e => e.IdPlazaPresupuesto);

                entity.ToTable("PlazaPresupuesto");

                entity.Property(e => e.IdPlazaPresupuesto).HasColumnName("idPlazaPresupuesto");

                entity.Property(e => e.EstaActivo)
                    .IsRequired()
                    .HasColumnName("estaActivo")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.FechaEliminacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaEliminacion");

                entity.Property(e => e.FechaHabilitacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaHabilitacion");

                entity.Property(e => e.FechaTermino)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaTermino");

                entity.Property(e => e.IdAfectacion).HasColumnName("idAfectacion");

                entity.Property(e => e.IdPartida).HasColumnName("idPartida");

                entity.Property(e => e.IdPartidaSuplente).HasColumnName("idPartidaSuplente");

                entity.Property(e => e.IdPlaza).HasColumnName("idPlaza");

                entity.Property(e => e.IdPlazaHistoria).HasColumnName("idPlazaHistoria");

                entity.Property(e => e.IdPlazaTransferida).HasColumnName("idPlazaTransferida");

                entity.Property(e => e.IdPresupuesto).HasColumnName("idPresupuesto");

                entity.HasOne(d => d.IdAfectacionNavigation)
                    .WithMany(p => p.PlazaPresupuestos)
                    .HasForeignKey(d => d.IdAfectacion)
                    .HasConstraintName("FK_PlazaPresupuesto_RefAfectacion");

                entity.HasOne(d => d.IdPartidaNavigation)
                    .WithMany(p => p.PlazaPresupuestos)
                    .HasForeignKey(d => d.IdPartida)
                    .HasConstraintName("FK_PlazaPresupuesto_Partida");

                entity.HasOne(d => d.IdPlazaNavigation)
                    .WithMany(p => p.PlazaPresupuestos)
                    .HasForeignKey(d => d.IdPlaza)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PlazaPresupuesto_Plaza");

                entity.HasOne(d => d.IdPlazaTransferidaNavigation)
                    .WithMany(p => p.PlazaPresupuestos)
                    .HasForeignKey(d => d.IdPlazaTransferida)
                    .HasConstraintName("FK_PlazaPresupuesto_PlazaTransferida");

                entity.HasOne(d => d.IdPresupuestoNavigation)
                    .WithMany(p => p.PlazaPresupuestos)
                    .HasForeignKey(d => d.IdPresupuesto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PlazaPresupuesto_Presupuesto");

                entity.HasOne(d => d.IdPlaza1)
                    .WithMany(p => p.PlazaPresupuestos)
                    .HasForeignKey(d => new { d.IdPlaza, d.IdPlazaHistoria })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PlazaPresupuesto_PlazaHistoria");
            });

            modelBuilder.Entity<PlazaTransferidaView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("PlazaTransferidaView");

                entity.Property(e => e.EsTransitorio).HasColumnName("esTransitorio");

                entity.Property(e => e.EstaActivo).HasColumnName("estaActivo");

                entity.Property(e => e.FechaDesde)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaDesde");

                entity.Property(e => e.FechaHasta)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaHasta");

                entity.Property(e => e.IdPlazaDestino).HasColumnName("idPlazaDestino");

                entity.Property(e => e.IdPlazaOrigen).HasColumnName("idPlazaOrigen");

                entity.Property(e => e.IdPlazaTransferida).HasColumnName("idPlazaTransferida");

                entity.Property(e => e.IdSolicitudPlaza).HasColumnName("idSolicitudPlaza");

                entity.Property(e => e.IdSolicitudPlazaDetalle).HasColumnName("idSolicitudPlazaDetalle");

                entity.Property(e => e.NumeroSolicitud).HasColumnName("numeroSolicitud");

                entity.Property(e => e.OrganizacionDestinoDesc)
                    .HasMaxLength(250)
                    .HasColumnName("organizacionDestinoDesc");

                entity.Property(e => e.OrganizacionOrigenDesc)
                    .HasMaxLength(250)
                    .HasColumnName("organizacionOrigenDesc");
            });

            modelBuilder.Entity<PlazaTransferidum>(entity =>
            {
                entity.HasKey(e => e.IdPlazaTransferida);

                entity.Property(e => e.IdPlazaTransferida).HasColumnName("idPlazaTransferida");

                entity.Property(e => e.EsTransitorio)
                    .IsRequired()
                    .HasColumnName("esTransitorio")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.EstaActivo)
                    .IsRequired()
                    .HasColumnName("estaActivo")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.FechaDesde)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaDesde");

                entity.Property(e => e.FechaEliminacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaEliminacion");

                entity.Property(e => e.FechaHasta)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaHasta");

                entity.Property(e => e.IdPlazaDestino).HasColumnName("idPlazaDestino");

                entity.Property(e => e.IdPlazaOrigen).HasColumnName("idPlazaOrigen");

                entity.Property(e => e.IdSolicitudPlazaDetalle).HasColumnName("idSolicitudPlazaDetalle");

                entity.Property(e => e.IdTerminoLectivo).HasColumnName("idTerminoLectivo");

                entity.HasOne(d => d.IdPlazaDestinoNavigation)
                    .WithMany(p => p.PlazaTransferidumIdPlazaDestinoNavigations)
                    .HasForeignKey(d => d.IdPlazaDestino)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PlazaTransferidaDestino_Plaza");

                entity.HasOne(d => d.IdPlazaOrigenNavigation)
                    .WithMany(p => p.PlazaTransferidumIdPlazaOrigenNavigations)
                    .HasForeignKey(d => d.IdPlazaOrigen)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PlazaTransferidaOrigen_Plaza");

                entity.HasOne(d => d.IdSolicitudPlazaDetalleNavigation)
                    .WithMany(p => p.PlazaTransferida)
                    .HasForeignKey(d => d.IdSolicitudPlazaDetalle)
                    .HasConstraintName("FK_PlazaTransferida_SolicitudPlazaDetalle");

                entity.HasOne(d => d.IdTerminoLectivoNavigation)
                    .WithMany(p => p.PlazaTransferida)
                    .HasForeignKey(d => d.IdTerminoLectivo)
                    .HasConstraintName("FK_PlazaTransferida_TerminoLectivo");
            });

            modelBuilder.Entity<PlazaView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("PlazaView");

                entity.Property(e => e.AdmiteSuplente).HasColumnName("admiteSuplente");

                entity.Property(e => e.AfectacionDesc)
                    .HasMaxLength(50)
                    .HasColumnName("afectacionDesc");

                entity.Property(e => e.AsignaturaDesc)
                    .HasMaxLength(60)
                    .HasColumnName("asignaturaDesc");

                entity.Property(e => e.BajaAutomatica).HasColumnName("bajaAutomatica");

                entity.Property(e => e.CargoFuncionalDesc)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("cargoFuncionalDesc");

                entity.Property(e => e.CargoSalarialDesc)
                    .HasMaxLength(100)
                    .HasColumnName("cargoSalarialDesc");

                entity.Property(e => e.CobraIncentivo).HasColumnName("cobraIncentivo");

                entity.Property(e => e.CodigoPartida).HasColumnName("codigoPartida");

                entity.Property(e => e.Curso)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("curso");

                entity.Property(e => e.DivisionDesc)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("divisionDesc");

                entity.Property(e => e.EsCabeceraDePaquete).HasColumnName("esCabeceraDePaquete");

                entity.Property(e => e.EstaActivo).HasColumnName("estaActivo");

                entity.Property(e => e.EstadoPlazaDesc).HasColumnName("estadoPlazaDesc");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaCreacion");

                entity.Property(e => e.FechaEliminacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaEliminacion");

                entity.Property(e => e.FechaHabilitacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaHabilitacion");

                entity.Property(e => e.FechaHabilitacionPlazaHistoria)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaHabilitacionPlazaHistoria");

                entity.Property(e => e.FechaHabilitacionPlazaPresup)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaHabilitacionPlazaPresup");

                entity.Property(e => e.FechaTermino)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaTermino");

                entity.Property(e => e.FechaTerminoPlazaHistoria)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaTerminoPlazaHistoria");

                entity.Property(e => e.FechaTerminoPlazaPresup)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaTerminoPlazaPresup");

                entity.Property(e => e.FinanciamientoDesc)
                    .HasMaxLength(50)
                    .HasColumnName("financiamientoDesc");

                entity.Property(e => e.GeneraPresupuesto).HasColumnName("generaPresupuesto");

                entity.Property(e => e.IdAfectacion).HasColumnName("idAfectacion");

                entity.Property(e => e.IdCargoFuncional).HasColumnName("idCargoFuncional");

                entity.Property(e => e.IdCargoSalarial).HasColumnName("idCargoSalarial");

                entity.Property(e => e.IdDivision).HasColumnName("idDivision");

                entity.Property(e => e.IdEducacionDiferencial).HasColumnName("idEducacionDiferencial");

                entity.Property(e => e.IdEjercicio).HasColumnName("idEjercicio");

                entity.Property(e => e.IdEstadoPlaza).HasColumnName("idEstadoPlaza");

                entity.Property(e => e.IdExpteCreacion).HasColumnName("idExpteCreacion");

                entity.Property(e => e.IdFinanciamiento).HasColumnName("idFinanciamiento");

                entity.Property(e => e.IdHistoriaOrg).HasColumnName("idHistoriaOrg");

                entity.Property(e => e.IdInstrumentoLegalBaja).HasColumnName("idInstrumentoLegalBaja");

                entity.Property(e => e.IdInstrumentoLegalCreacion).HasColumnName("idInstrumentoLegalCreacion");

                entity.Property(e => e.IdInstumentoLegalCohorte).HasColumnName("idInstumentoLegalCohorte");

                entity.Property(e => e.IdMotivoBaja).HasColumnName("idMotivoBaja");

                entity.Property(e => e.IdMotivoCreacion).HasColumnName("idMotivoCreacion");

                entity.Property(e => e.IdNivelEducativo).HasColumnName("idNivelEducativo");

                entity.Property(e => e.IdOrganizacion).HasColumnName("idOrganizacion");

                entity.Property(e => e.IdOrganizacionNivelEduc).HasColumnName("idOrganizacionNivelEduc");

                entity.Property(e => e.IdOrganizacionTurno).HasColumnName("idOrganizacionTurno");

                entity.Property(e => e.IdPaquete).HasColumnName("idPaquete");

                entity.Property(e => e.IdPartida).HasColumnName("idPartida");

                entity.Property(e => e.IdPlanAsignatura).HasColumnName("idPlanAsignatura");

                entity.Property(e => e.IdPlanEstudioCohorte).HasColumnName("idPlanEstudioCohorte");

                entity.Property(e => e.IdPlanUnidad).HasColumnName("idPlanUnidad");

                entity.Property(e => e.IdPlaza).HasColumnName("idPlaza");

                entity.Property(e => e.IdPlazaHistoria).HasColumnName("idPlazaHistoria");

                entity.Property(e => e.IdPlazaPresupuesto).HasColumnName("idPlazaPresupuesto");

                entity.Property(e => e.IdPresupuesto).HasColumnName("idPresupuesto");

                entity.Property(e => e.IdRegimenLaboral).HasColumnName("idRegimenLaboral");

                entity.Property(e => e.IdRegimenSalarial).HasColumnName("idRegimenSalarial");

                entity.Property(e => e.IdSistemaEducativo).HasColumnName("idSistemaEducativo");

                entity.Property(e => e.IdSolicitudPlaza).HasColumnName("idSolicitudPlaza");

                entity.Property(e => e.IdSolicitudPlazaDetalle).HasColumnName("idSolicitudPlazaDetalle");

                entity.Property(e => e.IdSubEstadoPlaza).HasColumnName("idSubEstadoPlaza");

                entity.Property(e => e.IdTemporalidad).HasColumnName("idTemporalidad");

                entity.Property(e => e.IdTerminoLectivo).HasColumnName("idTerminoLectivo");

                entity.Property(e => e.IdTerminoLectivoPlazaHistoria).HasColumnName("idTerminoLectivoPlazaHistoria");

                entity.Property(e => e.IdTurno).HasColumnName("idTurno");

                entity.Property(e => e.InstrumentoLegalBajaDesc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("instrumentoLegalBajaDesc");

                entity.Property(e => e.InstrumentoLegalCreacionDesc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("instrumentoLegalCreacionDesc");

                entity.Property(e => e.InstrumentoLegalDescCohorte)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("instrumentoLegalDescCohorte");

                entity.Property(e => e.MaxPlazaHistoria).HasColumnName("maxPlazaHistoria");

                entity.Property(e => e.MotivoCreacionDesc)
                    .HasMaxLength(50)
                    .HasColumnName("motivoCreacionDesc");

                entity.Property(e => e.Observacion)
                    .HasMaxLength(255)
                    .HasColumnName("observacion");

                entity.Property(e => e.OrganizacionDesc)
                    .HasMaxLength(250)
                    .HasColumnName("organizacionDesc");

                entity.Property(e => e.Partida)
                    .HasMaxLength(100)
                    .HasColumnName("partida");

                entity.Property(e => e.PlanEstudioDesc)
                    .HasMaxLength(100)
                    .HasColumnName("planEstudioDesc");

                entity.Property(e => e.RegimenLaboralDesc)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("regimenLaboralDesc");

                entity.Property(e => e.RegimenSalarialDesc)
                    .HasMaxLength(50)
                    .HasColumnName("regimenSalarialDesc");

                entity.Property(e => e.SistemaEducativoDesc)
                    .HasMaxLength(30)
                    .HasColumnName("sistemaEducativoDesc")
                    .IsFixedLength();

                entity.Property(e => e.Subestado)
                    .HasMaxLength(15)
                    .HasColumnName("subestado");

                entity.Property(e => e.TemporalidadDesc)
                    .HasMaxLength(20)
                    .HasColumnName("temporalidadDesc");

                entity.Property(e => e.TurnoDesc)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("turnoDesc");
            });

            modelBuilder.Entity<Presupuesto>(entity =>
            {
                entity.HasKey(e => e.IdPresupuesto);

                entity.ToTable("Presupuesto");

                entity.HasComment("Presupuesto anual de plazas por finalidad, funcion y escalafon");

                entity.Property(e => e.IdPresupuesto).HasColumnName("idPresupuesto");

                entity.Property(e => e.CantDisponible)
                    .HasColumnName("cantDisponible")
                    .HasComment("Inicialmente toma el valor de cantidad presupuestada, luego a medida que se van creando plazas se va descontando este valor,");

                entity.Property(e => e.CantPresupuestada)
                    .HasColumnName("cantPresupuestada")
                    .HasComment("Cantidad de plazas correspondiente a una finalidad, funcion, categoria y escalafon en particular presupuestadas para el año actual");

                entity.Property(e => e.EstaActivo)
                    .IsRequired()
                    .HasColumnName("estaActivo")
                    .HasDefaultValueSql("((1))")
                    .HasComment("Campo para eliminacion logica. Valor 0 es igual a falso, valor 1 es igual a verdadero");

                entity.Property(e => e.FechaEliminacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaEliminacion")
                    .HasComment("Campo para borrado lógico. Fecha en la que deja de estar activo el items de presupuesto");

                entity.Property(e => e.IdAdicional)
                    .HasColumnName("idAdicional")
                    .HasComment("Identificador de adicional. Ejemplo 1 - 33% mayor responsabilidad");

                entity.Property(e => e.IdCargoSalarial)
                    .HasColumnName("idCargoSalarial")
                    .HasComment("Clave foranea. Identificador de Categoria presupuesto");

                entity.Property(e => e.IdEscalafon).HasColumnName("idEscalafon");

                entity.Property(e => e.IdFinalidadxEjer).HasColumnName("idFinalidadxEjer");

                entity.Property(e => e.IdFuncionxEjer).HasColumnName("idFuncionxEjer");

                entity.Property(e => e.IdUdeOxEjer)
                    .HasColumnName("idUdeOxEjer")
                    .HasComment("Unidad de organización para la cual se destina el presupuesto de plazas");

                entity.HasOne(d => d.IdAdicionalNavigation)
                    .WithMany(p => p.Presupuestos)
                    .HasForeignKey(d => d.IdAdicional)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Presupuesto_RefAdicional");

                entity.HasOne(d => d.IdCargoSalarialNavigation)
                    .WithMany(p => p.Presupuestos)
                    .HasForeignKey(d => d.IdCargoSalarial)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Presupuesto_CargoSalarial");

                entity.HasOne(d => d.IdEscalafonNavigation)
                    .WithMany(p => p.Presupuestos)
                    .HasForeignKey(d => d.IdEscalafon)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Presupuesto_RefEscalafon");

                entity.HasOne(d => d.IdFinalidadxEjerNavigation)
                    .WithMany(p => p.Presupuestos)
                    .HasForeignKey(d => d.IdFinalidadxEjer)
                    .HasConstraintName("FK_Presupuesto_RefFinalidadxEjer");

                entity.HasOne(d => d.IdFuncionxEjerNavigation)
                    .WithMany(p => p.Presupuestos)
                    .HasForeignKey(d => d.IdFuncionxEjer)
                    .HasConstraintName("FK_Presupuesto_RefFuncionxEjer");

                entity.HasOne(d => d.IdUdeOxEjerNavigation)
                    .WithMany(p => p.Presupuestos)
                    .HasForeignKey(d => d.IdUdeOxEjer)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Presupuesto_RefUdeOxEjer");
            });

            modelBuilder.Entity<PresupuestoView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("PresupuestoView");

                entity.Property(e => e.AdicionalDesc)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("adicionalDesc");

                entity.Property(e => e.CantDisponible).HasColumnName("cantDisponible");

                entity.Property(e => e.CantPresupuestada).HasColumnName("cantPresupuestada");

                entity.Property(e => e.CargoSalarialDesc)
                    .HasMaxLength(100)
                    .HasColumnName("cargoSalarialDesc");

                entity.Property(e => e.CodFinalidad)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("codFinalidad")
                    .IsFixedLength();

                entity.Property(e => e.CodFuncion)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("codFuncion")
                    .IsFixedLength();

                entity.Property(e => e.CodUdeO)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("codUdeO")
                    .IsFixedLength();

                entity.Property(e => e.EjercicioDesc)
                    .HasMaxLength(4)
                    .HasColumnName("ejercicioDesc");

                entity.Property(e => e.EscalafonDesc)
                    .HasMaxLength(100)
                    .HasColumnName("escalafonDesc");

                entity.Property(e => e.EstaActivo).HasColumnName("estaActivo");

                entity.Property(e => e.FechaEliminacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaEliminacion");

                entity.Property(e => e.FinalidadDesc)
                    .HasMaxLength(50)
                    .HasColumnName("finalidadDesc");

                entity.Property(e => e.FuncionDesc)
                    .HasMaxLength(50)
                    .HasColumnName("funcionDesc");

                entity.Property(e => e.IdAdicional).HasColumnName("idAdicional");

                entity.Property(e => e.IdCargoSalarial).HasColumnName("idCargoSalarial");

                entity.Property(e => e.IdEjercicio).HasColumnName("idEjercicio");

                entity.Property(e => e.IdEscalafon).HasColumnName("idEscalafon");

                entity.Property(e => e.IdFinalidadxEjer).HasColumnName("idFinalidadxEjer");

                entity.Property(e => e.IdFuncionxEjer).HasColumnName("idFuncionxEjer");

                entity.Property(e => e.IdPresupuesto).HasColumnName("idPresupuesto");

                entity.Property(e => e.IdUdeOxEjer).HasColumnName("idUdeOxEjer");

                entity.Property(e => e.Porcentaje).HasColumnName("porcentaje");

                entity.Property(e => e.UdeoDesc)
                    .HasMaxLength(100)
                    .HasColumnName("udeoDesc");
            });

            modelBuilder.Entity<Provincium>(entity =>
            {
                entity.HasKey(e => e.IdProvincia);

                entity.HasComment("Provincias que posee un pais");

                entity.Property(e => e.IdProvincia)
                    .HasColumnName("idProvincia")
                    .HasComment("Clave primaria, autoincrementable. Identificador de provincia");

                entity.Property(e => e.EstaActivo)
                    .IsRequired()
                    .HasColumnName("estaActivo")
                    .HasDefaultValueSql("((1))")
                    .HasComment("Campo para eliminación lógica. Valor 0 es igual a falso, valor 1 es igual a verdadero");

                entity.Property(e => e.FechaEliminacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaEliminacion")
                    .HasComment("Fecha en la que deja de estar activo el registro");

                entity.Property(e => e.IdPaisNacionalidad)
                    .HasColumnName("idPaisNacionalidad")
                    .HasComment("Clave foranea. Identificador del país al que pertenece la provincia");

                entity.Property(e => e.ProvinciaDesc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("provinciaDesc")
                    .HasComment("Nombre de la provincia");

                entity.HasOne(d => d.IdPaisNacionalidadNavigation)
                    .WithMany(p => p.Provincia)
                    .HasForeignKey(d => d.IdPaisNacionalidad)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Provincia_RefPaisNacionalidad");
            });

            modelBuilder.Entity<RefAdicional>(entity =>
            {
                entity.HasKey(e => e.IdAdicional)
                    .HasName("PK_Adicional");

                entity.ToTable("RefAdicional");

                entity.HasComment("Adicionales para liquidacion. Ejemplo adicionales por mayor horario, por mayor responsabilidad, etc.");

                entity.Property(e => e.IdAdicional)
                    .HasColumnName("idAdicional")
                    .HasComment("Clave primaria, autoincrementable. Identificador de Adicional");

                entity.Property(e => e.AdicionalDesc)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("adicionalDesc")
                    .HasComment("Descripcion del adicional. Ejemplo: Adic. May. Dedicacion 33%; Adic. May. Horario 33%");

                entity.Property(e => e.EstaActivo)
                    .IsRequired()
                    .HasColumnName("estaActivo")
                    .HasDefaultValueSql("((1))")
                    .HasComment("Campo para eliminacion logica. Valor 0 es igual a falso, valor 1 es igual a verdadero");

                entity.Property(e => e.FechaEliminacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaEliminacion")
                    .HasComment("Fecha en la que deja de estar activo el adicional");

                entity.Property(e => e.Porcentaje)
                    .HasColumnName("porcentaje")
                    .HasComment("Porcentaje que corresponde al adicional. Ejemplo 33%; 50 %");
            });

            modelBuilder.Entity<RefAfectacion>(entity =>
            {
                entity.HasKey(e => e.IdAfectacion);

                entity.ToTable("RefAfectacion");

                entity.HasComment("Afectaciones presupuestarias de plazas. Intra o Extra Presupuestario");

                entity.Property(e => e.IdAfectacion).HasColumnName("idAfectacion");

                entity.Property(e => e.AfectacionDesc)
                    .HasMaxLength(50)
                    .HasColumnName("afectacionDesc")
                    .HasComment("Afectacion del cargo Ej: Intra o Extra presupuestario");

                entity.Property(e => e.EstaActivo)
                    .IsRequired()
                    .HasColumnName("estaActivo")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.FechaEliminacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaEliminacion");
            });

            modelBuilder.Entity<RefAmbito>(entity =>
            {
                entity.HasKey(e => e.IdAmbito);

                entity.ToTable("RefAmbito");

                entity.HasComment("Ambitos a los que puede pertenecer un aorganizacion.  Privado o publico");

                entity.Property(e => e.IdAmbito)
                    .HasColumnName("idAmbito")
                    .HasComment("Primary key");

                entity.Property(e => e.AmbitoDesc)
                    .HasMaxLength(60)
                    .HasColumnName("ambitoDesc")
                    .HasComment("Descriptivo del ambito al que pertenece la organizacion publica, privada, etc");

                entity.Property(e => e.EstaActivo)
                    .IsRequired()
                    .HasColumnName("estaActivo")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.FechaEliminacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaEliminacion");
            });

            modelBuilder.Entity<RefAplicacion>(entity =>
            {
                entity.HasKey(e => e.IdAplicacion);

                entity.ToTable("RefAplicacion");

                entity.Property(e => e.IdAplicacion)
                    .ValueGeneratedNever()
                    .HasColumnName("idAplicacion");

                entity.Property(e => e.AplicacionDesc)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EstaActivo).HasColumnName("estaActivo");

                entity.Property(e => e.FechaAlta)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaAlta");

                entity.Property(e => e.FechaEliminacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaEliminacion");
            });

            modelBuilder.Entity<RefAsignatura>(entity =>
            {
                entity.HasKey(e => e.IdAsignatura);

                entity.ToTable("RefAsignatura");

                entity.HasComment("Asignaturas");

                entity.Property(e => e.IdAsignatura)
                    .HasColumnName("idAsignatura")
                    .HasComment("Clave primaria, autoincrementable. Identificador de la asignatura");

                entity.Property(e => e.AsignaturaDesc)
                    .HasMaxLength(60)
                    .HasColumnName("asignaturaDesc")
                    .HasComment("Nombre descriptivo de la asignatura");

                entity.Property(e => e.EstaActivo)
                    .IsRequired()
                    .HasColumnName("estaActivo")
                    .HasDefaultValueSql("((1))")
                    .HasComment("Campo para eliminación lógica. Valor 0 es igual a falso, valor 1 es igual a verdadero");

                entity.Property(e => e.FechaEliminacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaEliminacion")
                    .HasComment("Fecha en la que deja de estar activa la asignatura");
            });

            modelBuilder.Entity<RefCalendarioFeriado>(entity =>
            {
                entity.HasKey(e => e.IdCalendarioFeriado);

                entity.ToTable("RefCalendarioFeriado");

                entity.HasComment("Registro de feriados o días no laborables");

                entity.Property(e => e.IdCalendarioFeriado)
                    .HasColumnName("idCalendarioFeriado")
                    .HasComment("Primary key");

                entity.Property(e => e.CalendarioFeriadoDesc)
                    .HasMaxLength(50)
                    .HasColumnName("calendarioFeriadoDesc");

                entity.Property(e => e.EstaActivo)
                    .IsRequired()
                    .HasColumnName("estaActivo")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.FechaEliminacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaEliminacion");

                entity.Property(e => e.FechaFeriado)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaFeriado");
            });

            modelBuilder.Entity<RefCargoTipo>(entity =>
            {
                entity.HasKey(e => e.IdTipoCargo)
                    .HasName("PK__CargoTip__9DD6CF236BAEFA67");

                entity.ToTable("RefCargoTipo");

                entity.Property(e => e.IdTipoCargo)
                    .HasColumnName("idTipoCargo")
                    .HasComment("Código identificador de tipo de cargo");

                entity.Property(e => e.EstaActivo)
                    .IsRequired()
                    .HasColumnName("estaActivo")
                    .HasDefaultValueSql("((1))")
                    .HasComment("Campo para eliminación lógica");

                entity.Property(e => e.FechaEliminacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaEliminacion");

                entity.Property(e => e.Observacion)
                    .HasMaxLength(100)
                    .HasColumnName("observacion")
                    .HasComment("Observaciones acerca del tipo de cargo");

                entity.Property(e => e.TipoCargoDesc)
                    .HasMaxLength(20)
                    .HasColumnName("tipoCargoDesc")
                    .HasComment("Tipo de cargo. Ejemplo: horas, cargo, etc.");
            });

            modelBuilder.Entity<RefCategoriaLicencium>(entity =>
            {
                entity.HasKey(e => e.IdCategoriaLicencia);

                entity.HasComment("Tipos de licecias: enfermedades cortas, maternidad, etc.");

                entity.Property(e => e.IdCategoriaLicencia)
                    .HasColumnName("idCategoriaLicencia")
                    .HasComment("Clave primaria, autoincrementable.Codigo identificador de la categoria de la licencia.");

                entity.Property(e => e.CategoriaLicenciaDesc)
                    .HasMaxLength(50)
                    .HasColumnName("categoriaLicenciaDesc")
                    .HasComment("Descripcion de la categoria de la licencia, ej.: Enfermedades Cortas, Maternidad, Mayor Jerarquia, etc.");

                entity.Property(e => e.EstaActivo)
                    .IsRequired()
                    .HasColumnName("estaActivo")
                    .HasDefaultValueSql("((1))")
                    .HasComment("Identifica si el registro esta activo. (1=SI, 0=NO).");

                entity.Property(e => e.FechaAlta)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaAlta")
                    .HasDefaultValueSql("((1))")
                    .HasComment("Almacena la fecha de alta de la categoria de la licencia.");

                entity.Property(e => e.FechaEliminacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaEliminacion")
                    .HasComment("Almacena la fecha de baja de la categoria de la licencia.");
            });

            modelBuilder.Entity<RefCategoriaOrganizacion>(entity =>
            {
                entity.HasKey(e => e.IdCategoriaOrganizacion);

                entity.ToTable("RefCategoriaOrganizacion");

                entity.HasComment("Categorias de establecimientos educativos. Primera categoria, segunda categoria, etc. Esta categoria se da según la cantidad de alumnos del establecimiento");

                entity.Property(e => e.IdCategoriaOrganizacion)
                    .HasColumnName("idCategoriaOrganizacion")
                    .HasComment("Clave primaria, autoincrementable. ");

                entity.Property(e => e.CategoriaOrganizacionDesc)
                    .HasMaxLength(60)
                    .HasColumnName("categoriaOrganizacionDesc")
                    .HasComment("Categoria de la organización. Ejemplo: Primera, segunda");

                entity.Property(e => e.EstaActivo)
                    .IsRequired()
                    .HasColumnName("estaActivo")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.FechaEliminacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaEliminacion");
            });

            modelBuilder.Entity<RefCuenta>(entity =>
            {
                entity.HasKey(e => e.IdCuenta)
                    .HasName("PK_Cuentas");

                entity.Property(e => e.IdCuenta).HasColumnName("idCuenta");

                entity.Property(e => e.Cuenta)
                    .HasMaxLength(100)
                    .HasColumnName("cuenta");

                entity.Property(e => e.EstaActivo)
                    .IsRequired()
                    .HasColumnName("estaActivo")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.FechaEliminacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaEliminacion");

                entity.Property(e => e.IdNodoPadre).HasColumnName("idNodoPadre");

                entity.Property(e => e.Nivel).HasColumnName("nivel");

                entity.Property(e => e.Partida1).HasColumnName("partida1");

                entity.Property(e => e.Partida2).HasColumnName("partida2");

                entity.Property(e => e.Seccion1).HasColumnName("seccion1");

                entity.Property(e => e.Seccion2).HasColumnName("seccion2");

                entity.Property(e => e.Sector1).HasColumnName("sector1");

                entity.Property(e => e.Sector2).HasColumnName("sector2");

                entity.Property(e => e.Tipo)
                    .HasColumnName("tipo")
                    .HasComment("0: Clasificación, 1: Nodo Hoja que contiene partidas");

                entity.HasOne(d => d.IdNodoPadreNavigation)
                    .WithMany(p => p.InverseIdNodoPadreNavigation)
                    .HasForeignKey(d => d.IdNodoPadre)
                    .HasConstraintName("FK_Cuentas_Cuentas");
            });

            modelBuilder.Entity<RefDependenciaFuncional>(entity =>
            {
                entity.HasKey(e => e.IdDependenciaFuncional);

                entity.ToTable("RefDependenciaFuncional");

                entity.Property(e => e.IdDependenciaFuncional).HasColumnName("idDependenciaFuncional");

                entity.Property(e => e.DependenciaFuncionalDesc)
                    .HasMaxLength(100)
                    .HasColumnName("dependenciaFuncionalDesc");

                entity.Property(e => e.EstaActivo)
                    .IsRequired()
                    .HasColumnName("estaActivo")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.FechaEliminacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaEliminacion");
            });

            modelBuilder.Entity<RefDescanso>(entity =>
            {
                entity.HasKey(e => e.IdDescanso);

                entity.ToTable("RefDescanso");

                entity.Property(e => e.IdDescanso).HasColumnName("idDescanso");

                entity.Property(e => e.DescansoDesc)
                    .HasMaxLength(64)
                    .HasColumnName("descansoDesc");

                entity.Property(e => e.EsPuente).HasColumnName("esPuente");

                entity.Property(e => e.EsTrasladable).HasColumnName("esTrasladable");

                entity.Property(e => e.EstaActivo)
                    .IsRequired()
                    .HasColumnName("estaActivo")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.FechaDesde)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaDesde");

                entity.Property(e => e.FechaEliminacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaEliminacion");

                entity.Property(e => e.FechaHasta)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaHasta");

                entity.Property(e => e.IdGrupoNivel).HasColumnName("idGrupoNivel");

                entity.Property(e => e.IdLocalidad).HasColumnName("idLocalidad");

                entity.Property(e => e.IdTipoDescanso).HasColumnName("idTipoDescanso");

                entity.Property(e => e.IdTipoJuridiccion).HasColumnName("idTipoJuridiccion");

                entity.HasOne(d => d.IdGrupoNivelNavigation)
                    .WithMany(p => p.RefDescansos)
                    .HasForeignKey(d => d.IdGrupoNivel)
                    .HasConstraintName("FK_RefDescanso_RefGrupoNivel");

                entity.HasOne(d => d.IdLocalidadNavigation)
                    .WithMany(p => p.RefDescansos)
                    .HasForeignKey(d => d.IdLocalidad)
                    .HasConstraintName("FK_RefDescanso_Localidad");

                entity.HasOne(d => d.IdTipoDescansoNavigation)
                    .WithMany(p => p.RefDescansos)
                    .HasForeignKey(d => d.IdTipoDescanso)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RefDescanso_RefTipoDescanso");

                entity.HasOne(d => d.IdTipoJuridiccionNavigation)
                    .WithMany(p => p.RefDescansos)
                    .HasForeignKey(d => d.IdTipoJuridiccion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RefDescanso_RefTipoJuridiccion");
            });

            modelBuilder.Entity<RefDiaDescansoAnual>(entity =>
            {
                entity.HasKey(e => e.IdDiaDescansoAnual)
                    .HasName("PK_RefDiasDescansoAnual");

                entity.ToTable("RefDiaDescansoAnual");

                entity.HasComment("");

                entity.Property(e => e.IdDiaDescansoAnual)
                    .HasColumnName("idDiaDescansoAnual")
                    .HasComment("Primary key");

                entity.Property(e => e.AnioDesde)
                    .HasColumnName("anioDesde")
                    .HasComment("Describe el comienzo del intervalo en años para los dias de descanso anual");

                entity.Property(e => e.AnioHasta)
                    .HasColumnName("anioHasta")
                    .HasComment("Describe el fin del intervalo en años para los dias de descanso anual");

                entity.Property(e => e.DiaDescanso)
                    .HasColumnName("diaDescanso")
                    .HasComment("Dias de descanso que corresponde segun el intervalo de años (desde-hasta)");

                entity.Property(e => e.DiaDescansoAnualDesc)
                    .HasMaxLength(100)
                    .HasColumnName("diaDescansoAnualDesc");

                entity.Property(e => e.EstaActivo)
                    .IsRequired()
                    .HasColumnName("estaActivo")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.FechaEliminacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaEliminacion");
            });

            modelBuilder.Entity<RefDiaSemana>(entity =>
            {
                entity.HasKey(e => e.IdDiaSemana)
                    .HasName("PK_RefDia");

                entity.ToTable("RefDiaSemana");

                entity.Property(e => e.IdDiaSemana).HasColumnName("idDiaSemana");

                entity.Property(e => e.DiaDesc)
                    .HasMaxLength(10)
                    .HasColumnName("diaDesc");

                entity.Property(e => e.Mnemo)
                    .HasMaxLength(2)
                    .HasColumnName("mnemo")
                    .IsFixedLength();
            });

            modelBuilder.Entity<RefEducacionDiferencial>(entity =>
            {
                entity.HasKey(e => e.IdEducacionDiferencial);

                entity.ToTable("RefEducacionDiferencial");

                entity.Property(e => e.IdEducacionDiferencial).HasColumnName("idEducacionDiferencial");

                entity.Property(e => e.EducacionDiferencialDesc)
                    .HasMaxLength(100)
                    .HasColumnName("educacionDiferencialDesc");

                entity.Property(e => e.EstaActivo)
                    .IsRequired()
                    .HasColumnName("estaActivo")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.FechaEliminacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaEliminacion");

                entity.Property(e => e.Porcentaje)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("porcentaje");
            });

            modelBuilder.Entity<RefEjercicio>(entity =>
            {
                entity.HasKey(e => e.IdEjercicio);

                entity.ToTable("RefEjercicio");

                entity.Property(e => e.IdEjercicio).HasColumnName("idEjercicio");

                entity.Property(e => e.EjercicioDesc)
                    .HasMaxLength(4)
                    .HasColumnName("ejercicioDesc");

                entity.Property(e => e.EstaActivo)
                    .IsRequired()
                    .HasColumnName("estaActivo")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.FechaEliminacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaEliminacion");
            });

            modelBuilder.Entity<RefEntidadOtorgante>(entity =>
            {
                entity.HasKey(e => e.IdEntidadOtorgante);

                entity.ToTable("RefEntidadOtorgante");

                entity.Property(e => e.IdEntidadOtorgante).HasColumnName("idEntidadOtorgante");

                entity.Property(e => e.EntidadOtorganteDesc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("entidadOtorganteDesc");

                entity.Property(e => e.EstaActivo).HasColumnName("estaActivo");

                entity.Property(e => e.FechaEliminacion)
                    .HasColumnType("date")
                    .HasColumnName("fechaEliminacion");
            });

            modelBuilder.Entity<RefEscalafon>(entity =>
            {
                entity.HasKey(e => e.IdEscalafon);

                entity.ToTable("RefEscalafon");

                entity.HasComment("Escalafon salarial de categorias. Personal docente, personal superior, etc.");

                entity.Property(e => e.IdEscalafon)
                    .HasColumnName("idEscalafon")
                    .HasComment("Clave primaria, autoincrementable. Identificador de escalafon salarial");

                entity.Property(e => e.EscalafonDesc)
                    .HasMaxLength(100)
                    .HasColumnName("escalafonDesc")
                    .HasComment("Describe el escalafon segun presupuesto");

                entity.Property(e => e.EstaActivo)
                    .IsRequired()
                    .HasColumnName("estaActivo")
                    .HasDefaultValueSql("((1))")
                    .HasComment("Indica si esta activa la funcion");

                entity.Property(e => e.FechaEliminacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaEliminacion")
                    .HasComment("Fecha que deja de estar activo el escalafon");

                entity.Property(e => e.IdGrupoNivel).HasColumnName("idGrupoNivel");

                entity.Property(e => e.Nomenclatura)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("nomenclatura");

                entity.HasOne(d => d.IdGrupoNivelNavigation)
                    .WithMany(p => p.RefEscalafons)
                    .HasForeignKey(d => d.IdGrupoNivel)
                    .HasConstraintName("FK_RefEscalafon_RefGrupoNivel");
            });

            modelBuilder.Entity<RefEspecialidad>(entity =>
            {
                entity.HasKey(e => e.IdEspecialidad);

                entity.ToTable("RefEspecialidad");

                entity.HasComment("Orientacion o estudio especifico de una rama de la educacion. Ejemplo: Computacion, orientacion docente, etc.");

                entity.Property(e => e.IdEspecialidad)
                    .HasColumnName("idEspecialidad")
                    .HasComment("Clave primaria, autoincrementable. Identificador de especialidad");

                entity.Property(e => e.EspecialidadDesc)
                    .HasMaxLength(70)
                    .HasColumnName("especialidadDesc")
                    .HasComment("Nombre de la especialidad u orientación del plan de estudio. Ejemplo: Bachillerato comun, computación");

                entity.Property(e => e.EstaActivo)
                    .IsRequired()
                    .HasColumnName("estaActivo")
                    .HasDefaultValueSql("((1))")
                    .HasComment("Campo de eliminacion lógica");

                entity.Property(e => e.FechaEliminacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaEliminacion")
                    .HasComment("Fecha en la que deja de estar activa la especialidad");
            });

            modelBuilder.Entity<RefEstado>(entity =>
            {
                entity.HasKey(e => e.IdEstado);

                entity.ToTable("RefEstado");

                entity.HasComment("Descripcion de estados en los que se puede encontrar un cuil. Por ejemplo: verificado, no valido");

                entity.Property(e => e.IdEstado)
                    .HasColumnName("idEstado")
                    .HasComment("Clave primaria, autoincrementable. Identificador de Estados Si o No");

                entity.Property(e => e.EstaActivo)
                    .IsRequired()
                    .HasColumnName("estaActivo")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.EstadoDesc)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("estadoDesc")
                    .HasComment("Estado del cuil. Ejemplo: Verificado, no verificado, no valido");

                entity.Property(e => e.FechaEliminacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaEliminacion");
            });

            modelBuilder.Entity<RefEstadoCivil>(entity =>
            {
                entity.HasKey(e => e.IdEstadoCivil);

                entity.ToTable("RefEstadoCivil");

                entity.HasComment("Estado civil en el que puede encontrarse una persona. Ejemplo: Casado, soltero, etc.");

                entity.Property(e => e.IdEstadoCivil)
                    .HasColumnName("idEstadoCivil")
                    .HasComment("Clave primaria, autoincrementable. Identificador de Estado Civil");

                entity.Property(e => e.EstaActivo)
                    .IsRequired()
                    .HasColumnName("estaActivo")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.EstadoCivilDesc)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("estadoCivilDesc")
                    .HasComment("Nombre de estado civil");

                entity.Property(e => e.FechaEliminacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaEliminacion");
            });

            modelBuilder.Entity<RefEstadoEdificio>(entity =>
            {
                entity.HasKey(e => e.IdEstadoEdificio);

                entity.ToTable("RefEstadoEdificio");

                entity.HasComment("Estados en los que se puede encontrar un edificio. Ejemplo: Bueno, muy bueno");

                entity.Property(e => e.IdEstadoEdificio)
                    .HasColumnName("idEstadoEdificio")
                    .HasComment("Clave primaria, autoincrementable. Identificador del estado del edificio.");

                entity.Property(e => e.EstaActivo)
                    .IsRequired()
                    .HasColumnName("estaActivo")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.EstadoEdificioDesc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("estadoEdificioDesc")
                    .HasComment("Describe el estado del edificio, ej.: bueno, muy bueno, regular, etc.");

                entity.Property(e => e.FechaEliminacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaEliminacion");
            });

            modelBuilder.Entity<RefEstadoPlaza>(entity =>
            {
                entity.HasKey(e => e.IdEstadoPlaza);

                entity.ToTable("RefEstadoPlaza");

                entity.Property(e => e.IdEstadoPlaza)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("idEstadoPlaza");

                entity.Property(e => e.EstaActivo).HasColumnName("estaActivo");

                entity.Property(e => e.EstadoPlazaDesc).HasColumnName("estadoPlazaDesc");

                entity.Property(e => e.FechaEliminacion)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("fechaEliminacion");
            });

            modelBuilder.Entity<RefEstadoSolicitud>(entity =>
            {
                entity.HasKey(e => e.IdEstadoSolicitud)
                    .HasName("PK_EstadoSolicitud");

                entity.ToTable("RefEstadoSolicitud");

                entity.HasComment("Estado en los que se puede encontrar una solicitud de habilitacion de plaza: borrador, pendiente; autorizado; habilitado");

                entity.Property(e => e.IdEstadoSolicitud)
                    .HasColumnName("idEstadoSolicitud")
                    .HasComment("Clave primaria, autoincremental. Identiifcador de estado de solicitud");

                entity.Property(e => e.EstaActivo)
                    .IsRequired()
                    .HasColumnName("estaActivo")
                    .HasDefaultValueSql("((1))")
                    .HasComment("Campo para eliminacion logica");

                entity.Property(e => e.EstadoSolicitudDesc)
                    .HasMaxLength(25)
                    .HasColumnName("estadoSolicitudDesc")
                    .HasComment("Estado de solicitud: pendiente, autorizada, etc.");

                entity.Property(e => e.FechaEliminacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaEliminacion")
                    .HasComment("Fecha en la que deja de estar activo el estado de la solicitud");
            });

            modelBuilder.Entity<RefEstadosSolicitudLegajo>(entity =>
            {
                entity.HasKey(e => e.IdEstadoSolicitudLegajo);

                entity.ToTable("RefEstadosSolicitudLegajo");

                entity.HasComment("Estados por los que puede pasar una solicitu de un agente (legajo)");

                entity.Property(e => e.IdEstadoSolicitudLegajo)
                    .HasColumnName("idEstadoSolicitudLegajo")
                    .HasComment("Campo clave, autoincremental");

                entity.Property(e => e.AplicaDetalle)
                    .HasColumnName("aplicaDetalle")
                    .HasComment("Indica si el estado se aplica al detalle de una solicitud. Por defecto es 0, es decir que aplica a la cabecera de una solicitud");

                entity.Property(e => e.EstaActivo)
                    .IsRequired()
                    .HasColumnName("estaActivo")
                    .HasDefaultValueSql("((1))")
                    .HasComment("Campo para eliminación lógica");

                entity.Property(e => e.EstadoSolicitudDesc)
                    .HasMaxLength(25)
                    .HasColumnName("estadoSolicitudDesc")
                    .HasComment("Descripción del estado que puede asumir una solicitud de un agente (legajo)");

                entity.Property(e => e.FechaEliminacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaEliminacion")
                    .HasComment("Fecha de eliminación lógica");
            });

            modelBuilder.Entity<RefFinalidad>(entity =>
            {
                entity.HasKey(e => e.IdFinalidad);

                entity.ToTable("RefFinalidad");

                entity.HasComment("Propio del presupuesto. Clasificacion de gastos por finalidad. Ejemplo: Cultura y educacion, adminsitracion general");

                entity.Property(e => e.IdFinalidad)
                    .HasColumnName("idFinalidad")
                    .HasComment("Clave primaria, NO autoincrementable. Identificador de la finalidad a la cual va dirigida el presupuesto");

                entity.Property(e => e.EstaActivo)
                    .IsRequired()
                    .HasColumnName("estaActivo")
                    .HasDefaultValueSql("((1))")
                    .HasComment("Indica si esta activa o no la finalidad");

                entity.Property(e => e.FechaEliminacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaEliminacion")
                    .HasComment("Fecha en la que deja de estar activa la finalidad");

                entity.Property(e => e.FinalidadDesc)
                    .HasMaxLength(50)
                    .HasColumnName("finalidadDesc")
                    .HasComment("Descripcion de la finalidad segun presupuesto. Ejemplo: 3-Administración general; 5-Cultura y educación");
            });

            modelBuilder.Entity<RefFinalidadxEjer>(entity =>
            {
                entity.HasKey(e => e.IdFinalidadxEjer);

                entity.ToTable("RefFinalidadxEjer");

                entity.Property(e => e.IdFinalidadxEjer).HasColumnName("idFinalidadxEjer");

                entity.Property(e => e.CodFinalidad)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("codFinalidad")
                    .IsFixedLength();

                entity.Property(e => e.EstaActivo)
                    .IsRequired()
                    .HasColumnName("estaActivo")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.FechaEliminacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaEliminacion");

                entity.Property(e => e.IdEjercicio).HasColumnName("idEjercicio");

                entity.Property(e => e.IdFinalidad).HasColumnName("idFinalidad");

                entity.HasOne(d => d.IdEjercicioNavigation)
                    .WithMany(p => p.RefFinalidadxEjers)
                    .HasForeignKey(d => d.IdEjercicio)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RefFinalidadxEjer_RefEjercicio");

                entity.HasOne(d => d.IdFinalidadNavigation)
                    .WithMany(p => p.RefFinalidadxEjers)
                    .HasForeignKey(d => d.IdFinalidad)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RefFinalidadxEjer_RefFinalidad");
            });

            modelBuilder.Entity<RefFinanciamiento>(entity =>
            {
                entity.HasKey(e => e.IdFinanciamiento);

                entity.ToTable("RefFinanciamiento");

                entity.HasComment("Tipos de financiemientos. Ejemplo: provincial, nacional");

                entity.Property(e => e.IdFinanciamiento)
                    .HasColumnName("idFinanciamiento")
                    .HasComment("Clave primaria, autoincrementable.Codigo identificador del financiamiento educativo.");

                entity.Property(e => e.EstaActivo)
                    .IsRequired()
                    .HasColumnName("estaActivo")
                    .HasDefaultValueSql("((1))")
                    .HasComment("Indica si esta activo");

                entity.Property(e => e.FechaEliminacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaEliminacion")
                    .HasComment("Fecha que termina la vigencia del financiamiento");

                entity.Property(e => e.FinanciamientoDesc)
                    .HasMaxLength(50)
                    .HasColumnName("financiamientoDesc")
                    .HasComment("Describe el tipo de financiamiento educativo. (Provincial, Nacional, etc.)");
            });

            modelBuilder.Entity<RefFuncion>(entity =>
            {
                entity.HasKey(e => e.IdFuncion);

                entity.ToTable("RefFuncion");

                entity.HasComment("Propio del presupuesto. Clasificacion de gastos por funcion. Ejemplo: Educacion elemental; media y tecnica");

                entity.Property(e => e.IdFuncion)
                    .HasColumnName("idFuncion")
                    .HasComment("Clave primaria, NO autoincrementable. Identificador de funcion");

                entity.Property(e => e.EstaActivo)
                    .IsRequired()
                    .HasColumnName("estaActivo")
                    .HasDefaultValueSql("((1))")
                    .HasComment("Indica si esta activa la funcion");

                entity.Property(e => e.FechaEliminacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaEliminacion")
                    .HasComment("Fecha que deja de estar activa la funcion");

                entity.Property(e => e.FuncionDesc)
                    .HasMaxLength(50)
                    .HasColumnName("funcionDesc")
                    .HasComment("Descripcion de la funcion segun el presupuesto. Ejemplo: Educacion Elemental; Educacion media y tecnica; Educacion superior");
            });

            modelBuilder.Entity<RefFuncionxEjer>(entity =>
            {
                entity.HasKey(e => e.IdFuncionxEjer);

                entity.ToTable("RefFuncionxEjer");

                entity.Property(e => e.IdFuncionxEjer).HasColumnName("idFuncionxEjer");

                entity.Property(e => e.CodFuncion)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("codFuncion")
                    .IsFixedLength();

                entity.Property(e => e.EstaActivo)
                    .IsRequired()
                    .HasColumnName("estaActivo")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.FechaEliminacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaEliminacion");

                entity.Property(e => e.IdEjercicio).HasColumnName("idEjercicio");

                entity.Property(e => e.IdFuncion).HasColumnName("idFuncion");

                entity.HasOne(d => d.IdEjercicioNavigation)
                    .WithMany(p => p.RefFuncionxEjers)
                    .HasForeignKey(d => d.IdEjercicio)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RefFuncionxEjer_RefEjercicio");

                entity.HasOne(d => d.IdFuncionNavigation)
                    .WithMany(p => p.RefFuncionxEjers)
                    .HasForeignKey(d => d.IdFuncion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RefFuncionxEjer_RefFuncion");
            });

            modelBuilder.Entity<RefGrupoNivel>(entity =>
            {
                entity.HasKey(e => e.IdGrupoNivel);

                entity.ToTable("RefGrupoNivel");

                entity.Property(e => e.IdGrupoNivel).HasColumnName("idGrupoNivel");

                entity.Property(e => e.EstaActivo)
                    .IsRequired()
                    .HasColumnName("estaActivo")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.FechaEliminacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaEliminacion");

                entity.Property(e => e.GrupoDesc)
                    .HasMaxLength(50)
                    .HasColumnName("grupoDesc");
            });

            modelBuilder.Entity<RefJornadum>(entity =>
            {
                entity.HasKey(e => e.IdJornada);

                entity.HasComment("Jornadas en las que se puede desempeñar una organizacion. Ejemplo: jornada completa, simple, etc.");

                entity.Property(e => e.IdJornada)
                    .HasColumnName("idJornada")
                    .HasComment("Clave primaria, autoincremental. Identificador de la jornada de la organizacion");

                entity.Property(e => e.EstaActivo)
                    .IsRequired()
                    .HasColumnName("estaActivo")
                    .HasDefaultValueSql("((1))")
                    .HasComment("Indica si esta activo (1) o no (0) el motivo de Alta");

                entity.Property(e => e.FechaEliminacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaEliminacion")
                    .HasComment("Fecha en la que deja de estar activa la jornada");

                entity.Property(e => e.JornadaDesc)
                    .HasMaxLength(20)
                    .HasColumnName("jornadaDesc")
                    .HasComment("Jornada de la organizacion. Ejemplo jornada simple, completa");

                entity.Property(e => e.Nemotecnico)
                    .HasMaxLength(2)
                    .HasColumnName("nemotecnico")
                    .IsFixedLength()
                    .HasComment("Nemotécnico de la jornada. Ejemplo JS, JC, AA");
            });

            modelBuilder.Entity<RefMe>(entity =>
            {
                entity.HasKey(e => e.IdMes);

                entity.Property(e => e.IdMes)
                    .ValueGeneratedNever()
                    .HasColumnName("idMes");

                entity.Property(e => e.Mes)
                    .HasMaxLength(10)
                    .HasColumnName("mes")
                    .IsFixedLength();
            });

            modelBuilder.Entity<RefModalidadAlimentarium>(entity =>
            {
                entity.HasKey(e => e.IdModAlimentaria);

                entity.Property(e => e.IdModAlimentaria)
                    .HasColumnName("idModAlimentaria")
                    .HasComment("Clave primaria, identificador de modalidad alimentaria");

                entity.Property(e => e.EstaActivo)
                    .IsRequired()
                    .HasColumnName("estaActivo")
                    .HasDefaultValueSql("((1))")
                    .HasComment("Campo para eliminacion logica. Valor 0 es igual a falso, valor 1 es igual a verdadero");

                entity.Property(e => e.FechaEliminacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaEliminacion")
                    .HasComment("Fecha de aliminación lógica");

                entity.Property(e => e.ModAlimentariaDesc)
                    .HasMaxLength(50)
                    .HasColumnName("modAlimentariaDesc")
                    .HasComment("Descripción de modalidad alimentaria");
            });

            modelBuilder.Entity<RefModalidadDia>(entity =>
            {
                entity.HasKey(e => e.IdModalidadDias)
                    .HasName("PK_ModalidadDias");

                entity.Property(e => e.IdModalidadDias).HasColumnName("idModalidadDias");

                entity.Property(e => e.EstaActivo)
                    .IsRequired()
                    .HasColumnName("estaActivo")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.FechaEliminacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaEliminacion");

                entity.Property(e => e.ModalidadDiasDesc)
                    .HasMaxLength(50)
                    .HasColumnName("modalidadDiasDesc");
            });

            modelBuilder.Entity<RefMotivoBaja>(entity =>
            {
                entity.HasKey(e => e.IdMotivoBaja);

                entity.ToTable("RefMotivoBaja");

                entity.HasComment("Motivos por los cuales se puede dar de baja un servicio o subservicio. Ejemplo: Designacion termino, renuncia,etc.");

                entity.Property(e => e.IdMotivoBaja)
                    .HasColumnName("idMotivoBaja")
                    .HasComment("Autoincremental");

                entity.Property(e => e.EstaActivo)
                    .IsRequired()
                    .HasColumnName("estaActivo")
                    .HasDefaultValueSql("((1))")
                    .HasComment("Indica si esta activo (1) o no (0) el motivo de baja");

                entity.Property(e => e.FechaEliminacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaEliminacion")
                    .HasComment("Fecha en la que deja de estar activo el motivo de baja");

                entity.Property(e => e.MotivoBajaDesc)
                    .HasMaxLength(50)
                    .HasColumnName("motivoBajaDesc")
                    .HasComment("Especifica el motivo de baja");
            });

            modelBuilder.Entity<RefMotivoCreacion>(entity =>
            {
                entity.HasKey(e => e.IdMotivoCreacion);

                entity.ToTable("RefMotivoCreacion");

                entity.HasComment("Motivos de creacion. Ejemplo: POF, NO POF");

                entity.Property(e => e.IdMotivoCreacion)
                    .HasColumnName("idMotivoCreacion")
                    .HasComment("Clave primaria, autoincrementable. Identificador de motivo de creacion");

                entity.Property(e => e.EstaActivo)
                    .IsRequired()
                    .HasColumnName("estaActivo")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.FechaEliminacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaEliminacion");

                entity.Property(e => e.MotivoCreacionDesc)
                    .HasMaxLength(50)
                    .HasColumnName("motivoCreacionDesc")
                    .HasComment("Indica si el cargo es POF (pertenece a la planta) o NO POF (no pertenece a la planta)");
            });

            modelBuilder.Entity<RefMotivoInstLegalPe>(entity =>
            {
                entity.HasKey(e => e.IdMotivoInstLegal)
                    .HasName("PK_RefMotivoInstLegal");

                entity.ToTable("RefMotivoInstLegalPE");

                entity.Property(e => e.IdMotivoInstLegal).HasColumnName("idMotivoInstLegal");

                entity.Property(e => e.EstaActivo)
                    .IsRequired()
                    .HasColumnName("estaActivo")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.FechaEliminacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaEliminacion");

                entity.Property(e => e.MotivoInstLegalDesc)
                    .HasMaxLength(50)
                    .HasColumnName("motivoInstLegalDesc");
            });

            modelBuilder.Entity<RefMotivoMovimientoPre>(entity =>
            {
                entity.HasKey(e => e.IdMotivoMovimientoPres)
                    .HasName("PK_MotivoMovimientoPres");

                entity.HasComment("Motivos por el cual se modifica la cantidad de cargos presupuestados ");

                entity.Property(e => e.IdMotivoMovimientoPres)
                    .HasColumnName("idMotivoMovimientoPres")
                    .HasComment("Identificador de motivo del movimiento sobre el presupuesto");

                entity.Property(e => e.EstaActivo)
                    .IsRequired()
                    .HasColumnName("estaActivo")
                    .HasDefaultValueSql("((1))")
                    .HasComment("Campo para eliminación lógica. Valor 1=verdadero, 0= falso ");

                entity.Property(e => e.FechaEliminacion)
                    .HasColumnType("date")
                    .HasColumnName("fechaEliminacion")
                    .HasComment("Fecha en la que deja de estar activo el motivo de movimiento");

                entity.Property(e => e.MotivoMovimientoDesc)
                    .HasMaxLength(100)
                    .HasColumnName("motivoMovimientoDesc")
                    .HasComment("Motivo por el cual se raliza un movimiento (cambio en la cantidad de cargos presupuestados). Ejemplo: Refuerzo");
            });

            modelBuilder.Entity<RefMovimiento>(entity =>
            {
                entity.HasKey(e => e.IdMovimiento);

                entity.ToTable("RefMovimiento");

                entity.HasComment("Movimientos que puede realizar un agente. Ejemplo:  alta, licencia, reubicacion, continuidad");

                entity.Property(e => e.IdMovimiento)
                    .HasColumnName("idMovimiento")
                    .HasComment("Clave primaria, autoincrementable. Identificador de movimiento docente");

                entity.Property(e => e.EstaActivo)
                    .IsRequired()
                    .HasColumnName("estaActivo")
                    .HasDefaultValueSql("((1))")
                    .HasComment("Campo para eliminacion logica. Valor 0 es igual a falso, valor 1 es igual a verdadero");

                entity.Property(e => e.FechaEliminacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaEliminacion")
                    .HasComment("Fecha en la que deja de estar activo el movimiento docente");

                entity.Property(e => e.GeneraSuplente).HasColumnName("generaSuplente");

                entity.Property(e => e.IdTipoMovIdRrhh).HasColumnName("idTipoMov_idRRHH");

                entity.Property(e => e.IdTipoMovimiento).HasColumnName("idTipoMovimiento");

                entity.Property(e => e.MovimientoDesc)
                    .HasMaxLength(100)
                    .HasColumnName("movimientoDesc")
                    .HasComment("Descripcion del movimiento que puede realizar un agente. Ejemplo: alta, licencia, reubicacion, continuidad");

                entity.HasOne(d => d.IdTipoMovimientoNavigation)
                    .WithMany(p => p.RefMovimientos)
                    .HasForeignKey(d => d.IdTipoMovimiento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RefMovimiento_RefTipoMovimiento");
            });

            modelBuilder.Entity<RefNivelEducativo>(entity =>
            {
                entity.HasKey(e => e.IdNivelEducativo);

                entity.ToTable("RefNivelEducativo");

                entity.HasComment("Niveles de enseñanza: Ejemplo: primario, secundario, etc,");

                entity.Property(e => e.IdNivelEducativo)
                    .HasColumnName("idNivelEducativo")
                    .HasComment("Clave primaria, autoincrementable. Identificador de nivel de escolaridad");

                entity.Property(e => e.EstaActivo)
                    .IsRequired()
                    .HasColumnName("estaActivo")
                    .HasDefaultValueSql("((1))")
                    .HasComment("Campo para eliminación lógica");

                entity.Property(e => e.FechaEliminacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaEliminacion")
                    .HasComment("Fecha  en la que deja de estar activo el nivel de escolaridad");

                entity.Property(e => e.IdGrupoNivel)
                    .HasColumnName("idGrupoNivel")
                    .HasComment("Puede tomar los valores 1,2,3, (Primario Secundario y Terciario) Campos que se utiliza para las Solicitudes");

                entity.Property(e => e.NivelEducativoDesc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nivelEducativoDesc")
                    .HasComment("Nombre del nivel de escolaridad: Ejemplo: primario, secundario, terciario, universitario");
            });

            modelBuilder.Entity<RefPaisNacionalidad>(entity =>
            {
                entity.HasKey(e => e.IdPaisNacionalidad)
                    .HasName("PK_RefPais");

                entity.ToTable("RefPaisNacionalidad");

                entity.HasComment("Paises con su respectiva nacionalidad");

                entity.Property(e => e.IdPaisNacionalidad)
                    .HasColumnName("idPaisNacionalidad")
                    .HasComment("Clave primaria, autoincrementable. Identificador de Pais-Nacionalidad");

                entity.Property(e => e.EstaActivo).HasColumnName("estaActivo");

                entity.Property(e => e.FechaEliminacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaEliminacion");

                entity.Property(e => e.Nacionalidad)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("nacionalidad")
                    .HasComment("Nombre de la nacionalidad que adopta");

                entity.Property(e => e.PaisDesc)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("paisDesc")
                    .HasComment("Nombre del país");
            });

            modelBuilder.Entity<RefParentesco>(entity =>
            {
                entity.HasKey(e => e.IdParentesco);

                entity.ToTable("RefParentesco");

                entity.HasComment("Relacion o vinculo de personas. Ejemplo: madre, padre, conyuge, etc.");

                entity.Property(e => e.IdParentesco)
                    .HasColumnName("idParentesco")
                    .HasComment("Clave primaria, autoincremental. Identificador de parentesco.");

                entity.Property(e => e.EstaActivo)
                    .IsRequired()
                    .HasColumnName("estaActivo")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.FechaEliminacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaEliminacion");

                entity.Property(e => e.ParentescoDesc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("parentescoDesc")
                    .HasComment("Descripcion de parentesco.");
            });

            modelBuilder.Entity<RefPermiso>(entity =>
            {
                entity.HasKey(e => new { e.IdPermiso, e.IdPermisoRel });

                entity.ToTable("RefPermiso");

                entity.Property(e => e.IdPermiso).HasColumnName("idPermiso");

                entity.Property(e => e.IdPermisoRel).HasColumnName("idPermisoRel");

                entity.Property(e => e.EstaActivo)
                    .IsRequired()
                    .HasColumnName("estaActivo")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.EstaMenu)
                    .HasColumnName("estaMenu")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.FechaAlta)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaAlta")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FechaEliminacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaEliminacion");

                entity.Property(e => e.IdAplicacion).HasColumnName("idAplicacion");

                entity.Property(e => e.Nivel1).HasMaxLength(50);

                entity.Property(e => e.Nivel2).HasMaxLength(50);

                entity.Property(e => e.PermisoDesc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("permisoDesc");

                entity.HasOne(d => d.IdAplicacionNavigation)
                    .WithMany(p => p.RefPermisos)
                    .HasForeignKey(d => d.IdAplicacion)
                    .HasConstraintName("FK_RefPermiso_RefAplicacion");
            });

            modelBuilder.Entity<RefRegimenEspCu>(entity =>
            {
                entity.HasKey(e => e.IdRegimen);

                entity.ToTable("RefRegimenEspCu");

                entity.Property(e => e.IdRegimen).HasColumnName("idRegimen");

                entity.Property(e => e.EstaActivo)
                    .IsRequired()
                    .HasColumnName("estaActivo")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.FechaEliminacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaEliminacion");

                entity.Property(e => e.RegimenDesc)
                    .HasMaxLength(20)
                    .HasColumnName("regimenDesc");
            });

            modelBuilder.Entity<RefRegimenLaboral>(entity =>
            {
                entity.HasKey(e => e.IdRegimenLaboral);

                entity.ToTable("RefRegimenLaboral");

                entity.HasComment("Ttipos de regimenes laborales. Ejemplo:  Docente, No Docente, Contratado Provincial");

                entity.Property(e => e.IdRegimenLaboral)
                    .HasColumnName("idRegimenLaboral")
                    .HasComment("Clave primaria, autoincrementable. Identificador de regimen laboral");

                entity.Property(e => e.EstaActivo)
                    .IsRequired()
                    .HasColumnName("estaActivo")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.FechaEliminacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaEliminacion");

                entity.Property(e => e.RegimenLaboralDesc)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("regimenLaboralDesc")
                    .HasComment("Describe el tipo de regimen laboral Docente, No Docente, Contratado Provincial");
            });

            modelBuilder.Entity<RefRegimenSalarial>(entity =>
            {
                entity.HasKey(e => e.IdRegimenSalarial);

                entity.ToTable("RefRegimenSalarial");

                entity.HasComment("El regimen salarial puede ser de tipo horas o cargo, etc.");

                entity.Property(e => e.IdRegimenSalarial)
                    .HasColumnName("idRegimenSalarial")
                    .HasComment("Clave primaria, autoincrementable. Identificador del regimen salarial");

                entity.Property(e => e.EstaActivo)
                    .IsRequired()
                    .HasColumnName("estaActivo")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.FechaEliminacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaEliminacion");

                entity.Property(e => e.RegimenSalarialDesc)
                    .HasMaxLength(50)
                    .HasColumnName("regimenSalarialDesc")
                    .HasComment("Indica si la Plaza es de tipo horas o bien un cargo");
            });

            modelBuilder.Entity<RefRegion>(entity =>
            {
                entity.HasKey(e => e.IdRegion);

                entity.ToTable("RefRegion");

                entity.HasComment("Regiones educativas. Ejemplo: region I, region II");

                entity.Property(e => e.IdRegion)
                    .HasColumnName("idRegion")
                    .HasComment("Clave primaria, autoincrementable. Identificador de la region educativa");

                entity.Property(e => e.EstaActivo)
                    .IsRequired()
                    .HasColumnName("estaActivo")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.FechaEliminacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaEliminacion");

                entity.Property(e => e.RegionDesc)
                    .HasMaxLength(50)
                    .HasColumnName("regionDesc")
                    .HasComment("Descriptivo de la region educativa a la que puede pertenecer un establecimiento");
            });

            modelBuilder.Entity<RefRol>(entity =>
            {
                entity.HasKey(e => e.IdRol)
                    .HasName("PK_tb_Rol");

                entity.ToTable("RefRol");

                entity.Property(e => e.IdRol).HasColumnName("idRol");

                entity.Property(e => e.EstaActivo)
                    .IsRequired()
                    .HasColumnName("estaActivo")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.FechaAlta)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaAlta");

                entity.Property(e => e.FechaEliminacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaEliminacion");

                entity.Property(e => e.RolDesc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("rolDesc");
            });

            modelBuilder.Entity<RefSexo>(entity =>
            {
                entity.HasKey(e => e.IdSexo);

                entity.ToTable("RefSexo");

                entity.HasComment("Genero");

                entity.Property(e => e.IdSexo)
                    .HasColumnName("idSexo")
                    .HasComment("Clave primaria. Identificador del sexo.");

                entity.Property(e => e.EstaActivo).HasColumnName("estaActivo");

                entity.Property(e => e.FechaEliminacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaEliminacion");

                entity.Property(e => e.Mnemo)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("mnemo")
                    .HasComment("");

                entity.Property(e => e.SexoDesc)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("sexoDesc")
                    .HasComment("Descripción del género");
            });

            modelBuilder.Entity<RefSistemaEducativo>(entity =>
            {
                entity.HasKey(e => e.IdSistemaEducativo);

                entity.ToTable("RefSistemaEducativo");

                entity.HasComment("Sistemas educativos");

                entity.Property(e => e.IdSistemaEducativo)
                    .HasColumnName("idSistemaEducativo")
                    .HasComment("Clave primaria, autoincrementable.Codigo identificador de sistema.");

                entity.Property(e => e.EstaActivo)
                    .IsRequired()
                    .HasColumnName("estaActivo")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.FechaEliminacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaEliminacion");

                entity.Property(e => e.SistemaEducativoDesc)
                    .HasMaxLength(30)
                    .HasColumnName("sistemaEducativoDesc")
                    .IsFixedLength()
                    .HasComment("Describe el sistema educativo");
            });

            modelBuilder.Entity<RefSituacionExtraordinarium>(entity =>
            {
                entity.HasKey(e => e.IdSituacionExtraordinaria);

                entity.HasComment("Situaciones extraordinarias. Ejemplo: afectacion; traslado transitorio; normal");

                entity.Property(e => e.IdSituacionExtraordinaria)
                    .HasColumnName("idSituacionExtraordinaria")
                    .HasComment("Clave primaria, autoincrementable. Identificador de Situacion extraordinaria");

                entity.Property(e => e.EstaActivo)
                    .IsRequired()
                    .HasColumnName("estaActivo")
                    .HasDefaultValueSql("((1))")
                    .HasComment("Campo para eliminacion logica. Valor 0 es igual a falso, valor 1 es igual a verdadero");

                entity.Property(e => e.FechaEliminacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaEliminacion")
                    .HasComment("Fecha en la que deja de estar activa la situacion extraordinaria");

                entity.Property(e => e.SituacionExtraordinariaDesc)
                    .HasMaxLength(50)
                    .HasColumnName("situacionExtraordinariaDesc")
                    .HasComment("Descripcion de la situacion extraordinaria. Ejemplo: afectacion; traslado transitorio; normal");
            });

            modelBuilder.Entity<RefSituacionRevistum>(entity =>
            {
                entity.HasKey(e => e.IdSituacionRevista);

                entity.HasComment("Situacion en la que puede estar trabajando un docente. Ejemplo: titular; provisional, suplente");

                entity.Property(e => e.IdSituacionRevista)
                    .HasColumnName("idSituacionRevista")
                    .HasComment("Clave primaria, autoincrementable. Identificador de situacion en la que puede estar trabajando un docente");

                entity.Property(e => e.EstaActivo).HasColumnName("estaActivo");

                entity.Property(e => e.FechaEliminacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaEliminacion");

                entity.Property(e => e.SituacionRevistaDesc)
                    .HasMaxLength(25)
                    .HasColumnName("situacionRevistaDesc")
                    .HasComment("Descripcion de la situacion de revista. Ejemplo: titular; provisional, suplente");
            });

            modelBuilder.Entity<RefSubEstadoPlaza>(entity =>
            {
                entity.HasKey(e => e.IdSubEstadoPlaza);

                entity.ToTable("RefSubEstadoPlaza");

                entity.Property(e => e.IdSubEstadoPlaza).HasColumnName("idSubEstadoPlaza");

                entity.Property(e => e.EstaActivo)
                    .IsRequired()
                    .HasColumnName("estaActivo")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.FechaEliminacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaEliminacion");

                entity.Property(e => e.IdEstadoPlaza)
                    .HasColumnName("idEstadoPlaza")
                    .HasComment("Clave foranea, Estado Plaza. Ejemplo: activo");

                entity.Property(e => e.Subestado)
                    .HasMaxLength(15)
                    .HasColumnName("subestado")
                    .HasComment("Descripción del subestado. Ejemplo para estado activo, subestado vacante, libre, ocupada");

                entity.HasOne(d => d.IdEstadoPlazaNavigation)
                    .WithMany(p => p.RefSubEstadoPlazas)
                    .HasForeignKey(d => d.IdEstadoPlaza)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RefSubEstadoPlaza_RefEstadoPlaza");
            });

            modelBuilder.Entity<RefSubvencion>(entity =>
            {
                entity.HasKey(e => e.IdSubvencion);

                entity.ToTable("RefSubvencion");

                entity.Property(e => e.IdSubvencion)
                    .HasColumnName("idSubvencion")
                    .HasComment("Clave primaria. Identificador de tipo de subvencion");

                entity.Property(e => e.EstaActivo)
                    .IsRequired()
                    .HasColumnName("estaActivo")
                    .HasDefaultValueSql("((1))")
                    .HasComment("Campo para eliminacion logica. Valor 0 es igual a falso, valor 1 es igual a verdadero");

                entity.Property(e => e.FechaEliminacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaEliminacion")
                    .HasComment("Fecha de eliminacion lógica");

                entity.Property(e => e.SubvencionDesc)
                    .HasMaxLength(60)
                    .HasColumnName("subvencionDesc")
                    .HasComment("Descripcion de tipo de subvención. Ej: Con subvencion- privada, Coon subvencion - gestion social, Sin subvebcion ");
            });

            modelBuilder.Entity<RefSumarioAlcance>(entity =>
            {
                entity.HasKey(e => e.IdSumarioAlcance)
                    .HasName("PK_SumarioAlcance");

                entity.ToTable("RefSumarioAlcance");

                entity.Property(e => e.IdSumarioAlcance)
                    .ValueGeneratedNever()
                    .HasColumnName("idSumarioAlcance");

                entity.Property(e => e.AlcandeDesc)
                    .HasMaxLength(100)
                    .HasColumnName("alcandeDesc");

                entity.Property(e => e.EstaActivo)
                    .IsRequired()
                    .HasColumnName("estaActivo")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.FechaEliminacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaEliminacion");
            });

            modelBuilder.Entity<RefSumarioEtapa>(entity =>
            {
                entity.HasKey(e => e.IdSumarioEtapa)
                    .HasName("PK_SumarioEtapa");

                entity.ToTable("RefSumarioEtapa");

                entity.Property(e => e.IdSumarioEtapa).HasColumnName("idSumarioEtapa");

                entity.Property(e => e.EstaActivo)
                    .IsRequired()
                    .HasColumnName("estaActivo")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.FechaEliminacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaEliminacion");

                entity.Property(e => e.SumarioEtapaDesc)
                    .HasMaxLength(50)
                    .HasColumnName("sumarioEtapaDesc");
            });

            modelBuilder.Entity<RefSumarioSancion>(entity =>
            {
                entity.HasKey(e => e.IdSancion)
                    .HasName("PK_RefSancion");

                entity.ToTable("RefSumarioSancion");

                entity.Property(e => e.IdSancion).HasColumnName("idSancion");

                entity.Property(e => e.EstaActivo)
                    .IsRequired()
                    .HasColumnName("estaActivo")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.FechaEliminacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaEliminacion");

                entity.Property(e => e.SancionDesc)
                    .HasMaxLength(250)
                    .HasColumnName("sancionDesc");
            });

            modelBuilder.Entity<RefTemporalidad>(entity =>
            {
                entity.HasKey(e => e.IdTemporalidad);

                entity.ToTable("RefTemporalidad");

                entity.Property(e => e.IdTemporalidad).HasColumnName("idTemporalidad");

                entity.Property(e => e.EstaActivo)
                    .IsRequired()
                    .HasColumnName("estaActivo")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.FechaEliminacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaEliminacion");

                entity.Property(e => e.TemporalidadDesc)
                    .HasMaxLength(20)
                    .HasColumnName("temporalidadDesc");
            });

            modelBuilder.Entity<RefTipoAsignaturaPrevium>(entity =>
            {
                entity.HasKey(e => e.IdTipoAsignaturaPrevia)
                    .HasName("PK_TipoAsignaturaPrevia");

                entity.Property(e => e.IdTipoAsignaturaPrevia)
                    .HasColumnName("idTipoAsignaturaPrevia")
                    .HasComment("Primary key");

                entity.Property(e => e.EstaActivo)
                    .IsRequired()
                    .HasColumnName("estaActivo")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.FechaEliminacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaEliminacion");

                entity.Property(e => e.MNemo)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("mNemo");

                entity.Property(e => e.TipoAsignaturaPreviaDesc)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("tipoAsignaturaPreviaDesc");
            });

            modelBuilder.Entity<RefTipoDescanso>(entity =>
            {
                entity.HasKey(e => e.IdTipoDescanso);

                entity.ToTable("RefTipoDescanso");

                entity.Property(e => e.IdTipoDescanso).HasColumnName("idTipoDescanso");

                entity.Property(e => e.EstaActivo)
                    .IsRequired()
                    .HasColumnName("estaActivo")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.FechaEliminacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaEliminacion");

                entity.Property(e => e.TipoDescansoDesc)
                    .HasMaxLength(64)
                    .HasColumnName("tipoDescansoDesc");
            });

            modelBuilder.Entity<RefTipoDictaman>(entity =>
            {
                entity.HasKey(e => e.IdTipoDictamen);

                entity.Property(e => e.IdTipoDictamen).HasColumnName("idTipoDictamen");

                entity.Property(e => e.EstaActivo)
                    .IsRequired()
                    .HasColumnName("estaActivo")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.FechaEliminacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaEliminacion");

                entity.Property(e => e.TipoDictamenDesc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("tipoDictamenDesc");
            });

            modelBuilder.Entity<RefTipoDocumento>(entity =>
            {
                entity.HasKey(e => e.IdTipoDocumento);

                entity.ToTable("RefTipoDocumento");

                entity.HasComment("Descripción del tipo de documento. Ejemplo: Documento Nacional de Identidad, Libreta cívica");

                entity.Property(e => e.IdTipoDocumento)
                    .HasColumnName("idTipoDocumento")
                    .HasComment("Clave primaria, autoincrementable. Identificador de tipo de documento");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .HasColumnName("descripcion")
                    .HasComment("Descripción del tipo de documento. Ejemplo: Documento Nacional de Identidad, Libreta cívica");

                entity.Property(e => e.EstaActivo)
                    .IsRequired()
                    .HasColumnName("estaActivo")
                    .HasDefaultValueSql("((1))")
                    .HasComment("Campo para eliminación lógica");

                entity.Property(e => e.FechaEliminacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaEliminacion")
                    .HasComment("Fecha en la que deja de estar activo el tipo de documento");

                entity.Property(e => e.TipoDocumentoDesc)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("tipoDocumentoDesc")
                    .HasComment("Nombre del tipo de documento. Ejemplo: DNI, LC");
            });

            modelBuilder.Entity<RefTipoEdificio>(entity =>
            {
                entity.HasKey(e => e.IdTipoEdificio);

                entity.ToTable("RefTipoEdificio");

                entity.HasComment("Almacena el tipo de edificio, ej.: escuela, municipio, policia, hospital, etc.");

                entity.Property(e => e.IdTipoEdificio)
                    .HasColumnName("idTipoEdificio")
                    .HasComment("Clave primaria, autoincrementable. Identificador del tipo de edificio.");

                entity.Property(e => e.EstaActivo)
                    .IsRequired()
                    .HasColumnName("estaActivo")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.FechaEliminacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaEliminacion");

                entity.Property(e => e.TipoEdificioDesc)
                    .HasMaxLength(50)
                    .HasColumnName("tipoEdificioDesc")
                    .HasComment("Almacena el tipo de edificio, ej.: escuela, municipio, policia, hospital, etc.");
            });

            modelBuilder.Entity<RefTipoEducacion>(entity =>
            {
                entity.HasKey(e => e.IdTipoEducacion);

                entity.ToTable("RefTipoEducacion");

                entity.HasComment("Tipo de educacion. Ejemplo: especial, comun");

                entity.Property(e => e.IdTipoEducacion)
                    .HasColumnName("idTipoEducacion")
                    .HasComment("Clave primaria, autoincrementable. Identificador del tipo de educacion");

                entity.Property(e => e.EstaActivo)
                    .IsRequired()
                    .HasColumnName("estaActivo")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.FechaEliminacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaEliminacion");

                entity.Property(e => e.TipoEducacionDesc)
                    .HasMaxLength(50)
                    .HasColumnName("tipoEducacionDesc")
                    .HasComment("Descriptivo del tipo de educacion: Especial; Comun");
            });

            modelBuilder.Entity<RefTipoEfectoInstLegal>(entity =>
            {
                entity.HasKey(e => e.IdTipoEfecto);

                entity.ToTable("RefTipoEfectoInstLegal");

                entity.Property(e => e.IdTipoEfecto).HasColumnName("idTipoEfecto");

                entity.Property(e => e.EstaActivo)
                    .IsRequired()
                    .HasColumnName("estaActivo")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.FechaEliminacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaEliminacion");

                entity.Property(e => e.TipoEfectoDesc)
                    .HasMaxLength(50)
                    .HasColumnName("tipoEfectoDesc");
            });

            modelBuilder.Entity<RefTipoEspacioCurricular>(entity =>
            {
                entity.HasKey(e => e.IdTipoEspacioCurricular);

                entity.ToTable("RefTipoEspacioCurricular");

                entity.HasComment("Tipo de espacio curricular. Ejemplo: asignatura, taller, etc.");

                entity.Property(e => e.IdTipoEspacioCurricular)
                    .HasColumnName("idTipoEspacioCurricular")
                    .HasComment("Clave primaria, autoincrementable. Identificador de tipo de espacio curricular");

                entity.Property(e => e.EstaActivo)
                    .IsRequired()
                    .HasColumnName("estaActivo")
                    .HasDefaultValueSql("((1))")
                    .HasComment("Campo para eliminacion logica. Valor 0 es igual a falso, valor 1 es igual a verdadero");

                entity.Property(e => e.FechaEliminacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaEliminacion")
                    .HasComment("Fecha en la que deja de estar activo el tipo de espacio curricular");

                entity.Property(e => e.TipoEspacioCurricularDesc)
                    .HasMaxLength(50)
                    .HasColumnName("tipoEspacioCurricularDesc")
                    .HasComment("Nombre del tipo de espacio curricular. Ejemplo: Asignatura, taller");
            });

            modelBuilder.Entity<RefTipoFuncion>(entity =>
            {
                entity.HasKey(e => e.IdTipoFuncion);

                entity.ToTable("RefTipoFuncion");

                entity.HasComment("Tipo de funcion, tiene como objetivo agrupar los cargos funcionales");

                entity.Property(e => e.IdTipoFuncion)
                    .HasColumnName("idTipoFuncion")
                    .HasComment("Clave primaria, autoincrementable. Identificador de tipo de funcion o agrupamiento de funciones");

                entity.Property(e => e.EstaActivo)
                    .IsRequired()
                    .HasColumnName("estaActivo")
                    .HasDefaultValueSql("((1))")
                    .HasComment("Campo para eliminación lógica. Valor 0 es igual a falso, valor 1 es igual a verdadero");

                entity.Property(e => e.FechaEliminacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaEliminacion")
                    .HasComment("Fecha en la que deja de estar activo le tipo de funcion");

                entity.Property(e => e.TipoFuncionDesc)
                    .HasMaxLength(100)
                    .HasColumnName("tipoFuncionDesc")
                    .HasComment("Nombre del tipo de funcion o agrupamiento");
            });

            modelBuilder.Entity<RefTipoGoceHaber>(entity =>
            {
                entity.HasKey(e => e.IdTipoGoceHaber);

                entity.ToTable("RefTipoGoceHaber");

                entity.HasComment("Describe el tipo de goce de haberes, ej.: Con Goce de Haberes, Sin Goce de Haberes.");

                entity.Property(e => e.IdTipoGoceHaber)
                    .HasColumnName("idTipoGoceHaber")
                    .HasComment("Clave primaria, autoincrementable. Identificador del tipo de goce de haberes.");

                entity.Property(e => e.Abreviatura)
                    .HasMaxLength(10)
                    .HasColumnName("abreviatura")
                    .HasComment("Describe la abreviatura del tipo de goce de haberes, ej.: CGH, SGH.");

                entity.Property(e => e.EstaActivo)
                    .IsRequired()
                    .HasColumnName("estaActivo")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.FechaEliminacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaEliminacion");

                entity.Property(e => e.TipoGoceHaberDesc)
                    .HasMaxLength(30)
                    .HasColumnName("tipoGoceHaberDesc")
                    .HasComment("Describe el tipo de goce de haberes, ej.: Con Goce de Haberes, Sin Goce de Haberes.");
            });

            modelBuilder.Entity<RefTipoInasistencium>(entity =>
            {
                entity.HasKey(e => e.IdTipoInasistencia);

                entity.HasComment("");

                entity.Property(e => e.IdTipoInasistencia).HasColumnName("idTipoInasistencia");

                entity.Property(e => e.EstaActivo).HasColumnName("estaActivo");

                entity.Property(e => e.Mnemo)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("mnemo");

                entity.Property(e => e.TipoInasistenciaDesc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("tipoInasistenciaDesc");

                entity.Property(e => e.Valor)
                    .HasColumnType("numeric(3, 1)")
                    .HasColumnName("valor");
            });

            modelBuilder.Entity<RefTipoInstrumentoLegal>(entity =>
            {
                entity.HasKey(e => e.IdTipoInstrumentoLegal);

                entity.ToTable("RefTipoInstrumentoLegal");

                entity.HasComment("Tipos de instrumento legales. Ejemplo: resolucion, norma, etc.");

                entity.Property(e => e.IdTipoInstrumentoLegal)
                    .HasColumnName("idTipoInstrumentoLegal")
                    .HasComment("Clave primaria, autoincrementable. Identificador de tipo de instrumento legal");

                entity.Property(e => e.EstaActivo)
                    .IsRequired()
                    .HasColumnName("estaActivo")
                    .HasDefaultValueSql("((1))")
                    .HasComment("Campo de eliminación logica");

                entity.Property(e => e.FechaEliminacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaEliminacion")
                    .HasComment("Fecha en la que deja de estar activo el tipo de instrumento legal");

                entity.Property(e => e.TipoInstrumentoLegalDesc)
                    .HasMaxLength(50)
                    .HasColumnName("tipoInstrumentoLegalDesc")
                    .HasComment("Nombre del tipo de instrumento legal");
            });

            modelBuilder.Entity<RefTipoJuridiccion>(entity =>
            {
                entity.HasKey(e => e.IdTipoJuridiccion);

                entity.ToTable("RefTipoJuridiccion");

                entity.Property(e => e.IdTipoJuridiccion).HasColumnName("idTipoJuridiccion");

                entity.Property(e => e.EstaActivo)
                    .IsRequired()
                    .HasColumnName("estaActivo")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.FechaEliminacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaEliminacion");

                entity.Property(e => e.TipoJuridiccionDesc)
                    .HasMaxLength(64)
                    .HasColumnName("tipoJuridiccionDesc");
            });

            modelBuilder.Entity<RefTipoMovimiento>(entity =>
            {
                entity.HasKey(e => e.IdTipoMovimiento);

                entity.ToTable("RefTipoMovimiento");

                entity.Property(e => e.IdTipoMovimiento).HasColumnName("idTipoMovimiento");

                entity.Property(e => e.EsHito)
                    .HasColumnName("esHito")
                    .HasComment("Permite identificar si es un movimiento tipo evento, es decir no abarca un período concreto");

                entity.Property(e => e.EstaActivo)
                    .IsRequired()
                    .HasColumnName("estaActivo")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.FechaEliminacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaEliminacion");

                entity.Property(e => e.TipoMovimientoDesc)
                    .HasMaxLength(50)
                    .HasColumnName("tipoMovimientoDesc");
            });

            modelBuilder.Entity<RefTipoNovedad>(entity =>
            {
                entity.HasKey(e => e.IdTipoNovedad)
                    .HasName("PK_RefTipoNovedad_1");

                entity.ToTable("RefTipoNovedad");

                entity.Property(e => e.IdTipoNovedad).HasColumnName("idTipoNovedad");

                entity.Property(e => e.ConGoceHaber).HasColumnName("conGoceHaber");

                entity.Property(e => e.EstaActivo)
                    .IsRequired()
                    .HasColumnName("estaActivo")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.FechaEliminacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaEliminacion");

                entity.Property(e => e.TipoNovedadDesc)
                    .HasMaxLength(50)
                    .HasColumnName("tipoNovedadDesc");
            });

            modelBuilder.Entity<RefTipoNovedadLua>(entity =>
            {
                entity.HasKey(e => e.IdTipoNovedad)
                    .HasName("PK_RefTipoNovedad");

                entity.ToTable("RefTipoNovedad_LUA");

                entity.Property(e => e.IdTipoNovedad)
                    .ValueGeneratedNever()
                    .HasColumnName("idTipoNovedad");

                entity.Property(e => e.EstaActivo).HasColumnName("estaActivo");

                entity.Property(e => e.Estado)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("estado");

                entity.Property(e => e.TipoNovedadDesc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("tipoNovedadDesc");
            });

            modelBuilder.Entity<RefTipoOrganizacion>(entity =>
            {
                entity.HasKey(e => e.IdTipoOrganizacion);

                entity.ToTable("RefTipoOrganizacion");

                entity.HasComment("La organización puede ser un establecimiento educativo, organismo de gobierno, etc.");

                entity.Property(e => e.IdTipoOrganizacion)
                    .HasColumnName("idTipoOrganizacion")
                    .HasComment("Clave primaria, autoincrementable. Identificador del tipo de organizacion");

                entity.Property(e => e.EstaActivo)
                    .IsRequired()
                    .HasColumnName("estaActivo")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.FechaEliminacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaEliminacion");

                entity.Property(e => e.TipoOrganizacionDesc)
                    .HasMaxLength(60)
                    .HasColumnName("tipoOrganizacionDesc")
                    .HasComment("Descriptivo almacena si la organizacion es un establecimiento educativo, organismo de gobierno");
            });

            modelBuilder.Entity<RefTipoPaquetePlaza>(entity =>
            {
                entity.HasKey(e => e.IdTipoPaquetePlaza)
                    .HasName("PK_RefTipoPaquete");

                entity.ToTable("RefTipoPaquetePlaza");

                entity.HasComment("");

                entity.Property(e => e.IdTipoPaquetePlaza)
                    .HasColumnName("idTipoPaquetePlaza")
                    .HasComment("Clave primaria, autoincrementable.Codigo identificador del tipo de paquete.");

                entity.Property(e => e.EstaActivo).HasColumnName("estaActivo");

                entity.Property(e => e.FechaEliminacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaEliminacion");

                entity.Property(e => e.TipoPaquetePlazaDesc)
                    .HasMaxLength(50)
                    .HasColumnName("tipoPaquetePlazaDesc")
                    .HasComment("Describe el tipo de paquete.");
            });

            modelBuilder.Entity<RefTipoPeriodoEscolar>(entity =>
            {
                entity.HasKey(e => e.IdTipoPeriodoEscolar);

                entity.ToTable("RefTipoPeriodoEscolar");

                entity.Property(e => e.IdTipoPeriodoEscolar).HasColumnName("idTipoPeriodoEscolar");

                entity.Property(e => e.EstaActivo).HasColumnName("estaActivo");

                entity.Property(e => e.FechaEliminacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaEliminacion");

                entity.Property(e => e.TipoPeriodoEscolarDesc)
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<RefTipoPlaza>(entity =>
            {
                entity.HasKey(e => e.IdTipoPlaza)
                    .HasName("PK_TipoSolicitud");

                entity.ToTable("RefTipoPlaza");

                entity.Property(e => e.IdTipoPlaza)
                    .HasColumnName("idTipoPlaza")
                    .HasComment("Clave primaria, autoincremental. Identificador de tipo de solicitud");

                entity.Property(e => e.EstaActivo)
                    .IsRequired()
                    .HasColumnName("estaActivo")
                    .HasDefaultValueSql("((1))")
                    .HasComment("Campo para eliminacion logica");

                entity.Property(e => e.FechaEliminacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaEliminacion");

                entity.Property(e => e.TipoPlazaDesc)
                    .HasMaxLength(50)
                    .HasColumnName("tipoPlazaDesc")
                    .HasComment("Tipo de solicitud: ordinaria, extraordinaria");
            });

            modelBuilder.Entity<RefTipoServicio>(entity =>
            {
                entity.HasKey(e => e.IdTipoServicio);

                entity.ToTable("RefTipoServicio");

                entity.HasComment("Tipos de servicio. Ejemplo: De base, sujeto a licencia, etc.");

                entity.Property(e => e.IdTipoServicio)
                    .HasColumnName("idTipoServicio")
                    .HasComment("Clave primaria, autoincrementable. Identificador de tipo de servicio");

                entity.Property(e => e.EstaActivo)
                    .IsRequired()
                    .HasColumnName("estaActivo")
                    .HasDefaultValueSql("((1))")
                    .HasComment("Campo para eliminación lógica. Valor 0 es igual a falso, valor 1 es igual a verdadero");

                entity.Property(e => e.FechaEliminacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaEliminacion")
                    .HasComment("Fecha en la que deja de estar activo el tipo de servicio");

                entity.Property(e => e.TipoServicioDesc)
                    .HasMaxLength(100)
                    .HasColumnName("tipoServicioDesc")
                    .HasComment("Descripción del tipo de servicio. Ejemplo: De base, Sujeto a licencia, Servicio componente");
            });

            modelBuilder.Entity<RefTipoSolicitud>(entity =>
            {
                entity.HasKey(e => e.IdTipoSolicitud);

                entity.ToTable("RefTipoSolicitud");

                entity.Property(e => e.IdTipoSolicitud).HasColumnName("idTipoSolicitud");

                entity.Property(e => e.EstaActivo)
                    .IsRequired()
                    .HasColumnName("estaActivo")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.FechaEliminacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaEliminacion");

                entity.Property(e => e.TipoSolicitudDesc)
                    .HasMaxLength(50)
                    .HasColumnName("tipoSolicitudDesc");
            });

            modelBuilder.Entity<RefTipoSumario>(entity =>
            {
                entity.HasKey(e => e.IdTipoSumario);

                entity.ToTable("RefTipoSumario");

                entity.Property(e => e.IdTipoSumario).HasColumnName("idTipoSumario");

                entity.Property(e => e.EstaActivo)
                    .IsRequired()
                    .HasColumnName("estaActivo")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.FechaEliminacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaEliminacion");

                entity.Property(e => e.TipoSumarioDesc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("tipoSumarioDesc");
            });

            modelBuilder.Entity<RefTipoTablero>(entity =>
            {
                entity.HasKey(e => e.IdTipoTablero);

                entity.ToTable("RefTipoTablero");

                entity.Property(e => e.IdTipoTablero).HasColumnName("idTipoTablero");

                entity.Property(e => e.EsEducativo)
                    .IsRequired()
                    .HasColumnName("esEducativo")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.EstaActivo)
                    .IsRequired()
                    .HasColumnName("estaActivo")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.FechaEliminacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaEliminacion");

                entity.Property(e => e.IdGrupoNivel).HasColumnName("idGrupoNivel");

                entity.Property(e => e.IdTurno).HasColumnName("idTurno");

                entity.Property(e => e.TipoTableroDesc)
                    .HasMaxLength(50)
                    .HasColumnName("tipoTableroDesc");

                entity.HasOne(d => d.IdGrupoNivelNavigation)
                    .WithMany(p => p.RefTipoTableros)
                    .HasForeignKey(d => d.IdGrupoNivel)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RefTipoTablero_RefGrupoNivel");

                entity.HasOne(d => d.IdTurnoNavigation)
                    .WithMany(p => p.RefTipoTableros)
                    .HasForeignKey(d => d.IdTurno)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RefTipoTablero_RefTurno");
            });

            modelBuilder.Entity<RefTipoTenencium>(entity =>
            {
                entity.HasKey(e => e.IdTipoTenencia);

                entity.HasComment("Tipos de tenencia. Un edificio puede ser propio, alquilado, etc. ");

                entity.Property(e => e.IdTipoTenencia)
                    .HasColumnName("idTipoTenencia")
                    .HasComment("Clave primaria, autoincrementable. Identificador del tipo de tenencia del edificio.");

                entity.Property(e => e.EstaActivo)
                    .IsRequired()
                    .HasColumnName("estaActivo")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.FechaEliminacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaEliminacion");

                entity.Property(e => e.TipoTenenciaDesc)
                    .HasMaxLength(20)
                    .HasColumnName("tipoTenenciaDesc")
                    .HasComment("Describe el tipo de tenencia de un edificio, ej.: propio, alquilado, cedido, etc.");
            });

            modelBuilder.Entity<RefTitulo>(entity =>
            {
                entity.HasKey(e => e.IdTitulo);

                entity.ToTable("RefTitulo");

                entity.Property(e => e.IdTitulo).HasColumnName("idTitulo");

                entity.Property(e => e.CantidadAnios).HasColumnName("cantidadAnios");

                entity.Property(e => e.EstaActivo).HasColumnName("estaActivo");

                entity.Property(e => e.FechaEliminacion)
                    .HasColumnType("date")
                    .HasColumnName("fechaEliminacion");

                entity.Property(e => e.IdNivelEducativo).HasColumnName("idNivelEducativo");

                entity.Property(e => e.TituloDesc)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("tituloDesc");

                entity.HasOne(d => d.IdNivelEducativoNavigation)
                    .WithMany(p => p.RefTitulos)
                    .HasForeignKey(d => d.IdNivelEducativo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RefTitulo_RefNivelEducativo");
            });

            modelBuilder.Entity<RefTituloHabilitante>(entity =>
            {
                entity.HasKey(e => e.IdTituloHabilitante);

                entity.ToTable("RefTituloHabilitante");

                entity.Property(e => e.IdTituloHabilitante).HasColumnName("idTituloHabilitante");

                entity.Property(e => e.EstaActivo).HasColumnName("estaActivo");

                entity.Property(e => e.FechaEliminacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaEliminacion");

                entity.Property(e => e.TituloHabilitanteDesc)
                    .HasMaxLength(50)
                    .HasColumnName("tituloHabilitanteDesc");
            });

            modelBuilder.Entity<RefTurno>(entity =>
            {
                entity.HasKey(e => e.IdTurno);

                entity.ToTable("RefTurno");

                entity.HasComment("Turnos en los que se puede desempeñar una organización");

                entity.Property(e => e.IdTurno)
                    .HasColumnName("idTurno")
                    .HasComment("Clave primaria, autoincrementable. Identificador de turno");

                entity.Property(e => e.EstaActivo)
                    .IsRequired()
                    .HasColumnName("estaActivo")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.FechaEliminacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaEliminacion");

                entity.Property(e => e.TurnoDesc)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("turnoDesc")
                    .HasComment("Descripción del turno. Ejemplo: mañana, mañana-tarde");
            });

            modelBuilder.Entity<RefUdeO>(entity =>
            {
                entity.HasKey(e => e.IdUdeO)
                    .HasName("PK_UdeO");

                entity.ToTable("RefUdeO");

                entity.HasComment("Unidad de Organizacion. Ejemplo. Ministerio de Educacion (F1), Dirección General de Administración (F1A)");

                entity.Property(e => e.IdUdeO)
                    .HasColumnName("idUdeO")
                    .HasComment("Clave primaria, autoincrementable. Identificador de Unidad de Organizacion");

                entity.Property(e => e.EstaActivo)
                    .IsRequired()
                    .HasColumnName("estaActivo")
                    .HasDefaultValueSql("((1))")
                    .HasComment("Campo para eliminacion logica. Valor 0 es igual a false, valor 1 es igual a verdadero");

                entity.Property(e => e.FechaEliminacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaEliminacion")
                    .HasComment("Fecha en la que deja de estar activa la Unidad de Organizacion");

                entity.Property(e => e.UdeoDesc)
                    .HasMaxLength(100)
                    .HasColumnName("udeoDesc")
                    .HasComment("Descripcion de la unidad de organizacion");
            });

            modelBuilder.Entity<RefUdeOxEjer>(entity =>
            {
                entity.HasKey(e => e.IdUdeOxEjer);

                entity.ToTable("RefUdeOxEjer");

                entity.Property(e => e.IdUdeOxEjer).HasColumnName("idUdeOxEjer");

                entity.Property(e => e.CodUdeO)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("codUdeO")
                    .IsFixedLength();

                entity.Property(e => e.EstaActivo)
                    .IsRequired()
                    .HasColumnName("estaActivo")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.FechaEliminacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaEliminacion");

                entity.Property(e => e.IdEjercicio).HasColumnName("idEjercicio");

                entity.Property(e => e.IdUdeO).HasColumnName("idUdeO");

                entity.HasOne(d => d.IdEjercicioNavigation)
                    .WithMany(p => p.RefUdeOxEjers)
                    .HasForeignKey(d => d.IdEjercicio)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RefUdeOxEjer_RefEjercicio");

                entity.HasOne(d => d.IdUdeONavigation)
                    .WithMany(p => p.RefUdeOxEjers)
                    .HasForeignKey(d => d.IdUdeO)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RefUdeOxEjer_RefUdeO");
            });

            modelBuilder.Entity<RefUnidadTemporal>(entity =>
            {
                entity.HasKey(e => e.IdUnidadTemporal);

                entity.ToTable("RefUnidadTemporal");

                entity.HasComment("Unidadades temporales. Ejemplo: dias corridos, dias habiles.");

                entity.Property(e => e.IdUnidadTemporal)
                    .HasColumnName("idUnidadTemporal")
                    .HasComment("Clave primaria, autoincrementable.Codigo identificador de la unidad temporal.");

                entity.Property(e => e.EstaActivo)
                    .IsRequired()
                    .HasColumnName("estaActivo")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.FechaEliminacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaEliminacion");

                entity.Property(e => e.UnidadTemporalDesc)
                    .HasMaxLength(50)
                    .HasColumnName("unidadTemporalDesc")
                    .HasComment("Descripcion de la unidad temporal, ej.: dias corridos, dias habiles.");
            });

            modelBuilder.Entity<RefUnidadTemporalContexto>(entity =>
            {
                entity.HasKey(e => e.IdUnidadTemporalContexto);

                entity.ToTable("RefUnidadTemporalContexto");

                entity.HasComment(" Unidad temporales según  el contexto, ej.: en el año calendario, en el año de servicio, en el mes calendario, etc.");

                entity.Property(e => e.IdUnidadTemporalContexto)
                    .HasColumnName("idUnidadTemporalContexto")
                    .HasComment("Clave primaria, autoincrementable.Codigo identificador de la unidad temporal contexto.");

                entity.Property(e => e.EstaActivo)
                    .IsRequired()
                    .HasColumnName("estaActivo")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.FechaEliminacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaEliminacion");

                entity.Property(e => e.UnidadTemporalContextoDesc)
                    .HasMaxLength(50)
                    .HasColumnName("unidadTemporalContextoDesc")
                    .HasComment("Descripcion de la unidad temporal contexto, ej.: en el año calendario, en el año de servicio, en el mes calendario, etc.");
            });

            modelBuilder.Entity<RefValidacionLicencium>(entity =>
            {
                entity.HasKey(e => e.IdValidacionLicencia);

                entity.Property(e => e.IdValidacionLicencia).HasColumnName("idValidacionLicencia");

                entity.Property(e => e.EstaActivo)
                    .IsRequired()
                    .HasColumnName("estaActivo")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.FechaEliminacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaEliminacion");

                entity.Property(e => e.ValidacionLicenciaNombre)
                    .HasMaxLength(50)
                    .HasColumnName("validacionLicenciaNombre");
            });

            modelBuilder.Entity<RefZona>(entity =>
            {
                entity.HasKey(e => e.IdZona);

                entity.ToTable("RefZona");

                entity.HasComment("Zonas educativas. Ejemplo Zona 0 (desfavorable)");

                entity.Property(e => e.IdZona)
                    .HasColumnName("idZona")
                    .HasComment("Clave primaria, autoincrementable. Identificador de zona ");

                entity.Property(e => e.EstaActivo)
                    .IsRequired()
                    .HasColumnName("estaActivo")
                    .HasDefaultValueSql("((1))")
                    .HasComment("Clave para eliminación lógica. Valor 0 es igual a falso, valor 1 es igual a verdadero");

                entity.Property(e => e.FechaEliminacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaEliminacion")
                    .HasComment("Fecha en la que deja de estar activa la zona");

                entity.Property(e => e.Porcentaje)
                    .HasColumnName("porcentaje")
                    .HasComment("porcentaje que corresponde a la zona, para liquidacion");

                entity.Property(e => e.ZonaDesc)
                    .HasMaxLength(20)
                    .HasColumnName("zonaDesc")
                    .HasComment("Descripcion de la zona. Ejemplo: Zona 0; zona 1");
            });

            modelBuilder.Entity<ReqSolicitudPrimarium>(entity =>
            {
                entity.HasKey(e => new { e.IdSolicitud, e.IdRequerimiento });

                entity.HasComment("SIAC. Requerimientos de plazas pertenecientes a una solicitud (nivel primario) \r\n");

                entity.Property(e => e.IdSolicitud)
                    .HasColumnName("idSolicitud")
                    .HasComment("Codigo identificador de solicitud");

                entity.Property(e => e.IdRequerimiento)
                    .HasColumnName("idRequerimiento")
                    .HasComment("Codigo identificador de cada requerimiento de una solicitud");

                entity.Property(e => e.AdmiteSuplente).HasColumnName("admiteSuplente");

                entity.Property(e => e.Cantidad)
                    .HasColumnName("cantidad")
                    .HasComment("Cantidad de cargos solicitados de una determinada categoría");

                entity.Property(e => e.Caracter)
                    .HasMaxLength(15)
                    .HasColumnName("caracter")
                    .IsFixedLength()
                    .HasComment("Caracter del cargo, puede ser definitov o provisional");

                entity.Property(e => e.CargaMateria)
                    .HasColumnName("cargaMateria")
                    .HasComment("");

                entity.Property(e => e.CobraIncentivo).HasColumnName("cobraIncentivo");

                entity.Property(e => e.Cupof).HasColumnName("cupof");

                entity.Property(e => e.EstaActivo).HasColumnName("estaActivo");

                entity.Property(e => e.FechaDesde)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaDesde")
                    .HasComment("Fecha de inidio del periodo de habilitacion del cargo");

                entity.Property(e => e.FechaHasta)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaHasta")
                    .HasComment("Fecha de fin de habilitacion del cargo");

                entity.Property(e => e.IdCargoFuncional)
                    .HasColumnName("idCargoFuncional")
                    .HasComment("Codigo identificador de cargo funcional");

                entity.Property(e => e.IdCategoriaPresupuesto)
                    .HasColumnName("idCategoriaPresupuesto")
                    .HasComment("Codigo identificador de categoría (registrada en la ley de presupuesto)");

                entity.Property(e => e.IdDivision)
                    .HasColumnName("idDivision")
                    .HasComment("Clave foranea, Identificador de division. Campo opcional");

                entity.Property(e => e.IdEspacioAsignatura)
                    .HasColumnName("idEspacioAsignatura")
                    .HasComment("Codigo identificador de materia");

                entity.Property(e => e.IdEstadoRequerimiento)
                    .HasColumnName("idEstadoRequerimiento")
                    .HasComment("Clave foranea, identificador de estado en que se puede encontrar un requerimiento. Ejemplo: autorizado, habilitado. rechazado, etc.");

                entity.Property(e => e.IdFinanciamiento).HasColumnName("idFinanciamiento");

                entity.Property(e => e.IdJornada)
                    .HasColumnName("idJornada")
                    .HasComment("Codigo identificador de jornada (simple, completa, etc.)");

                entity.Property(e => e.IdOrgCompartida)
                    .HasColumnName("idOrgCompartida")
                    .HasComment("Identificador de Organización en la que se comparte el cargo");

                entity.Property(e => e.IdOrganizacionTurno)
                    .HasColumnName("idOrganizacionTurno")
                    .HasComment("Codigo identificador de organizacion turno");

                entity.Property(e => e.IdPlanUnidad).HasColumnName("idPlanUnidad");

                entity.Property(e => e.IdRegimenLaboral).HasColumnName("idRegimenLaboral");

                entity.Property(e => e.IdRegimenSalarial).HasColumnName("idRegimenSalarial");

                entity.Property(e => e.IdSistemaEducativo).HasColumnName("idSistemaEducativo");

                entity.Property(e => e.ObsEstado)
                    .HasMaxLength(300)
                    .HasColumnName("obsEstado")
                    .HasComment("Descirpcion detallada acera del estado del requerimiento");

                entity.Property(e => e.Observacion)
                    .HasMaxLength(500)
                    .HasColumnName("observacion");

                entity.Property(e => e.PCupof).HasColumnName("pCupof");

                entity.Property(e => e.PartidaTeducacion)
                    .HasMaxLength(10)
                    .HasColumnName("partidaTEducacion")
                    .HasComment("Indica si es educación formal o no formal");

                entity.HasOne(d => d.IdCargoFuncionalNavigation)
                    .WithMany(p => p.ReqSolicitudPrimaria)
                    .HasForeignKey(d => d.IdCargoFuncional)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ReqSolicitudPrimaria_CargoFuncional");

                entity.HasOne(d => d.IdDivisionNavigation)
                    .WithMany(p => p.ReqSolicitudPrimaria)
                    .HasForeignKey(d => d.IdDivision)
                    .HasConstraintName("FK_ReqSolicitudPrimaria_Division");

                entity.HasOne(d => d.IdEspacioAsignaturaNavigation)
                    .WithMany(p => p.ReqSolicitudPrimaria)
                    .HasForeignKey(d => d.IdEspacioAsignatura)
                    .HasConstraintName("FK_ReqSolicitudPrimaria_EspacioAsignatura");

                entity.HasOne(d => d.IdEstadoRequerimientoNavigation)
                    .WithMany(p => p.ReqSolicitudPrimaria)
                    .HasForeignKey(d => d.IdEstadoRequerimiento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ReqSolicitudPrimaria_RefEstadoSolicitud");

                entity.HasOne(d => d.IdFinanciamientoNavigation)
                    .WithMany(p => p.ReqSolicitudPrimaria)
                    .HasForeignKey(d => d.IdFinanciamiento)
                    .HasConstraintName("FK_ReqSolicitudPrimaria_RefFinanciamiento");

                entity.HasOne(d => d.IdJornadaNavigation)
                    .WithMany(p => p.ReqSolicitudPrimaria)
                    .HasForeignKey(d => d.IdJornada)
                    .HasConstraintName("FK_ReqSolicitudPrimaria_RefJornada");

                entity.HasOne(d => d.IdPlanUnidadNavigation)
                    .WithMany(p => p.ReqSolicitudPrimaria)
                    .HasForeignKey(d => d.IdPlanUnidad)
                    .HasConstraintName("FK_ReqSolicitudPrimaria_PlanUnidad");

                entity.HasOne(d => d.IdRegimenLaboralNavigation)
                    .WithMany(p => p.ReqSolicitudPrimaria)
                    .HasForeignKey(d => d.IdRegimenLaboral)
                    .HasConstraintName("FK_ReqSolicitudPrimaria_RefRegimenLaboral");

                entity.HasOne(d => d.IdRegimenSalarialNavigation)
                    .WithMany(p => p.ReqSolicitudPrimaria)
                    .HasForeignKey(d => d.IdRegimenSalarial)
                    .HasConstraintName("FK_ReqSolicitudPrimaria_RefRegimenSalarial");

                entity.HasOne(d => d.IdSistemaEducativoNavigation)
                    .WithMany(p => p.ReqSolicitudPrimaria)
                    .HasForeignKey(d => d.IdSistemaEducativo)
                    .HasConstraintName("FK_ReqSolicitudPrimaria_RefSistemaEducativo");
            });

            modelBuilder.Entity<RespDependencium>(entity =>
            {
                entity.HasKey(e => e.IdRespDependencia);

                entity.Property(e => e.IdRespDependencia).HasColumnName("idRespDependencia");

                entity.Property(e => e.EstaActivo)
                    .IsRequired()
                    .HasColumnName("estaActivo")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.FechaDesde)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaDesde");

                entity.Property(e => e.FechaEliminacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaEliminacion");

                entity.Property(e => e.FechaHasta)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaHasta");

                entity.Property(e => e.IdDependencia).HasColumnName("idDependencia");

                entity.Property(e => e.IdPersona).HasColumnName("idPersona");
            });

            modelBuilder.Entity<Servicio>(entity =>
            {
                entity.HasKey(e => e.IdServicio);

                entity.ToTable("Servicio");

                entity.HasComment("Servicio o cargos que ocupa un agente");

                entity.HasIndex(e => e.IdSolicitudDetalleDesignacion, "idx_idSolicitudDetalleDesignacion_notnull")
                    .IsUnique()
                    .HasFilter("([idSolicitudDetalleDesignacion] IS NOT NULL)");

                entity.Property(e => e.IdServicio)
                    .HasColumnName("idServicio")
                    .HasComment("Clave primaria, autoincrementable. Identificador de un servicio de un agente");

                entity.Property(e => e.AdmiteSuplente).HasColumnName("admiteSuplente");

                entity.Property(e => e.EsEditable)
                    .IsRequired()
                    .HasColumnName("esEditable")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.EstaActivo)
                    .IsRequired()
                    .HasColumnName("estaActivo")
                    .HasDefaultValueSql("((1))")
                    .HasComment("Campo para eliminación lógica. Valor 0 es igual a falso, valor 1 es igual a verdadero");

                entity.Property(e => e.EstaFrenteAlumnoInicial).HasColumnName("estaFrenteAlumnoInicial");

                entity.Property(e => e.FechaDesde)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaDesde")
                    .HasComment("Fecha desde la cual se inicia el servicio del agente");

                entity.Property(e => e.FechaHasta)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaHasta")
                    .HasComment("Fecha en la que finaliza el servicio de un agente");

                entity.Property(e => e.Fechaeliminacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaeliminacion")
                    .HasComment("Fecha de eliminaicón lógica");

                entity.Property(e => e.IdExpteAlta)
                    .HasColumnName("idExpteAlta")
                    .HasComment("Clave foranea, guarda el expediente que tramita el inicio del servicio");

                entity.Property(e => e.IdExpteBaja)
                    .HasColumnName("idExpteBaja")
                    .HasComment("Clave foranea, guarda el expediente de que tramita la finalización del servicio");

                entity.Property(e => e.IdInstrumentoLegalAlta)
                    .HasColumnName("idInstrumentoLegalAlta")
                    .HasComment("Clave foranea, guarda el instrumento legal que avala el inicio del servicio");

                entity.Property(e => e.IdInstrumentoLegalBaja)
                    .HasColumnName("idInstrumentoLegalBaja")
                    .HasComment("Clave foranea, guarda el instrumento legal que avala la finalización del servicio");

                entity.Property(e => e.IdMotivoAlta)
                    .HasColumnName("idMotivoAlta")
                    .HasComment("Clave foranea. Indentificador del motivo de alta de servicio. Ejemplo: 1. Designacion por concurso normal; 2.Designacion sinconcurso");

                entity.Property(e => e.IdMotivoBaja)
                    .HasColumnName("idMotivoBaja")
                    .HasComment("Clave foranea. Identificador de la causa o motivo de la baja del servicio. Ejemplo: 1. Termino, 2. Renuncia");

                entity.Property(e => e.IdPersona)
                    .HasColumnName("idPersona")
                    .HasComment("Clave foranea. Identificador de agente");

                entity.Property(e => e.IdPlaza)
                    .HasColumnName("idPlaza")
                    .HasComment("Clave foranea. Identificador de la plaza asociada al servicio");

                entity.Property(e => e.IdPlazaHistoria).HasColumnName("idPlazaHistoria");

                entity.Property(e => e.IdSituacionRevista)
                    .HasColumnName("idSituacionRevista")
                    .HasComment("Clave foranea. Identificador de situacion de revista. Ejemplo: 1. Titular 2. Interino");

                entity.Property(e => e.IdSolicitudDetalleDesignacion)
                    .HasColumnName("idSolicitudDetalleDesignacion")
                    .HasComment("Identificador de solicitud de designación que generó el servicio");

                entity.Property(e => e.IdSubservicioOrigen)
                    .HasColumnName("idSubservicioOrigen")
                    .HasComment("Subservicio de licencia que da origen al nuevo servicio (suplente)");

                entity.Property(e => e.IdSubservicioSeorigen)
                    .HasColumnName("idSubservicioSEOrigen")
                    .HasComment("Subservicio de Situación Extraordinaria que da origen al nuevo servicio ");

                entity.Property(e => e.IdTerminoLectivo).HasColumnName("idTerminoLectivo");

                entity.Property(e => e.IdTipoServicio)
                    .HasColumnName("idTipoServicio")
                    .HasComment("Clave foranea. Identificador de tipo de servicio. Ejemplo 1. De base; 2. Sujeto a licencia");

                entity.Property(e => e.Observaciones).HasColumnName("observaciones");

                entity.HasOne(d => d.IdInstrumentoLegalAltaNavigation)
                    .WithMany(p => p.ServicioIdInstrumentoLegalAltaNavigations)
                    .HasForeignKey(d => d.IdInstrumentoLegalAlta)
                    .HasConstraintName("FK_Servicio_InstrumentoLegal");

                entity.HasOne(d => d.IdInstrumentoLegalBajaNavigation)
                    .WithMany(p => p.ServicioIdInstrumentoLegalBajaNavigations)
                    .HasForeignKey(d => d.IdInstrumentoLegalBaja)
                    .HasConstraintName("FK_Servicio_InstrumentoLegal1");

                entity.HasOne(d => d.IdMotivoAltaNavigation)
                    .WithMany(p => p.Servicios)
                    .HasForeignKey(d => d.IdMotivoAlta)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Servicio_RefMovimiento");

                entity.HasOne(d => d.IdPersonaNavigation)
                    .WithMany(p => p.Servicios)
                    .HasForeignKey(d => d.IdPersona)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Servicio_Persona");

                entity.HasOne(d => d.IdSituacionRevistaNavigation)
                    .WithMany(p => p.Servicios)
                    .HasForeignKey(d => d.IdSituacionRevista)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Servicio_RefSituacionRevista");

                entity.HasOne(d => d.IdSolicitudDetalleDesignacionNavigation)
                    .WithOne(p => p.Servicio)
                    .HasForeignKey<Servicio>(d => d.IdSolicitudDetalleDesignacion)
                    .HasConstraintName("FK_Servicio_SolicitudDetalle");

                entity.HasOne(d => d.IdTituloHabilitanteNavigation)
                    .WithMany(p => p.Servicios)
                    .HasForeignKey(d => d.IdTituloHabilitante)
                    .HasConstraintName("FK_Servicio_RefTituloHabilitante");

                entity.HasOne(d => d.IdPlazaNavigation)
                    .WithMany(p => p.Servicios)
                    .HasForeignKey(d => new { d.IdPlaza, d.IdPlazaHistoria })
                    .HasConstraintName("FK_Servicio_PlazaHistoria");
            });

            modelBuilder.Entity<ServicioExterno>(entity =>
            {
                entity.HasKey(e => e.IdServicioExterno)
                    .IsClustered(false);

                entity.ToTable("ServicioExterno");

                entity.Property(e => e.IdServicioExterno).HasColumnName("idServicioExterno");

                entity.Property(e => e.Años).HasColumnName("años");

                entity.Property(e => e.Dias).HasColumnName("dias");

                entity.Property(e => e.EstaActivo)
                    .IsRequired()
                    .HasColumnName("estaActivo")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.FechaDesde)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("fechaDesde");

                entity.Property(e => e.FechaHasta)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("fechaHasta");

                entity.Property(e => e.Fechaeliminacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaeliminacion");

                entity.Property(e => e.IdHistoriaOrg).HasColumnName("idHistoriaOrg");

                entity.Property(e => e.IdOrganizacion).HasColumnName("idOrganizacion");

                entity.Property(e => e.IdPersona).HasColumnName("idPersona");

                entity.Property(e => e.Meses).HasColumnName("meses");

                entity.Property(e => e.Observaciones).HasColumnName("observaciones");

                entity.HasOne(d => d.IdPersonaNavigation)
                    .WithMany(p => p.ServicioExternos)
                    .HasForeignKey(d => d.IdPersona)
                    .HasConstraintName("FK_ServicioExterno_Persona");

                entity.HasOne(d => d.Id)
                    .WithMany(p => p.ServicioExternos)
                    .HasForeignKey(d => new { d.IdOrganizacion, d.IdHistoriaOrg })
                    .HasConstraintName("FK_ServicioExterno_Organizacion");
            });

            modelBuilder.Entity<ServicioView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ServicioView");

                entity.Property(e => e.AdmiteSuplente).HasColumnName("admiteSuplente");

                entity.Property(e => e.Apellido)
                    .HasMaxLength(50)
                    .HasColumnName("apellido");

                entity.Property(e => e.BajaAutomatica).HasColumnName("bajaAutomatica");

                entity.Property(e => e.CargoFuncionalDesc)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("cargoFuncionalDesc");

                entity.Property(e => e.CargoSalarialDesc)
                    .HasMaxLength(100)
                    .HasColumnName("cargoSalarialDesc");

                entity.Property(e => e.CobraIncentivo).HasColumnName("cobraIncentivo");

                entity.Property(e => e.Curso)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("curso");

                entity.Property(e => e.DivisionDesc)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("divisionDesc");

                entity.Property(e => e.EsEditable).HasColumnName("esEditable");

                entity.Property(e => e.EstaActivo).HasColumnName("estaActivo");

                entity.Property(e => e.EstaFrenteAlumnoInicial).HasColumnName("estaFrenteAlumnoInicial");

                entity.Property(e => e.FechaDesde)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaDesde");

                entity.Property(e => e.FechaHabilitacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaHabilitacion");

                entity.Property(e => e.FechaHasta)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaHasta");

                entity.Property(e => e.FechaTermino)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaTermino");

                entity.Property(e => e.Fechaeliminacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaeliminacion");

                entity.Property(e => e.GeneraPresupuesto).HasColumnName("generaPresupuesto");

                entity.Property(e => e.IdAfectacion).HasColumnName("idAfectacion");

                entity.Property(e => e.IdCargoFuncional).HasColumnName("idCargoFuncional");

                entity.Property(e => e.IdDivision).HasColumnName("idDivision");

                entity.Property(e => e.IdExpteAlta).HasColumnName("idExpteAlta");

                entity.Property(e => e.IdExpteBaja).HasColumnName("idExpteBaja");

                entity.Property(e => e.IdExpteCreacion).HasColumnName("idExpteCreacion");

                entity.Property(e => e.IdFinanciamiento).HasColumnName("idFinanciamiento");

                entity.Property(e => e.IdGrupoNivel).HasColumnName("idGrupoNivel");

                entity.Property(e => e.IdHistoriaOrg).HasColumnName("idHistoriaOrg");

                entity.Property(e => e.IdInstrumentoLegalAlta).HasColumnName("idInstrumentoLegalAlta");

                entity.Property(e => e.IdInstrumentoLegalBaja).HasColumnName("idInstrumentoLegalBaja");

                entity.Property(e => e.IdInstrumentoLegalCreacion).HasColumnName("idInstrumentoLegalCreacion");

                entity.Property(e => e.IdMotivoAlta).HasColumnName("idMotivoAlta");

                entity.Property(e => e.IdMotivoBaja).HasColumnName("idMotivoBaja");

                entity.Property(e => e.IdMotivoCreacion).HasColumnName("idMotivoCreacion");

                entity.Property(e => e.IdOrganizacion).HasColumnName("idOrganizacion");

                entity.Property(e => e.IdOrganizacionNivelEduc).HasColumnName("idOrganizacionNivelEduc");

                entity.Property(e => e.IdOrganizacionTurno).HasColumnName("idOrganizacionTurno");

                entity.Property(e => e.IdPersona).HasColumnName("idPersona");

                entity.Property(e => e.IdPlanAsignatura).HasColumnName("idPlanAsignatura");

                entity.Property(e => e.IdPlanUnidad).HasColumnName("idPlanUnidad");

                entity.Property(e => e.IdPlaza).HasColumnName("idPlaza");

                entity.Property(e => e.IdPlazaHistoria).HasColumnName("idPlazaHistoria");

                entity.Property(e => e.IdRegimenLaboral).HasColumnName("idRegimenLaboral");

                entity.Property(e => e.IdRegimenSalarial).HasColumnName("idRegimenSalarial");

                entity.Property(e => e.IdServicio).HasColumnName("idServicio");

                entity.Property(e => e.IdSistemaEducativo).HasColumnName("idSistemaEducativo");

                entity.Property(e => e.IdSituacionRevista).HasColumnName("idSituacionRevista");

                entity.Property(e => e.IdSolicitudDetalleDesignacion).HasColumnName("idSolicitudDetalleDesignacion");

                entity.Property(e => e.IdSubservicioOrigen).HasColumnName("idSubservicioOrigen");

                entity.Property(e => e.IdSubservicioSeorigen).HasColumnName("idSubservicioSEOrigen");

                entity.Property(e => e.IdTemporalidad).HasColumnName("idTemporalidad");

                entity.Property(e => e.IdTerminoLectivo).HasColumnName("idTerminoLectivo");

                entity.Property(e => e.IdTipoServicio).HasColumnName("idTipoServicio");

                entity.Property(e => e.InstrumentoLegalAltaDesc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("instrumentoLegalAltaDesc");

                entity.Property(e => e.InstrumentoLegalBajaDesc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("instrumentoLegalBajaDesc");

                entity.Property(e => e.MaxPlazaHistoria).HasColumnName("maxPlazaHistoria");

                entity.Property(e => e.NivelEducativoDesc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nivelEducativoDesc");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .HasColumnName("nombre");

                entity.Property(e => e.Observacion)
                    .HasMaxLength(255)
                    .HasColumnName("observacion");

                entity.Property(e => e.Observaciones).HasColumnName("observaciones");

                entity.Property(e => e.OrganizacionDesc)
                    .HasMaxLength(250)
                    .HasColumnName("organizacionDesc");

                entity.Property(e => e.PlanEstudioDesc)
                    .HasMaxLength(100)
                    .HasColumnName("planEstudioDesc");

                entity.Property(e => e.SituacionRevistaDesc)
                    .HasMaxLength(25)
                    .HasColumnName("situacionRevistaDesc");

                entity.Property(e => e.TurnoDesc)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("turnoDesc");
            });

            modelBuilder.Entity<SolicitudDetalle>(entity =>
            {
                entity.HasKey(e => e.IdSolicitudDetalle);

                entity.ToTable("SolicitudDetalle");

                entity.Property(e => e.IdSolicitudDetalle).HasColumnName("idSolicitudDetalle");

                entity.Property(e => e.EstaActivo)
                    .IsRequired()
                    .HasColumnName("estaActivo")
                    .HasDefaultValueSql("((1))")
                    .HasComment("Campo para eliminaicón lógica.  ");

                entity.Property(e => e.FechaEliminacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaEliminacion")
                    .HasComment("Fecha de eliminación de la baja lógica");

                entity.Property(e => e.IdCircuitoEtapaLegajo)
                    .HasColumnName("idCircuitoEtapaLegajo")
                    .HasComment("Identificador del circuito que debe seguir la solicitud según su tipo.");

                entity.Property(e => e.IdEstadoSolicitudLegajo)
                    .HasColumnName("idEstadoSolicitudLegajo")
                    .HasComment("Identificador de estado del detalle de solicitud");

                entity.Property(e => e.IdExpteSolicitud)
                    .HasColumnName("idExpteSolicitud")
                    .HasComment("Clave foranea. Identificador del expediente con el que se tramita la solicitud");

                entity.Property(e => e.IdInstrumentoLegal)
                    .HasColumnName("idInstrumentoLegal")
                    .HasComment("Clave foranea. Identificador del instrumento legal que avala el subservicio");

                entity.Property(e => e.IdMovimiento).HasColumnName("idMovimiento");

                entity.Property(e => e.IdPersona)
                    .HasColumnName("idPersona")
                    .HasComment("Clave foranea. Identificador de agente");

                entity.Property(e => e.IdServicio)
                    .HasColumnName("idServicio")
                    .HasComment("Clave foranea Identificador del servicio al cual está asociado este subservicio");

                entity.Property(e => e.IdSolicitudLegajo)
                    .HasColumnName("idSolicitudLegajo")
                    .HasComment("Identificador de cabecera de solicitud");

                entity.Property(e => e.ObsEstado)
                    .HasMaxLength(100)
                    .HasColumnName("obsEstado")
                    .HasComment("Observacion del estado");

                entity.Property(e => e.Observaciones)
                    .HasColumnName("observaciones")
                    .HasComment("Observaciones");

                entity.HasOne(d => d.IdCircuitoEtapaLegajoNavigation)
                    .WithMany(p => p.SolicitudDetalles)
                    .HasForeignKey(d => d.IdCircuitoEtapaLegajo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SolicitudDetalle_CircuitoEtapaLegajo");

                entity.HasOne(d => d.IdEstadoSolicitudLegajoNavigation)
                    .WithMany(p => p.SolicitudDetalles)
                    .HasForeignKey(d => d.IdEstadoSolicitudLegajo)
                    .HasConstraintName("FK_SolicitudDetalle_RefEstadosSolicitudLegajo");

                entity.HasOne(d => d.IdInstrumentoLegalNavigation)
                    .WithMany(p => p.SolicitudDetalles)
                    .HasForeignKey(d => d.IdInstrumentoLegal)
                    .HasConstraintName("FK_SolicitudDetalle_InstrumentoLegal");

                entity.HasOne(d => d.IdMovimientoNavigation)
                    .WithMany(p => p.SolicitudDetalles)
                    .HasForeignKey(d => d.IdMovimiento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SolicitudDetalle_RefMovimiento");

                entity.HasOne(d => d.IdPersonaNavigation)
                    .WithMany(p => p.SolicitudDetalles)
                    .HasForeignKey(d => d.IdPersona)
                    .HasConstraintName("FK_SolicitudDetalle_Persona");

                entity.HasOne(d => d.IdServicioNavigation)
                    .WithMany(p => p.SolicitudDetalles)
                    .HasForeignKey(d => d.IdServicio)
                    .HasConstraintName("FK_SolicitudDetalle_Servicio");

                entity.HasOne(d => d.IdSolicitudLegajoNavigation)
                    .WithMany(p => p.SolicitudDetalles)
                    .HasForeignKey(d => d.IdSolicitudLegajo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SolicitudDetalle_SolicitudLegajo");
            });

            modelBuilder.Entity<SolicitudDetalleBaja>(entity =>
            {
                entity.HasKey(e => e.IdSolicitudDetalle)
                    .HasName("PK_SolicitudDetalleBaja_1");

                entity.ToTable("SolicitudDetalleBaja");

                entity.Property(e => e.IdSolicitudDetalle)
                    .ValueGeneratedNever()
                    .HasColumnName("idSolicitudDetalle")
                    .HasComment("Identificador de cabecera de solicitud");

                entity.Property(e => e.Fecha)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha")
                    .HasComment("Fecha a partir de la cual finaliza el servicio");

                entity.Property(e => e.FechaHasta)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaHasta")
                    .HasComment("fecha de Fin del Servicio antes de la Baja");

                entity.HasOne(d => d.IdSolicitudDetalleNavigation)
                    .WithOne(p => p.SolicitudDetalleBaja)
                    .HasForeignKey<SolicitudDetalleBaja>(d => d.IdSolicitudDetalle)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SolicitudDetalleBaja_SolicitudDetalle");
            });

            modelBuilder.Entity<SolicitudDetalleCambioSr>(entity =>
            {
                entity.HasKey(e => e.IdSolicitudDetalle);

                entity.ToTable("SolicitudDetalleCambioSR");

                entity.Property(e => e.IdSolicitudDetalle)
                    .ValueGeneratedNever()
                    .HasColumnName("idSolicitudDetalle");

                entity.Property(e => e.FechaDesde)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaDesde");

                entity.Property(e => e.FechaHasta)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaHasta");

                entity.Property(e => e.IdSituacionRevista).HasColumnName("idSituacionRevista");

                entity.HasOne(d => d.IdSituacionRevistaNavigation)
                    .WithMany(p => p.SolicitudDetalleCambioSrs)
                    .HasForeignKey(d => d.IdSituacionRevista)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SolicitudDetalleCambioSR_RefSituacionRevista");

                entity.HasOne(d => d.IdSolicitudDetalleNavigation)
                    .WithOne(p => p.SolicitudDetalleCambioSr)
                    .HasForeignKey<SolicitudDetalleCambioSr>(d => d.IdSolicitudDetalle)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SolicitudDetalleCambioSR_SolicitudDetalle");
            });

            modelBuilder.Entity<SolicitudDetalleDesignacion>(entity =>
            {
                entity.HasKey(e => e.IdSolicitudDetalle)
                    .HasName("PK_SolicitudDetalleDesignacion_1");

                entity.ToTable("SolicitudDetalleDesignacion");

                entity.Property(e => e.IdSolicitudDetalle)
                    .ValueGeneratedNever()
                    .HasColumnName("idSolicitudDetalle")
                    .HasComment("Identificador de la cabecera de solicitud");

                entity.Property(e => e.AdmiteSuplente).HasColumnName("admiteSuplente");

                entity.Property(e => e.Apellido)
                    .HasMaxLength(50)
                    .HasColumnName("apellido")
                    .HasComment("Apellido del agente");

                entity.Property(e => e.Cuil)
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("cuil")
                    .HasComment("Cuil");

                entity.Property(e => e.EstaFrenteAlumno)
                    .HasColumnName("estaFrenteAlumno")
                    .HasComment("Indica si el servicio se cumple frente a alumnos");

                entity.Property(e => e.FechaDesde)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaDesde");

                entity.Property(e => e.FechaHasta)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaHasta");

                entity.Property(e => e.IdPlaza)
                    .HasColumnName("idPlaza")
                    .HasComment("Identificador de la plaza vinculada al servicio");

                entity.Property(e => e.IdPlazaHistoria).HasColumnName("idPlazaHistoria");

                entity.Property(e => e.IdSexo)
                    .HasColumnName("idSexo")
                    .HasComment("Identificador de sexo del agente");

                entity.Property(e => e.IdSituacionRevista)
                    .HasColumnName("idSituacionRevista")
                    .HasComment("Identificador de situación de revista:. Ejemplo: 1. Titular, 2. Interino");

                entity.Property(e => e.IdSolicitudDetalleSitExt)
                    .HasColumnName("idSolicitudDetalleSitExt")
                    .HasComment("Identificador del detalle de solicitud de situacióin extraordinaria, en caso de idTipoSolicitud = 7 Alta por situación extraordinaria");

                entity.Property(e => e.IdTerminoLectivo)
                    .HasColumnName("idTerminoLectivo")
                    .HasComment("Identificador de termino lectivo ITL (fecha hasta)");

                entity.Property(e => e.IdTipoDocumento)
                    .HasColumnName("idTipoDocumento")
                    .HasComment("Identificador de tipo de documento. En caso de que el agente no exista en la base de datos");

                entity.Property(e => e.IdTipoServicio)
                    .HasColumnName("idTipoServicio")
                    .HasComment("Identificador de tipo de servicio, ejemplo: 1. de base , 2. sujeto a licencia");

                entity.Property(e => e.IdTituloHabilitante)
                    .HasColumnName("idTituloHabilitante")
                    .HasComment("Identificador de título habilitante ");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .HasColumnName("nombre")
                    .HasComment("Nombre del agente");

                entity.Property(e => e.NroDocumento)
                    .HasColumnName("nroDocumento")
                    .HasComment("nro de documento");

                entity.HasOne(d => d.IdSexoNavigation)
                    .WithMany(p => p.SolicitudDetalleDesignacions)
                    .HasForeignKey(d => d.IdSexo)
                    .HasConstraintName("FK_SolicitudDetalleDesignacion_RefSexo");

                entity.HasOne(d => d.IdSituacionRevistaNavigation)
                    .WithMany(p => p.SolicitudDetalleDesignacions)
                    .HasForeignKey(d => d.IdSituacionRevista)
                    .HasConstraintName("FK_SolicitudDetalleDesignacion_RefSituacionRevista");

                entity.HasOne(d => d.IdSolicitudDetalleNavigation)
                    .WithOne(p => p.SolicitudDetalleDesignacionIdSolicitudDetalleNavigation)
                    .HasForeignKey<SolicitudDetalleDesignacion>(d => d.IdSolicitudDetalle)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SolicitudDetalleDesignacion_SolicitudDetalle");

                entity.HasOne(d => d.IdSolicitudDetalleSitExtNavigation)
                    .WithMany(p => p.SolicitudDetalleDesignacionIdSolicitudDetalleSitExtNavigations)
                    .HasForeignKey(d => d.IdSolicitudDetalleSitExt)
                    .HasConstraintName("FK_SolicitudDetalleDesignacion_SolicitudDetalle1");

                entity.HasOne(d => d.IdTerminoLectivoNavigation)
                    .WithMany(p => p.SolicitudDetalleDesignacions)
                    .HasForeignKey(d => d.IdTerminoLectivo)
                    .HasConstraintName("FK_SolicitudDetalleDesignacion_TerminoLectivo");

                entity.HasOne(d => d.IdTipoDocumentoNavigation)
                    .WithMany(p => p.SolicitudDetalleDesignacions)
                    .HasForeignKey(d => d.IdTipoDocumento)
                    .HasConstraintName("FK_SolicitudDetalleDesignacion_RefTipoDocumento");

                entity.HasOne(d => d.IdTipoServicioNavigation)
                    .WithMany(p => p.SolicitudDetalleDesignacions)
                    .HasForeignKey(d => d.IdTipoServicio)
                    .HasConstraintName("FK_SolicitudDetalleDesignacion_RefTipoServicio");

                entity.HasOne(d => d.IdTituloHabilitanteNavigation)
                    .WithMany(p => p.SolicitudDetalleDesignacions)
                    .HasForeignKey(d => d.IdTituloHabilitante)
                    .HasConstraintName("FK_SolicitudDetalleDesignacion_RefTituloHabilitante");

                entity.HasOne(d => d.IdPlazaNavigation)
                    .WithMany(p => p.SolicitudDetalleDesignacions)
                    .HasForeignKey(d => new { d.IdPlaza, d.IdPlazaHistoria })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SolicitudDetalleDesignacion_PlazaHistoria");
            });

            modelBuilder.Entity<SolicitudDetalleDesignacionView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("SolicitudDetalleDesignacionView");

                entity.Property(e => e.AdmiteSuplente).HasColumnName("admiteSuplente");

                entity.Property(e => e.Apellido)
                    .HasMaxLength(50)
                    .HasColumnName("apellido");

                entity.Property(e => e.CargoFuncionalDesc)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("cargoFuncionalDesc");

                entity.Property(e => e.CircuitoEtapaLegajoDesc)
                    .HasMaxLength(100)
                    .HasColumnName("circuitoEtapaLegajoDesc");

                entity.Property(e => e.Cue).HasColumnName("cue");

                entity.Property(e => e.Cuil)
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("cuil");

                entity.Property(e => e.Curso)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("curso");

                entity.Property(e => e.DivisionDesc)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("divisionDesc");

                entity.Property(e => e.EstaActivo).HasColumnName("estaActivo");

                entity.Property(e => e.EstaFrenteAlumno).HasColumnName("estaFrenteAlumno");

                entity.Property(e => e.EstadoSolicitudDesc)
                    .HasMaxLength(25)
                    .HasColumnName("estadoSolicitudDesc");

                entity.Property(e => e.FechaDesde)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaDesde");

                entity.Property(e => e.FechaEliminacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaEliminacion");

                entity.Property(e => e.FechaHasta)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaHasta");

                entity.Property(e => e.IdCircuitoEtapaLegajo).HasColumnName("idCircuitoEtapaLegajo");

                entity.Property(e => e.IdEjercicio).HasColumnName("idEjercicio");

                entity.Property(e => e.IdEstadoSolicitudLegajo).HasColumnName("idEstadoSolicitudLegajo");

                entity.Property(e => e.IdHistoriaOrg).HasColumnName("idHistoriaOrg");

                entity.Property(e => e.IdInstrumentoLegal).HasColumnName("idInstrumentoLegal");

                entity.Property(e => e.IdMovimiento).HasColumnName("idMovimiento");

                entity.Property(e => e.IdNivelEducativo).HasColumnName("idNivelEducativo");

                entity.Property(e => e.IdOrganizacion).HasColumnName("idOrganizacion");

                entity.Property(e => e.IdOrganizacionNivelEduc).HasColumnName("idOrganizacionNivelEduc");

                entity.Property(e => e.IdPersona).HasColumnName("idPersona");

                entity.Property(e => e.IdPlaza).HasColumnName("idPlaza");

                entity.Property(e => e.IdPlazaHistoria).HasColumnName("idPlazaHistoria");

                entity.Property(e => e.IdServicio).HasColumnName("idServicio");

                entity.Property(e => e.IdSexo).HasColumnName("idSexo");

                entity.Property(e => e.IdSituacionRevista).HasColumnName("idSituacionRevista");

                entity.Property(e => e.IdSolicitudDetalle).HasColumnName("idSolicitudDetalle");

                entity.Property(e => e.IdSolicitudDetalleSitExt).HasColumnName("idSolicitudDetalleSitExt");

                entity.Property(e => e.IdSolicitudLegajo).HasColumnName("idSolicitudLegajo");

                entity.Property(e => e.IdTerminoLectivo).HasColumnName("idTerminoLectivo");

                entity.Property(e => e.IdTipoDocumento).HasColumnName("idTipoDocumento");

                entity.Property(e => e.IdTipoServicio).HasColumnName("idTipoServicio");

                entity.Property(e => e.IdTipoSolicitud).HasColumnName("idTipoSolicitud");

                entity.Property(e => e.IdTituloHabilitante).HasColumnName("idTituloHabilitante");

                entity.Property(e => e.InstrumentoLegalDesc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("instrumentoLegalDesc");

                entity.Property(e => e.MovimientoDesc)
                    .HasMaxLength(100)
                    .HasColumnName("movimientoDesc");

                entity.Property(e => e.NivelEducativoDesc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nivelEducativoDesc");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .HasColumnName("nombre");

                entity.Property(e => e.NroDocumento).HasColumnName("nroDocumento");

                entity.Property(e => e.NumeroSolicitud).HasColumnName("numeroSolicitud");

                entity.Property(e => e.ObsEstado)
                    .HasMaxLength(100)
                    .HasColumnName("obsEstado");

                entity.Property(e => e.Observaciones).HasColumnName("observaciones");

                entity.Property(e => e.OrganizacionDesc)
                    .HasMaxLength(250)
                    .HasColumnName("organizacionDesc");

                entity.Property(e => e.PersonaApellido).HasMaxLength(50);

                entity.Property(e => e.PersonaNombre).HasMaxLength(50);

                entity.Property(e => e.PlanEstudioDesc)
                    .HasMaxLength(100)
                    .HasColumnName("planEstudioDesc");

                entity.Property(e => e.RegimenSalarialDesc)
                    .HasMaxLength(50)
                    .HasColumnName("regimenSalarialDesc");

                entity.Property(e => e.SituacionRevistaDesc)
                    .HasMaxLength(25)
                    .HasColumnName("situacionRevistaDesc");

                entity.Property(e => e.TurnoDesc)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("turnoDesc");
            });

            modelBuilder.Entity<SolicitudDetalleFrenteAlumno>(entity =>
            {
                entity.HasKey(e => e.IdSolicitudDetalle);

                entity.ToTable("SolicitudDetalleFrenteAlumno");

                entity.Property(e => e.IdSolicitudDetalle)
                    .ValueGeneratedNever()
                    .HasColumnName("idSolicitudDetalle");

                entity.Property(e => e.EstaFrenteAlumno).HasColumnName("estaFrenteAlumno");

                entity.Property(e => e.Fecha)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha");

                entity.Property(e => e.Funcion)
                    .HasMaxLength(200)
                    .HasColumnName("funcion")
                    .HasComment("Funcion a cumplir");

                entity.HasOne(d => d.IdSolicitudDetalleNavigation)
                    .WithOne(p => p.SolicitudDetalleFrenteAlumno)
                    .HasForeignKey<SolicitudDetalleFrenteAlumno>(d => d.IdSolicitudDetalle)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SolicitudDetalleFrenteAlumno_SolicitudDetalle");
            });

            modelBuilder.Entity<SolicitudDetalleLicenciaView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("SolicitudDetalleLicenciaView");

                entity.Property(e => e.Apellido)
                    .HasMaxLength(50)
                    .HasColumnName("apellido");

                entity.Property(e => e.CantAños).HasColumnName("cantAños");

                entity.Property(e => e.CantDias).HasColumnName("cantDias");

                entity.Property(e => e.CantMeses).HasColumnName("cantMeses");

                entity.Property(e => e.CategoriaLicenciaDesc)
                    .HasMaxLength(50)
                    .HasColumnName("categoriaLicenciaDesc");

                entity.Property(e => e.DiasLicencia).HasColumnName("diasLicencia");

                entity.Property(e => e.EstadoSolicitudDesc)
                    .HasMaxLength(25)
                    .HasColumnName("estadoSolicitudDesc");

                entity.Property(e => e.FechaDesde)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaDesde");

                entity.Property(e => e.FechaHasta)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaHasta");

                entity.Property(e => e.IdEjercicio).HasColumnName("idEjercicio");

                entity.Property(e => e.IdEstadoSolicitudLegajo).HasColumnName("idEstadoSolicitudLegajo");

                entity.Property(e => e.IdEstadoSolicitudLegajoDetalle).HasColumnName("idEstadoSolicitudLegajoDetalle");

                entity.Property(e => e.IdHistoriaOrg).HasColumnName("idHistoriaOrg");

                entity.Property(e => e.IdInstrumentoLegal).HasColumnName("idInstrumentoLegal");

                entity.Property(e => e.IdMovimiento).HasColumnName("idMovimiento");

                entity.Property(e => e.IdOrganizacion).HasColumnName("idOrganizacion");

                entity.Property(e => e.IdOrganizacionNivelEduc).HasColumnName("idOrganizacionNivelEduc");

                entity.Property(e => e.IdPersona).HasColumnName("idPersona");

                entity.Property(e => e.IdPlaza).HasColumnName("idPlaza");

                entity.Property(e => e.IdPlazaHistoria).HasColumnName("idPlazaHistoria");

                entity.Property(e => e.IdServicio).HasColumnName("idServicio");

                entity.Property(e => e.IdSituacionRevista).HasColumnName("idSituacionRevista");

                entity.Property(e => e.IdSolicitudDetalle).HasColumnName("idSolicitudDetalle");

                entity.Property(e => e.IdSolicitudLegajo).HasColumnName("idSolicitudLegajo");

                entity.Property(e => e.IdTerminoLectivoServ).HasColumnName("idTerminoLectivoServ");

                entity.Property(e => e.IdTipoServicio).HasColumnName("idTipoServicio");

                entity.Property(e => e.MovimientoDesc)
                    .HasMaxLength(100)
                    .HasColumnName("movimientoDesc");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .HasColumnName("nombre");

                entity.Property(e => e.NumeroArticulo)
                    .HasMaxLength(15)
                    .HasColumnName("numeroArticulo");

                entity.Property(e => e.NumeroSolicitud).HasColumnName("numeroSolicitud");

                entity.Property(e => e.OrganizacionDesc)
                    .HasMaxLength(250)
                    .HasColumnName("organizacionDesc");
            });

            modelBuilder.Entity<SolicitudDetalleLicencium>(entity =>
            {
                entity.HasKey(e => e.IdSolicitudDetalle);

                entity.HasComment("Detalle de solicitudes de licencias");

                entity.Property(e => e.IdSolicitudDetalle)
                    .ValueGeneratedNever()
                    .HasColumnName("idSolicitudDetalle")
                    .HasComment("Identificador de cabecera de solicitud");

                entity.Property(e => e.CantAños)
                    .HasColumnName("cantAños")
                    .HasComment("Años de antigüedad");

                entity.Property(e => e.CantDias)
                    .HasColumnName("cantDias")
                    .HasComment("Días de antigüedad");

                entity.Property(e => e.CantMeses)
                    .HasColumnName("cantMeses")
                    .HasComment("Meses de antigüedad");

                entity.Property(e => e.DiasLicencia).HasColumnName("diasLicencia");

                entity.Property(e => e.FechaDesde)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaDesde")
                    .HasComment("Fecha a partir de la cual entra en vigencia el subservicio");

                entity.Property(e => e.FechaHasta)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaHasta")
                    .HasComment("Fecha en la que termina la vigencia del subservicio");

                entity.Property(e => e.IdTerminoLectivo).HasColumnName("idTerminoLectivo");

                entity.HasOne(d => d.IdSolicitudDetalleNavigation)
                    .WithOne(p => p.SolicitudDetalleLicencium)
                    .HasForeignKey<SolicitudDetalleLicencium>(d => d.IdSolicitudDetalle)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SolicitudDetalleLicencia_SolicitudDetalle");

                entity.HasOne(d => d.IdTerminoLectivoNavigation)
                    .WithMany(p => p.SolicitudDetalleLicencia)
                    .HasForeignKey(d => d.IdTerminoLectivo)
                    .HasConstraintName("FK_SolicitudDetalleLicencia_TerminoLectivo");
            });

            modelBuilder.Entity<SolicitudDetalleSitExt>(entity =>
            {
                entity.HasKey(e => e.IdSolicitudDetalle)
                    .HasName("PK_SolicitudDetalleSitExt_1");

                entity.ToTable("SolicitudDetalleSitExt");

                entity.Property(e => e.IdSolicitudDetalle)
                    .ValueGeneratedNever()
                    .HasColumnName("idSolicitudDetalle")
                    .HasComment("Identificador de cabecera de solicitud");

                entity.Property(e => e.CantAños)
                    .HasColumnName("cantAños")
                    .HasComment("Años de antigüedad");

                entity.Property(e => e.CantDias)
                    .HasColumnName("cantDias")
                    .HasComment("Días de antigüedad");

                entity.Property(e => e.CantMeses)
                    .HasColumnName("cantMeses")
                    .HasComment("Meses de antigüedad");

                entity.Property(e => e.FechaDesde)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaDesde")
                    .HasComment("Fecha a partir de la cual entra en vigencia el servicio generado por la situación extraordinaria");

                entity.Property(e => e.FechaHasta)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaHasta")
                    .HasComment("Fecha en la que termina la vigencia del servicio generado por la situación extraordinaria");

                entity.Property(e => e.IdHistoriaOrgDestino)
                    .HasColumnName("idHistoriaOrgDestino")
                    .HasComment("Histórico de organizaicón destino");

                entity.Property(e => e.IdOrganizacionDestino)
                    .HasColumnName("idOrganizacionDestino")
                    .HasComment("Organización destino en donde se generará el servicio (puede ser la misma organizaicón u otra distinta).");

                entity.Property(e => e.IdPlazaDestino)
                    .HasColumnName("idPlazaDestino")
                    .HasComment("Clave foranea. Plaza destino en la que se realiza el traslado");

                entity.Property(e => e.IdTerminoLectivo).HasColumnName("idTerminoLectivo");

                entity.HasOne(d => d.IdPlazaDestinoNavigation)
                    .WithMany(p => p.SolicitudDetalleSitExts)
                    .HasForeignKey(d => d.IdPlazaDestino)
                    .HasConstraintName("FK_SolicitudDetalleSitExt_Plaza");

                entity.HasOne(d => d.IdSolicitudDetalleNavigation)
                    .WithOne(p => p.SolicitudDetalleSitExt)
                    .HasForeignKey<SolicitudDetalleSitExt>(d => d.IdSolicitudDetalle)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SolicitudDetalleSitExt_SolicitudDetalle");

                entity.HasOne(d => d.IdTerminoLectivoNavigation)
                    .WithMany(p => p.SolicitudDetalleSitExts)
                    .HasForeignKey(d => d.IdTerminoLectivo)
                    .HasConstraintName("FK_SolicitudDetalleSitExt_TerminoLectivo");

                entity.HasOne(d => d.Id)
                    .WithMany(p => p.SolicitudDetalleSitExts)
                    .HasForeignKey(d => new { d.IdOrganizacionDestino, d.IdHistoriaOrgDestino })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SolicitudDetalleSitExt_Organizacion");
            });

            modelBuilder.Entity<SolicitudDetalleSitExtView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("SolicitudDetalleSitExtView");

                entity.Property(e => e.Apellido)
                    .HasMaxLength(50)
                    .HasColumnName("apellido");

                entity.Property(e => e.CantAños).HasColumnName("cantAños");

                entity.Property(e => e.CantDias).HasColumnName("cantDias");

                entity.Property(e => e.CantMeses).HasColumnName("cantMeses");

                entity.Property(e => e.EstadoSolicitudDesc)
                    .HasMaxLength(25)
                    .HasColumnName("estadoSolicitudDesc");

                entity.Property(e => e.FechaDesde)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaDesde");

                entity.Property(e => e.FechaHasta)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaHasta");

                entity.Property(e => e.IdEjercicio).HasColumnName("idEjercicio");

                entity.Property(e => e.IdEstadoSolicitudLegajo).HasColumnName("idEstadoSolicitudLegajo");

                entity.Property(e => e.IdEstadoSolicitudLegajoDetalle).HasColumnName("idEstadoSolicitudLegajoDetalle");

                entity.Property(e => e.IdHistoriaOrg).HasColumnName("idHistoriaOrg");

                entity.Property(e => e.IdInstrumentoLegal).HasColumnName("idInstrumentoLegal");

                entity.Property(e => e.IdMovimiento).HasColumnName("idMovimiento");

                entity.Property(e => e.IdOrganizacion).HasColumnName("idOrganizacion");

                entity.Property(e => e.IdOrganizacionNivelEduc).HasColumnName("idOrganizacionNivelEduc");

                entity.Property(e => e.IdPersona).HasColumnName("idPersona");

                entity.Property(e => e.IdPlaza).HasColumnName("idPlaza");

                entity.Property(e => e.IdPlazaHistoria).HasColumnName("idPlazaHistoria");

                entity.Property(e => e.IdServicio).HasColumnName("idServicio");

                entity.Property(e => e.IdSituacionRevista).HasColumnName("idSituacionRevista");

                entity.Property(e => e.IdSolicitudDetalle).HasColumnName("idSolicitudDetalle");

                entity.Property(e => e.IdSolicitudLegajo).HasColumnName("idSolicitudLegajo");

                entity.Property(e => e.IdTerminoLectivoServ).HasColumnName("idTerminoLectivoServ");

                entity.Property(e => e.IdTipoServicio).HasColumnName("idTipoServicio");

                entity.Property(e => e.MovimientoDesc)
                    .HasMaxLength(100)
                    .HasColumnName("movimientoDesc");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .HasColumnName("nombre");

                entity.Property(e => e.NumeroSolicitud).HasColumnName("numeroSolicitud");

                entity.Property(e => e.OrganizacionDesc)
                    .HasMaxLength(250)
                    .HasColumnName("organizacionDesc");
            });

            modelBuilder.Entity<SolicitudDetalleSuplente>(entity =>
            {
                entity.HasKey(e => e.IdSolicitudDetalle);

                entity.ToTable("SolicitudDetalleSuplente");

                entity.Property(e => e.IdSolicitudDetalle)
                    .ValueGeneratedNever()
                    .HasColumnName("idSolicitudDetalle");

                entity.Property(e => e.AdmiteSuplente).HasColumnName("admiteSuplente");

                entity.Property(e => e.EstaFrenteAlumno).HasColumnName("estaFrenteAlumno");

                entity.Property(e => e.FechaDesde)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaDesde");

                entity.Property(e => e.FechaHasta)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaHasta");

                entity.Property(e => e.IdPlaza).HasColumnName("idPlaza");

                entity.Property(e => e.IdPlazaHistoria).HasColumnName("idPlazaHistoria");

                entity.Property(e => e.IdSituacionRevista).HasColumnName("idSituacionRevista");

                entity.Property(e => e.IdSolicitudDetalleLicenciaOrigen).HasColumnName("idSolicitudDetalleLicenciaOrigen");

                entity.Property(e => e.IdSubServicioOrigen).HasColumnName("idSubServicioOrigen");

                entity.Property(e => e.IdTerminoLectivo).HasColumnName("idTerminoLectivo");

                entity.Property(e => e.IdTipoServicio).HasColumnName("idTipoServicio");

                entity.Property(e => e.IdTituloHabilitante).HasColumnName("idTituloHabilitante");

                entity.HasOne(d => d.IdPlazaNavigation)
                    .WithMany(p => p.SolicitudDetalleSuplentes)
                    .HasForeignKey(d => d.IdPlaza)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SolicitudDetalleSuplente_Plaza");

                entity.HasOne(d => d.IdSituacionRevistaNavigation)
                    .WithMany(p => p.SolicitudDetalleSuplentes)
                    .HasForeignKey(d => d.IdSituacionRevista)
                    .HasConstraintName("FK_SolicitudDetalleSuplente_RefSituacionRevista");

                entity.HasOne(d => d.IdSolicitudDetalleNavigation)
                    .WithOne(p => p.SolicitudDetalleSuplente)
                    .HasForeignKey<SolicitudDetalleSuplente>(d => d.IdSolicitudDetalle)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SolicitudDetalleSuplente_SolicitudDetalle");

                entity.HasOne(d => d.IdTerminoLectivoNavigation)
                    .WithMany(p => p.SolicitudDetalleSuplentes)
                    .HasForeignKey(d => d.IdTerminoLectivo)
                    .HasConstraintName("FK_SolicitudDetalleSuplente_TerminoLectivo");

                entity.HasOne(d => d.IdTipoServicioNavigation)
                    .WithMany(p => p.SolicitudDetalleSuplentes)
                    .HasForeignKey(d => d.IdTipoServicio)
                    .HasConstraintName("FK_SolicitudDetalleSuplente_RefTipoServicio");

                entity.HasOne(d => d.IdTituloHabilitanteNavigation)
                    .WithMany(p => p.SolicitudDetalleSuplentes)
                    .HasForeignKey(d => d.IdTituloHabilitante)
                    .HasConstraintName("FK_SolicitudDetalleSuplente_RefTituloHabilitante");
            });

            modelBuilder.Entity<SolicitudDetalleSuplenteView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("SolicitudDetalleSuplenteView");

                entity.Property(e => e.AdmiteSuplente).HasColumnName("admiteSuplente");

                entity.Property(e => e.EstaFrenteAlumno).HasColumnName("estaFrenteAlumno");

                entity.Property(e => e.FechaDesde)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaDesde");

                entity.Property(e => e.FechaHasta)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaHasta");

                entity.Property(e => e.IdCircuitoEtapaLegajo).HasColumnName("idCircuitoEtapaLegajo");

                entity.Property(e => e.IdEjercicio).HasColumnName("idEjercicio");

                entity.Property(e => e.IdEstadoSolicitudLegajo).HasColumnName("idEstadoSolicitudLegajo");

                entity.Property(e => e.IdExpteSolicitud).HasColumnName("idExpteSolicitud");

                entity.Property(e => e.IdHistoriaOrg).HasColumnName("idHistoriaOrg");

                entity.Property(e => e.IdInstrumentoLegal).HasColumnName("idInstrumentoLegal");

                entity.Property(e => e.IdMovimiento).HasColumnName("idMovimiento");

                entity.Property(e => e.IdOrganizacion).HasColumnName("idOrganizacion");

                entity.Property(e => e.IdOrganizacionNivelEduc).HasColumnName("idOrganizacionNivelEduc");

                entity.Property(e => e.IdPersona).HasColumnName("idPersona");

                entity.Property(e => e.IdPlaza).HasColumnName("idPlaza");

                entity.Property(e => e.IdPlazaHistoria).HasColumnName("idPlazaHistoria");

                entity.Property(e => e.IdServicio).HasColumnName("idServicio");

                entity.Property(e => e.IdSituacionRevista).HasColumnName("idSituacionRevista");

                entity.Property(e => e.IdSolicitudDetalle).HasColumnName("idSolicitudDetalle");

                entity.Property(e => e.IdSolicitudDetalleLicenciaOrigen).HasColumnName("idSolicitudDetalleLicenciaOrigen");

                entity.Property(e => e.IdSolicitudLegajo).HasColumnName("idSolicitudLegajo");

                entity.Property(e => e.IdSubServicioOrigen).HasColumnName("idSubServicioOrigen");

                entity.Property(e => e.IdTerminoLectivo).HasColumnName("idTerminoLectivo");

                entity.Property(e => e.IdTipoServicio).HasColumnName("idTipoServicio");

                entity.Property(e => e.IdTipoSolicitud).HasColumnName("idTipoSolicitud");

                entity.Property(e => e.IdTituloHabilitante).HasColumnName("idTituloHabilitante");

                entity.Property(e => e.MovimientoDesc)
                    .HasMaxLength(100)
                    .HasColumnName("movimientoDesc");

                entity.Property(e => e.NumeroSolicitud).HasColumnName("numeroSolicitud");
            });

            modelBuilder.Entity<SolicitudDetalleSuspension>(entity =>
            {
                entity.HasKey(e => e.IdSolicitudDetalle);

                entity.ToTable("SolicitudDetalleSuspension");

                entity.Property(e => e.IdSolicitudDetalle)
                    .ValueGeneratedNever()
                    .HasColumnName("idSolicitudDetalle");

                entity.Property(e => e.Fecha)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha")
                    .HasComment("Fecha de la Suspención");

                entity.Property(e => e.FechaHasta)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaHasta")
                    .HasComment("Fecha Hasta del SubServicio");

                entity.Property(e => e.IdSubServicio)
                    .HasColumnName("idSubServicio")
                    .HasComment("Id  del SubServicio de Licencia que se Suspende");

                entity.HasOne(d => d.IdSolicitudDetalleNavigation)
                    .WithOne(p => p.SolicitudDetalleSuspension)
                    .HasForeignKey<SolicitudDetalleSuspension>(d => d.IdSolicitudDetalle)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SolicitudDetalleSuspension_SolicitudDetalle");
            });

            modelBuilder.Entity<SolicitudEstado>(entity =>
            {
                entity.HasKey(e => e.IdEstadoSol);

                entity.HasIndex(e => e.IdSolicitudPlaza, "<Name of Missing Index, sysname,>");

                entity.HasIndex(e => e.IdSolicitudPlaza, "IndexSolicitudEstados");

                entity.Property(e => e.IdEstadoSol)
                    .HasColumnName("idEstadoSol")
                    .HasComment("Campo clave, identificador de la relación entre solicitud y estado");

                entity.Property(e => e.FechaEstado)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaEstado")
                    .HasComment("Fecha en la que se produjo le cambio de estado de una solicitud");

                entity.Property(e => e.IdCircuitoSol)
                    .HasColumnName("idCircuitoSol")
                    .HasComment("Identificador de parte interviniente del circuito de habilitación. Ejemplo: 1. Organización, 2. Supervisión regional. etc.  ");

                entity.Property(e => e.IdEstadoSolicitud)
                    .HasColumnName("idEstadoSolicitud")
                    .HasComment("Identificador de estado. Ejemplo: 1- Pendiente 2-Presentada, 3- Aprobada");

                entity.Property(e => e.IdSolicitudPlaza)
                    .HasColumnName("idSolicitudPlaza")
                    .HasComment("Identificador de solicitud");

                entity.Property(e => e.Observacion)
                    .HasMaxLength(250)
                    .HasColumnName("observacion")
                    .IsFixedLength()
                    .HasComment("Descripción u observación del estado de la solicitud");

                entity.HasOne(d => d.IdCircuitoSolNavigation)
                    .WithMany(p => p.SolicitudEstados)
                    .HasForeignKey(d => d.IdCircuitoSol)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SolicitudEstados_CircuitoSolicitudPlaza");

                entity.HasOne(d => d.IdEstadoSolicitudNavigation)
                    .WithMany(p => p.SolicitudEstados)
                    .HasForeignKey(d => d.IdEstadoSolicitud)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SolicitudEstados_RefEstadoSolicitud");

                entity.HasOne(d => d.IdSolicitudPlazaNavigation)
                    .WithMany(p => p.SolicitudEstados)
                    .HasForeignKey(d => d.IdSolicitudPlaza)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SolicitudEstados_SolicitudPlaza");
            });

            modelBuilder.Entity<SolicitudEstadosLegajo>(entity =>
            {
                entity.HasKey(e => e.IdSolicitudEstadoLegajo);

                entity.ToTable("SolicitudEstadosLegajo");

                entity.HasComment("Registra el historial de estados por los que pasó una solicitud y la parte interviniente que registró dicho estado");

                entity.Property(e => e.IdSolicitudEstadoLegajo)
                    .HasColumnName("idSolicitudEstadoLegajo")
                    .HasComment("Campo clave, autoincremental");

                entity.Property(e => e.EstaActivo)
                    .IsRequired()
                    .HasColumnName("estaActivo")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.FechaEstado)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaEstado")
                    .HasComment("Fecha en la que se registró el estado");

                entity.Property(e => e.IdCircuitoEtapaLegajo)
                    .HasColumnName("idCircuitoEtapaLegajo")
                    .HasComment("Identificador de parte interviniente del circuito que sigue un determinado tipo de solicitud");

                entity.Property(e => e.IdEstadoSolicitudLegajo)
                    .HasColumnName("idEstadoSolicitudLegajo")
                    .HasComment("Identificador de estado que puede asumir la solicitud de un agente (legajo) . Ejemplo: creada, presetnada, etc.. ");

                entity.Property(e => e.IdHistoriaOrg).HasColumnName("idHistoriaOrg");

                entity.Property(e => e.IdOrganizacion).HasColumnName("idOrganizacion");

                entity.Property(e => e.IdSolicitudLegajo)
                    .HasColumnName("idSolicitudLegajo")
                    .HasComment("Identificadro de solicitud de legajo");

                entity.Property(e => e.Observacion)
                    .HasMaxLength(250)
                    .HasColumnName("observacion")
                    .HasComment("Observaciones");

                entity.Property(e => e.Orden).HasColumnName("orden");

                entity.HasOne(d => d.IdCircuitoEtapaLegajoNavigation)
                    .WithMany(p => p.SolicitudEstadosLegajos)
                    .HasForeignKey(d => d.IdCircuitoEtapaLegajo)
                    .HasConstraintName("FK_SolicitudEstadosLegajo_CircuitoEtapaLegajo");

                entity.HasOne(d => d.IdEstadoSolicitudLegajoNavigation)
                    .WithMany(p => p.SolicitudEstadosLegajos)
                    .HasForeignKey(d => d.IdEstadoSolicitudLegajo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SolicitudEstadosLegajo_RefEstadosSolicitudLegajo");

                entity.HasOne(d => d.IdSolicitudLegajoNavigation)
                    .WithMany(p => p.SolicitudEstadosLegajos)
                    .HasForeignKey(d => d.IdSolicitudLegajo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SolicitudEstadosLegajo_SolicitudLegajo");
            });

            modelBuilder.Entity<SolicitudEstadosTurno>(entity =>
            {
                entity.HasKey(e => e.IdSolicitudEstadoTurno);

                entity.ToTable("SolicitudEstadosTurno");

                entity.Property(e => e.IdSolicitudEstadoTurno).HasColumnName("idSolicitudEstadoTurno");

                entity.Property(e => e.EstaActivo)
                    .IsRequired()
                    .HasColumnName("estaActivo")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.FechaEliminacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaEliminacion");

                entity.Property(e => e.FechaEstado)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaEstado");

                entity.Property(e => e.IdEstadoSolicitud).HasColumnName("idEstadoSolicitud");

                entity.Property(e => e.IdSolicitudTurno).HasColumnName("idSolicitudTurno");

                entity.Property(e => e.Observacion)
                    .HasMaxLength(250)
                    .HasColumnName("observacion")
                    .IsFixedLength();

                entity.HasOne(d => d.IdEstadoSolicitudNavigation)
                    .WithMany(p => p.SolicitudEstadosTurnos)
                    .HasForeignKey(d => d.IdEstadoSolicitud)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SolicitudEstadosTurno_RefEstadoSolicitud");

                entity.HasOne(d => d.IdSolicitudTurnoNavigation)
                    .WithMany(p => p.SolicitudEstadosTurnos)
                    .HasForeignKey(d => d.IdSolicitudTurno)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SolicitudEstadosTurno_SolicitudTurno");
            });

            modelBuilder.Entity<SolicitudEstadosUltimoEstado>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("SolicitudEstados_UltimoEstado");

                entity.Property(e => e.IdEstadoSol).HasColumnName("idEstadoSol");

                entity.Property(e => e.IdSolicitudPlaza).HasColumnName("idSolicitudPlaza");
            });

            modelBuilder.Entity<SolicitudEstadosUltimoIdSolicitudEstadosView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("solicitudEstados_UltimoIdSolicitudEstadosView");

                entity.Property(e => e.Anio).HasColumnName("anio");

                entity.Property(e => e.IdEstadoSolicitud).HasColumnName("idEstadoSolicitud");

                entity.Property(e => e.IdHistoriaOrg).HasColumnName("idHistoriaOrg");

                entity.Property(e => e.IdOrganizacion).HasColumnName("idOrganizacion");

                entity.Property(e => e.IdOrganizacionNivelEduc).HasColumnName("idOrganizacionNivelEduc");

                entity.Property(e => e.IdSolicitudPlaza).HasColumnName("idSolicitudPlaza");

                entity.Property(e => e.IdTipoSolicitud).HasColumnName("idTipoSolicitud");
            });

            modelBuilder.Entity<SolicitudEstadosView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("SolicitudEstadosView");

                entity.Property(e => e.CircuitoSolDesc).HasMaxLength(100);

                entity.Property(e => e.EstadoSolicitudDesc)
                    .HasMaxLength(25)
                    .HasColumnName("estadoSolicitudDesc");

                entity.Property(e => e.FechaEstado)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaEstado");

                entity.Property(e => e.IdCircuitoSol).HasColumnName("idCircuitoSol");

                entity.Property(e => e.IdEstadoSol).HasColumnName("idEstadoSol");

                entity.Property(e => e.IdEstadoSolicitud).HasColumnName("idEstadoSolicitud");

                entity.Property(e => e.IdSolicitudPlaza).HasColumnName("idSolicitudPlaza");

                entity.Property(e => e.Observacion)
                    .HasMaxLength(250)
                    .HasColumnName("observacion")
                    .IsFixedLength();

                entity.Property(e => e.Orden).HasColumnName("orden");
            });

            modelBuilder.Entity<SolicitudLegajo>(entity =>
            {
                entity.HasKey(e => e.IdSolicitudLegajo);

                entity.ToTable("SolicitudLegajo");

                entity.Property(e => e.IdSolicitudLegajo).HasColumnName("idSolicitudLegajo");

                entity.Property(e => e.EstaActivo)
                    .IsRequired()
                    .HasColumnName("estaActivo")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.FechaEliminacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaEliminacion");

                entity.Property(e => e.IdEjercicio).HasColumnName("idEjercicio");

                entity.Property(e => e.IdHistoriaOrg).HasColumnName("idHistoriaOrg");

                entity.Property(e => e.IdOrganizacion).HasColumnName("idOrganizacion");

                entity.Property(e => e.IdOrganizacionNivelEduc)
                    .HasColumnName("idOrganizacionNivelEduc")
                    .HasComment("Identificador de nivel educativo vinculado a la organización. ");

                entity.Property(e => e.IdPlanillaNov)
                    .HasColumnName("idPlanillaNov")
                    .HasComment("Clave foranea. Identificador de planilla de novedad en la que se incluyó la solicitud");

                entity.Property(e => e.IdTipoSolicitud).HasColumnName("idTipoSolicitud");

                entity.Property(e => e.NumeroSolicitud).HasColumnName("numeroSolicitud");

                entity.HasOne(d => d.IdEjercicioNavigation)
                    .WithMany(p => p.SolicitudLegajos)
                    .HasForeignKey(d => d.IdEjercicio)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SolicitudLegajo_RefEjercicio");

                entity.HasOne(d => d.IdOrganizacionNivelEducNavigation)
                    .WithMany(p => p.SolicitudLegajos)
                    .HasForeignKey(d => d.IdOrganizacionNivelEduc)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SolicitudLegajo_OrganizacionNivelEducativo");

                entity.HasOne(d => d.IdPlanillaNovNavigation)
                    .WithMany(p => p.SolicitudLegajos)
                    .HasForeignKey(d => d.IdPlanillaNov)
                    .HasConstraintName("FK_SolicitudLegajo_PlanillaNovedades");

                entity.HasOne(d => d.IdTipoSolicitudNavigation)
                    .WithMany(p => p.SolicitudLegajos)
                    .HasForeignKey(d => d.IdTipoSolicitud)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SolicitudLegajo_RefTipoSolicitud");

                entity.HasOne(d => d.Id)
                    .WithMany(p => p.SolicitudLegajos)
                    .HasForeignKey(d => new { d.IdOrganizacion, d.IdHistoriaOrg })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SolicitudLegajo_Organizacion");
            });

            modelBuilder.Entity<SolicitudPlaza>(entity =>
            {
                entity.HasKey(e => e.IdSolicitudPlaza)
                    .HasName("PK_SolicitudGral");

                entity.ToTable("SolicitudPlaza");

                entity.HasComment("Solicitud de habilitación de plazas");

                entity.Property(e => e.IdSolicitudPlaza)
                    .HasColumnName("idSolicitudPlaza")
                    .HasComment("Identificador de solicitud, autoincremental");

                entity.Property(e => e.Anio)
                    .HasColumnName("anio")
                    .HasComment("Año para le cuál se solicita la creación de plazas");

                entity.Property(e => e.CantDivisiones)
                    .HasColumnName("cantDivisiones")
                    .HasComment("Cantidad de divisiones que posee la organizacion");

                entity.Property(e => e.EstaActivo)
                    .IsRequired()
                    .HasColumnName("estaActivo")
                    .HasDefaultValueSql("((1))")
                    .HasComment("Campo para borrado logico: Valor 0: falso; 1: verdadero");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaCreacion")
                    .HasComment("Fecha de alta del registro de la solicitud en el sistema ");

                entity.Property(e => e.FechaEliminacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaEliminacion");

                entity.Property(e => e.IdEjercicio).HasColumnName("idEjercicio");

                entity.Property(e => e.IdHistoriaOrg).HasColumnName("idHistoriaOrg");

                entity.Property(e => e.IdInstrumentoLegalHab)
                    .HasColumnName("idInstrumentoLegalHab")
                    .HasComment("Numero de resolucion correspondiente a la habilitacion de plazas solicitadas. Este campo es completado en la fase de habilitacion");

                entity.Property(e => e.IdOrganizacion)
                    .HasColumnName("idOrganizacion")
                    .HasComment("Clave foranea. Codigo de organizacion solicitante");

                entity.Property(e => e.IdOrganizacionNivelEduc).HasColumnName("idOrganizacionNivelEduc");

                entity.Property(e => e.IdTipoSolicitud).HasColumnName("idTipoSolicitud");

                entity.Property(e => e.IdUsuarioCreador)
                    .HasColumnName("idUsuarioCreador")
                    .HasComment("Clave foranea. Identificador del usuario que creo la solicitud");

                entity.Property(e => e.MatriculaMujeres)
                    .HasColumnName("matriculaMujeres")
                    .HasComment("Total de alumnos, si se trata de un establecimiento educativo ");

                entity.Property(e => e.MatriculaVarones).HasColumnName("matriculaVarones");

                entity.Property(e => e.NumeroSolicitud).HasColumnName("numeroSolicitud");

                entity.Property(e => e.Observacion)
                    .HasMaxLength(500)
                    .HasColumnName("observacion")
                    .HasComment("Observaciones");

                entity.HasOne(d => d.IdEjercicioNavigation)
                    .WithMany(p => p.SolicitudPlazas)
                    .HasForeignKey(d => d.IdEjercicio)
                    .HasConstraintName("FK_SolicitudPlaza_RefEjercicio");

                entity.HasOne(d => d.IdInstrumentoLegalHabNavigation)
                    .WithMany(p => p.SolicitudPlazas)
                    .HasForeignKey(d => d.IdInstrumentoLegalHab)
                    .HasConstraintName("FK_SolicitudPlaza_InstrumentoLegal");

                entity.HasOne(d => d.IdOrganizacionNivelEducNavigation)
                    .WithMany(p => p.SolicitudPlazas)
                    .HasForeignKey(d => d.IdOrganizacionNivelEduc)
                    .HasConstraintName("FK_SolicitudPlaza_OrganizacionNivelEducativo");

                entity.HasOne(d => d.IdTipoSolicitudNavigation)
                    .WithMany(p => p.SolicitudPlazas)
                    .HasForeignKey(d => d.IdTipoSolicitud)
                    .HasConstraintName("FK_SolicitudPlaza_RefTipoSolicitud");

                entity.HasOne(d => d.Id)
                    .WithMany(p => p.SolicitudPlazas)
                    .HasForeignKey(d => new { d.IdOrganizacion, d.IdHistoriaOrg })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Solicitud_Organizacion");
            });

            modelBuilder.Entity<SolicitudPlazaBorrar>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("SolicitudPlazaBorrar");

                entity.Property(e => e.IdEstadoSol).HasColumnName("idEstadoSol");
            });

            modelBuilder.Entity<SolicitudPlazaDesignacion>(entity =>
            {
                entity.HasKey(e => e.IdSolicitudPlazaDesignacion);

                entity.ToTable("SolicitudPlazaDesignacion");

                entity.Property(e => e.IdSolicitudPlazaDesignacion).HasColumnName("idSolicitudPlazaDesignacion");

                entity.Property(e => e.Apellido)
                    .HasMaxLength(50)
                    .HasColumnName("apellido");

                entity.Property(e => e.Cuil)
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("cuil");

                entity.Property(e => e.Dni).HasColumnName("dni");

                entity.Property(e => e.EstaActivo)
                    .HasColumnName("estaActivo")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.FechaEliminacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaEliminacion");

                entity.Property(e => e.IdInstrumentoLegalDesig).HasColumnName("idInstrumentoLegalDesig");

                entity.Property(e => e.IdPersona).HasColumnName("idPersona");

                entity.Property(e => e.IdSexo).HasColumnName("idSexo");

                entity.Property(e => e.IdSituacionRevista).HasColumnName("idSituacionRevista");

                entity.Property(e => e.IdSolicitudPlazaDetalle).HasColumnName("idSolicitudPlazaDetalle");

                entity.Property(e => e.IdTipoDocumento).HasColumnName("idTipoDocumento");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .HasColumnName("nombre");

                entity.HasOne(d => d.IdInstrumentoLegalDesigNavigation)
                    .WithMany(p => p.SolicitudPlazaDesignacions)
                    .HasForeignKey(d => d.IdInstrumentoLegalDesig)
                    .HasConstraintName("FK_SolicitudPlazaDesignacion_InstrumentoLegal");

                entity.HasOne(d => d.IdPersonaNavigation)
                    .WithMany(p => p.SolicitudPlazaDesignacions)
                    .HasForeignKey(d => d.IdPersona)
                    .HasConstraintName("FK_SolicitudPlazaDesignacion_Persona");

                entity.HasOne(d => d.IdSexoNavigation)
                    .WithMany(p => p.SolicitudPlazaDesignacions)
                    .HasForeignKey(d => d.IdSexo)
                    .HasConstraintName("FK_SolicitudPlazaDesignacion_RefSexo");

                entity.HasOne(d => d.IdSituacionRevistaNavigation)
                    .WithMany(p => p.SolicitudPlazaDesignacions)
                    .HasForeignKey(d => d.IdSituacionRevista)
                    .HasConstraintName("FK_SolicitudPlazaDesignacion_RefSituacionRevista");

                entity.HasOne(d => d.IdSolicitudPlazaDetalleNavigation)
                    .WithMany(p => p.SolicitudPlazaDesignacions)
                    .HasForeignKey(d => d.IdSolicitudPlazaDetalle)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SolicitudPlazaDesignacion_SolicitudPlazaDetalle");

                entity.HasOne(d => d.IdTipoDocumentoNavigation)
                    .WithMany(p => p.SolicitudPlazaDesignacions)
                    .HasForeignKey(d => d.IdTipoDocumento)
                    .HasConstraintName("FK_SolicitudPlazaDesignacion_RefTipoDocumento");
            });

            modelBuilder.Entity<SolicitudPlazaDetalle>(entity =>
            {
                entity.HasKey(e => e.IdSolicitudPlazaDetalle)
                    .HasName("PK_SolicitudPlazaItems");

                entity.ToTable("SolicitudPlazaDetalle");

                entity.HasComment("Ítems o cargos de una solicitud de habilitación de plazas");

                entity.Property(e => e.IdSolicitudPlazaDetalle).HasColumnName("idSolicitudPlazaDetalle");

                entity.Property(e => e.AccionPlaza)
                    .HasMaxLength(10)
                    .HasColumnName("accionPlaza")
                    .HasComment("Acción realziada sobre la plaza solicitda, ins: agregar; upd: modificar: nch: sin cambios; del: eliminar");

                entity.Property(e => e.AdmiteSuplente)
                    .HasColumnName("admiteSuplente")
                    .HasComment("Indica si la plaza admite suplencias");

                entity.Property(e => e.BajaAutomatica)
                    .HasColumnName("bajaAutomatica")
                    .HasComment("Campo para determinar si al finalziar el período de habilitación de la plaza ésta será dada de baja de forma automática.");

                entity.Property(e => e.CantidadHs).HasComment("cantidad de horas en caso de tratassrse de una cargo tipo hs.");

                entity.Property(e => e.CobraIncentivo).HasColumnName("cobraIncentivo");

                entity.Property(e => e.EsCabeceraDePaquete).HasColumnName("esCabeceraDePaquete");

                entity.Property(e => e.EstaActivo)
                    .IsRequired()
                    .HasColumnName("estaActivo")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaCreacion")
                    .HasComment("Fecha de creación del cargo ");

                entity.Property(e => e.FechaEliminacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaEliminacion");

                entity.Property(e => e.FechaHabilitacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaHabilitacion")
                    .HasComment("Fecha desde la que se solicita la habilitación  de la plaza");

                entity.Property(e => e.FechaModificacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaModificacion");

                entity.Property(e => e.FechaTermino)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaTermino")
                    .HasComment("Fecha de término del período de habilitación de la plaza");

                entity.Property(e => e.FuncionExtra)
                    .HasMaxLength(50)
                    .HasColumnName("funcionExtra");

                entity.Property(e => e.IdAfectacion)
                    .HasColumnName("idAfectacion")
                    .HasComment("Intrapresupeustaria, extrapresupeustaria");

                entity.Property(e => e.IdCargoFuncional)
                    .HasColumnName("idCargoFuncional")
                    .HasComment("Identificador de la función se de desempeñará en el cargo o plaza");

                entity.Property(e => e.IdCargoSalarial).HasColumnName("idCargoSalarial");

                entity.Property(e => e.IdCircuitoSol).HasColumnName("idCircuitoSol");

                entity.Property(e => e.IdDivision)
                    .HasColumnName("idDivision")
                    .HasComment("Divisón de una organización para un pland e estudio en particular");

                entity.Property(e => e.IdEstadoPlaza)
                    .HasColumnName("idEstadoPlaza")
                    .HasComment("Estado de la plaza detalle de la solicitud. Ejemplo: creada, presentada, aprobada, rechazada,");

                entity.Property(e => e.IdExpteCreacion)
                    .HasColumnName("idExpteCreacion")
                    .HasComment("Clave foranea, identificador del expediente con el que se tramita la solicitud.");

                entity.Property(e => e.IdFinanciamiento)
                    .HasColumnName("idFinanciamiento")
                    .HasComment("Provincia, nacion, municipalidad");

                entity.Property(e => e.IdInstrumentoLegalBaja).HasColumnName("idInstrumentoLegalBaja");

                entity.Property(e => e.IdInstrumentoLegalCreacion).HasColumnName("idInstrumentoLegalCreacion");

                entity.Property(e => e.IdMotivoBaja)
                    .HasColumnName("idMotivoBaja")
                    .HasComment("Identificador de motivo de baja de la plaza. Ejemplo: termino de periodo de habilitacion");

                entity.Property(e => e.IdMotivoCreacion)
                    .HasColumnName("idMotivoCreacion")
                    .HasComment("Identificador de motivo de creación. Ejemplo POF, NO POF");

                entity.Property(e => e.IdOrganizacionTurno)
                    .HasColumnName("idOrganizacionTurno")
                    .HasComment("Identificador de turno dentro de una organización");

                entity.Property(e => e.IdPaquete).HasColumnName("idPaquete");

                entity.Property(e => e.IdPlanAsignatura)
                    .HasColumnName("idPlanAsignatura")
                    .HasComment("Identificador de asignatura dentro un plan de estudio de una organización");

                entity.Property(e => e.IdPlanUnidad)
                    .HasColumnName("idPlanUnidad")
                    .HasComment("Identificador de una unidad académica, es decir plan de estudio dentro de una organizaicón para un determinado nivel educativo. ");

                entity.Property(e => e.IdPlaza)
                    .HasColumnName("idPlaza")
                    .HasComment("Código único de plaza orgánica funcional - requerido si se trata de una renovación, 0 si se trata de una plaza nueva");

                entity.Property(e => e.IdRegimenLaboral)
                    .HasColumnName("idRegimenLaboral")
                    .HasComment("Docente, no docente,  contrato de servicio, etc.");

                entity.Property(e => e.IdRegimenSalarial)
                    .HasColumnName("idRegimenSalarial")
                    .HasComment("Cargo, horas");

                entity.Property(e => e.IdSistemaEducativo)
                    .HasColumnName("idSistemaEducativo")
                    .HasComment("Indica si es educación formal o no formal");

                entity.Property(e => e.IdSolicitudPlaza)
                    .HasColumnName("idSolicitudPlaza")
                    .HasComment("Identificador de solicitud");

                entity.Property(e => e.IdTemporalidad)
                    .HasColumnName("idTemporalidad")
                    .HasComment("Identificador de la temporalidad o caracter de la palza- Ejemplo: 1 - definitivo, 2-provisional");

                entity.Property(e => e.IdTerminoLectivo).HasColumnName("idTerminoLectivo");

                entity.Property(e => e.IdTipoPlaza).HasColumnName("idTipoPlaza");

                entity.Property(e => e.IdUsuarioModificacion).HasColumnName("idUsuarioModificacion");

                entity.Property(e => e.ObsEstadoPlaza)
                    .HasMaxLength(100)
                    .HasColumnName("obsEstadoPlaza")
                    .HasComment("Observaciones sobre el estado de la plaza detalle de la solicitud");

                entity.Property(e => e.Observacion)
                    .HasMaxLength(255)
                    .HasColumnName("observacion");

                entity.HasOne(d => d.IdAfectacionNavigation)
                    .WithMany(p => p.SolicitudPlazaDetalles)
                    .HasForeignKey(d => d.IdAfectacion)
                    .HasConstraintName("FK_SolicitudPlazaItem_RefAfectacion");

                entity.HasOne(d => d.IdCargoFuncionalNavigation)
                    .WithMany(p => p.SolicitudPlazaDetalles)
                    .HasForeignKey(d => d.IdCargoFuncional)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SolicitudPlazaItem_CargoFuncional");

                entity.HasOne(d => d.IdCargoSalarialNavigation)
                    .WithMany(p => p.SolicitudPlazaDetalles)
                    .HasForeignKey(d => d.IdCargoSalarial)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SolicitudPlazaItem_CargoSalarial");

                entity.HasOne(d => d.IdCircuitoSolNavigation)
                    .WithMany(p => p.SolicitudPlazaDetalles)
                    .HasForeignKey(d => d.IdCircuitoSol)
                    .HasConstraintName("FK_SolicitudPlazaDetalle_CircuitoSolicitudPlaza");

                entity.HasOne(d => d.IdDivisionNavigation)
                    .WithMany(p => p.SolicitudPlazaDetalles)
                    .HasForeignKey(d => d.IdDivision)
                    .HasConstraintName("FK_SolicitudPlazaItem_Division");

                entity.HasOne(d => d.IdEstadoPlazaNavigation)
                    .WithMany(p => p.SolicitudPlazaDetalles)
                    .HasForeignKey(d => d.IdEstadoPlaza)
                    .HasConstraintName("FK_SolicitudPlazaDetalle_RefEstadoSolicitud");

                entity.HasOne(d => d.IdFinanciamientoNavigation)
                    .WithMany(p => p.SolicitudPlazaDetalles)
                    .HasForeignKey(d => d.IdFinanciamiento)
                    .HasConstraintName("FK_SolicitudPlazaItem_RefFinanciamiento");

                entity.HasOne(d => d.IdInstrumentoLegalBajaNavigation)
                    .WithMany(p => p.SolicitudPlazaDetalleIdInstrumentoLegalBajaNavigations)
                    .HasForeignKey(d => d.IdInstrumentoLegalBaja)
                    .HasConstraintName("FK_SolicitudPlazaItem_InstrumentoLegal1");

                entity.HasOne(d => d.IdInstrumentoLegalCreacionNavigation)
                    .WithMany(p => p.SolicitudPlazaDetalleIdInstrumentoLegalCreacionNavigations)
                    .HasForeignKey(d => d.IdInstrumentoLegalCreacion)
                    .HasConstraintName("FK_SolicitudPlazaItem_InstrumentoLegal");

                entity.HasOne(d => d.IdOrganizacionTurnoNavigation)
                    .WithMany(p => p.SolicitudPlazaDetalles)
                    .HasForeignKey(d => d.IdOrganizacionTurno)
                    .HasConstraintName("FK_SolicitudPlazaItem_OrganizacionTurno");

                entity.HasOne(d => d.IdPlanAsignaturaNavigation)
                    .WithMany(p => p.SolicitudPlazaDetalles)
                    .HasForeignKey(d => d.IdPlanAsignatura)
                    .HasConstraintName("FK_SolicitudPlazaItem_PlanAsignatura");

                entity.HasOne(d => d.IdPlanUnidadNavigation)
                    .WithMany(p => p.SolicitudPlazaDetalles)
                    .HasForeignKey(d => d.IdPlanUnidad)
                    .HasConstraintName("FK_SolicitudPlazaItem_PlanUnidad");

                entity.HasOne(d => d.IdRegimenLaboralNavigation)
                    .WithMany(p => p.SolicitudPlazaDetalles)
                    .HasForeignKey(d => d.IdRegimenLaboral)
                    .HasConstraintName("FK_SolicitudPlazaItem_RefRegimenLaboral");

                entity.HasOne(d => d.IdRegimenSalarialNavigation)
                    .WithMany(p => p.SolicitudPlazaDetalles)
                    .HasForeignKey(d => d.IdRegimenSalarial)
                    .HasConstraintName("FK_SolicitudPlazaItem_RefRegimenSalarial");

                entity.HasOne(d => d.IdSistemaEducativoNavigation)
                    .WithMany(p => p.SolicitudPlazaDetalles)
                    .HasForeignKey(d => d.IdSistemaEducativo)
                    .HasConstraintName("FK_SolicitudPlazaItem_RefSistemaEducativo");

                entity.HasOne(d => d.IdSolicitudPlazaNavigation)
                    .WithMany(p => p.SolicitudPlazaDetalles)
                    .HasForeignKey(d => d.IdSolicitudPlaza)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SolicitudPlazaItem_SolicitudPlazas");

                entity.HasOne(d => d.IdTemporalidadNavigation)
                    .WithMany(p => p.SolicitudPlazaDetalles)
                    .HasForeignKey(d => d.IdTemporalidad)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SolicitudPlazaItem_RefTemporalidad");

                entity.HasOne(d => d.IdTerminoLectivoNavigation)
                    .WithMany(p => p.SolicitudPlazaDetalles)
                    .HasForeignKey(d => d.IdTerminoLectivo)
                    .HasConstraintName("FK_SolicitudPlazaDetalle_TerminoLectivo");

                entity.HasOne(d => d.IdTipoPlazaNavigation)
                    .WithMany(p => p.SolicitudPlazaDetalles)
                    .HasForeignKey(d => d.IdTipoPlaza)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SolicitudPlazaDetalle_RefTipoPlaza");

                entity.HasOne(d => d.IdUsuarioModificacionNavigation)
                    .WithMany(p => p.SolicitudPlazaDetalles)
                    .HasForeignKey(d => d.IdUsuarioModificacion)
                    .HasConstraintName("FK_SolicitudPlazaDetalle_Usuario");
            });

            modelBuilder.Entity<SolicitudPlazaDetalleBk>(entity =>
            {
                entity.HasKey(e => e.IdSolicitudPlazaDetalle)
                    .HasName("PK_SolicitudPlazaItemsBK");

                entity.ToTable("SolicitudPlazaDetalleBK");

                entity.Property(e => e.IdSolicitudPlazaDetalle).HasColumnName("idSolicitudPlazaDetalle");

                entity.Property(e => e.AccionPlaza)
                    .HasMaxLength(10)
                    .HasColumnName("accionPlaza");

                entity.Property(e => e.AdmiteSuplente).HasColumnName("admiteSuplente");

                entity.Property(e => e.BajaAutomatica).HasColumnName("bajaAutomatica");

                entity.Property(e => e.CobraIncentivo).HasColumnName("cobraIncentivo");

                entity.Property(e => e.EsCabeceraDePaquete).HasColumnName("esCabeceraDePaquete");

                entity.Property(e => e.EstaActivo).HasColumnName("estaActivo");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaCreacion");

                entity.Property(e => e.FechaEliminacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaEliminacion");

                entity.Property(e => e.FechaHabilitacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaHabilitacion");

                entity.Property(e => e.FechaModificacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaModificacion");

                entity.Property(e => e.FechaTermino)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaTermino");

                entity.Property(e => e.FuncionExtra)
                    .HasMaxLength(50)
                    .HasColumnName("funcionExtra");

                entity.Property(e => e.IdAfectacion).HasColumnName("idAfectacion");

                entity.Property(e => e.IdCargoFuncional).HasColumnName("idCargoFuncional");

                entity.Property(e => e.IdCargoSalarial).HasColumnName("idCargoSalarial");

                entity.Property(e => e.IdCircuitoSol).HasColumnName("idCircuitoSol");

                entity.Property(e => e.IdDivision).HasColumnName("idDivision");

                entity.Property(e => e.IdEstadoPlaza).HasColumnName("idEstadoPlaza");

                entity.Property(e => e.IdFinanciamiento).HasColumnName("idFinanciamiento");

                entity.Property(e => e.IdInstrumentoLegalBaja).HasColumnName("idInstrumentoLegalBaja");

                entity.Property(e => e.IdInstrumentoLegalCreacion).HasColumnName("idInstrumentoLegalCreacion");

                entity.Property(e => e.IdMotivoBaja).HasColumnName("idMotivoBaja");

                entity.Property(e => e.IdMotivoCreacion).HasColumnName("idMotivoCreacion");

                entity.Property(e => e.IdOrganizacionTurno).HasColumnName("idOrganizacionTurno");

                entity.Property(e => e.IdPaquete).HasColumnName("idPaquete");

                entity.Property(e => e.IdPlanAsignatura).HasColumnName("idPlanAsignatura");

                entity.Property(e => e.IdPlanUnidad).HasColumnName("idPlanUnidad");

                entity.Property(e => e.IdPlaza).HasColumnName("idPlaza");

                entity.Property(e => e.IdRegimenLaboral).HasColumnName("idRegimenLaboral");

                entity.Property(e => e.IdRegimenSalarial).HasColumnName("idRegimenSalarial");

                entity.Property(e => e.IdSistemaEducativo).HasColumnName("idSistemaEducativo");

                entity.Property(e => e.IdSolicitudPlaza).HasColumnName("idSolicitudPlaza");

                entity.Property(e => e.IdTemporalidad).HasColumnName("idTemporalidad");

                entity.Property(e => e.IdTipoPlaza).HasColumnName("idTipoPlaza");

                entity.Property(e => e.IdUsuarioModificacion).HasColumnName("idUsuarioModificacion");

                entity.Property(e => e.ObsEstadoPlaza)
                    .HasMaxLength(100)
                    .HasColumnName("obsEstadoPlaza");

                entity.Property(e => e.Observacion)
                    .HasMaxLength(255)
                    .HasColumnName("observacion");
            });

            modelBuilder.Entity<SolicitudPlazaDetallePresupuestoView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("SolicitudPlazaDetallePresupuestoView");

                entity.Property(e => e.AccionPlaza)
                    .HasMaxLength(10)
                    .HasColumnName("accionPlaza");

                entity.Property(e => e.AdmiteSuplente).HasColumnName("admiteSuplente");

                entity.Property(e => e.AsignaturaDesc)
                    .HasMaxLength(60)
                    .HasColumnName("asignaturaDesc");

                entity.Property(e => e.BajaAutomatica).HasColumnName("bajaAutomatica");

                entity.Property(e => e.CargoFuncionalDesc)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("cargoFuncionalDesc");

                entity.Property(e => e.CargoSalarialDesc)
                    .HasMaxLength(100)
                    .HasColumnName("cargoSalarialDesc");

                entity.Property(e => e.CircuitoSolDesc).HasMaxLength(100);

                entity.Property(e => e.CobraIncentivo).HasColumnName("cobraIncentivo");

                entity.Property(e => e.Curso)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("curso");

                entity.Property(e => e.DivisionDesc)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("divisionDesc");

                entity.Property(e => e.EsCabeceraDePaquete).HasColumnName("esCabeceraDePaquete");

                entity.Property(e => e.EscalafonDesc)
                    .HasMaxLength(100)
                    .HasColumnName("escalafonDesc");

                entity.Property(e => e.EstaActivo).HasColumnName("estaActivo");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaCreacion");

                entity.Property(e => e.FechaEliminacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaEliminacion");

                entity.Property(e => e.FechaHabilitacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaHabilitacion");

                entity.Property(e => e.FechaTermino)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaTermino");

                entity.Property(e => e.FuncionExtra)
                    .HasMaxLength(50)
                    .HasColumnName("funcionExtra");

                entity.Property(e => e.IdAfectacion).HasColumnName("idAfectacion");

                entity.Property(e => e.IdCargoFuncional).HasColumnName("idCargoFuncional");

                entity.Property(e => e.IdCargoSalarial).HasColumnName("idCargoSalarial");

                entity.Property(e => e.IdCircuitoSol).HasColumnName("idCircuitoSol");

                entity.Property(e => e.IdDivision).HasColumnName("idDivision");

                entity.Property(e => e.IdEscalafon).HasColumnName("idEscalafon");

                entity.Property(e => e.IdEstadoPlaza).HasColumnName("idEstadoPlaza");

                entity.Property(e => e.IdFinanciamiento).HasColumnName("idFinanciamiento");

                entity.Property(e => e.IdInstrumentoLegalBaja).HasColumnName("idInstrumentoLegalBaja");

                entity.Property(e => e.IdInstrumentoLegalCreacion).HasColumnName("idInstrumentoLegalCreacion");

                entity.Property(e => e.IdJornada).HasColumnName("idJornada");

                entity.Property(e => e.IdMotivoBaja).HasColumnName("idMotivoBaja");

                entity.Property(e => e.IdMotivoCreacion).HasColumnName("idMotivoCreacion");

                entity.Property(e => e.IdOrganizacionTurno).HasColumnName("idOrganizacionTurno");

                entity.Property(e => e.IdPaquete).HasColumnName("idPaquete");

                entity.Property(e => e.IdPlanAsignatura).HasColumnName("idPlanAsignatura");

                entity.Property(e => e.IdPlanUnidad).HasColumnName("idPlanUnidad");

                entity.Property(e => e.IdPlaza).HasColumnName("idPlaza");

                entity.Property(e => e.IdRegimenLaboral).HasColumnName("idRegimenLaboral");

                entity.Property(e => e.IdRegimenSalarial).HasColumnName("idRegimenSalarial");

                entity.Property(e => e.IdSistemaEducativo).HasColumnName("idSistemaEducativo");

                entity.Property(e => e.IdSolicitudPlaza).HasColumnName("idSolicitudPlaza");

                entity.Property(e => e.IdSolicitudPlazaDetalle).HasColumnName("idSolicitudPlazaDetalle");

                entity.Property(e => e.IdTemporalidad).HasColumnName("idTemporalidad");

                entity.Property(e => e.IdTipoPlaza).HasColumnName("idTipoPlaza");

                entity.Property(e => e.IdTipoSolicitud).HasColumnName("idTipoSolicitud");

                entity.Property(e => e.JornadaDesc)
                    .HasMaxLength(20)
                    .HasColumnName("jornadaDesc");

                entity.Property(e => e.ObsEstadoPlaza)
                    .HasMaxLength(100)
                    .HasColumnName("obsEstadoPlaza");

                entity.Property(e => e.Observacion)
                    .HasMaxLength(255)
                    .HasColumnName("observacion");

                entity.Property(e => e.PlanEstudioDesc)
                    .HasMaxLength(100)
                    .HasColumnName("planEstudioDesc");

                entity.Property(e => e.TemporalidadDesc)
                    .HasMaxLength(20)
                    .HasColumnName("temporalidadDesc");

                entity.Property(e => e.TipoPlazaDesc)
                    .HasMaxLength(50)
                    .HasColumnName("tipoPlazaDesc");

                entity.Property(e => e.TurnoDesc)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("turnoDesc");
            });

            modelBuilder.Entity<SolicitudPlazaDetalleView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("SolicitudPlazaDetalleView");

                entity.Property(e => e.AccionPlaza)
                    .HasMaxLength(10)
                    .HasColumnName("accionPlaza");

                entity.Property(e => e.AdmiteSuplente).HasColumnName("admiteSuplente");

                entity.Property(e => e.AsignaturaDesc)
                    .HasMaxLength(60)
                    .HasColumnName("asignaturaDesc");

                entity.Property(e => e.BajaAutomatica).HasColumnName("bajaAutomatica");

                entity.Property(e => e.CargoFuncionalDesc)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("cargoFuncionalDesc");

                entity.Property(e => e.CargoSalarialDesc)
                    .HasMaxLength(100)
                    .HasColumnName("cargoSalarialDesc");

                entity.Property(e => e.CircuitoSolDesc).HasMaxLength(100);

                entity.Property(e => e.CobraIncentivo).HasColumnName("cobraIncentivo");

                entity.Property(e => e.Curso)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("curso");

                entity.Property(e => e.DivisionDesc)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("divisionDesc");

                entity.Property(e => e.EsCabeceraDePaquete).HasColumnName("esCabeceraDePaquete");

                entity.Property(e => e.EstaActivo).HasColumnName("estaActivo");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaCreacion");

                entity.Property(e => e.FechaEliminacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaEliminacion");

                entity.Property(e => e.FechaHabilitacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaHabilitacion");

                entity.Property(e => e.FechaTermino)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaTermino");

                entity.Property(e => e.FuncionExtra)
                    .HasMaxLength(50)
                    .HasColumnName("funcionExtra");

                entity.Property(e => e.IdAfectacion).HasColumnName("idAfectacion");

                entity.Property(e => e.IdCargoFuncional).HasColumnName("idCargoFuncional");

                entity.Property(e => e.IdCargoSalarial).HasColumnName("idCargoSalarial");

                entity.Property(e => e.IdCircuitoSol).HasColumnName("idCircuitoSol");

                entity.Property(e => e.IdDivision).HasColumnName("idDivision");

                entity.Property(e => e.IdEstadoPlaza).HasColumnName("idEstadoPlaza");

                entity.Property(e => e.IdFinanciamiento).HasColumnName("idFinanciamiento");

                entity.Property(e => e.IdInstrumentoLegalBaja).HasColumnName("idInstrumentoLegalBaja");

                entity.Property(e => e.IdInstrumentoLegalCreacion).HasColumnName("idInstrumentoLegalCreacion");

                entity.Property(e => e.IdJornada).HasColumnName("idJornada");

                entity.Property(e => e.IdMotivoBaja).HasColumnName("idMotivoBaja");

                entity.Property(e => e.IdMotivoCreacion).HasColumnName("idMotivoCreacion");

                entity.Property(e => e.IdOrganizacionTurno).HasColumnName("idOrganizacionTurno");

                entity.Property(e => e.IdPaquete).HasColumnName("idPaquete");

                entity.Property(e => e.IdPlanAsignatura).HasColumnName("idPlanAsignatura");

                entity.Property(e => e.IdPlanUnidad).HasColumnName("idPlanUnidad");

                entity.Property(e => e.IdPlaza).HasColumnName("idPlaza");

                entity.Property(e => e.IdRegimenLaboral).HasColumnName("idRegimenLaboral");

                entity.Property(e => e.IdRegimenSalarial).HasColumnName("idRegimenSalarial");

                entity.Property(e => e.IdSistemaEducativo).HasColumnName("idSistemaEducativo");

                entity.Property(e => e.IdSolicitudPlaza).HasColumnName("idSolicitudPlaza");

                entity.Property(e => e.IdSolicitudPlazaDetalle).HasColumnName("idSolicitudPlazaDetalle");

                entity.Property(e => e.IdTemporalidad).HasColumnName("idTemporalidad");

                entity.Property(e => e.IdTipoPlaza).HasColumnName("idTipoPlaza");

                entity.Property(e => e.IdTipoSolicitud).HasColumnName("idTipoSolicitud");

                entity.Property(e => e.IdTurno).HasColumnName("idTurno");

                entity.Property(e => e.JornadaDesc)
                    .HasMaxLength(20)
                    .HasColumnName("jornadaDesc");

                entity.Property(e => e.MotivoCreacionDesc)
                    .HasMaxLength(50)
                    .HasColumnName("motivoCreacionDesc");

                entity.Property(e => e.ObsEstadoPlaza)
                    .HasMaxLength(100)
                    .HasColumnName("obsEstadoPlaza");

                entity.Property(e => e.Observacion)
                    .HasMaxLength(255)
                    .HasColumnName("observacion");

                entity.Property(e => e.PlanEstudioDesc)
                    .HasMaxLength(100)
                    .HasColumnName("planEstudioDesc");

                entity.Property(e => e.TemporalidadDesc)
                    .HasMaxLength(20)
                    .HasColumnName("temporalidadDesc");

                entity.Property(e => e.TipoPlazaDesc)
                    .HasMaxLength(50)
                    .HasColumnName("tipoPlazaDesc");

                entity.Property(e => e.TurnoDesc)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("turnoDesc");
            });

            modelBuilder.Entity<SolicitudPlazaListview>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("SolicitudPlazaLISTView");

                entity.Property(e => e.Anio).HasColumnName("anio");

                entity.Property(e => e.CircuitoSolDesc).HasMaxLength(100);

                entity.Property(e => e.EjercicioDesc)
                    .HasMaxLength(4)
                    .HasColumnName("ejercicioDesc");

                entity.Property(e => e.EstadoSolicitudDesc)
                    .HasMaxLength(25)
                    .HasColumnName("estadoSolicitudDesc");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaCreacion");

                entity.Property(e => e.IdCircuitoSol).HasColumnName("idCircuitoSol");

                entity.Property(e => e.IdEjercicio).HasColumnName("idEjercicio");

                entity.Property(e => e.IdEstadoSolicitud).HasColumnName("idEstadoSolicitud");

                entity.Property(e => e.IdGrupoNivel).HasColumnName("idGrupoNivel");

                entity.Property(e => e.IdHistoriaOrg).HasColumnName("idHistoriaOrg");

                entity.Property(e => e.IdNivelEducativo).HasColumnName("idNivelEducativo");

                entity.Property(e => e.IdOrganizacion).HasColumnName("idOrganizacion");

                entity.Property(e => e.IdOrganizacionNivelEduc).HasColumnName("idOrganizacionNivelEduc");

                entity.Property(e => e.IdSolicitudPlaza).HasColumnName("idSolicitudPlaza");

                entity.Property(e => e.IdTipoSolicitud).HasColumnName("idTipoSolicitud");

                entity.Property(e => e.NivelEducativoDesc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nivelEducativoDesc");

                entity.Property(e => e.NumeroSolicitud).HasColumnName("numeroSolicitud");

                entity.Property(e => e.OrganizacionDesc)
                    .HasMaxLength(250)
                    .HasColumnName("organizacionDesc");

                entity.Property(e => e.TipoSolicitudDesc)
                    .HasMaxLength(50)
                    .HasColumnName("tipoSolicitudDesc");
            });

            modelBuilder.Entity<SolicitudPlazaSitExt>(entity =>
            {
                entity.HasKey(e => e.IdSolicitudPlazaSitExt);

                entity.ToTable("SolicitudPlazaSitExt");

                entity.HasComment("Ítems o cargos de una solicitud de habilitación de plazas");

                entity.Property(e => e.IdSolicitudPlazaSitExt)
                    .HasColumnName("idSolicitudPlazaSitExt")
                    .HasComment("Campo cñave autoincremental");

                entity.Property(e => e.AdmiteSuplente)
                    .HasColumnName("admiteSuplente")
                    .HasComment("Indica si la plaza admite suplencias");

                entity.Property(e => e.BajaAutomatica)
                    .HasColumnName("bajaAutomatica")
                    .HasComment("Campo para determinar si al finalziar el período de habilitación de la plaza ésta será dada de baja de forma automática.");

                entity.Property(e => e.CantidadHs).HasComment("cantidad de horas en caso de tratarse de una cargo tipo hs.");

                entity.Property(e => e.CobraIncentivo)
                    .HasColumnName("cobraIncentivo")
                    .HasComment("Indica si la plaza habilita el cobro de incentivo");

                entity.Property(e => e.EstaActivo)
                    .HasColumnName("estaActivo")
                    .HasComment("Campo para eliminación lógica");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaCreacion")
                    .HasComment("Fecha de creación del cargo ");

                entity.Property(e => e.FechaEliminacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaEliminacion")
                    .HasComment("Fecha de eliminación lógica");

                entity.Property(e => e.FechaHabilitacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaHabilitacion")
                    .HasComment("Fecha desde la que se solicita la habilitación  de la plaza");

                entity.Property(e => e.FechaTermino)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaTermino")
                    .HasComment("Fecha de término del período de habilitación de la plaza");

                entity.Property(e => e.FuncionExtra)
                    .HasMaxLength(50)
                    .HasColumnName("funcionExtra");

                entity.Property(e => e.IdAfectacion)
                    .HasColumnName("idAfectacion")
                    .HasComment("Intrapresupeustaria, extrapresupeustaria");

                entity.Property(e => e.IdCargoFuncional)
                    .HasColumnName("idCargoFuncional")
                    .HasComment("Identificador de la función se de desempeñará en el cargo o plaza");

                entity.Property(e => e.IdCargoSalarial)
                    .HasColumnName("idCargoSalarial")
                    .HasComment("Identificadoe de cargo salarial");

                entity.Property(e => e.IdDivision)
                    .HasColumnName("idDivision")
                    .HasComment("Divisón de una organización para un pland e estudio en particular");

                entity.Property(e => e.IdExpteCreacion)
                    .HasColumnName("idExpteCreacion")
                    .HasComment("Clave foranea, identificador del expediente con el que se tramita la creacion de la plaza extraordinaria.");

                entity.Property(e => e.IdFinanciamiento)
                    .HasColumnName("idFinanciamiento")
                    .HasComment("Provincia, nacion, municipalidad");

                entity.Property(e => e.IdInstrumentoLegalBaja)
                    .HasColumnName("idInstrumentoLegalBaja")
                    .HasComment("Instrumento legal de baja");

                entity.Property(e => e.IdInstrumentoLegalCreacion)
                    .HasColumnName("idInstrumentoLegalCreacion")
                    .HasComment("Instrumento legal de creación");

                entity.Property(e => e.IdMotivoBaja)
                    .HasColumnName("idMotivoBaja")
                    .HasComment("Identificador de motivo de baja de la plaza. Ejemplo: termino de periodo de habilitacion");

                entity.Property(e => e.IdMotivoCreacion)
                    .HasColumnName("idMotivoCreacion")
                    .HasComment("Identificador de motivo de creación. Ejemplo POF, NO POF");

                entity.Property(e => e.IdOrganizacionTurno)
                    .HasColumnName("idOrganizacionTurno")
                    .HasComment("Identificador de turno dentro de una organización");

                entity.Property(e => e.IdPlanAsignatura)
                    .HasColumnName("idPlanAsignatura")
                    .HasComment("Identificador de asignatura dentro un plan de estudio de una organización");

                entity.Property(e => e.IdPlanUnidad)
                    .HasColumnName("idPlanUnidad")
                    .HasComment("Identificador de una unidad académica, es decir plan de estudio dentro de una organizaicón para un determinado nivel educativo. ");

                entity.Property(e => e.IdPlaza)
                    .HasColumnName("idPlaza")
                    .HasComment("Identificador de plaza para la cual se generará un servicio");

                entity.Property(e => e.IdRegimenLaboral)
                    .HasColumnName("idRegimenLaboral")
                    .HasComment("Docente, no docente,  contrato de servicio, etc.");

                entity.Property(e => e.IdRegimenSalarial)
                    .HasColumnName("idRegimenSalarial")
                    .HasComment("Cargo, horas");

                entity.Property(e => e.IdSistemaEducativo)
                    .HasColumnName("idSistemaEducativo")
                    .HasComment("Indica si es educación formal o no formal");

                entity.Property(e => e.IdSolicitudDetalle)
                    .HasColumnName("idSolicitudDetalle")
                    .HasComment("Identificador del detalle de solicitud de situación extraordinaria para la cual se genera la plaza.");

                entity.Property(e => e.IdTemporalidad)
                    .HasColumnName("idTemporalidad")
                    .HasComment("Identificador de la temporalidad o caracter de la palza- Ejemplo: 1 - definitivo, 2-provisional");

                entity.Property(e => e.IdTipoPlaza)
                    .HasColumnName("idTipoPlaza")
                    .HasComment("Identificador de tipo de plaza");

                entity.Property(e => e.Observacion)
                    .HasMaxLength(255)
                    .HasColumnName("observacion");

                entity.HasOne(d => d.IdAfectacionNavigation)
                    .WithMany(p => p.SolicitudPlazaSitExts)
                    .HasForeignKey(d => d.IdAfectacion)
                    .HasConstraintName("FK_SolicitudPlazaSitExt_RefAfectacion");

                entity.HasOne(d => d.IdCargoFuncionalNavigation)
                    .WithMany(p => p.SolicitudPlazaSitExts)
                    .HasForeignKey(d => d.IdCargoFuncional)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SolicitudPlazaSitExt_CargoFuncional");

                entity.HasOne(d => d.IdCargoSalarialNavigation)
                    .WithMany(p => p.SolicitudPlazaSitExts)
                    .HasForeignKey(d => d.IdCargoSalarial)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SolicitudPlazaSitExt_CargoSalarial");

                entity.HasOne(d => d.IdDivisionNavigation)
                    .WithMany(p => p.SolicitudPlazaSitExts)
                    .HasForeignKey(d => d.IdDivision)
                    .HasConstraintName("FK_SolicitudPlazaSitExt_Division");

                entity.HasOne(d => d.IdFinanciamientoNavigation)
                    .WithMany(p => p.SolicitudPlazaSitExts)
                    .HasForeignKey(d => d.IdFinanciamiento)
                    .HasConstraintName("FK_SolicitudPlazaSitExt_RefFinanciamiento");

                entity.HasOne(d => d.IdInstrumentoLegalBajaNavigation)
                    .WithMany(p => p.SolicitudPlazaSitExtIdInstrumentoLegalBajaNavigations)
                    .HasForeignKey(d => d.IdInstrumentoLegalBaja)
                    .HasConstraintName("FK_SolicitudPlazaSitExt_InstrumentoLegal1");

                entity.HasOne(d => d.IdInstrumentoLegalCreacionNavigation)
                    .WithMany(p => p.SolicitudPlazaSitExtIdInstrumentoLegalCreacionNavigations)
                    .HasForeignKey(d => d.IdInstrumentoLegalCreacion)
                    .HasConstraintName("FK_SolicitudPlazaSitExt_InstrumentoLegal");

                entity.HasOne(d => d.IdOrganizacionTurnoNavigation)
                    .WithMany(p => p.SolicitudPlazaSitExts)
                    .HasForeignKey(d => d.IdOrganizacionTurno)
                    .HasConstraintName("FK_SolicitudPlazaSitExt_OrganizacionTurno");

                entity.HasOne(d => d.IdPlanAsignaturaNavigation)
                    .WithMany(p => p.SolicitudPlazaSitExts)
                    .HasForeignKey(d => d.IdPlanAsignatura)
                    .HasConstraintName("FK_SolicitudPlazaSitExt_PlanAsignatura");

                entity.HasOne(d => d.IdPlanUnidadNavigation)
                    .WithMany(p => p.SolicitudPlazaSitExts)
                    .HasForeignKey(d => d.IdPlanUnidad)
                    .HasConstraintName("FK_SolicitudPlazaSitExt_PlanUnidad");

                entity.HasOne(d => d.IdRegimenLaboralNavigation)
                    .WithMany(p => p.SolicitudPlazaSitExts)
                    .HasForeignKey(d => d.IdRegimenLaboral)
                    .HasConstraintName("FK_SolicitudPlazaSitExt_RefRegimenLaboral");

                entity.HasOne(d => d.IdRegimenSalarialNavigation)
                    .WithMany(p => p.SolicitudPlazaSitExts)
                    .HasForeignKey(d => d.IdRegimenSalarial)
                    .HasConstraintName("FK_SolicitudPlazaSitExt_RefRegimenSalarial");

                entity.HasOne(d => d.IdSistemaEducativoNavigation)
                    .WithMany(p => p.SolicitudPlazaSitExts)
                    .HasForeignKey(d => d.IdSistemaEducativo)
                    .HasConstraintName("FK_SolicitudPlazaSitExt_RefSistemaEducativo");

                entity.HasOne(d => d.IdTemporalidadNavigation)
                    .WithMany(p => p.SolicitudPlazaSitExts)
                    .HasForeignKey(d => d.IdTemporalidad)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SolicitudPlazaSitExt_RefTemporalidad");

                entity.HasOne(d => d.IdTipoPlazaNavigation)
                    .WithMany(p => p.SolicitudPlazaSitExts)
                    .HasForeignKey(d => d.IdTipoPlaza)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SolicitudPlazaSitExt_RefTipoPlaza");
            });

            modelBuilder.Entity<SolicitudTurno>(entity =>
            {
                entity.HasKey(e => e.IdSolicitudTurno);

                entity.ToTable("SolicitudTurno");

                entity.Property(e => e.IdSolicitudTurno).HasColumnName("idSolicitudTurno");

                entity.Property(e => e.EstaActivo)
                    .IsRequired()
                    .HasColumnName("estaActivo")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.FechaEliminacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaEliminacion");

                entity.Property(e => e.FechaNotificacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaNotificacion");

                entity.Property(e => e.FechaPedido)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaPedido");

                entity.Property(e => e.FechaTurno)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaTurno");

                entity.Property(e => e.IdEjercicio).HasColumnName("idEjercicio");

                entity.Property(e => e.IdHistoriaOrg).HasColumnName("idHistoriaOrg");

                entity.Property(e => e.IdLicencia).HasColumnName("idLicencia");

                entity.Property(e => e.IdOrganismo).HasColumnName("idOrganismo");

                entity.Property(e => e.IdPersona).HasColumnName("idPersona");

                entity.Property(e => e.IdTipoSolicitud).HasColumnName("idTipoSolicitud");

                entity.Property(e => e.MailContacto)
                    .HasMaxLength(50)
                    .HasColumnName("mailContacto")
                    .IsFixedLength();

                entity.Property(e => e.NumeroSolicitud).HasColumnName("numeroSolicitud");

                entity.HasOne(d => d.IdEjercicioNavigation)
                    .WithMany(p => p.SolicitudTurnos)
                    .HasForeignKey(d => d.IdEjercicio)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SolicitudTurno_RefEjercicio");

                entity.HasOne(d => d.IdLicenciaNavigation)
                    .WithMany(p => p.SolicitudTurnos)
                    .HasForeignKey(d => d.IdLicencia)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SolicitudTurno_Licencia");

                entity.HasOne(d => d.IdPersonaNavigation)
                    .WithMany(p => p.SolicitudTurnos)
                    .HasForeignKey(d => d.IdPersona)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SolicitudTurno_Persona");

                entity.HasOne(d => d.IdTipoSolicitudNavigation)
                    .WithMany(p => p.SolicitudTurnos)
                    .HasForeignKey(d => d.IdTipoSolicitud)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SolicitudTurno_RefTipoSolicitud");

                entity.HasOne(d => d.Id)
                    .WithMany(p => p.SolicitudTurnos)
                    .HasForeignKey(d => new { d.IdOrganismo, d.IdHistoriaOrg })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SolicitudTurno_Organizacion");
            });

            modelBuilder.Entity<SolicitudTurnoView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("SolicitudTurnoView");

                entity.Property(e => e.Apellido)
                    .HasMaxLength(50)
                    .HasColumnName("apellido");

                entity.Property(e => e.Cue).HasColumnName("cue");

                entity.Property(e => e.Cuil)
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("cuil");

                entity.Property(e => e.Documento).HasColumnName("documento");

                entity.Property(e => e.EstaActivo).HasColumnName("estaActivo");

                entity.Property(e => e.FechaEliminacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaEliminacion");

                entity.Property(e => e.FechaNotificacion)
                    .HasColumnType("date")
                    .HasColumnName("fechaNotificacion");

                entity.Property(e => e.FechaPedido)
                    .HasColumnType("date")
                    .HasColumnName("fechaPedido");

                entity.Property(e => e.FechaTurno)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaTurno");

                entity.Property(e => e.IdHistoriaOrg).HasColumnName("idHistoriaOrg");

                entity.Property(e => e.IdLicencia).HasColumnName("idLicencia");

                entity.Property(e => e.IdOrganismo).HasColumnName("idOrganismo");

                entity.Property(e => e.IdOrganizacion).HasColumnName("idOrganizacion");

                entity.Property(e => e.IdPersona).HasColumnName("idPersona");

                entity.Property(e => e.IdSolicitudTurno).HasColumnName("idSolicitudTurno");

                entity.Property(e => e.IdTipoDocumento).HasColumnName("idTipoDocumento");

                entity.Property(e => e.MailContacto)
                    .HasMaxLength(50)
                    .HasColumnName("mailContacto")
                    .IsFixedLength();

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .HasColumnName("nombre");

                entity.Property(e => e.NumeroArticulo)
                    .HasMaxLength(15)
                    .HasColumnName("numeroArticulo");

                entity.Property(e => e.OrganizacionDesc)
                    .HasMaxLength(250)
                    .HasColumnName("organizacionDesc");
            });

            modelBuilder.Entity<SubServicio>(entity =>
            {
                entity.HasKey(e => e.IdSubServicio);

                entity.ToTable("SubServicio");

                entity.HasComment("Subservicios ligados a un servicio");

                entity.Property(e => e.IdSubServicio)
                    .HasColumnName("idSubServicio")
                    .HasComment("Clave primaria, autoincrementable. Identificador de Subservicio");

                entity.Property(e => e.EstaActivo)
                    .IsRequired()
                    .HasColumnName("estaActivo")
                    .HasDefaultValueSql("((1))")
                    .HasComment("Campo para eliminación lógica. Valor 0 es igual a falso, valor 1 es igual a verdadero");

                entity.Property(e => e.EstaFrenteAlumno)
                    .HasColumnName("estaFrenteAlumno")
                    .HasComment("Indica si el servicio se realiza frente a alumnos. ");

                entity.Property(e => e.FechaDesde)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaDesde")
                    .HasComment("Fecha a partir de la cual entra en vigencia el subservicio");

                entity.Property(e => e.FechaEliminacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaEliminacion")
                    .HasComment("Fecha en la que se realiza la eliminación lógica");

                entity.Property(e => e.FechaHasta)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaHasta")
                    .HasComment("Fecha en la que termina la vigencia del subservicio");

                entity.Property(e => e.IdAdicional)
                    .HasColumnName("idAdicional")
                    .HasComment("Clave foranea. Identificador de adicional. Ejemplo: 1. Adicional por mayor horario; 2. Adicional por mayor responsabilidad");

                entity.Property(e => e.IdExpteCreacion)
                    .HasColumnName("idExpteCreacion")
                    .HasComment("Clave foranea, identificador del expediente con el que se tramita la creacion del sub servicio.");

                entity.Property(e => e.IdInstrumentoLegal)
                    .HasColumnName("idInstrumentoLegal")
                    .HasComment("Clave foranea. Identificador del instrumento legal que avala el subservicio");

                entity.Property(e => e.IdMovimiento)
                    .HasColumnName("idMovimiento")
                    .HasComment("Clave foranea. Identificador de movimiento. Ejemplo: 1. Alta; 2. Baja; 3.Licencia; 4. Situación extraordinaria (Slector de tabla)");

                entity.Property(e => e.IdServicio)
                    .HasColumnName("idServicio")
                    .HasComment(" Clave foranea. Identificador de Servicio al cual esta asociado este subservicio");

                entity.Property(e => e.IdServicioDestino)
                    .HasColumnName("idServicioDestino")
                    .HasComment("Clave foranea. Identificador del servicio ligado, en caso de dar inicio un nuevo servicio, por situación extraordinaria por ejemplo.");

                entity.Property(e => e.IdSolicitudDetalle)
                    .HasColumnName("idSolicitudDetalle")
                    .HasComment("Clave foranea. Identificador del detalle de solicitud que generó el subservicio (SPuede hacer referencia a las tablas olicitudDetalleLicSe, SolicitudDetalleDesignación, según idMovimiento)");

                entity.Property(e => e.IdSubServicioVinculado).HasColumnName("idSubServicioVinculado");

                entity.Property(e => e.IdTerminoLectivo).HasColumnName("idTerminoLectivo");

                entity.Property(e => e.TieneSuplente)
                    .HasColumnName("tieneSuplente")
                    .HasDefaultValueSql("((0))")
                    .HasComment("True si el subservicio de licencia ya tiene un suplente designado durante la totalidad del periodo de la licencia");

                entity.HasOne(d => d.IdAdicionalNavigation)
                    .WithMany(p => p.SubServicios)
                    .HasForeignKey(d => d.IdAdicional)
                    .HasConstraintName("FK_SubServicio_RefAdicional");

                entity.HasOne(d => d.IdInstrumentoLegalNavigation)
                    .WithMany(p => p.SubServicios)
                    .HasForeignKey(d => d.IdInstrumentoLegal)
                    .HasConstraintName("FK_SubServicio_InstrumentoLegal");

                entity.HasOne(d => d.IdMovimientoNavigation)
                    .WithMany(p => p.SubServicios)
                    .HasForeignKey(d => d.IdMovimiento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SubServicio_RefMovimiento");

                entity.HasOne(d => d.IdServicioNavigation)
                    .WithMany(p => p.SubServicioIdServicioNavigations)
                    .HasForeignKey(d => d.IdServicio)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SubServicio_Servicio");

                entity.HasOne(d => d.IdServicioDestinoNavigation)
                    .WithMany(p => p.SubServicioIdServicioDestinoNavigations)
                    .HasForeignKey(d => d.IdServicioDestino)
                    .HasConstraintName("FK_SubServicio_ServicioDestino");

                entity.HasOne(d => d.IdSolicitudDetalleNavigation)
                    .WithMany(p => p.SubServicios)
                    .HasForeignKey(d => d.IdSolicitudDetalle)
                    .HasConstraintName("FK_SubServicio_SolicitudDetalle");

                entity.HasOne(d => d.IdTerminoLectivoNavigation)
                    .WithMany(p => p.SubServicios)
                    .HasForeignKey(d => d.IdTerminoLectivo)
                    .HasConstraintName("FK_SubServicio_TerminoLectivo");
            });

            modelBuilder.Entity<SubServicioView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("SubServicioView");

                entity.Property(e => e.EsHito).HasColumnName("esHito");

                entity.Property(e => e.EstaActivo).HasColumnName("estaActivo");

                entity.Property(e => e.EstaFrenteAlumno).HasColumnName("estaFrenteAlumno");

                entity.Property(e => e.FechaDesde)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaDesde");

                entity.Property(e => e.FechaHasta)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaHasta");

                entity.Property(e => e.GeneraSuplente).HasColumnName("generaSuplente");

                entity.Property(e => e.IdAdicional).HasColumnName("idAdicional");

                entity.Property(e => e.IdExpteCreacion).HasColumnName("idExpteCreacion");

                entity.Property(e => e.IdInstrumentoLegal).HasColumnName("idInstrumentoLegal");

                entity.Property(e => e.IdMovimiento).HasColumnName("idMovimiento");

                entity.Property(e => e.IdPlaza).HasColumnName("idPlaza");

                entity.Property(e => e.IdServicio).HasColumnName("idServicio");

                entity.Property(e => e.IdServicioDestino).HasColumnName("idServicioDestino");

                entity.Property(e => e.IdSolicitudDetalle).HasColumnName("idSolicitudDetalle");

                entity.Property(e => e.IdSubServicio).HasColumnName("idSubServicio");

                entity.Property(e => e.IdSubServicioVinculado).HasColumnName("idSubServicioVinculado");

                entity.Property(e => e.IdTerminoLectivo).HasColumnName("idTerminoLectivo");

                entity.Property(e => e.IdTipoMovimiento).HasColumnName("idTipoMovimiento");

                entity.Property(e => e.InstrumentoLegalDesc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("instrumentoLegalDesc");

                entity.Property(e => e.MovimientoDesc)
                    .HasMaxLength(100)
                    .HasColumnName("movimientoDesc");

                entity.Property(e => e.TieneSuplente).HasColumnName("tieneSuplente");

                entity.Property(e => e.TipoMovimientoDesc)
                    .HasMaxLength(50)
                    .HasColumnName("tipoMovimientoDesc");
            });

            modelBuilder.Entity<SumarioDictamenServicio>(entity =>
            {
                entity.HasKey(e => e.IdDictamenServicio);

                entity.Property(e => e.IdDictamenServicio).HasColumnName("idDictamenServicio");

                entity.Property(e => e.EstaActivo).HasColumnName("estaActivo");

                entity.Property(e => e.FechaEliminacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaEliminacion");

                entity.Property(e => e.IdPersonaSumarioDictamen).HasColumnName("idPersonaSumarioDictamen");

                entity.Property(e => e.IdServicio).HasColumnName("idServicio");

                entity.HasOne(d => d.IdPersonaSumarioDictamenNavigation)
                    .WithMany(p => p.SumarioDictamenServicios)
                    .HasForeignKey(d => d.IdPersonaSumarioDictamen)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SumarioDictamenServicios_PersonaSumarioDictamen");

                entity.HasOne(d => d.IdServicioNavigation)
                    .WithMany(p => p.SumarioDictamenServicios)
                    .HasForeignKey(d => d.IdServicio)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SumarioDictamenServicios_Servicio");
            });

            modelBuilder.Entity<TableroBase>(entity =>
            {
                entity.HasKey(e => e.IdTableroBase);

                entity.ToTable("TableroBase");

                entity.Property(e => e.IdTableroBase).HasColumnName("idTableroBase");

                entity.Property(e => e.EstaActivo)
                    .IsRequired()
                    .HasColumnName("estaActivo")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.FechaEliminacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaEliminacion");

                entity.Property(e => e.HoraDesde).HasColumnName("horaDesde");

                entity.Property(e => e.HoraHasta).HasColumnName("horaHasta");

                entity.Property(e => e.IdDiaSemana).HasColumnName("idDiaSemana");

                entity.Property(e => e.IdTipoTablero).HasColumnName("idTipoTablero");

                entity.Property(e => e.NroModulo).HasColumnName("nroModulo");

                entity.HasOne(d => d.IdDiaSemanaNavigation)
                    .WithMany(p => p.TableroBases)
                    .HasForeignKey(d => d.IdDiaSemana)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TableroBase_RefDiaSemana");

                entity.HasOne(d => d.IdTipoTableroNavigation)
                    .WithMany(p => p.TableroBases)
                    .HasForeignKey(d => d.IdTipoTablero)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TableroBase_RefTipoTablero");
            });

            modelBuilder.Entity<TableroOrganizacion>(entity =>
            {
                entity.HasKey(e => e.IdTableroOrganizacion);

                entity.ToTable("TableroOrganizacion");

                entity.Property(e => e.IdTableroOrganizacion).HasColumnName("idTableroOrganizacion");

                entity.Property(e => e.EstaActivo)
                    .IsRequired()
                    .HasColumnName("estaActivo")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaCreacion");

                entity.Property(e => e.FechaEliminacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaEliminacion");

                entity.Property(e => e.IdEjercicio).HasColumnName("idEjercicio");

                entity.Property(e => e.IdOrganizacionNivelEducativo).HasColumnName("idOrganizacionNivelEducativo");

                entity.Property(e => e.IdOrganizacionTurno).HasColumnName("idOrganizacionTurno");

                entity.HasOne(d => d.IdEjercicioNavigation)
                    .WithMany(p => p.TableroOrganizacions)
                    .HasForeignKey(d => d.IdEjercicio)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TableroOrganizacion_RefEjercicio");

                entity.HasOne(d => d.IdOrganizacionNivelEducativoNavigation)
                    .WithMany(p => p.TableroOrganizacions)
                    .HasForeignKey(d => d.IdOrganizacionNivelEducativo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TableroOrganizacion_OrganizacionNivelEducativo");

                entity.HasOne(d => d.IdOrganizacionTurnoNavigation)
                    .WithMany(p => p.TableroOrganizacions)
                    .HasForeignKey(d => d.IdOrganizacionTurno)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TableroOrganizacion_OrganizacionTurno");
            });

            modelBuilder.Entity<TableroOrganizacionDetalle>(entity =>
            {
                entity.HasKey(e => e.IdTableroOrganizacionDetalle);

                entity.ToTable("TableroOrganizacionDetalle");

                entity.Property(e => e.IdTableroOrganizacionDetalle).HasColumnName("idTableroOrganizacionDetalle");

                entity.Property(e => e.EstaActivo)
                    .IsRequired()
                    .HasColumnName("estaActivo")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.FechaEliminacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaEliminacion");

                entity.Property(e => e.HoraDesde).HasColumnName("horaDesde");

                entity.Property(e => e.HoraHasta).HasColumnName("horaHasta");

                entity.Property(e => e.IdDiaSemana).HasColumnName("idDiaSemana");

                entity.Property(e => e.IdTableroOrganizacion).HasColumnName("idTableroOrganizacion");

                entity.Property(e => e.NroModulo).HasColumnName("nroModulo");

                entity.HasOne(d => d.IdDiaSemanaNavigation)
                    .WithMany(p => p.TableroOrganizacionDetalles)
                    .HasForeignKey(d => d.IdDiaSemana)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TableroOrganizacionDetalle_RefDiaSemana");

                entity.HasOne(d => d.IdTableroOrganizacionNavigation)
                    .WithMany(p => p.TableroOrganizacionDetalles)
                    .HasForeignKey(d => d.IdTableroOrganizacion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TableroOrganizacionDetalle_TableroOrganizacion");
            });

            modelBuilder.Entity<TableroOrganizacionView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("TableroOrganizacionView");

                entity.Property(e => e.EstaActivo).HasColumnName("estaActivo");

                entity.Property(e => e.GrupoDesc)
                    .HasMaxLength(50)
                    .HasColumnName("grupoDesc");

                entity.Property(e => e.IdEjercicio).HasColumnName("idEjercicio");

                entity.Property(e => e.IdHistoriaOrg).HasColumnName("idHistoriaOrg");

                entity.Property(e => e.IdOrganizacion).HasColumnName("idOrganizacion");

                entity.Property(e => e.IdOrganizacionNivelEducativo).HasColumnName("idOrganizacionNivelEducativo");

                entity.Property(e => e.IdOrganizacionTurno).HasColumnName("idOrganizacionTurno");

                entity.Property(e => e.IdTableroOrganizacion).HasColumnName("idTableroOrganizacion");

                entity.Property(e => e.NivelEducativoDesc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nivelEducativoDesc");

                entity.Property(e => e.OrganizacionDesc)
                    .HasMaxLength(250)
                    .HasColumnName("organizacionDesc");

                entity.Property(e => e.TurnoDesc)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("turnoDesc");
            });

            modelBuilder.Entity<TableroPlaza>(entity =>
            {
                entity.HasKey(e => e.IdTableroPlaza);

                entity.ToTable("TableroPlaza");

                entity.Property(e => e.IdTableroPlaza).HasColumnName("idTableroPlaza");

                entity.Property(e => e.EstaActivo)
                    .IsRequired()
                    .HasColumnName("estaActivo")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.FechaDesde)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaDesde");

                entity.Property(e => e.FechaEliminacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaEliminacion");

                entity.Property(e => e.FechaHasta)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaHasta");

                entity.Property(e => e.IdPlaza).HasColumnName("idPlaza");

                entity.Property(e => e.IdTableroOrganizacionDetalle).HasColumnName("idTableroOrganizacionDetalle");

                entity.HasOne(d => d.IdPlazaNavigation)
                    .WithMany(p => p.TableroPlazas)
                    .HasForeignKey(d => d.IdPlaza)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TableroPlaza_Plaza");

                entity.HasOne(d => d.IdTableroOrganizacionDetalleNavigation)
                    .WithMany(p => p.TableroPlazas)
                    .HasForeignKey(d => d.IdTableroOrganizacionDetalle)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TableroPlaza_TableroOrganizacionDetalle");
            });

            modelBuilder.Entity<TerminoLectivo>(entity =>
            {
                entity.HasKey(e => e.IdTerminoLectivo);

                entity.ToTable("TerminoLectivo");

                entity.HasComment("Representa  el anuario escolar");

                entity.Property(e => e.IdTerminoLectivo)
                    .HasColumnName("idTerminoLectivo")
                    .HasComment("Clave primari de termino lectivo, autoincrementable");

                entity.Property(e => e.EstaActivo)
                    .IsRequired()
                    .HasColumnName("estaActivo")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.FechaEliminación)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaEliminación");

                entity.Property(e => e.FechaFinalizacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaFinalizacion")
                    .HasComment("Fecha de fin del ciclo lectivo completo. Ejemplo: nivel superiro 25 de noviembre de 2017");

                entity.Property(e => e.FechaInicio)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaInicio")
                    .HasComment("Fecha de inicio del ciclo lectivo completo. Ejemplo: nivel superiro 14 de marzo de 2017");

                entity.Property(e => e.IdEjercicio).HasColumnName("idEjercicio");

                entity.Property(e => e.IdGrupoNivel)
                    .HasColumnName("idGrupoNivel")
                    .HasComment("Identificador de grupo de nivel educativo. Ejemplo: grupo Primaria abarca niveles inicial y primaria, Secundaria, abarca niveles secundaria, egb, polimodal, etc. ");

                entity.Property(e => e.IdTipoPeriodoEscolar)
                    .HasColumnName("idTipoPeriodoEscolar")
                    .HasComment("Tipo de periodo escolar. Ejemplo: Común, especial");

                entity.Property(e => e.Organizacion)
                    .HasMaxLength(50)
                    .HasColumnName("organizacion")
                    .HasComment("Organización del término lectivo. Ejemplo: bimestre, treimestre, cuatrimestre");

                entity.HasOne(d => d.IdEjercicioNavigation)
                    .WithMany(p => p.TerminoLectivos)
                    .HasForeignKey(d => d.IdEjercicio)
                    .HasConstraintName("FK_TerminoLectivo_RefEjercicio");

                entity.HasOne(d => d.IdGrupoNivelNavigation)
                    .WithMany(p => p.TerminoLectivos)
                    .HasForeignKey(d => d.IdGrupoNivel)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TerminoLectivo_RefGrupoNivel");

                entity.HasOne(d => d.IdTipoPeriodoEscolarNavigation)
                    .WithMany(p => p.TerminoLectivos)
                    .HasForeignKey(d => d.IdTipoPeriodoEscolar)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TerminoLectivo_RefTipoPeriodoEscolar");
            });

            modelBuilder.Entity<TerminoLectivoRegistro>(entity =>
            {
                entity.HasKey(e => e.IdTerminoLectivoRegistro);

                entity.ToTable("TerminoLectivoRegistro");

                entity.Property(e => e.IdTerminoLectivoRegistro).HasColumnName("idTerminoLectivoRegistro");

                entity.Property(e => e.Entidad)
                    .HasMaxLength(32)
                    .HasColumnName("entidad");

                entity.Property(e => e.EstaActivo)
                    .IsRequired()
                    .HasColumnName("estaActivo")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.FechaInicioActual)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaInicioActual");

                entity.Property(e => e.FechaInicioNueva)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaInicioNueva");

                entity.Property(e => e.IdEntidad).HasColumnName("idEntidad");

                entity.Property(e => e.IdTerminoLectivo).HasColumnName("idTerminoLectivo");

                entity.Property(e => e.IdTerminoLectivoActualizacion).HasColumnName("idTerminoLectivoActualizacion");

                entity.Property(e => e.Mensaje)
                    .HasMaxLength(128)
                    .HasColumnName("mensaje");

                entity.Property(e => e.Procesado).HasColumnName("procesado");

                entity.HasOne(d => d.IdTerminoLectivoNavigation)
                    .WithMany(p => p.TerminoLectivoRegistros)
                    .HasForeignKey(d => d.IdTerminoLectivo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TerminoLectivoRegistro_TerminoLectivo");
            });

            modelBuilder.Entity<UdeOxEjerView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("UdeOxEjerView");

                entity.Property(e => e.CodUdeO)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("codUdeO")
                    .IsFixedLength();

                entity.Property(e => e.EjercicioDesc)
                    .HasMaxLength(4)
                    .HasColumnName("ejercicioDesc");

                entity.Property(e => e.EstaActivo).HasColumnName("estaActivo");

                entity.Property(e => e.IdEjercicio).HasColumnName("idEjercicio");

                entity.Property(e => e.IdUdeO).HasColumnName("idUdeO");

                entity.Property(e => e.IdUdeOxEjer).HasColumnName("idUdeOxEjer");

                entity.Property(e => e.UdeoDesc)
                    .HasMaxLength(100)
                    .HasColumnName("udeoDesc");
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.IdUsuario);

                entity.ToTable("Usuario");

                entity.Property(e => e.IdUsuario).HasColumnName("idUsuario");

                entity.Property(e => e.EstaActivo)
                    .IsRequired()
                    .HasColumnName("estaActivo")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.FechaAlta)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaAlta");

                entity.Property(e => e.FechaEliminacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaEliminacion");

                entity.Property(e => e.IdPersona).HasColumnName("idPersona");

                entity.Property(e => e.UserId).HasColumnName("userId");

                entity.Property(e => e.Usuario1)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("usuario");

                entity.HasOne(d => d.IdPersonaNavigation)
                    .WithMany(p => p.Usuarios)
                    .HasForeignKey(d => d.IdPersona)
                    .HasConstraintName("FK_Usuario_Persona");
            });

            modelBuilder.Entity<UsuarioOrganizacion>(entity =>
            {
                entity.HasKey(e => e.IdUsuarioOrganizacion)
                    .HasName("PK_UsuarioDependencia");

                entity.ToTable("UsuarioOrganizacion");

                entity.Property(e => e.IdUsuarioOrganizacion)
                    .HasColumnName("idUsuarioOrganizacion")
                    .HasComment("Clave primaria, autoincrementable. Identificador de la relacion entre Usuario y Dependencia.");

                entity.Property(e => e.EstaActivo)
                    .IsRequired()
                    .HasColumnName("estaActivo")
                    .HasDefaultValueSql("((1))")
                    .HasComment("Campo para eliminación lógica. Valor 0 = Falso, Valor 1 = Verdadero.");

                entity.Property(e => e.FechaAlta)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaAlta")
                    .HasComment("Fecha de alta.");

                entity.Property(e => e.FechaEliminacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaEliminacion")
                    .HasComment("Fecha de baja, modifica el estado del campo estaActivo.");

                entity.Property(e => e.IdHistoriaOrg).HasColumnName("idHistoriaOrg");

                entity.Property(e => e.IdOrganizacion)
                    .HasColumnName("idOrganizacion")
                    .HasComment("Clave foranea. Identificador de dependencia.  Ejemplo: mesa de entrada, despacho.");

                entity.Property(e => e.IdUsuario)
                    .HasColumnName("idUsuario")
                    .HasComment("Clave foranea. Identificador de usuario. Ejemplo: ptorres, hdiaz.");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.UsuarioOrganizacions)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UsuarioOrganizacion_Usuario");

                entity.HasOne(d => d.Id)
                    .WithMany(p => p.UsuarioOrganizacions)
                    .HasForeignKey(d => new { d.IdOrganizacion, d.IdHistoriaOrg })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UsuarioOrganizacion_Organizacion");
            });

            modelBuilder.Entity<UsuarioOrganizacionPermiso>(entity =>
            {
                entity.HasKey(e => e.IdUsuarioOrganizacionPermiso)
                    .HasName("PK_UsuarioDependenciaPermiso");

                entity.ToTable("UsuarioOrganizacionPermiso");

                entity.Property(e => e.IdUsuarioOrganizacionPermiso)
                    .HasColumnName("idUsuarioOrganizacionPermiso")
                    .HasComment("Clave primaria, autoincrementable. Identificador de la relacion entre UsuarioDependencia y RefPermiso.");

                entity.Property(e => e.EstaActivo)
                    .IsRequired()
                    .HasColumnName("estaActivo")
                    .HasDefaultValueSql("((1))")
                    .HasComment("Campo para eliminación lógica. Valor 0 = Falso, Valor 1 = Verdadero.");

                entity.Property(e => e.FechaAlta)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaAlta")
                    .HasComment("Fecha de alta.");

                entity.Property(e => e.FechaEliminacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaEliminacion")
                    .HasComment("Fecha de baja, modifica el estado del campo estaActivo.");

                entity.Property(e => e.IdPermiso)
                    .HasColumnName("idPermiso")
                    .HasComment("Clave foranea. Identificador de permiso.  Ejemplo: crear expediente, enviar expediente.");

                entity.Property(e => e.IdPermisoRel).HasColumnName("idPermisoRel");

                entity.Property(e => e.IdRol).HasColumnName("idRol");

                entity.Property(e => e.IdUsuarioOrganizacion)
                    .HasColumnName("idUsuarioOrganizacion")
                    .HasComment("Clave foranea. Identificador de un usuario en una dependencia.");

                entity.HasOne(d => d.IdUsuarioOrganizacionNavigation)
                    .WithMany(p => p.UsuarioOrganizacionPermisos)
                    .HasForeignKey(d => d.IdUsuarioOrganizacion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UsuarioOrganizacionPermiso_UsuarioOrganizacion");

                entity.HasOne(d => d.IdPermisoNavigation)
                    .WithMany(p => p.UsuarioOrganizacionPermisos)
                    .HasForeignKey(d => new { d.IdPermiso, d.IdPermisoRel })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UsuarioOrganizacionPermiso_RefPermiso");
            });

            modelBuilder.Entity<UsuarioOrganizacionRol>(entity =>
            {
                entity.HasKey(e => e.IdUsuarioOrganizacionRol)
                    .HasName("PK_UsuarioRol");

                entity.ToTable("UsuarioOrganizacionRol");

                entity.Property(e => e.IdUsuarioOrganizacionRol)
                    .HasColumnName("idUsuarioOrganizacionRol")
                    .HasComment("Clave primaria, autoincrementable. Identificador de la relacion entre UsuarioDependencia y RefRol.");

                entity.Property(e => e.EstaActivo)
                    .IsRequired()
                    .HasColumnName("estaActivo")
                    .HasDefaultValueSql("((1))")
                    .HasComment("Campo para eliminación lógica. Valor 0 = Falso, Valor 1 = Verdadero.");

                entity.Property(e => e.FechaAlta)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaAlta")
                    .HasComment("Fecha de alta.");

                entity.Property(e => e.FechaEliminacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaEliminacion")
                    .HasComment("Fecha de baja, modifica el estado del campo estaActivo.");

                entity.Property(e => e.IdRol)
                    .HasColumnName("idRol")
                    .HasComment("Clave foranea. Identificador de rol.  Ejemplo: administrador.");

                entity.Property(e => e.IdUsuarioOrganizacion)
                    .HasColumnName("idUsuarioOrganizacion")
                    .HasComment("Clave foranea. Identificador de un usuario en una dependencia.");

                entity.HasOne(d => d.IdRolNavigation)
                    .WithMany(p => p.UsuarioOrganizacionRols)
                    .HasForeignKey(d => d.IdRol)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UsuarioOrganizacionRol_RefRol");

                entity.HasOne(d => d.IdUsuarioOrganizacionNavigation)
                    .WithMany(p => p.UsuarioOrganizacionRols)
                    .HasForeignKey(d => d.IdUsuarioOrganizacion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UsuarioOrganizacionRol_UsuarioOrganizacion");
            });

            modelBuilder.Entity<UsuarioOrganizacionView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("UsuarioOrganizacionView");

                entity.Property(e => e.EstaActivo).HasColumnName("estaActivo");

                entity.Property(e => e.FechaAlta)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaAlta");

                entity.Property(e => e.FechaEliminacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaEliminacion");

                entity.Property(e => e.IdHistoriaOrg).HasColumnName("idHistoriaOrg");

                entity.Property(e => e.IdOrganizacion).HasColumnName("idOrganizacion");

                entity.Property(e => e.IdUsuario).HasColumnName("idUsuario");

                entity.Property(e => e.IdUsuarioOrganizacion).HasColumnName("idUsuarioOrganizacion");

                entity.Property(e => e.Usuario)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("usuario");
            });

            modelBuilder.Entity<VwCircuitoSolicitudLegajo>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VwCircuitoSolicitudLegajo");

                entity.Property(e => e.CircuitoEtapaLegajoDesc)
                    .HasMaxLength(100)
                    .HasColumnName("circuitoEtapaLegajoDesc");

                entity.Property(e => e.CircuitoSolicitudLegajoDesc)
                    .HasMaxLength(100)
                    .HasColumnName("circuitoSolicitudLegajoDesc");

                entity.Property(e => e.EstadoSolicitudDesc)
                    .HasMaxLength(25)
                    .HasColumnName("estadoSolicitudDesc");

                entity.Property(e => e.IdCircuitoEtapaLegajo).HasColumnName("idCircuitoEtapaLegajo");

                entity.Property(e => e.IdEstadoSolicitudLegajo).HasColumnName("idEstadoSolicitudLegajo");

                entity.Property(e => e.IdSolicitudEstadoLegajo).HasColumnName("idSolicitudEstadoLegajo");

                entity.Property(e => e.IdSolicitudLegajo).HasColumnName("idSolicitudLegajo");
            });

            modelBuilder.Entity<VwCircuitoSolictudPlaza>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VwCircuitoSolictudPlaza");

                entity.Property(e => e.FechaEstado)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaEstado");

                entity.Property(e => e.IdCircuitoSol).HasColumnName("idCircuitoSol");

                entity.Property(e => e.IdEstadoSol).HasColumnName("idEstadoSol");

                entity.Property(e => e.IdEstadoSolicitud).HasColumnName("idEstadoSolicitud");

                entity.Property(e => e.IdSolicitudPlaza).HasColumnName("idSolicitudPlaza");

                entity.Property(e => e.Observacion)
                    .HasMaxLength(250)
                    .HasColumnName("observacion")
                    .IsFixedLength();
            });

            modelBuilder.Entity<_23MigracionSolicitudestado>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("23 - MIGRACION - SOLICITUDESTADOS");

                entity.Property(e => e.FechaEstado)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaEstado");

                entity.Property(e => e.IdCircuitoSol).HasColumnName("idCircuitoSol");

                entity.Property(e => e.IdEstadoSolicitud).HasColumnName("idEstadoSolicitud");

                entity.Property(e => e.IdSolicitudPlaza)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("idSolicitudPlaza");

                entity.Property(e => e.Observacion)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("observacion");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
