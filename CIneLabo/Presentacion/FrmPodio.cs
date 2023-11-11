using CIneLabo.Data;
using CIneLabo.Data.Clientes;
using CIneLabo.Entidades.Cine;
using CIneLabo.Entidades.Personas;
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
using CIneLabo.Data.DBHelper;


namespace CIneLabo.Presentacion
{
    public partial class FrmPodio : Form
    {
        DaoPeliculas daopel;
        DaoGeneros daogen;
        ClientesDao daocli;

        public FrmPodio()
        {
            InitializeComponent();
            daopel = new DaoPeliculas();
            daogen = new DaoGeneros();
            daocli = new ClientesDao();
            
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

        private void dgvPodio_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string generoSeleccionado = cboGenero.SelectedItem.ToString();

            
            string sp = "SP_CONSULTAR_CLIENTES_POR_GENERO_PUNTAJE";
            List<Parametro> lst = new List<Parametro>();
            lst.Add(new Parametro("@GeneroPelicula", generoSeleccionado));
            DataTable table = DbHelper.GetInstancia().Consultar(sp, lst);
            dgvPodio.Rows.Clear();
            foreach (DataRow fila in table.Rows)
            {
                dgvPodio.Rows.Add(new object[] { fila["ID_CLIENTE"].ToString(),
                                                   fila["NOMBRE_CLIENTE"],
                                                   fila["TotalGastado"].ToString()});
            }
        }
    }
}
