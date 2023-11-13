using Cines.Clases.Cines.Cine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinesFront.Presentacion
{
    public partial class FrmCandyBar : Form
    {
        public FrmCandyBar()
        {
            InitializeComponent();
        }
        private bool ClickEnBoton = false;
        private Color originalColor;
        private Butacas butaca;

        private void FrmCandyBar_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCombo1_Click(object sender, EventArgs e)
        {
            if (ClickEnBoton)
            {
                btnCombo1.BackColor = originalColor;
            }
            else
            {
                originalColor = btnCombo1.BackColor;
                btnCombo1.BackColor = Color.Aqua;
            }
            ClickEnBoton = !ClickEnBoton;
        }

        private void btnCombo3_Click(object sender, EventArgs e)
        {
            btnCombo3.BackColor = Color.Aqua;

        }

        private void btnCombo2_Click(object sender, EventArgs e)
        {
            btnCombo2.BackColor = Color.Aqua;

        }

        private void btnCombo5_Click(object sender, EventArgs e)
        {
            btnCombo5.BackColor = Color.Aqua;
        }

        private void btnCombo6_Click(object sender, EventArgs e)
        {
            btnCombo6.BackColor = Color.Aqua;
        }

        private void btnCandyCancelar_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("¿Estas seguro que quieres cancelar la compra y volver al menu anterior?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                this.Close();
        }
    }
}
