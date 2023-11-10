namespace CIneLabo.Entidades.Personas
{
    public class TipoDocumentos
    {
        public int IdTipoDocumento { get; set; }
        public string Tipo { get; set; }

        public TipoDocumentos()
        {
            IdTipoDocumento = 0;
            Tipo = string.Empty;
        }
        public TipoDocumentos(int id, string tipo)
        {
            IdTipoDocumento = id;
            Tipo = tipo;
            
        }
    }
}