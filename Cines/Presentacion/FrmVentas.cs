using System;
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




    public partial class FrmVentas : Form
    {
        private Dictionary<Button, int> cambiosPorBoton = new Dictionary<Button, int>();
        private bool esRojo = false;

        public FrmVentas()
        {
            InitializeComponent();
            AsignarManejadoresEventos();
        }

        private void CambiarColorBoton(Button boton)
        {
            if (cambiosPorBoton.ContainsKey(boton) && cambiosPorBoton[boton] > 0)
            {
                boton.BackColor = (esRojo) ? Color.Red : Color.White;
                esRojo = !esRojo;
                cambiosPorBoton[boton]--;
            }
        }

        private void AsignarManejadoresEventos()
        {
            // Asigna el mismo manejador de eventos a los botones btnS1 a btnS18
            for (int i = 1; i <= 18; i++)
            {
                Button boton = this.Controls.Find("btnS" + i, true).FirstOrDefault() as Button;
                if (boton != null)
                {
                    cambiosPorBoton[boton] = 0; // Inicializa con 0 cambios
                    boton.Click += (sender, e) => CambiarColorBoton(boton);
                }
            }
        }

        private void nudCantidad_ValueChanged(object sender, EventArgs e)
        {
            if (nudCantidad.Value < 0)
            {
                MessageBox.Show("La cantidad no puede ser un valor negativo.");
                nudCantidad.Value = 0;
            }

            foreach (Button boton in cambiosPorBoton.Keys)
            {
                cambiosPorBoton[boton] = (int)nudCantidad.Value;
            }
        }
    }
}
