using CIneLabo.Presentacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CineApp.Forms
{
    public partial class frmAdministrador : Form
    {
        public frmAdministrador()
        {
            InitializeComponent();
        }

        private void iconoMenu_Click(object sender, EventArgs e)
        {
            if (pbFondoMenu.Width == 400)
            {
                pbFondoMenu.Width = 150;
                lblMenu.Enabled = false;
                lblMenu.Visible = false;
                lblNosotros.Enabled = false;
                lblNosotros.Visible = false;
                lblReporte.Enabled = false;
                lblReporte.Visible = false;
                lblSoporte.Enabled = false;
                lblSoporte.Visible = false;
                lblTransaccion.Enabled = false;
                lblTransaccion.Visible = false;
                btnSalir.Enabled = false;
                btnSalir.Visible = false;
            }
            else
            {
                pbFondoMenu.Width = 400;
                lblMenu.Enabled = true;
                lblMenu.Visible = true;
                lblNosotros.Enabled = true;
                lblNosotros.Visible = true;
                lblReporte.Enabled = true;
                lblReporte.Visible = true;
                lblSoporte.Enabled = true;
                lblSoporte.Visible = true;
                lblTransaccion.Enabled = true;
                lblTransaccion.Visible = true;
                btnSalir.Enabled = true;
                btnSalir.Visible = true;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estas seguro que desea abandonar la aplicación?", "SALIR", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void lblReporte_Click(object sender, EventArgs e)
        {

        }

        private void iconoReporte_Click(object sender, EventArgs e)
        {
            FrmPodio podio = new FrmPodio();
            podio.ShowDialog();

        }

        private void iconoSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estas seguro que desea abandonar la aplicación?", "SALIR", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
