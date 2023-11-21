using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cines.Clases.Cine;
using Cines.Clases.Cines.Cine;
using Cines.Clases.Personas;
using Cines.Clases.Ventas;
using CinesFront.Http;
using CinesFront.Presentacion;
using Newtonsoft.Json;
using SistemaCineBack.Acceso_a_Datos.Dao;

namespace CineApp.Forms
{
    public partial class frmComprarEntrada : Form
    {
        private bool ClickEnBoton = false;
        private Color originalColor;
        private Butacas butaca;
        private IDao dao;
        private Dictionary<int, PictureBox> diccionarioPictureBox;

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

        private async void frmComprarEntrada_Load_1(object sender, EventArgs e)
        {
            habilitar();
            limpiarCampos();
           await cargarPeliculas();
            lblTotal.Text = "10.50";
        }
        private void cargarFuncioneS(string p, string fecha)
        {
            List<Funciones> funcionesList = dao.TraerFunciones(p, fecha);
            cbFuncion.DataSource = funcionesList;
            cbFuncion.ValueMember = "IdFuncion";
            cbFuncion.DisplayMember = "Hora";
            cbFuncion.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFuncion.SelectedItem = null;
        }
        private async Task cargarPeliculas()
        {
            string url = string.Format("https://localhost:7011/Peliculas");
            var data = await ClienteSingleton.GetInstance().GetAsync(url);
            List<Peliculas> peliculas = JsonConvert.DeserializeObject<List<Peliculas>>(data);
            cbPelicula.DataSource = peliculas;
            cbPelicula.ValueMember = "TITULO";
            cbPelicula.DisplayMember = "ID_PELICULA";
            cbPelicula.DropDownStyle = ComboBoxStyle.DropDownList;
            cbPelicula.SelectedItem = 1;

        }
        private bool grabar(Comprobantes c, Clientes cl)
        {
            //string Json = JsonConvert.SerializeObject(c);
            //string url = "https://localhost:7028/InsertarComprobante";
            //var data = await ClienteSingleton.GetInstance().PostAsync(url, Json);
            //MessageBox.Show(data, "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
             return dao.crear(c, cl);
        }
        private void limpiarCampos()
        {
            txtCorreo.Text = String.Empty;
            txtDNI.Text = String.Empty;
            txtTelefono.Text = String.Empty;
            tbApellido.Text = String.Empty;
            tbNombre.Text = String.Empty;
            cbFuncion.SelectedIndex = -1;
            cbFuncion.Enabled = false;
            cbPelicula.SelectedIndex = -1;
        }
        private void btnConfirmar_Click_1(object sender, EventArgs e)
        {
            Comprobantes c = new Comprobantes();
            Clientes cl = new Clientes();
            DetalleComprobante d = new DetalleComprobante();

            cl.persona.Nombre = tbNombre.Text;
            cl.persona.Apellido = tbApellido.Text;
            cl.NroDocumento = (int)Convert.ToInt64(txtDNI.Text);
            cl.Telefono = (int)Convert.ToInt64(txtTelefono.Text);
            cl.Mail = txtCorreo.Text;

            c.fecha = DateTime.Today;

            d.funcione.IdFuncion = 5;
            d.funcione.sala.IdSala = 4;
            d.funcione.Precio = Convert.ToDouble(lblTotal.Text);
            c.detalle.Add(d);          
            Butacas b = new Butacas();
            if (pbButaca1.Focused)
                b.IdButaca = 1;
            if (pbButaca1.Focused)
                b.IdButaca = 2;
            if (pbButaca1.Focused)
                b.IdButaca = 3;
            if (pbButaca1.Focused)
                b.IdButaca = 4;
            if (pbButaca1.Focused)
                b.IdButaca = 5;
            if (pbButaca1.Focused)
                b.IdButaca = 6;
            if (pbButaca1.Focused)
                b.IdButaca = 7;
            if (pbButaca1.Focused)
                b.IdButaca = 8;
            if (pbButaca1.Focused)
                b.IdButaca = 9;
            if (pbButaca1.Focused)
                b.IdButaca = 10;
            if (pbButaca1.Focused)
                b.IdButaca = 11;
            if (pbButaca1.Focused)
                b.IdButaca = 12;
            if (pbButaca1.Focused)
                b.IdButaca = 13;
            if (pbButaca1.Focused)
                b.IdButaca = 14;
            if (pbButaca1.Focused)
                b.IdButaca = 15;
            if (pbButaca1.Focused)
                b.IdButaca = 16;
            if (pbButaca1.Focused)
                b.IdButaca = 17;
            if (pbButaca1.Focused)
                b.IdButaca = 18;


            b.IdButaca = 1;
            Salas s = new Salas();
            s.agregarButacas(b);

            if(grabar(c, cl) == true)
                MessageBox.Show("Exito en la compra", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pbButaca2_Click(object sender, EventArgs e)
        {

        }

        private void pbButaca1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Desea Salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                this.Dispose();
        }
        private void habilitar()
        {
            txtCorreo.Enabled = true;
            txtDNI.Enabled = true;
            txtTelefono.Enabled = true;
            tbApellido.Enabled = true;
            tbNombre.Enabled = true;
            cbFuncion.Enabled = true;
            cbPelicula.Enabled = true;
            pbButaca1.Enabled = true;
            pbButaca2.Enabled = true;
            pbButaca3.Enabled = true;
            pbButaca4.Enabled = true;
            pbButaca5.Enabled = true;
            pbButaca6.Enabled = true;
            pbButaca7.Enabled = true;
            pbButaca8.Enabled = true;
            pbButaca9.Enabled = true;
            pbButaca10.Enabled = true;
            pbButaca11.Enabled = true;
            pbButaca12.Enabled = true;
            pbButaca13.Enabled = true;
            pbButaca14.Enabled = true;
            pbButaca15.Enabled = true;
            pbButaca16.Enabled = true;
            pbButaca17.Enabled = true;
            pbButaca18.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cargarFuncioneS(cbPelicula.Text, dtpFecha.Value.ToShortDateString());
            cbFuncion.Enabled=true;
        }

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }
    }
}
