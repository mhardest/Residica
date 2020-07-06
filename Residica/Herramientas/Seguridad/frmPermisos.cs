using Servicios.Bitacora.BLL;
using Servicios.Seguridad;
using Servicios.Seguridad.BLL;
using Servicios.Seguridad.Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Residica.Herramientas.Seguridad
{  
    public partial class frmPermisos : Form
    {
        private int IdUsuario;

        public int IdUsuarioValue
        {
            get { return IdUsuario; }
            set { IdUsuario = value; }
        }

        public frmPermisos()
        {
            InitializeComponent();
            cbPermisosUsuario.Enabled = false;
            tbSector.Enabled = false;
        }

        private void listFamiliaContiene_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.btnFamiliaAgregar.Enabled = false;
            this.btnFamiliaRemover.Enabled = true;
        }

        private void listFamiliaNoContiene_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.btnFamiliaAgregar.Enabled = true;
            this.btnFamiliaRemover.Enabled = false;
        }

        private void listPatenteContiene_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.btnPatenteAgregar.Enabled = false;
            this.btnPatenteRemover.Enabled = true;
        }

        private void listPatenteNoContiene_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.btnPatenteAgregar.Enabled = true;
            this.btnPatenteRemover.Enabled = false;
        }

        private void btnPermisosAsignarUsuario_Click(object sender, EventArgs e)
        {
            frmAsignarUsuario frmAsignarUsuario = new frmAsignarUsuario();
            frmAsignarUsuario.FormClosed += new FormClosedEventHandler(frmAsignarUsuario_FormClosed);
            frmAsignarUsuario.ShowDialog();
        }

        void frmAsignarUsuario_FormClosed(object sender, EventArgs e)
        {
            frmAsignarUsuario frm = sender as frmAsignarUsuario;
            IdUsuario = frm.IdUsuarioValue;

            if (IdUsuario != 0)
            {
                Usuario usuario = UsuarioBLL.GetAdapted(IdUsuario);

                DataTable dt = new DataTable();
                dt.Columns.Add("IdUsuario", typeof(int));
                dt.Columns.Add("Nombre");

                cbPermisosUsuario.DisplayMember = "Nombre";
                cbPermisosUsuario.ValueMember = "IdUsuario";

                DataRow dr = dt.NewRow();
                dr["IdUsuario"] = usuario.IdUsuario;
                dr["Nombre"] = usuario.NombreCompleto;
                dt.Rows.InsertAt(dr, 0);

                cbPermisosUsuario.DataSource = dt;
                cbPermisosUsuario.SelectedIndex = 0;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            try
            {

                this.pnlFamilia.Enabled = false;
                Usuario usuarioSelect = UsuarioBLL.GetAdapted(Convert.ToInt32(this.cbPermisosUsuario.SelectedValue));

                //Familias
                DataTable dtFamiliaContiene = (DataTable)this.listFamiliaContiene.DataSource;

                List<Permiso> NuevosPermisos = new List<Permiso>();

                foreach (DataRow drfnp in dtFamiliaContiene.Rows)
                {
                    Familia familia = new Familia();
                    familia.IdFamiliaElement = drfnp[0].ToString();
                    familia.Nombre = drfnp[1].ToString();
                    NuevosPermisos.Add(familia);
                }

                //Patentes
                //Si No Tiene Patente
                if ((this.listPatenteContiene.SelectedValue == null))
                {
                    usuarioSelect.Permisos = NuevosPermisos;
                    UsuarioBLL.ActualizarPermisos(usuarioSelect);
                }
                else
                {
                    //Si tiene Patente
                    DataTable dtPoseePAT = (DataTable)this.listPatenteContiene.DataSource;

                    foreach (DataRow drfnpPAT in dtPoseePAT.Rows)
                    {
                        Patente Patente = new Patente();
                        Patente.IdFamiliaElement = drfnpPAT[0].ToString();
                        Patente.Nombre = drfnpPAT[1].ToString();
                        NuevosPermisos.Add(Patente);
                    }
                    usuarioSelect.Permisos = NuevosPermisos;
                    UsuarioBLL.ActualizarPermisos(usuarioSelect);
                }

                //comentado
                BitacoraBLL.GetInstance().RegistrarEnBitacora("Se realizaron cambios de Permiso de Usuario", User._userSession.NombreUsuario, string.Empty, TraceEventType.Information);
                MessageBox.Show("Cambios realizados exitosamente", "Residica", MessageBoxButtons.OKCancel, MessageBoxIcon.None);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Residica", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == MessageBox.Show("Está seguro que desea salir?", "Residica", MessageBoxButtons.OKCancel, MessageBoxIcon.Question))
            {
                this.Close();
            }
        }

        private void btnFamiliaAgregar_Click(object sender, EventArgs e)
        {

            if ((this.listFamiliaNoContiene.SelectedValue != null))
            {
                this.btnGuardar.Enabled = true;
                DataTable dtFamiliaNoContiene = (DataTable)this.listFamiliaNoContiene.DataSource;
                DataTable dtFamiliaContiene = (DataTable)this.listFamiliaContiene.DataSource;
                List<Familia> ListaFamiliaNoPosee = new List<Familia>();

                foreach (DataRow drfp in dtFamiliaNoContiene.Rows)
                {
                    if ((this.listFamiliaNoContiene.SelectedValue == drfp[0]))
                    {
                        DataRow drPosee = dtFamiliaContiene.NewRow();
                        drPosee[0] = drfp[0];
                        drPosee[1] = drfp[1];
                        dtFamiliaContiene.Rows.Add(drPosee);
                    }
                    else
                    {
                        Familia flia = new Familia();
                        flia.IdFamiliaElement = drfp[0].ToString();
                        flia.Nombre = drfp[1].ToString();
                        ListaFamiliaNoPosee.Add(flia);
                    }
                }

                DataTable nwdtNoPosee = new DataTable();
                nwdtNoPosee.Columns.Add("Id");
                nwdtNoPosee.Columns.Add("Nombre");

                foreach (Familia idi in ListaFamiliaNoPosee)
                {
                    DataRow drNoPosee = nwdtNoPosee.NewRow();
                    drNoPosee[0] = idi.IdFamiliaElement;
                    drNoPosee[1] = idi.Nombre;
                    nwdtNoPosee.Rows.Add(drNoPosee);
                }

                this.listFamiliaNoContiene.DataSource = nwdtNoPosee;
                this.listFamiliaNoContiene.ValueMember = "Id";
                this.listFamiliaNoContiene.DisplayMember = "Nombre";
            }
        }

        private void btnFamiliaRemover_Click(object sender, EventArgs e)
        {

            if ((this.listFamiliaContiene.SelectedValue != null))
            {
                this.btnGuardar.Enabled = true;
                DataTable dtPosee = (DataTable)this.listFamiliaContiene.DataSource;
                DataTable dtNoPosee = (DataTable)this.listFamiliaNoContiene.DataSource;
                List<Familia> ListaFamiliaPosee = new List<Familia>();

                foreach (DataRow drfnp in dtPosee.Rows)
                {
                    if ((this.listFamiliaContiene.SelectedValue == drfnp[0]))
                    {
                        DataRow drNoPosee = dtNoPosee.NewRow();
                        drNoPosee[0] = drfnp[0];
                        drNoPosee[1] = drfnp[1];
                        dtNoPosee.Rows.Add(drNoPosee);
                    }
                    else
                    {
                        Familia flia = new Familia();
                        flia.IdFamiliaElement = drfnp[0].ToString();
                        flia.Nombre = drfnp[1].ToString();
                        ListaFamiliaPosee.Add(flia);
                    }
                }

                DataTable nwdtPosee = new DataTable();
                nwdtPosee.Columns.Add("Id");
                nwdtPosee.Columns.Add("Nombre");
                foreach (Familia idi in ListaFamiliaPosee)
                {
                    DataRow drPosee = nwdtPosee.NewRow();
                    drPosee[0] = idi.IdFamiliaElement;
                    drPosee[1] = idi.Nombre;
                    nwdtPosee.Rows.Add(drPosee);
                }
                this.listFamiliaContiene.DataSource = nwdtPosee;
                this.listFamiliaContiene.ValueMember = "Id";
                this.listFamiliaContiene.DisplayMember = "Nombre";
            }

        }

        private void btnPatenteRemover_Click(object sender, EventArgs e)
        {
            //Me.LstPoseePAT.Items.Add(LstNoPoseePAT.SelectedItem)
            {
                if ((this.listPatenteContiene.SelectedValue != null))
                {
                    this.btnGuardar.Enabled = true;

                    DataTable dtposeePAT = (DataTable)this.listPatenteContiene.DataSource;
                    //Dim dtNoposeePAT As DataTable = Me.LstNoPoseePAT.DataSource
                    List<Patente> listaPatentesPosee = new List<Patente>();


                    foreach (DataRow drpat in dtposeePAT.Rows)
                    {
                        if ((this.listPatenteContiene.SelectedValue == drpat[0]))
                        {
                            //seleccionado no lo cargo al listado disponible
                            //'Dim drNoposePat As DataRow = dtNoposeePAT.NewRow
                            //'drNoposePat(0) = drpat(0)
                            //'drNoposePat(1) = drpat(1)
                            //'dtNoposeePAT.Rows.Add(drNoposePat)
                        }
                        else
                        {
                            //no seleccionado
                            Patente pat = new Patente();
                            pat.IdFamiliaElement = drpat[0].ToString();
                            pat.Nombre = drpat[1].ToString();
                            listaPatentesPosee.Add(pat);
                        }
                    }

                    //refresco el posee con la lista de patentes que no posee
                    DataTable nwdtPoseePAT = new DataTable();
                    nwdtPoseePAT.Columns.Add("Id");
                    nwdtPoseePAT.Columns.Add("Nombre");
                    foreach (Patente idi in listaPatentesPosee)
                    {
                        DataRow drPoseePAT = nwdtPoseePAT.NewRow();
                        drPoseePAT[0] = idi.IdFamiliaElement;
                        drPoseePAT[1] = idi.Nombre;
                        nwdtPoseePAT.Rows.Add(drPoseePAT);
                    }
                    this.listPatenteContiene.DataSource = nwdtPoseePAT;
                    this.listPatenteContiene.ValueMember = "Id";
                    this.listPatenteContiene.DisplayMember = "Nombre";
                }
            }
        }

        private void btnPatenteAgregar_Click(object sender, EventArgs e)
        {
            //Listbox sin DataSource es asi... con DS
            //Me.LstPoseePAT.Items.Add(listPatenteNoContiene.SelectedItem)
            {
                if ((this.listPatenteNoContiene.SelectedValue != null))
                {
                    this.btnGuardar.Enabled = true;

                    DataTable dtNoposeePAT = (DataTable)this.listPatenteNoContiene.DataSource;
                    DataTable dtposeePAT = (DataTable)this.listPatenteContiene.DataSource;
                    List<Patente> listaPatentesNoPosee = new List<Patente>();

                    foreach (DataRow drpat in dtNoposeePAT.Rows)
                    {
                        if ((this.listPatenteNoContiene.SelectedValue == drpat[0]))
                        {
                            DataRow drposePat = dtposeePAT.NewRow();
                            drposePat[0] = drpat[0];
                            drposePat[1] = drpat[1];
                            dtposeePAT.Rows.Add(drposePat);
                        }

                        Patente pat = new Patente();
                        pat.IdFamiliaElement = drpat[0].ToString();
                        pat.Nombre = drpat[1].ToString();
                        listaPatentesNoPosee.Add(pat);
                    }
                    //refresco el no pose con la lista de patentes que no posee
                    DataTable nwdtNoPoseePAT = new DataTable();
                    nwdtNoPoseePAT.Columns.Add("Id");
                    nwdtNoPoseePAT.Columns.Add("Nombre");

                    foreach (Patente idi in listaPatentesNoPosee)
                    {
                        DataRow drNoPoseePAT = nwdtNoPoseePAT.NewRow();
                        drNoPoseePAT[0] = idi.IdFamiliaElement;
                        drNoPoseePAT[1] = idi.Nombre;
                        nwdtNoPoseePAT.Rows.Add(drNoPoseePAT);
                    }
                    this.listPatenteNoContiene.DataSource = nwdtNoPoseePAT;
                    this.listPatenteNoContiene.ValueMember = "Id";
                    this.listPatenteNoContiene.DisplayMember = "Nombre";

                }
            }
        }

        private void btnPermisoBuscar_Click(object sender, EventArgs e)
        {

            try
            {


                if (Convert.ToInt32(cbPermisosUsuario.SelectedValue) != 0)
                {
                    DataTable dtPosee = new DataTable();
                    dtPosee.Columns.Add("Id");
                    dtPosee.Columns.Add("Nombre");
                    Usuario usuarioSelect = UsuarioBLL.GetAdapted(Convert.ToInt32(this.cbPermisosUsuario.SelectedValue));

                    //If (usuarioSelect.Nombre <> Me.User.Nombre) Then
                    //    usuarioSelect.GestionarPermisos()
                    //End If

                    foreach (Permiso idi in usuarioSelect.FamiliasFinales)
                    {
                        DataRow drPosee = dtPosee.NewRow();
                        drPosee[0] = idi.IdFamiliaElement;
                        drPosee[1] = idi.Nombre;
                        dtPosee.Rows.Add(drPosee);

                    }

                    this.listFamiliaContiene.DataSource = dtPosee;
                    this.listFamiliaContiene.ValueMember = "Id";
                    this.listFamiliaContiene.DisplayMember = "Nombre";

                    DataTable dtNoPosee = new DataTable();
                    dtNoPosee.Columns.Add("Id");
                    dtNoPosee.Columns.Add("Nombre");

                    List<Familia> auxNoPosee = FamiliaBLL.GetAllAdapted(); // fijarse bien

                    List<Familia> auxNP = new List<Familia>();
                    foreach (Familia anp in auxNoPosee)
                    {
                        bool existeFamilia = false;
                        foreach (Permiso anf in usuarioSelect.FamiliasFinales)
                        {
                            if ((anp.Nombre == anf.Nombre))
                            {
                                existeFamilia = true;
                            }
                        }
                        if (!(existeFamilia))
                        {
                            auxNP.Add(anp);
                        }
                    }
                    auxNoPosee = auxNP;

                    foreach (Familia idi in auxNoPosee)
                    {
                        DataRow drPosee = dtNoPosee.NewRow();
                        drPosee[0] = idi.IdFamiliaElement;
                        drPosee[1] = idi.Nombre;
                        dtNoPosee.Rows.Add(drPosee);
                    }

                    this.listFamiliaNoContiene.DataSource = dtNoPosee;
                    this.listFamiliaNoContiene.ValueMember = "Id";
                    this.listFamiliaNoContiene.DisplayMember = "Nombre";
                    this.pnlFamilia.Enabled = true;






                    //Patentes a cargar --> posee PAT

                    DataTable dtPoseePAT = new DataTable();
                    dtPoseePAT.Columns.Add("Id");
                    dtPoseePAT.Columns.Add("Nombre");

                    DataRow drPoseePAT = dtPoseePAT.NewRow();
                    this.listPatenteContiene.DataSource = dtPoseePAT;
                    this.listPatenteContiene.ValueMember = "Id";
                    this.listPatenteContiene.DisplayMember = "Nombre";

                    //Solo para cargar listbox de patentes que Posee actual 

                    DataTable dtPoseePATAct = new DataTable();
                    dtPoseePATAct.Columns.Add("Id");
                    dtPoseePATAct.Columns.Add("Nombre");

                    foreach (Permiso idi in usuarioSelect.PatentesFinales)
                    {
                        DataRow drTienePAT = dtPoseePATAct.NewRow();
                        drTienePAT[0] = idi.IdFamiliaElement;
                        drTienePAT[1] = idi.Nombre;
                        dtPoseePATAct.Rows.Add(drTienePAT);
                    }

                    this.listPatenteContieneACT.DataSource = dtPoseePATAct;
                    this.listPatenteContieneACT.ValueMember = "Id";
                    this.listPatenteContieneACT.DisplayMember = "Nombre";

                    //Patentes que NO Posee y estan Disponibles(Todas las patentes)

                    DataTable dtNoPoseePAT = new DataTable();
                    dtNoPoseePAT.Columns.Add("Id");
                    dtNoPoseePAT.Columns.Add("Nombre");
                    List<Patente> auxNoPoseePAT = PatenteBLL.GetAllAdapted();  // fijarse bien


                    List<Patente> auxNPPAT = new List<Patente>();
                    foreach (Patente anpPAT in auxNoPoseePAT)
                    {
                        bool existeFamilia = false;
                        foreach (Familia anfPAT in usuarioSelect.FamiliasFinales)
                        {
                            if ((anpPAT.Nombre == anfPAT.Nombre))
                            {
                                existeFamilia = true;
                            }
                        }
                        if (!(existeFamilia))
                        {
                            auxNPPAT.Add(anpPAT);
                        }
                    }

                    auxNoPoseePAT = auxNPPAT;

                    foreach (Patente idi in auxNoPoseePAT)
                    {
                        DataRow drNOPoseePAT = dtNoPoseePAT.NewRow();
                        drNOPoseePAT[0] = idi.IdFamiliaElement;
                        drNOPoseePAT[1] = idi.Nombre;
                        dtNoPoseePAT.Rows.Add(drNOPoseePAT);
                    }
                    this.listPatenteNoContiene.DataSource = dtNoPoseePAT;
                    this.listPatenteNoContiene.ValueMember = "Id";
                    this.listPatenteNoContiene.DisplayMember = "Nombre";

                    //cargar el puesto que ocupa
                    this.tbSector.Text = usuarioSelect.Sector.Descripcion;
                }
                else
                {
                    MessageBox.Show("Seleccione un usuario.", "Residica", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                    //MessageBox.Show(MsgSeleccioneUsuario, MsgInforme);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Residica", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
