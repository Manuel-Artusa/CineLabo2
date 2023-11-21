using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Cines.Clases.Cines.Cine;
using CinesFront.Presentacion;

namespace CineApp.Forms
{
    public partial class frmComprarEntrada : Form
    {
        private bool ClickEnBoton = false;
        private Color originalColor;
        private Butacas butaca;
        public frmComprarEntrada()
        {
            InitializeComponent();

        }
        private void CambiarColorDeBoton(PictureBox butaca, Color color1)
        {
            if (ClickEnBoton)
            {
                butaca.BackColor = originalColor;
            }
            else
            {
                originalColor = butaca.BackColor;
                butaca.BackColor = color1;
            }

            ClickEnBoton = !ClickEnBoton;
        }
        private void pbButaca1_Click(object sender, EventArgs e)
        {
            CambiarColorDeBoton(pbButaca1, Color.DarkGreen);
        }

        private void pbButaca3_Click(object sender, EventArgs e)
        {

            CambiarColorDeBoton(pbButaca3, Color.DarkGreen);
        }
        private void pbButaca4_Click(object sender, EventArgs e)
        {

            CambiarColorDeBoton(pbButaca4, Color.DarkGreen);
        }
        private void pbButaca5_Click(object sender, EventArgs e)
        {

            CambiarColorDeBoton(pbButaca5, Color.DarkGreen);
        }

        private void pbButaca6_Click(object sender, EventArgs e)
        {

            CambiarColorDeBoton(pbButaca6, Color.DarkGreen);
        }

        private void pbButaca7_Click(object sender, EventArgs e)
        {

            CambiarColorDeBoton(pbButaca7, Color.DarkGreen);
        }

        private void pbButaca8_Click(object sender, EventArgs e)
        {
            CambiarColorDeBoton(pbButaca8, Color.DarkGreen);

        }

        private void pbButaca9_Click(object sender, EventArgs e)
        {

            CambiarColorDeBoton(pbButaca9, Color.DarkGreen);

        }

        private void pbButaca10_Click(object sender, EventArgs e)
        {

        }

        private void pbButaca11_Click(object sender, EventArgs e)
        {

        }

        private void pbButaca12_Click(object sender, EventArgs e)
        {

        }

        private void pbButaca13_Click(object sender, EventArgs e)
        {

        }

        private void pbButaca14_Click(object sender, EventArgs e)
        {

        }

        private void pbButaca15_Click(object sender, EventArgs e)
        {

        }

        private void pbButaca16_Click(object sender, EventArgs e)
        {

        }

        private void pbButaca17_Click(object sender, EventArgs e)
        {

        }

        private void pbButaca18_Click(object sender, EventArgs e)
        {

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            FrmButacasDisponiblies butacasDisponiblies = new FrmButacasDisponiblies();

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estas seguro que quieres cancelar la compra y volver al menu anterior?", "VOLVER", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                this.Close();
        }

        private void frmComprarEntrada_Load(object sender, EventArgs e)
        {

        }
    }
}
