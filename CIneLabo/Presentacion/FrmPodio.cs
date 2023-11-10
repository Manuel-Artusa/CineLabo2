using CIneLabo.Data;
using CIneLabo.Entidades.Cine;
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
        DaoGeneros daogen;

        public FrmPodio()
        {
              InitializeComponent();
            daopel = new DaoPeliculas();
            daogen = new DaoGeneros();
        }
        private void FrmPodio_Load(object sender, EventArgs e)
        {
            //CargarPeliculas();
            CargarGeneros();
            
        }

        private void CargarGeneros()
        {
            cboGenero.DataSource = daogen.ObtenerGeneros();
            cboGenero.ValueMember = "IdGenero";
            cboGenero.DisplayMember = "genero";
        }

        private void CargarPeliculas()
        {
            cboGenero.DataSource = daopel.ObtenerPeliculas();
            cboGenero.ValueMember = "IdPelicula";
            cboGenero.DisplayMember = "Titulo";
        }
    }
}
