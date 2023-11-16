namespace CIneLabo.Entidades.Cine
{
    public class Salas
    {
        public int IdSala { get; set; }
        public int Numero { get; set; }

        public Salas()
        {
            IdSala = 0;
            Numero = 0;
        }
        public Salas(int id, int nro)
        {
            IdSala = id;
            Numero = nro;
             
        }
    }
}