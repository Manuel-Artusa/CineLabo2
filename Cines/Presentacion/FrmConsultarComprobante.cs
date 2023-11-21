using Cines.Clases.Personas;
using Cines.Clases.Ventas;
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
    public partial class FrmConsultarComprobante : Form
    {
        IDao dao;
        Clientes cliente;
        Comprobantes c;     
        private async Task eliminarComprobante(int id)
        {
            string Json = JsonConvert.SerializeObject(id);
            string url = "https://localhost:7028/BorrarComprobantes";
            var data = await ClienteSingleton.GetInstance().PutAsync(url, Json);
            MessageBox.Show(data, "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dgvComprobantes.Rows.Clear();
            await CargarDGV();
            btnCargar.Enabled = true;
            btnCargar.Enabled = false;
            btnElminar.Enabled = false;
            btnModificar.Enabled = false;
        }
        private void obtenerComprobantes()
        {
            if(txtCliente.Text == "")
            {
                MessageBox.Show("INGRESE UN CLIENTE", "ERROR");
                return;
            }
            if(txtDoc.Text == string.Empty)
            {
                MessageBox.Show("INGRESE UN CLIENTE", "ERROR");
                return;
            }
            int nroDoc = Convert.ToInt32(txtDoc.Text);
            List<Comprobantes> lista = dao.obtenerComprobantesParametros(nroDoc, txtCliente.Text);
        }
        private async Task<List<Comprobantes>> CargarDGV()
        {
            //Cargar DGV
            //string url = "https://localhost:7028/getComprobantes";
            //var data = await ClienteSingleton.GetInstance().GetAsync(url);
            //List<Comprobantes> lstComprobantes = JsonConvert.DeserializeObject<List<Comprobantes>>(data);
            int nroDoc = Convert.ToInt32(txtDoc.Text);
            List<Comprobantes> lista = dao.obtenerComprobantesParametros(nroDoc, txtCliente.Text);

            foreach (Comprobantes c in lista)
            {
                
                dgvComprobantes.Rows.Add(new object[] { c.IdComprobante, cliente.persona.Apellido, c.fecha, "Eliminar Comprobante" });
            }
            return lista;
        }
        public FrmConsultarComprobante()
        {
            InitializeComponent();
            dao = new DaoCine();
            c = new Comprobantes();
        }

        private void FrmConsultarComprobante_Load(object sender, EventArgs e)
        {

        }
        private async Task editarComprobante(Comprobantes comprobantes)
        {
            string Json = JsonConvert.SerializeObject(comprobantes);
            string url = "https://localhost:7028/editarComprobante";
            var data = await ClienteSingleton.GetInstance().PutAsync(url, Json);
            MessageBox.Show(data, "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private async void btnCargar_Click(object sender, EventArgs e)
        {
            cliente = new Clientes();
            cliente.NroDocumento = Convert.ToInt32(txtDoc.Text);
            cliente.persona.Apellido = txtCliente.Text;
            await CargarDGV();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private async void btnElminar_Click(object sender, EventArgs e)
        {
            int nro = Convert.ToInt32(txtNroComprobante.Text);
            eliminarComprobante(nro);

        }

        private void dgvComprobantes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
    }
}
