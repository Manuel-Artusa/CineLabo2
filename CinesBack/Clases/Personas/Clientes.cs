namespace Cines.Clases.Personas
{
    public class Clientes
    {
        public int IdCliente { get; set; }
        public Persona persona { get; set; }
        public TipoDocumentos documento { get; set; }
        public int NroDocumento { get; set; }
        public int Telefono { get; set; }
        public string Mail { get; set; }

        public Clientes()
        {
            IdCliente = 0;
            persona = new Persona();
            documento = new TipoDocumentos();
            NroDocumento = 0;
            Telefono = 0;
            Mail = string.Empty;
        }
        public Clientes(int id, Persona pers, TipoDocumentos doc, int nroD,int tel, string email)
        {
            IdCliente = id;
            persona = pers;
            documento = doc;
            NroDocumento = nroD;
            Telefono = tel;
            Mail = email;
            
        }
    }
}