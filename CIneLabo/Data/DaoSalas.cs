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
    public class DaoSalas
    {
        public List<Salas> ObtenerSalas(string pelicula, string fecha)
        {
            List<Salas> lSalas = new List<Salas>();
            DataTable table = DbHelper.GetInstancia().ConsultarConParametros("SP_OBTENER_SALAS", pelicula, fecha);

            foreach (DataRow fila in table.Rows)
            {
                int idSala = int.Parse(fila["ID_SALA"].ToString());
                int cantAsientos = int.Parse(fila["CANTIDAD_ASIENTOS"].ToString());

                Salas sala = new Salas(idSala, cantAsientos);
                lSalas.Add(sala);
            }

            return lSalas;
        }

    }
}
