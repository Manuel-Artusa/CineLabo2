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
using CinesFront.Http;
using CinesFront.Presentacion;
using Newtonsoft.Json;
using SistemaCineBack.Acceso_a_Datos.Dao;
using Cines.Clases.Cine;

namespace CineApp.Forms
{
    public partial class frmComprarEntrada : Form
    {
        private bool ClickEnBoton = false;
        private Color originalColor;
        private Butacas butaca;
        private IDao dao;
        public frmComprarEntrada()
        {
            InitializeComponent();

            dao = new DaoCine();
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


        private void btnVolver_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estas seguro que quieres cancelar la compra y volver al menu anterior?", "VOLVER", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                this.Close();
        }

        private void frmComprarEntrada_Load(object sender, EventArgs e)
        {
            CargarPeliculasasync();
            CargarFuncionesAsync();
        }

        private async Task CargarFuncionesAsync()
        {
            string url = string.Format("https://localhost:7011/FuncionesTraer");
            var data = await
            ClienteSingleton.GetInstance().GetAsync(url);
            List<Funciones> funciones = JsonConvert.DeserializeObject<List<Funciones>>(data);
            cbPelicula.DataSource = funciones;
            cbPelicula.ValueMember = "HORA";
            cbPelicula.DisplayMember = "ID_FUNCION";
            cbPelicula.DropDownStyle = ComboBoxStyle.DropDownList;
            cbPelicula.SelectedItem = 1;
        }

        private async Task CargarPeliculasasync()
        {
            string url = string.Format("https://localhost:7011/Peliculas");
            var data = await
            ClienteSingleton.GetInstance().GetAsync(url);
            List<Peliculas> peliculas = JsonConvert.DeserializeObject<List<Peliculas>>(data);
            cbPelicula.DataSource = peliculas;
            cbPelicula.ValueMember = "TITULO";
            cbPelicula.DisplayMember = "ID_PELICULA";
            cbPelicula.DropDownStyle = ComboBoxStyle.DropDownList;
            cbPelicula.SelectedItem = 1;

        }
    }
}
