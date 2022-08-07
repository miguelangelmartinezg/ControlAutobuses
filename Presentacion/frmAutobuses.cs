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
    public partial class frmAutobuses : Form
    {
        string cTabla = "";
        string cModo = "Inicio";
        Logica_Negocio oLogicaNegocio = new Logica_Negocio();
        public frmAutobuses()
        {
            InitializeComponent();
        }

      

        private void frmAutobuses_Load(object sender, EventArgs e)
        {
            Inicir();
            LlenarCombo();
        }
        private  void LlenarCombo()
        {
            cTabla = "Marcas";
            cboMarcas.DataSource = oLogicaNegocio.DatosGeneral(cTabla);
            cboMarcas.DisplayMember = "Nombre";
            cboMarcas.ValueMember = "IdMarca";
            //cboColor.SelectedIndex = 0;

            cTabla = "Colores";
            cboColor.DataSource = oLogicaNegocio.DatosGeneral(cTabla);
            cboColor.DisplayMember = "Nombre";
            cboColor.ValueMember = "IdColor";
            //cboColor.SelectedIndex = 0;

            cTabla = "Anos";
            cboAno.DataSource = oLogicaNegocio.DatosGeneral(cTabla);
            cboAno.DisplayMember = "Nombre";
            cboAno.ValueMember = "IdAno";
            //cboAno.SelectedIndex = 0;
        }
        private void LlenaModelo(int nIdMarca)
        {
            string cConsulta = "select * from Modelos where IdMarca = " + nIdMarca;
            cboModelos.DataSource = oLogicaNegocio.DatosGeneralConsulta(cConsulta);
            cboModelos.DisplayMember = "Nombre";
            cboModelos.ValueMember = "IdModelo";
           
        }

        private void cboMarcas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboMarcas_DropDownClosed(object sender, EventArgs e)
        {
            int nIdMarca = Convert.ToInt32(cboMarcas.SelectedValue);
            LlenaModelo(nIdMarca);
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
            txtPlaca.Enabled = false;
            txtPlaca.ReadOnly = true;
            cboAno.Enabled = false;
            cboColor.Enabled = false;
            cboMarcas.Enabled = false;
            cboModelos.Enabled = false;

        }

        private void Habilitar()
        {
            txtPlaca.Enabled = true;
            txtPlaca.ReadOnly = false;
            cboAno.Enabled = true;
            cboColor.Enabled = true;
            cboMarcas.Enabled = true;
            cboModelos.Enabled = true;
        }

        private void Limpiar()
        {
            txtPlaca.Text = "";
            cboAno.SelectedIndex = -1;
            cboColor.SelectedIndex = -1;
            cboMarcas.SelectedIndex = -1;
            cboModelos.SelectedIndex = -1;
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

                DataTable dtDatos = oLogica.CargarAutobus(nId);
                grdBuses.Rows.Clear();
                foreach (DataRow contacto in dtDatos.Rows)
                {

                    grdBuses.Rows.Add(Convert.ToString(contacto["Marca"]), Convert.ToString(contacto["Modelo"]),
                        Convert.ToString(contacto["Placa"]), Convert.ToString(contacto["Color"]), Convert.ToString(contacto["Ano"]),
                        Convert.ToInt32(contacto["IdBus"]), Convert.ToInt32(contacto["IdMarca"]), Convert.ToInt32(contacto["IdModelo"]),
                        Convert.ToInt32(contacto["IdColor"]), Convert.ToInt32(contacto["IdAno"]));
                }
            }
            catch (Exception ex)
            {

                string cMensajeError = ex.Message + ", " + ((ex.InnerException != null) ? ex.InnerException.Message.Trim() : "").ToString();
                MessageBox.Show("Error Llenando Grid: " + cMensajeError, "", MessageBoxButtons.OK,
                      MessageBoxIcon.Information);

            }

        }
        private void BuscarBus(int nId)
        {
            try
            {
                Logica_Negocio oLogica = new Logica_Negocio();
                DataTable dtDatos = oLogica.CargarAutobus(nId);
                foreach (DataRow contacto in dtDatos.Rows)
                {
                    txtPlaca.Text = contacto["Placa"].ToString();
                    cboMarcas.SelectedValue = Convert.ToString(contacto["IdMarca"]);
                    cboModelos.SelectedValue = Convert.ToString(contacto["IdModelo"]);
                    cboColor.SelectedValue = Convert.ToString(contacto["IdColor"]);
                    cboAno.SelectedValue = Convert.ToString(contacto["IdAno"]);

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
           
        }

        private void cmdGrabar_Click(object sender, EventArgs e)
        {
            try
            {

                if (cModo == "Nuevo")
                {

                    Logica_Negocio oLogica = new Logica_Negocio();

                    Autobus oBus = new Autobus
                    {
                        Placa = txtPlaca.Text,
                        IdAno = Convert.ToInt32(cboAno.SelectedValue),
                        IdColor = Convert.ToInt32(cboColor.SelectedValue),
                        IdMarca = Convert.ToInt32(cboMarcas.SelectedValue),
                        IdModelo = Convert.ToInt32(cboModelos.SelectedValue)

                    };
                    oLogica.InsertarAutobus(oBus);

                    MessageBox.Show("AutoBus Insertado Correctamente!!!");
                    LlenarGrid(0);
                    Limpiar();
                    Inicir();
                }
                if (cModo == "Actualizar")
                {
                    Logica_Negocio oLogica = new Logica_Negocio();
                    Autobus oBus = new Autobus
                    {
                        IdBus = Convert.ToInt32(txtIdBus.Text),
                        Placa = txtPlaca.Text,
                        IdAno = Convert.ToInt32(cboAno.SelectedValue),
                        IdColor = Convert.ToInt32(cboColor.SelectedValue),
                        IdMarca = Convert.ToInt32(cboMarcas.SelectedValue),
                        IdModelo = Convert.ToInt32(cboModelos.SelectedValue)
                    };
                    oLogica.ActualizarBus(oBus);
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

        private void cmdEditar_Click(object sender, EventArgs e)
        {
            DataGridViewRow IdChofer = grdBuses.CurrentRow;
            int nId = Convert.ToInt32(IdChofer.Cells["idbus"].Value);
            if (nId > 0)
            {
                cModo = "Actualizar";
                Botones();
                Limpiar();
                BuscarBus(nId);
                Habilitar();
            }
        }

        private void cmdBorrar_Click(object sender, EventArgs e)
        {
            if (cModo == "Actualizar")
            {
                Logica_Negocio oLogica = new Logica_Negocio();
                var oResponse = MessageBox.Show("Seguro que desea Eliminar Este AutoBus??", "Borrar Contacto",
                                     MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (oResponse == DialogResult.Yes)
                {
                    oLogica.BorrarBus(Convert.ToInt32(txtIdBus.Text));
                    MessageBox.Show("Bus Eliminado Correctamente!!!");
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
