﻿using Cines.Clases.Cine;
using Cines.Clases.Personas;

namespace Cines.Clases.Ventas
{
    public class Comprobantes
    {
        public int IdComprobante { get; set; }
        public Clientes cliente { get; set; }
        public Empleados empleado { get; set; }
        public DateTime fecha { get; set; }
        public CineClase cine { get; set; }
        public FormaCompra forma { get; set; }
        public List<DetalleComprobante> Detalle { get; set; }


        public Comprobantes()
        {
            IdComprobante = 0;
            cliente = new Clientes();
            empleado = new Empleados();
            fecha = DateTime.Now;
            cine = new CineClase();
            forma = new FormaCompra();
            Detalle = new DetalleComprobante();

        }
        public Comprobantes(int id, Clientes cli, Empleados emp,DateTime fec, CineClase cin, FormaCompra form, DetalleComprobante det)
        {
            IdComprobante = id;
            cliente = cli;
            empleado = emp;
            fecha = fec;
            cine = cin;
            forma = form;
            Detalle = det;
        }

    }
}