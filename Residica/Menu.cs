﻿using Servicios.Facade.Extensions;
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
            this.bajaToolStripMenuItem.Text = "Modificar Residente".Translate();
            this.anularResidenteToolStripMenuItem.Text = "Anular Residente".Translate();
            this.verResidentesToolStripMenuItem.Text = "Ver Residentes".Translate();
            this.verHabitacionesDispobilesToolStripMenuItem.Text = "Ver Habitaciones Disponibles".Translate();
            this.auditoriaToolStripMenuItem.Text = "Auditoría".Translate();
            this.psicologicaToolStripMenuItem.Text = "Psicológica".Translate();
            this.auditarToolStripMenuItem.Text = "Auditar".Translate();
            this.porAuditarToolStripMenuItem.Text = "Ver Por Auditar".Translate();
            this.verAuditadosToolStripMenuItem.Text = "Ver Auditados".Translate();
            this.traumatológicaToolStripMenuItem.Text = "Traumatológica".Translate();
            this.auditarToolStripMenuItem1.Text = "Auditar".Translate();
            this.verPorAuditarToolStripMenuItem.Text = "Ver Por Auditar".Translate();
            this.verAuditadosToolStripMenuItem1.Text = "Ver Auditados".Translate();
            this.medicaToolStripMenuItem.Text = "Medica".Translate();
            this.auditarToolStripMenuItem2.Text = "Auditar".Translate();
            this.verPorAuditarToolStripMenuItem1.Text = "Ver Por Auditar".Translate();
            this.verAuditadosToolStripMenuItem2.Text = "Ver Auditados".Translate();
            this.generalToolStripMenuItem.Text = "General".Translate();
            this.auditarToolStripMenuItem3.Text = "Auditar".Translate();
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
    }
}