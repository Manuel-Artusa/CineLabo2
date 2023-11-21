using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cines.Clases.Cine;
using Cines.Clases.Cines;
using Cines.Clases.Cines.Cine;
using CinesBack.Clases.Candy_Bar;

namespace Cines.Clases.Ventas
{
    public class DetalleComprobante
    {
        public int IdDetalleComprobante { get; set; }
        public Funciones funcione { get; set; }
        public Butacas butaca { get; set; }
        public Peliculas peliculas { get; set; }

        public FormaPago formaPago { get; set; }
        public VentasCandyBar CandyBar { get; set; }
        //public ButacasSalas butacasala { get; set; }
        public double precio { get; set; }

        public DetalleComprobante()
        {
            IdDetalleComprobante = 0;
            CandyBar = new VentasCandyBar();
            funcione = new Funciones();
            butaca = new Butacas();
            peliculas = new Peliculas();
            formaPago = new FormaPago();
            precio = 0;
        }
        public DetalleComprobante(int id, Comprobantes comp, Funciones fun, Butacas bxf, FormaPago forma, double pre)
        {
            IdDetalleComprobante = id;
            
            funcione = fun;
            butaca = bxf;
            formaPago = forma; 
            precio = pre;
        }
    }
}
