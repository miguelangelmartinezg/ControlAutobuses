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
    public partial class frmRuta : Form
    {
        string cModo = "Inicio";
        public frmRuta()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Autobuses autobuses = new Autobuses();
            //autobuses.Show();
            //this.Hide();
        }

      

        private void frnRuta_Load(object sender, EventArgs e)
        {
            Inicir();
        }
        private void Inicir()
        {

            cModo = "Inicio";
            Botones();
            DesHabilitar();
            Limpiar();
            LlenarGrid(0);
            txtNombre.Focus();



        }
        private void DesHabilitar()
        {
            txtNombre.Enabled = false;
            txtNombre.ReadOnly = true;
           
        }

        private void Habilitar()
        {
            txtNombre.Enabled = true;
            txtNombre.ReadOnly = false;
          
        }

        private void Limpiar()
        {
            txtIdRuta.Text = "";
            txtNombre.Text = "";
          
        }

        public void Botones()
        {

            switch (cModo)
            {

                case "Inicio":
                    this.cmdBorrar.Enabled = false;
                    this.cmdGrabar.Enabled = false;
                    this.cmdNuevo.Enabled = true;
                    this.cmdSalir.Enabled = true;
                    this.cmdEditar.Enabled = true;
                    this.cmdCancelar.Enabled = false;
                    break;
                case "Nuevo":
                    this.cmdBorrar.Enabled = false;
                    this.cmdCancelar.Enabled = true;
                    this.cmdGrabar.Enabled = true;
                    this.cmdNuevo.Enabled = false;
                    this.cmdEditar.Enabled = false;
                    this.cmdSalir.Enabled = true;

                    break;

                case "Grabar":
                    this.cmdBorrar.Enabled = false;
                    this.cmdCancelar.Enabled = false;
                    this.cmdGrabar.Enabled = false;
                    this.cmdNuevo.Enabled = true;
                    this.cmdSalir.Enabled = true;
                    this.cmdEditar.Enabled = false;
                    break;

                case "Eliminar":
                    this.cmdBorrar.Enabled = false;
                    this.cmdCancelar.Enabled = false;
                    this.cmdGrabar.Enabled = false;
                    this.cmdNuevo.Enabled = true;
                    this.cmdSalir.Enabled = true;
                    break;

                case "Cancelar":
                    this.cmdBorrar.Enabled = false;
                    this.cmdCancelar.Enabled = false;
                    this.cmdGrabar.Enabled = false;
                    this.cmdNuevo.Enabled = true;
                    this.cmdSalir.Enabled = true;
                    break;

                case "Buscar":
                    this.cmdBorrar.Enabled = true;
                    this.cmdCancelar.Enabled = true;
                    this.cmdGrabar.Enabled = false;
                    this.cmdNuevo.Enabled = false;
                    this.cmdSalir.Enabled = true;
                    this.cmdEditar.Enabled = true;
                    break;

                case "Actualizar":
                    this.cmdBorrar.Enabled = true;
                    this.cmdCancelar.Enabled = true;
                    this.cmdGrabar.Enabled = true;
                    this.cmdNuevo.Enabled = false;
                    this.cmdSalir.Enabled = true;
                    this.cmdEditar.Enabled = false;
                    break;


                default:
                    this.cmdBorrar.Enabled = false;

                    this.cmdCancelar.Enabled = false;
                    this.cmdGrabar.Enabled = false;
                    this.cmdNuevo.Enabled = true;
                    this.cmdSalir.Enabled = true;
                    this.cmdEditar.Enabled = false;
                    break;
            }
        } // fin Botones
        private void LlenarGrid(int nId)
        {

            try
            {
                Logica_Negocio oLogica = new Logica_Negocio();

                DataTable dtDatos = oLogica.CargarRutas(nId);
                grdRutas.Rows.Clear();
                foreach (DataRow contacto in dtDatos.Rows)
                {

                    grdRutas.Rows.Add(Convert.ToString(contacto["IdRuta"]), Convert.ToString(contacto["Nombre"]),
                        Convert.ToBoolean(contacto["lOcupada"]));
                }
            }
            catch (Exception ex)
            {

                string cMensajeError = ex.Message + ", " + ((ex.InnerException != null) ? ex.InnerException.Message.Trim() : "").ToString();
                MessageBox.Show("Error Llenando Grid: " + cMensajeError, "", MessageBoxButtons.OK,
                      MessageBoxIcon.Information);

            }

        }
        private void BuscarRuta(int nId)
        {
            try
            {
                Logica_Negocio oLogica = new Logica_Negocio();
                DataTable dtDatos = oLogica.CargarRutas(nId);
                foreach (DataRow contacto in dtDatos.Rows)
                {
                    txtIdRuta.Text = contacto["IdRuta"].ToString();
                    txtNombre.Text = contacto["Nombre"].ToString();
                  
                }

            }
            catch (Exception ex)
            {

                string cMensajeError = ex.Message + ", " + ((ex.InnerException != null) ? ex.InnerException.Message.Trim() : "").ToString();
                MessageBox.Show("Error Buscando Contacto: " + cMensajeError, "", MessageBoxButtons.OK,
                      MessageBoxIcon.Information);

            }
        }

        private void cmdNuevo_Click(object sender, EventArgs e)
        {
            cModo = "Nuevo";
            Botones();
            Habilitar();
            Limpiar();
            txtNombre.Focus();
        }

        private void cmdGrabar_Click(object sender, EventArgs e)
        {
            try
            {

                if (cModo == "Nuevo")
                {

                    Logica_Negocio oLogica = new Logica_Negocio();

                    Ruta oRuta = new Ruta
                    {
                        Nombre = txtNombre.Text,
                     
                    };
                    oLogica.InsertarRuta(oRuta);

                    MessageBox.Show("Ruta Insertada Correctamente!!!");
                    LlenarGrid(0);
                    Limpiar();
                    Inicir();
                }
                if (cModo == "Actualizar")
                {
                    Logica_Negocio oLogica = new Logica_Negocio();
                    Ruta oRuta = new Ruta
                    {

                        IdRuta = Convert.ToInt32(txtIdRuta.Text),
                        Nombre = txtNombre.Text,
                     
                    };
                    oLogica.ActualizarRuta(oRuta);
                    MessageBox.Show("Ruta Actualizada Correctamente!!!");
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

        private void cmdEditar_Click(object sender, EventArgs e)
        {
            DataGridViewRow IdChofer = grdRutas.CurrentRow;
            int nId = Convert.ToInt32(IdChofer.Cells["idruta"].Value);
            if (nId > 0)
            {
                cModo = "Actualizar";
                Botones();
                Limpiar();
                BuscarRuta(nId);
                Habilitar();
            }
        }

        private void cmdBorrar_Click(object sender, EventArgs e)
        {
            if (cModo == "Actualizar")
            {
                Logica_Negocio oLogica = new Logica_Negocio();
                var oResponse = MessageBox.Show("Seguro que desea Eliminar Este Contacto??", "Borrar Contacto",
                                     MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (oResponse == DialogResult.Yes)
                {
                    oLogica.BorrarRuta(Convert.ToInt32(txtIdRuta.Text));
                    MessageBox.Show("Ruta Eliminada Correctamente!!!");
                    LlenarGrid(0);
                    Limpiar();
                    Inicir();
                }

            }
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            Inicir();
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            var oResponse = MessageBox.Show("Seguro que desea Salir del Sistema??", "Salir del Sistema",
                                   MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (oResponse == DialogResult.Yes)
            {
                frmMenu oFrmMenu = new frmMenu();
                oFrmMenu.Show();
                this.Close();
            }
        }
    }
}
