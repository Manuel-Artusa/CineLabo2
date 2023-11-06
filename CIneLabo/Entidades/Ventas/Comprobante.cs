using CIneLabo.Entidades.Personas;
using CIneLabo.Entidades.Cine;



namespace CIneLabo.Entidades.Ventas
{
    internal class Comprobantes
    {
        private int IdComprobante { get; set; }
        private Cliente cliente { get; set; }
        private Empleados empleado { get; set; }
        private DateTime fecha { get; set; }
        private Cines cine { get; set; }
        private FormaCompra forma { get; set; }

        private EstadoPago estado { get; set; }

        public Comprobantes()
        {
            IdComprobante = 0;
            cliente = new Cliente();
            empleado = new Empleados();
            fecha = DateTime.Now;
            cine = new Cines();
            forma = new FormaCompra();
            estado = new EstadoPago();

        }
        public Comprobantes(int id, Cliente cli, Empleados emp,DateTime fec, Cines cin, FormaCompra form, EstadoPago est)
        {
            IdComprobante = id;
            cliente = cli;
            empleado = emp;
            fecha = fec;
            cine = cin;
            forma = form;
            estado = est;
        }

    }
}