using CIneLabo.Data.DBHelper.Ventas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIneLabo.Presentacion
{
    public partial class FrmInformeDeVentasPorMes : Form
    {
        IDaoInformeVentas dao;
        public FrmInformeDeVentasPorMes()
        {
            InitializeComponent();
            dao = new DaoInformeVentas();
        }

        private void FrmInformeDeVentasPorMes_Load(object sender, EventArgs e)
        {

        }

        private void btnGenerarInforme_Click(object sender, EventArgs e)
        {
            DateTime fechaIncio = dateTimePicker1.Value;
            DateTime fechaFin = dateTimePicker2.Value;
            DataTable datosInforme =dao.ObtenerDatosInformeVentasPorMes(fechaIncio,fechaFin);

            // Asignar al DataGridView
            if (datosInforme != null)
            {
                dataGridView1.DataSource = datosInforme;
            }
        }
    }
}
