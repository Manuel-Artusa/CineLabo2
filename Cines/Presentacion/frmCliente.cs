using CineApp.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CineApp
{
    public partial class frmCliente : Form
    {
        public frmCliente()
        {
            InitializeComponent();
        }

        private void btnComprarEntradas_Click(object sender, EventArgs e)
        {

        }

        private void btnNombreUsuario_Click(object sender, EventArgs e)
        {
            if (btnSalir.Enabled == false)
            {
                btnSalir.Enabled = true;
                btnSalir.Visible = true;
            }
            else
            {
                btnSalir.Enabled = false;
                btnSalir.Visible = false;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estas seguro que deseas salir?", "SALIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                this.Close();
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {

        }

        private void btnComprarEntradas_Click_1(object sender, EventArgs e)
        {
            frmComprarEntrada frm = new frmComprarEntrada();
            frm.ShowDialog();
        }
    }
}