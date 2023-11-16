using CIneLabo.Data;
using CIneLabo.Data.DBHelper;
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
    public partial class FrmActualizacionPrecio : Form
    {
        public FrmActualizacionPrecio()
        {
            InitializeComponent();
        }

        private void FrmActualizacionPrecio_Load(object sender, EventArgs e)
        {
            cargarvalordolar();
        }

        private void cargarvalordolar()
        {
            string sp = "ObtenerUltimoValorDolar";
            DataTable dt = DbHelper.GetInstancia().Consultar(sp);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sp = "AjustarPreciosPorDolar";
            List<Parametro> lst = new List<Parametro>();
            lst.Add(new Parametro("@ValorDolarAntes", txtDolarAntes.Text));
            lst.Add(new Parametro("@ValorDolarActual", txtValorDolarActual.Text));
            DataTable table = DbHelper.GetInstancia().Consultar(sp, lst);
        }
    }
}
