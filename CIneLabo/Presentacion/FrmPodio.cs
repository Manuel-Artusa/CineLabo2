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
using 

namespace CIneLabo.Entidades.Personas;.Entidades.Personas.Presentacion
{
    public partial class FrmPodio : Form
    {
        public FrmPodio()
        {
            InitializeComponent();
        }

        private void FrmPodio_Load(object sender, EventArgs e)
        {

            CargarCombo();
        }
        public DataTable Consultar(string nombreSP)
        {
            cnn.Open();
            SqlCommand comando = new SqlCommand();
            comando.Connection = cnn;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = nombreSP;
            DataTable tabla = new DataTable();
            tabla.Load(comando.ExecuteReader());
            cnn.Close();
            return tabla;
        }

        private void CargarCombo()
        {


            List<Genero> lstGen = new List<Genero>();
            DataTable dt = Consultar("SP_CONSULTAR_GERNEROS");

            foreach (DataRow dr in dt.Rows)
            {
                int id_gen = Convert.ToInt32(dr["ID_GENERO"]);
                string desc = dr["DESCRIPCION"].ToString();


                Genero gen = new Genero(id_gen, desc);
                lstGen.Add(gen);
            }
            return lstGen;

        }
        private void cmbGenero_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedGenre = cmbGenero.SelectedItem.ToString(); // Obten el género seleccionado





            using (SqlConnection connection = new SqlConnection(@"connectioData Source =.\SQLEXPRESS; Initial Catalog = CINE; Integrated Security = TruenString"))
            {
                connection.Open();

                // Crea un SqlCommand para ejecutar el procedimiento almacenado
                using (SqlCommand cmd = new SqlCommand("ObtenerPuntajesPorGenero", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Agrega el parámetro de género
                    cmd.Parameters.Add(new SqlParameter("@Genero", SqlDbType.NVarChar, 50)).Value = selectedGenre;

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // Enlaza los resultados al DataGridView
                        dgvPodio.DataSource = dataTable;
                    }
                }
            }
        }
    }
}
