using Cines.Acceso_a_Datos.Factory;
using Cines.Clases.Cine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cines.Presentacion
{
    public partial class FrmPodio : Form
    {
        private aFactoria fact;
        public FrmPodio()
        {
            InitializeComponent();
            fact = new Factoria();
        }

        private void FrmPodio_Load(object sender, EventArgs e)
        {

        }
        private void CargarCombo()
        {


         
        }

    }
}
