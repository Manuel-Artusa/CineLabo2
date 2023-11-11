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
    public class DaoFunciones
    {
/*        public List<Funciones> TraerFunciones()
        {
            List<Funciones> lFunciones = new List<Funciones>();

            DataTable funciones = DbHelper.GetInstancia().Consultar("SP_CONSULTAR_FUNCIONES");
            foreach (DataRow r in funciones.Rows)
            {
                int idFuncion = Convert.ToInt32(r["ID_FUNCION"].ToString());
                DateTime hora = (DateTime)r["HORA"];
                DateTime fecha = (DateTime)r["FECHA"];
                int idSala = Convert.ToInt32(r["ID_SALA"].ToString());
                int idPelicula = Convert.ToInt32(r["ID_PELICULA"].ToString());
                double precioActual = Convert.ToDouble(r["PRECIO_ACTUAL"].ToString());
                int idTipo_Formato = 0;
                Funciones f = new Funciones(idFuncion, hora, fecha, idSala, idPelicula, precioActual, idTipo_Formato);
                lFunciones.Add(f);
            }
            return lFunciones;
        }*/

    }
}
