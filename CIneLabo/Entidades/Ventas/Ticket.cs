using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CIneLabo.Entidades.Cine;

namespace CIneLabo.Entidades.Ventas
{
    public class Ticket
    {
        public int IdTicket { get; set; }
        public Comprobantes comprobante { get; set; }
        public Butacas butaca { get; set; }
        public Funciones funcion { get; set; }
        public double Precio { get; set; }

        public Ticket()
        {
            IdTicket = 0;
            comprobante = new Comprobantes();
            funcion = new Funciones();
            butaca = new Butacas();
            Precio = 0;
        }

        public Ticket(int id, Comprobantes comp, Butacas but, Funciones func, double pre)
        {
            IdTicket = id;
            comprobante = comp;
            funcion = func;
            butaca = but;
            Precio = pre;
            
        }
    }
}
