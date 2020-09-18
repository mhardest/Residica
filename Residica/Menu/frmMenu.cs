using Residica.Herramientas.Backup;
using Residica.Herramientas.Log;
using Residica.Herramientas.Seguridad;
using Residica.Residentes;
using Residica.Auditoria;
using Residica.Habitaciones;
using Servicios.Facade.Extensions;
using Servicios.Multioma.BLL;
using Servicios.Multioma.Domain;
using Servicios.Seguridad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Residica
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            int idioma = User._userSession.IdIdioma;
            IdiomaDM idiomaDM= new IdiomaDM();
            idiomaDM = IdiomaBLL.GetAdapted(idioma);
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(idiomaDM.Descripcion);
            traductor();
        }

        private void inglesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-US");
            traductor();
        }

        private void españolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("es-AR");
            traductor();
        }

        private void traductor()
        {
            this.residenteToolStripMenuItem.Text = "Residente".Translate();
            this.altaToolStripMenuItem.Text = "Nuevo Residente".Translate();
            this.verResidentesToolStripMenuItem.Text = "Gestión Residentes".Translate();
            this.verHabitacionesDispobilesToolStripMenuItem.Text = "Ver Habitaciones Disponibles".Translate();
            this.auditoriaToolStripMenuItem.Text = "Auditoría".Translate();
            this.psicologicaToolStripMenuItem.Text = "Psicológica".Translate();
            this.porAuditarToolStripMenuItem.Text = "Ver Por Auditar".Translate();
            this.verAuditadosToolStripMenuItem.Text = "Ver Auditados".Translate();
            this.traumatológicaToolStripMenuItem.Text = "Traumatológica".Translate();
            this.verPorAuditarToolStripMenuItem.Text = "Ver Por Auditar".Translate();
            this.verAuditadosToolStripMenuItem1.Text = "Ver Auditados".Translate();
            this.medicaToolStripMenuItem.Text = "Medica".Translate();
            this.verPorAuditarToolStripMenuItem1.Text = "Ver Por Auditar".Translate();
            this.verAuditadosToolStripMenuItem2.Text = "Ver Auditados".Translate();
            this.generalToolStripMenuItem.Text = "General".Translate();
            this.verPorAuditarToolStripMenuItem2.Text = "Ver Por Auditar".Translate();
            this.verAuditadosToolStripMenuItem3.Text = "Ver Auditados".Translate();
            this.verAceptadosToolStripMenuItem.Text = "Ver Aceptados".Translate();
            this.verRechazadosToolStripMenuItem.Text = "Ver Rechazados".Translate();
            this.turnoToolStripMenuItem.Text = "Turno".Translate();
            this.gestiónEquiposToolStripMenuItem.Text = "Gestión Equipos".Translate();
            this.reservarToolStripMenuItem.Text = "Reservar".Translate();
            this.anularReservaToolStripMenuItem.Text = "Anular Reserva".Translate();
            this.verDisponiblesToolStripMenuItem.Text = "Ver Disponibles".Translate();
            this.verEquiposReservadasToolStripMenuItem.Text = "Ver Reservas".Translate();
            this.gestiónSalasToolStripMenuItem.Text = "Gestión Salas".Translate();
            this.reservarToolStripMenuItem1.Text = "Reservar".Translate();
            this.anularReservaToolStripMenuItem1.Text = "Anular Reserva".Translate();
            this.verSalasDisponiblesToolStripMenuItem.Text = "Ver Disponibles".Translate();
            this.verSalasReservadasToolStripMenuItem.Text = "Ver Reservas".Translate();
            this.gestiónTrasladosToolStripMenuItem.Text = "Gestión Traslados".Translate();
            this.reservarToolStripMenuItem2.Text = "Reservar".Translate();
            this.anularReservaToolStripMenuItem2.Text = "Anular Reserva".Translate();
            this.verDisponiblesToolStripMenuItem1.Text = "Ver Reservas".Translate();
            this.medicamentoToolStripMenuItem.Text = "Medicamento".Translate();
            this.pedidosToolStripMenuItem.Text = "Pedidos".Translate();
            this.nuevoPedidoToolStripMenuItem.Text = "Nuevo".Translate();
            this.anularPedidoToolStripMenuItem.Text = "Anular".Translate();
            this.verPedidosToolStripMenuItem.Text = "Ver".Translate();
            this.presupuestosToolStripMenuItem.Text = "Presupuestos".Translate();
            this.nuevoPresupuestoToolStripMenuItem.Text = "Nuevo".Translate();
            this.anularPresupuestoToolStripMenuItem.Text = "Anular".Translate();
            this.verPresupuestosToolStripMenuItem.Text = "Ver".Translate();
            this.ordenDeComprasToolStripMenuItem.Text = "Orden de Compras".Translate();
            this.nuevaOrdenDeCompraToolStripMenuItem.Text = "Nueva".Translate();
            this.verOrdenDeComprasToolStripMenuItem.Text = "Ver".Translate();
            this.controlTomaToolStripMenuItem.Text = "Control Toma".Translate();
            this.seguimientoTomaToolStripMenuItem.Text = "Seguimiento Toma".Translate();
            this.facturaciónToolStripMenuItem.Text = "Facturación".Translate();
            this.periodosDeFacturaciónToolStripMenuItem.Text = "Periodos de Facturación".Translate();
            this.configuraciónToolStripMenuItem.Text = "Configuración".Translate();
            this.salasToolStripMenuItem.Text = "Salas".Translate();
            this.equipoToolStripMenuItem.Text = "Equipos".Translate();
            this.habitacionesToolStripMenuItem.Text = "Habitaciones".Translate();
            this.proveedoresToolStripMenuItem.Text = "Proveedores".Translate();
            this.medicosToolStripMenuItem.Text = "Medicos".Translate();
            this.agenteDeCuentaToolStripMenuItem.Text = "Agente de Cuenta".Translate();
            this.planToolStripMenuItem.Text = "Planes".Translate();
            this.idiomaToolStripMenuItem.Text = "Idioma".Translate();
            this.españolToolStripMenuItem.Text = "Español".Translate();
            this.inglesToolStripMenuItem.Text = "Ingles".Translate();
            this.salidToolStripMenuItem.Text = "Salir".Translate();
        }

        private void salidToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsuario frmUsuario = new frmUsuario();
            frmUsuario.ShowDialog();
        }

        private void hacerCopiaDeSeguridadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBackup frmBackup = new frmBackup();
            frmBackup.ShowDialog();
        }

        private void cambiarContraseñaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCambioContrasenia frmCambioContrasenia = new frmCambioContrasenia();
            frmCambioContrasenia.ShowDialog();
        }

        private void permisosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPermisos frmPermisos = new frmPermisos();
            frmPermisos.ShowDialog();
        }

        private void desbloquearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDesbloqueoCuenta frmDesbloqueoCuenta = new frmDesbloqueoCuenta();
            frmDesbloqueoCuenta.ShowDialog();
        }

        private void bitacoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLog frmlog = new frmLog();
            frmlog.ShowDialog();
        }

        private void altaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNuevoResidente frmNuevoResidente = new frmNuevoResidente();
            frmNuevoResidente.ShowDialog();
        }

        private void verResidentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGestionResidente frmGestionResidente = new frmGestionResidente();
            frmGestionResidente.ShowDialog();
        }

        private void verListaDeEsperaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVerResidenteListaEspera frmVerResidenteListaEspera = new frmVerResidenteListaEspera();
            frmVerResidenteListaEspera.ShowDialog();
        }

        private void porAuditarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVerResidentesSinAuditoriaPsico frmVerResidentesSinAuditoriaPsico = new frmVerResidentesSinAuditoriaPsico();
            frmVerResidentesSinAuditoriaPsico.ShowDialog();
        }

        private void verAuditadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            frmVerResidentesAuditoriaPsico frmVerResidentesAuditoriaPsico = new frmVerResidentesAuditoriaPsico();
            frmVerResidentesAuditoriaPsico.ShowDialog();
            
        }


        private void verHabitacionesDispobilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHabitacionesDisponibles frmHabitacionesDisponibles = new frmHabitacionesDisponibles();
            frmHabitacionesDisponibles.ShowDialog();
        }

        private void verPorAuditarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVerResidentesSinAuditoriaTrau frmVerResidentesSinAuditoriaTrau = new frmVerResidentesSinAuditoriaTrau();
            frmVerResidentesSinAuditoriaTrau.ShowDialog();
        }

        private void verAuditadosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmVerResidentesAuditoriaTrau frmVerResidentesAuditoriaTrau = new frmVerResidentesAuditoriaTrau();
            frmVerResidentesAuditoriaTrau.ShowDialog();
        }

        private void verPorAuditarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmVerResidentesSinAuditoriaMedica frmVerResidentesSinAuditoriaMedica = new frmVerResidentesSinAuditoriaMedica();
            frmVerResidentesSinAuditoriaMedica.ShowDialog();
        }

        private void verAuditadosToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmVerResidentesAuditoriaMedica frmVerResidentesAuditoriaMedica = new frmVerResidentesAuditoriaMedica();
            frmVerResidentesAuditoriaMedica.ShowDialog();
        }

        private void verPorAuditarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmVerResidentesSinAuditoriaGral frmVerResidentesSinAuditoriaGral = new frmVerResidentesSinAuditoriaGral();
            frmVerResidentesSinAuditoriaGral.ShowDialog();
        }

        private void verAuditadosToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            frmVerResidentesAuditoriaGral frmVerResidentesAuditoriaGral = new frmVerResidentesAuditoriaGral();
            frmVerResidentesAuditoriaGral.ShowDialog();
        }
    }
}
