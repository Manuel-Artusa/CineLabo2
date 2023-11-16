using CIneLabo.Data.DBHelper;
using CIneLabo.Entidades.Cine;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIneLabo.Data
{
    public class DaoButacas
    {
        public List<Butacas> ObtenerButacas(string pelicula, string fechaf, int salab, int funciones)
        {
            List<Butacas> lButacas = new List<Butacas>();

            DataTable table = DbHelper.GetInstancia().ConsultarConParametrosButacas("SP_CONSULTAR_BUTACAS", pelicula, fechaf, salab, funciones);
            foreach (DataRow r in table.Rows)
            {
                Butacas b = new Butacas();
                //Los IF son para que no me acpete valores Nulos

                int idButaca = int.Parse(r["ID_BUTACA"].ToString());
                int nroButaca = int.Parse(r["NRO_BUTACA"].ToString());
                int fila = int.Parse(r["FILA"].ToString());
                int idSala = int.Parse(r["ID_SALA"].ToString());
                int cantAsientos = int.Parse(r["CANTIDAD_ASIENTOS"].ToString());  // Ajusta el nombre del campo según tu base de datos
                Salas sala = new Salas(idSala, cantAsientos);
                Butacas butacas = new Butacas(idButaca,nroButaca,fila,sala);
                lButacas.Add(butacas);
            }

            return lButacas;
        }

    }
}
