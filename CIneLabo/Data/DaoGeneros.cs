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
    public class DaoGeneros
    {
        public List<Genero> ObtenerGeneros()
        {
            List<Genero> lGeneros = new List<Genero>();
            DataTable table = DbHelper.GetInstancia().Consultar("SP_OBTENER_GENEROS");

            foreach (DataRow fila in table.Rows)
            {
                int idGenero = int.Parse(fila["ID_GENERO"].ToString());
                string descripcion = fila["DESCRIPCION"].ToString();

                Genero genero = new Genero(idGenero, descripcion);
                lGeneros.Add(genero);
            }

            return lGeneros;
        }

    }
}
