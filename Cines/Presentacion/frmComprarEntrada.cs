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
using Cines.Acceso_a_Datos.Factory;

namespace CineApp.Forms
{
    public partial class frmComprarEntrada : Form
    {
        private bool ClickEnBoton = false;
        private Color originalColor;
        private Butacas butaca;
        private aFactoria fact;
        private IDao dao;
        private Dictionary<int, PictureBox> diccionarioPictureBox;
        private Dictionary<Button, bool> botonesEstado = new Dictionary<Button, bool>();
        private List<Butacas> butacas;
        public frmComprarEntrada()
        {
            InitializeComponent();
            fact = new Factoria();
            dao = new DaoCine();
            diccionarioPictureBox = new Dictionary<int, PictureBox>();
           // EnlazarButacasConNumeritos();
            foreach (Control control in Controls)
            {
                if (control is Button)
                {
                    Button boton = (Button)control;
                    botonesEstado.Add(boton, false); // Inicialmente, todos los botones están en estado 'false'
                    ////boton.Click += Boton_Click; // Agrega el evento clic a cada botón
                }
            }

        }
        public void EnlazarButacasConNumeritos()
        {

            diccionarioPictureBox.Add(2, pictureBox2);
            diccionarioPictureBox.Add(3, pictureBox3);
            diccionarioPictureBox.Add(4, pictureBox4);
            diccionarioPictureBox.Add(5, pictureBox5);
            diccionarioPictureBox.Add(6, pictureBox6);
            diccionarioPictureBox.Add(7, pictureBox7);
            diccionarioPictureBox.Add(8, pictureBox8);


            diccionarioPictureBox.Add(12, pictureBox11);
            diccionarioPictureBox.Add(13, pictureBox12);
            diccionarioPictureBox.Add(14, pictureBox13);
            diccionarioPictureBox.Add(15, pictureBox14);
            diccionarioPictureBox.Add(16, pictureBox15);
            diccionarioPictureBox.Add(17, pictureBox16);
            diccionarioPictureBox.Add(18, pictureBox17);
            diccionarioPictureBox.Add(19, pictureBox18);

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
            //string url = string.Format("https://localhost:7011/FuncionesTraer");
            //var data = await
            //ClienteSingleton.GetInstance().GetAsync(url);
            //List<Funciones> funciones = JsonConvert.DeserializeObject<List<Funciones>>(data);
            List<Funciones> funciones = dao.TraerFunciones(cbPelicula.Text, dtpFechaCompra.ToString());
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

        private void frmComprarEntrada_Load_1(object sender, EventArgs e)
        {
            cbPelicula.DataSource = fact.crearDao().TraerPeliculas();
            cbPelicula.ValueMember = "TITULO";
            cbPelicula.DisplayMember = "ID_PELICULA";
            cbPelicula.DropDownStyle = ComboBoxStyle.DropDownList;
            cbPelicula.SelectedItem = 1;






        }
        private void CargarButacas()
        {

            for (int i = 1; i <= 18; i++)
            {

                string nombreBoton = "Butaca" + i.ToString();
                Button boton = Controls.Find(nombreBoton, true).FirstOrDefault() as Button;
                if (boton != null)
                {
                    // Obtén la butaca correspondiente en la lista
                    Butacas butaca = butacas[i - 1];

                    if (butaca != null)
                    {
                        boton.Tag = butaca.IdButaca;
                        if (butaca.IdButaca != null)
                        {
                            boton.BackColor = Color.Aqua;
                            botonesEstado[boton] = false; // Cambia el estado del botón
                        }
                        else 
                        {
                            boton.BackColor = Color.DarkBlue;
                            botonesEstado[boton] = true;
                            boton.Enabled = false;

                        }
                    }
                }
            }

        }
        private void GetButacas()
        {
            string FechaSeleccionada = dtpFechaCompra.Value.ToString();
            int SalaSeleccionada = Convert.ToInt32(txtSala.Text.ToString());
            string PeliculaSeleccionada = cbPelicula.Text.ToString();
            string FuncionSeleccionada = cbFuncion.Text.ToString();

            if (PeliculaSeleccionada != null)
            {
                List<Butacas> butacasVendidas = fact.crearDao().TraerButacas(FechaSeleccionada, PeliculaSeleccionada, SalaSeleccionada, FuncionSeleccionada);
                AsignarColoresButacas(butacasVendidas);

            }
        }
        //foreach (var kpv in diccionarioPictureBox)
        //{
        //    int numeroButacas = kpv.Key;
        //    PictureBox pictureBox = kpv.Value;

        //    but = numeroButacas;

        //    if (but != null)
        //    {


        //        pictureBox.BackColor = Color.White;
        //    }
        //    else
        //    {
        //        pictureBox.BackColor = Color.DarkGreen;
        //    }  




        private void AsignarColoresButacas(List<Butacas> butacasVendida)
        {
            foreach (var kvp in diccionarioPictureBox)
            {
                int numeroButaca = (int)kvp.Key;
                PictureBox pictureBox = kvp.Value;


               // AsignarColorButaca(pictureBox, butacasVendida);
            }

        }
        //private void PictureBox_click (object sender, EventArgs e) 
        //{
            
        //        Butacas butacaVendida = butacasVendidas.FirstOrDefault(b => b.IdButaca == numeroButaca);
        //        if(butacaVendida == null)
        //        {
        //            Butacas newButaca = new Butacas();
        //            newButaca.IdButaca = numeroButaca;
        //            butacasVendidas.Add(newButaca);
        //        }
        //        else
        //        {
        //            butacasVendidas.Remove(butacaVendida);
        //        }
        //}
        private void AsignarColorButaca(PictureBox pictureBox, bool butacaVendida)
        {
            pictureBox.BackColor = butacaVendida ? Color.Red : Color.White;
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            cbFuncion.DataSource = fact.crearDao().TraerFunciones(cbPelicula.Text, dtpFechaCompra.Text);
            cbFuncion.ValueMember = "IdFuncion";
            cbFuncion.DisplayMember = "HORA";


        }

        private void cboSala_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnVer2_Click(object sender, EventArgs e)
        {
            txtSala.Text = "1";
            //cboSala.DataSource = fact.crearDao().TraerSala(cbFuncion.SelectedIndex);
            //cboSala.ValueMember = "IdSala";
            //cboSala.DisplayMember = "1";

        }

        private void btnVerAsientos_Click(object sender, EventArgs e)
        {
            GetButacas();
        }
    }
}
