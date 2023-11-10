using CIneLabo.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CIneLabo.Presentacion
{
    public partial class FrmPodio : Form
    {
        DaoPeliculas daopel;

        public FrmPodio()
        {
            InitializeComponent();
            daopel = new DaoPeliculas();
        }
        private void FrmPodio_Load(object sender, EventArgs e)
        {
            CargarPeliculas();
        }

        private void CargarPeliculas()
        {
            cboGenero.DataSource = daopel.ObtenerPeliculas();
            cboGenero.ValueMember = "IdPelicula";
            cboGenero.DisplayMember = "Titulo";
        }
    }
}
