namespace CIneLabo.Entidades.Personas
{

    public class Cliente
    {
        private int IdCliente { get; set; }
        private Persona persona { get; set; }
        private TipoDocumentos documento { get; set; }
        private int NroDocumento { get; set; }
        private int Telefono { get; set; }
        private string Mail { get; set; }

        public Cliente()
        {
            IdCliente = 0;
            persona = new Persona();
            documento = new TipoDocumentos();
            NroDocumento = 0;
            Telefono = 0;
            Mail = string.Empty;
        }
        public Cliente(int id, Persona pers, TipoDocumentos doc, int nroD, int tel, string email)
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