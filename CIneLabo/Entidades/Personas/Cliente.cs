namespace CIneLabo.Entidades.Personas
{

    public class Cliente
    {
        public int IdCliente { get; set; }
        public Persona Persona { get; set; }
        public TipoDocumentos documento { get; set; }
        public int NroDocumento { get; set; }
        public int Telefono { get; set; }
        public string Mail { get; set; }

        public Cliente()
        {
            IdCliente = 0;
            Persona = new Persona();
            documento = new TipoDocumentos();
            NroDocumento = 0;
            Telefono = 0;
            Mail = string.Empty;
        }
        public Cliente(int id, Persona pers, TipoDocumentos doc, int nroD, int tel, string email)
        {
            IdCliente = id;
            Persona = pers;
            documento = doc;
            NroDocumento = nroD;
            Telefono = tel;
            Mail = email;

        }
    }
}