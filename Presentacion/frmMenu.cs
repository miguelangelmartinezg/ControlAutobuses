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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void cmdAddChofere_Click(object sender, EventArgs e)
        {
            frmChoferes ofrmChoferes = new frmChoferes();
            ofrmChoferes.Show();
            this.Hide();
        }

        private void cmdAddBus_Click(object sender, EventArgs e)
        {
            frmAutobuses oFrmAutobus = new frmAutobuses();
            oFrmAutobus.Show();
            this.Hide();
        }

        private void cmdAsignar_Click(object sender, EventArgs e)
        {
            frmAsignarRuta ofrmAsignar = new frmAsignarRuta();
            ofrmAsignar.Show();
            this.Hide();
        }

        private void cmdAddRuta_Click(object sender, EventArgs e)
        {
            frmRuta ofrmRuta = new frmRuta();
            ofrmRuta.Show();
            this.Hide();
        }
    }
}
