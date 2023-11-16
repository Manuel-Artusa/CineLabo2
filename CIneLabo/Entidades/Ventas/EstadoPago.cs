namespace CIneLabo.Entidades.Ventas
{
    public class EstadoPago
    {
        public int IdEstadoPago { get; set; }
        public string Estado { get; set; }

        public EstadoPago()
        {
            IdEstadoPago = 0;
            Estado = string.Empty;
        }

        public EstadoPago(int id, string est)
        {
            IdEstadoPago = id;
            Estado = est;
            
        }
    }
}