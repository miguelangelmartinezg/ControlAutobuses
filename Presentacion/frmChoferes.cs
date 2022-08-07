using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities;
using LogicaNegocio;

namespace Presentacion
{
    public partial class frmChoferes : Form
    {
        string cModo = "Inicio";
        public frmChoferes()
        {
            
            InitializeComponent();
            //this.Width = 807;
            //this.Height = 533;
        }

        private void frmChoferes_Load(object sender, EventArgs e)
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



        }
        private void DesHabilitar()
        {
            txtNombre.Enabled = false;
            txtNombre.ReadOnly = true;
            txtApellido.Enabled = false;
            txtApellido.ReadOnly = true;
            txtFecha.Enabled = false;
            txtCedula.ReadOnly = true;
            txtCedula.Enabled = false;

        }

        private void Habilitar()
        {
            txtNombre.Enabled = true;
            txtNombre.ReadOnly = false;
            txtApellido.Enabled = true;
            txtApellido.ReadOnly = false;
            txtFecha.Enabled = true;
            txtCedula.ReadOnly = false;
            txtCedula.Enabled = true;
        }

        private void Limpiar()
        {
            txtNombre.Text = "";          
            txtApellido.Text = "";
            txtFecha.Text = "";
            txtCedula.Text = "";
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

                DataTable dtDatos = oLogica.CargarChoferes(nId);               
                grdChoferes.Rows.Clear();
                foreach (DataRow contacto in dtDatos.Rows)
                {

                    grdChoferes.Rows.Add(Convert.ToString(contacto["Nombre"]), Convert.ToString(contacto["Apellido"]),
                        Convert.ToString(contacto["cedula"]),Convert.ToBoolean(contacto["lOcupadO"]),Convert.ToInt32(contacto["IdChofer"]));
                }
            }
            catch (Exception ex)
            {

                string cMensajeError = ex.Message + ", " + ((ex.InnerException != null) ? ex.InnerException.Message.Trim() : "").ToString();
                MessageBox.Show("Error Llenando Grid: " + cMensajeError, "", MessageBoxButtons.OK,
                      MessageBoxIcon.Information);

            }

        }
        private void BuscarContacto(int nId)
        {
            try
            {
                Logica_Negocio oLogica = new Logica_Negocio();
                DataTable dtDatos = oLogica.CargarChoferes(nId);
                foreach (DataRow contacto in dtDatos.Rows)
                {
                    txtIdChofer.Text = contacto["IdChofer"].ToString();
                    txtNombre.Text = contacto["Nombre"].ToString();
                    txtApellido.Text = contacto["Apellido"].ToString();
                    txtCedula.Text = contacto["Cedula"].ToString();
                    txtFecha.Value = Convert.ToDateTime(contacto["FechaNac"]);
                   
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
                  
                    Chofer oChofer = new Chofer
                    {
                        Nombre = txtNombre.Text,
                        Apellido = txtApellido.Text,
                        FechaNac = Convert.ToDateTime(txtFecha.Value.ToString("yyyy-MM-dd")),
                        Cedula = txtCedula.Text
                        
                    };
                    oLogica.InsertarChofer(oChofer);

                    MessageBox.Show("Chofer Insertado Correctamente!!!");
                    LlenarGrid(0);
                    Limpiar();
                    Inicir();
                }
                if (cModo == "Actualizar")
                {
                    Logica_Negocio oLogica = new Logica_Negocio();
                    Chofer oChofer = new Chofer
                    {

                        IdChofer = Convert.ToInt32(txtIdChofer.Text),
                        Nombre = txtNombre.Text,
                        Apellido = txtApellido.Text,
                        FechaNac = Convert.ToDateTime(txtFecha.Value.ToString("yyyy-MM-dd")),
                        Cedula = txtCedula.Text
                    };
                    oLogica.ActualizarChofer(oChofer);
                    MessageBox.Show("Chofer Actualizado Correctamente Correctamente!!!");
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
            DataGridViewRow IdChofer = grdChoferes.CurrentRow;
            int nId = Convert.ToInt32(IdChofer.Cells["idchofer"].Value);
            if (nId > 0)
            {
                cModo = "Actualizar";
                Botones();
                Limpiar();
                BuscarContacto(nId);
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
                    oLogica.BorrarChofer(Convert.ToInt32(txtIdChofer.Text));
                    MessageBox.Show("Chofer Eliminado Correctamente!!!");
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
