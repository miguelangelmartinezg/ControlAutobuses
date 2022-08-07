using Entities;
using LogicaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class frmAsignarRuta : Form
    {
        string cTabla = "";
        string cConsulta = "";
        string cModo = "Inicio";
        Logica_Negocio oLogicaNegocio = new Logica_Negocio();
        StringBuilder sbQuery = new StringBuilder();
        public frmAsignarRuta()
        {
            InitializeComponent();
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            frmMenu oFrmMenu = new frmMenu();
            oFrmMenu.Show();
            this.Close();
        }

        private void frmAsignarRuta_Load(object sender, EventArgs e)
        {
            LlenarCombo();
            Inicir();
            
        }
        private void LlenarCombo()
        {
            cConsulta = "select IdChofer,CONCAT(Nombre,' ', Apellido) as NombreCompleto from Choferes where lOcupado = 0";
            cboChoferes.DataSource = oLogicaNegocio.DatosGeneralConsulta(cConsulta);
            cboChoferes.DisplayMember = "NombreCompleto";
            cboChoferes.ValueMember = "IdChofer";
            //cboColor.SelectedIndex = 0;

            sbQuery.Clear();
            sbQuery.Append("select Autobuses.IdBus,Autobuses.IdMarca,CONCAT(Marcas.Nombre,'-',Modelos.Nombre,'-',Colores.Nombre,'-',Anos.Nombre,' Placa: ',Autobuses.Placa) as Datos");
            sbQuery.Append(" from Autobuses");
            sbQuery.Append(" inner join Marcas on Marcas.IdMarca = Autobuses.IdMarca");
            sbQuery.Append(" inner join Modelos on Modelos.IdModelo = Autobuses.IdModelo");
            sbQuery.Append(" inner join Colores on Colores.IdColor = Autobuses.IdColor");
            sbQuery.Append(" inner join Anos on Anos.IdAno = Autobuses.IdAno");
            sbQuery.Append(" where Autobuses.lOcupado = 0");

            cboBuses.DataSource = oLogicaNegocio.DatosGeneralConsulta(sbQuery.ToString());
            cboBuses.DisplayMember = "Datos";
            cboBuses.ValueMember = "IdBus";
            ////cboColor.SelectedIndex = 0;

            cConsulta = "Select * from Rutas where lOcupada = 0";
            cboRutas.DataSource = oLogicaNegocio.DatosGeneralConsulta(cConsulta);
            cboRutas.DisplayMember = "Nombre";
            cboRutas.ValueMember = "IdRuta";
        }
        private void Inicir()
        {

            cModo = "Inicio";
            //Botones();
            DesHabilitar();
            Limpiar();
            LlenarGrid(0);



        }
        private void DesHabilitar()
        {
            
            cboBuses.Enabled = false;
            cboChoferes.Enabled = false;
            cboRutas.Enabled = false;

        }

        private void Habilitar()
        {
            cboBuses.Enabled = true;
            cboChoferes.Enabled = true;
            cboRutas.Enabled = true;
        }

        private void Limpiar()
        {
            
            cboBuses.SelectedIndex = -1;
            cboChoferes.SelectedIndex = -1;
            cboRutas.SelectedIndex = -1;
        }
        private void LlenarGrid(int nId)
        {

            try
            {
                Logica_Negocio oLogica = new Logica_Negocio();

                DataTable dtDatos = oLogica.ListarAsignaciones(nId);
                grdDatos.Rows.Clear();
                foreach (DataRow contacto in dtDatos.Rows)
                {

                    grdDatos.Rows.Add(Convert.ToString(contacto["Chofer"]), Convert.ToString(contacto["Bus"]),
                        Convert.ToString(contacto["Ruta"]), Convert.ToInt32(contacto["IdAsignacion"]), Convert.ToInt32(contacto["IdChofer"]),
                        Convert.ToInt32(contacto["IdBus"]),Convert.ToInt32(contacto["IdRuta"]));
                }
            }
            catch (Exception ex)
            {

                string cMensajeError = ex.Message + ", " + ((ex.InnerException != null) ? ex.InnerException.Message.Trim() : "").ToString();
                MessageBox.Show("Error Llenando Grid: " + cMensajeError, "", MessageBoxButtons.OK,
                      MessageBoxIcon.Information);

            }

        }
        private void BuscarAsignacion(int nId)
        {
            try
            {
                LlenarCombo();
                Logica_Negocio oLogica = new Logica_Negocio();
                DataTable dtDatos = oLogica.ListarAsignaciones(nId);
                foreach (DataRow contacto in dtDatos.Rows)
                {
                    txtIdAsignacion.Text = contacto["IdAsignacion"].ToString();
                    string borrar = Convert.ToString(contacto["IdBus"]);
                    cboChoferes.SelectedValue = contacto["IdChofer"].ToString();
                    cboBuses.SelectedValue = Convert.ToString(contacto["IdBus"]);
                    cboRutas.SelectedValue = Convert.ToString(contacto["IdRuta"]);
                    

                }

            }
            catch (Exception ex)
            {

                string cMensajeError = ex.Message + ", " + ((ex.InnerException != null) ? ex.InnerException.Message.Trim() : "").ToString();
                MessageBox.Show("Error Buscando Contacto: " + cMensajeError, "", MessageBoxButtons.OK,
                      MessageBoxIcon.Information);

            }
        }

        private void cmdAsignar_Click(object sender, EventArgs e)
        {
            try
            {

                if (cModo == "Nuevo")
                {

                    Logica_Negocio oLogica = new Logica_Negocio();

                    Asignacion oAsignacion = new Asignacion
                    {
                        IdBus = Convert.ToInt32(cboBuses.SelectedValue),
                        IdChofer = Convert.ToInt32(cboChoferes.SelectedValue),
                        IdRuta = Convert.ToInt32(cboRutas.SelectedValue)
                    };
                    oLogica.Asignar(oAsignacion);

                    MessageBox.Show("Asignación Hecha Correctamente!!!");
                    LlenarGrid(0);
                    Limpiar();
                    Inicir();
                }
                if (cModo == "Actualizar")
                {
                    Logica_Negocio oLogica = new Logica_Negocio();
                    Asignacion oAsignacion = new Asignacion
                    {
                        IdAsignacion = Convert.ToInt32(txtIdAsignacion.Text),
                        IdBus = Convert.ToInt32(cboBuses.SelectedValue),
                        IdChofer = Convert.ToInt32(cboChoferes.SelectedValue),
                        IdRuta = Convert.ToInt32(cboRutas.SelectedValue)
                    };
                    oLogica.DesAsignar(oAsignacion);
                    MessageBox.Show("AutoBus Actualizado Correctamente Correctamente!!!");
                    LlenarGrid(0);
                    Limpiar();
                    Inicir();
                }
            }
            catch (Exception ex)
            {
                string cMensajeError = ex.Message + ", " + ((ex.InnerException != null) ? ex.InnerException.Message.Trim() : "").ToString();
                MessageBox.Show("Error Llenando Grid: " + cMensajeError, "", MessageBoxButtons.OK,
                      MessageBoxIcon.Information);
            }
        }

        private void cmdNuevo_Click(object sender, EventArgs e)
        {
            cModo = "Nuevo";
            //Botones();
            Habilitar();
            Limpiar();
        }

        private void cmdEditar_Click(object sender, EventArgs e)
        {
            DataGridViewRow IdChofer = grdDatos.CurrentRow;
            int nId = Convert.ToInt32(IdChofer.Cells["idasignacion"].Value);
            if (nId > 0)
            {
                cModo = "Actualizar";
                Limpiar();
                BuscarAsignacion(nId);
                Habilitar();
            }
        }
    }
}
