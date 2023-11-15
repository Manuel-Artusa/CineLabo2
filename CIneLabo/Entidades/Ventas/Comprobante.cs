using CIneLabo.Entidades.Personas;
using CIneLabo.Entidades.Cine;



namespace CIneLabo.Entidades.Ventas
{
    public class Comprobantes
    {
        public int IdComprobante { get; set; }
        public Cliente cliente { get; set; }
        public Empleados empleado { get; set; }
        public DateTime fecha { get; set; }
        public Cines cine { get; set; }
        public FormaCompra forma { get; set; }

        public EstadoPago estado { get; set; }

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