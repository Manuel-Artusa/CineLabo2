using Cines.Acceso_a_Datos.Factory;
using Cines.Clases.Cine;
using Cines.Clases.Cines.Cine;
using CinesBack.Clases;
using CinesFront.Http;
using Newtonsoft.Json;
using SistemaCineBack.Acceso_a_Datos.Dao;
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

    public partial class FrmButacasDisponiblies : Form
    {
        private bool ClickEnBoton;
        private Color originalColor;
        private Butacas butaca;
        private aFactoria fact;
        private Dictionary<int, PictureBox> diccionarioPictureBox;
        IDao dao;
        



        public FrmButacasDisponiblies()
        {
            InitializeComponent();
            fact = new Factoria();
            ClickEnBoton = false;
            diccionarioPictureBox = new Dictionary<int, PictureBox>();
            EnlazarButacasConNumeritos();
            dao = new DaoCine();

        }

        public void EnlazarButacasConNumeritos()
        {
            diccionarioPictureBox.Add(1, pictureBox1);
            diccionarioPictureBox.Add(2, pictureBox2);
            diccionarioPictureBox.Add(3, pictureBox3);
            diccionarioPictureBox.Add(4, pictureBox4);
            diccionarioPictureBox.Add(5, pictureBox5);
            diccionarioPictureBox.Add(6, pictureBox6);
            diccionarioPictureBox.Add(7, pictureBox7);
            diccionarioPictureBox.Add(8, pictureBox8);
            diccionarioPictureBox.Add(9, pictureBox9);
            diccionarioPictureBox.Add(10, pictureBox10);
            diccionarioPictureBox.Add(11, pictureBox11);
            diccionarioPictureBox.Add(12, pictureBox12);
            diccionarioPictureBox.Add(13, pictureBox13);
            diccionarioPictureBox.Add(14, pictureBox14);
            diccionarioPictureBox.Add(15, pictureBox15);
            diccionarioPictureBox.Add(16, pictureBox16);
            diccionarioPictureBox.Add(17, pictureBox17);
            diccionarioPictureBox.Add(18, pictureBox18);
            diccionarioPictureBox.Add(19, pictureBox19);
            diccionarioPictureBox.Add(20, pictureBox20);
            diccionarioPictureBox.Add(21, pictureBox21);
            diccionarioPictureBox.Add(22, pictureBox22);
            diccionarioPictureBox.Add(23, pictureBox23);
            diccionarioPictureBox.Add(24, pictureBox24);
            diccionarioPictureBox.Add(25, pictureBox25);
        }
        private async void FrmButacasDisponiblies_LoadAsync(object sender, EventArgs e)
        {
            //cargarComboPelicula();
            await cargarPeliculas();
        }
        private void cargarComboPelicula()
        {
            cboPelicula.DataSource = fact.crearDao().TraerPeliculas();
            cboPelicula.ValueMember = "TITULO";
            cboPelicula.DisplayMember = "ID_PELICULA";
            cboPelicula.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPelicula.SelectedItem = 1;



            foreach (var kvp in diccionarioPictureBox)
            {
                kvp.Value.Click += PictureBox_Click;
            }
        }
        public void MostrarButacasDisponibles()
        {
            // Obtener la fecha seleccionada del DateTimePicker
            DateTime fechaSeleccionada = dtpDesde.Value;

            // Obtener el nombre de la película seleccionada del ComboBox
            string? peliculaSelccionada = cboPelicula.SelectedItem?.ToString();

            TimeSpan hora = TimeSpan.Zero;  // Inicializar con un valor predeterminado

            // Verificar si hay un elemento seleccionado en el ComboBox
            if (cboFunciones.SelectedItem != null)
            {
                // Suponiendo que el objeto en el ComboBox tiene una propiedad "HoraFuncion" de tipo TimeSpan
                hora = ((Funciones)cboFunciones.SelectedItem).Hora;
            }

            // Verificar si se ha seleccionado una película
            if (peliculaSelccionada != null)
            {
                //try
                //{
                //    // Obtener la lista de butacas disponibles para la película y fecha seleccionadas
                //    List<Butacas> butacas = fact.crearDao().TraerButacas(fechaSeleccionada.ToShortDateString(), peliculaSelccionada);

                //    // Iterar a través de los PictureBox en el diccionario
                //    foreach (var kvp in diccionarioPictureBox)
                //    {
                //        // Obtener el número de butaca y el PictureBox correspondiente
                //        int numeroButaca = kvp.Key;
                //        PictureBox pictureBox = kvp.Value;

                //        // Buscar la butaca con el número correspondiente en la lista
                //        Butacas but = butacas.FirstOrDefault(but => but.IdButaca == numeroButaca);

                //        // Verificar si se encontró la butaca
                //        if (but != null)
                //        {
                //            // Verificar si la butaca está disponible
                //            if (but.Disponible)
                //            {
                //                // Pintar el PictureBox de verde si la butaca está disponible
                //                pictureBox.BackColor = Color.Green;
                //            }
                //            else
                //            {
                //                // Pintar el PictureBox de rojo si la butaca no está disponible
                //                pictureBox.BackColor = Color.Black;
                //            }
                //        }
                //        else
                //        {
                //            // Pintar el PictureBox de transparente si no existe la butaca
                //            pictureBox.BackColor = Color.Azure;
                //        }
                //    }
                //}
                //catch (Exception ex)
                //{
                //    // Manejar cualquier excepción que pueda ocurrir al obtener las butacas
                //    MessageBox.Show($"Error al cargar butacas: {ex.Message}");
                //}
            }
            else
            {
                // Mostrar un mensaje si no se ha seleccionado una película
                MessageBox.Show("Debe seleccionar una película");
                cboPelicula.Focus();
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            MostrarButacasDisponibles();
            MessageBox.Show("Estas son las butacas disponibles");

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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox_Click(object sender, EventArgs e)
        {
            if (sender is PictureBox pictureBox)
            {
                // Cambia el color del PictureBox cuando se hace clic
                CambiarColorDeBoton(pictureBox, Color.Green);
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private async void btnHabilitarFuncion_Click(object sender, EventArgs e)
        {

        }

        private async void FrmButacasDisponiblies_Load_1(object sender, EventArgs e)
        {
            await cargarPeliculas();          
        }
        private async Task cargarPeliculas()
        {
            string url = string.Format("https://localhost:7011/Peliculas");
            var data = await
            ClienteSingleton.GetInstance().GetAsync(url);
            List<Peliculas> peliculas = JsonConvert.DeserializeObject<List<Peliculas>>(data);
            cboPelicula.DataSource = peliculas;
            cboPelicula.ValueMember = "TITULO";
            cboPelicula.DisplayMember = "ID_PELICULA";
            cboPelicula.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPelicula.SelectedItem = 1;
            
        }   

        private async void btnHabilitarFuncion_Click_1(object sender, EventArgs e)
        {
            if (cboPelicula.SelectedItem != null)
            {             
                await cargarComboFuncion(dtpDesde.Value.ToShortDateString(), cboPelicula.Text);
           
            }
        }
        private async Task cargarComboFuncion(string fecha, string pelicula)
        {
            try
            {
                var parametros = new Dictionary<string, string>
        {
            { "pelicula", pelicula },
            { "fechita", fecha }
        };
                //var contenido = JsonConvert.SerializeObject(parametros);
                //string url = $"https://localhost:7011/Traer_Funciones?pelicula={pelicula}&fechita={fecha}";

                //// Leer y deserializar los datos de la respuesta
                //var data = await ClienteSingleton.GetInstance().PostAsync(url, contenido);
                //List<Funciones> funcionesList = JsonConvert.DeserializeObject<List<Funciones>>(data);
                List<Funciones> funcionesList = dao.TraerFunciones(pelicula, fecha);
                cboFunciones.DataSource = funcionesList;
                cboFunciones.ValueMember = "IdFuncion";
                cboFunciones.DisplayMember = "Hora";
                cboFunciones.DropDownStyle = ComboBoxStyle.DropDownList;
                cboFunciones.SelectedItem = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
