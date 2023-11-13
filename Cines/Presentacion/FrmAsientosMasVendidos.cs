using Cines.Acceso_a_Datos.Factory;
using Cines.Clases.Cines.Cine;
using SistemaCineBack.Acceso_a_Datos.Dao;
using System;
using System.Collections;
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
    public partial class FrmAsientosMasVendidos : Form
    {
        private IDao dao = null;
        private Dictionary<int, PictureBox> diccionarioPictureBox = new Dictionary<int, PictureBox>();
        public FrmAsientosMasVendidos(aFactoria factoria, int nro)
        {
            InitializeComponent();
            dao = factoria.crearDao();
            EnlazarButacasConNumeritos();



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
        public void MostrarButacasDisponibles()
        {
            DateTime fechaSeleccionada = dtpDesde.Value;
            string peliculaSelccionada = cboPelicula.SelectedItem.ToString();
            List<Butacas> butacas = new List<Butacas>();
             butacas = dao.TraerButacas(fechaSeleccionada, peliculaSelccionada, TimeSpan.Zero);
            foreach (Butacas b in butacas )
            {//Metodo para que me pinte de color las butacas que esten disponibles
                PictureBox PB = new PictureBox();
                PB.BackColor = Color.DarkGreen;
                if (butacas.Contains(b))
                {
                    PB.BackColor = Color.DarkGreen;
                }
                else
                {
                    PB.BackColor = Color.DarkRed;
                }

                // Agrega el PictureBox al Frm


            }
        }

        public FrmAsientosMasVendidos()
        {
        }

        private void FrmAsientosMasVendidos_Load(object sender, EventArgs e)
        {

            cboPelicula.DataSource = dao.TraerPeliculas();
            cboFunciones.DataSource = dao.TraerFunciones("",dtpDesde.Value.ToShortDateString());
            cboFunciones.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPelicula.DropDownStyle = ComboBoxStyle.DropDownList;


        }

        private void cboPelicula_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
                


        }

        private void dtpDesde_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
