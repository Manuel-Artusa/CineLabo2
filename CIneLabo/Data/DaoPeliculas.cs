using CIneLabo.Data.DBHelper;
using CIneLabo.Entidades.Cine;
using CIneLabo.Entidades.Ubicacion;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIneLabo.Data
{
    public class DaoPeliculas
    {
        public List<Peliculas> ObtenerPeliculas()
        {
            List<Peliculas>lPeliculas = new List<Peliculas>();
            DataTable table = DbHelper.GetInstancia().Consultar("SP_CONSULTAR_PELICULAS_DETALLADO2");

            foreach (DataRow fila in table.Rows)
            {
                int idPeli = int.Parse(fila["ID_PELICULA"].ToString());
                string titulo = fila["TITULO"].ToString();
                DateTime duracion = DateTime.Parse(fila["Duracion"].ToString());
                
                int idGenero = int.Parse(fila["id_genero"].ToString());
                string nombreGenero = fila["NombreGenero"].ToString();
                Genero genero = new Genero(idGenero, nombreGenero);

                int idClasificacion = int.Parse(fila["id_clasificacion"].ToString());
                string descripcion = fila["DescripcionClasificacion"].ToString();  // Ajusta el nombre del campo según tu base de datos
                Clasificacion clasificacion = new Clasificacion(idClasificacion, descripcion);

                int idIdioma = int.Parse(fila["id_idioma"].ToString());
                string lenguaje = fila["Lenguaje"].ToString();  // Ajusta el nombre del campo según tu base de datos
                Idioma idioma = new Idioma(idIdioma, lenguaje);

                DateTime fecEstreno = DateTime.Parse(fila["Fec_Estreno"].ToString());
                ;

                Peliculas pelicula = new Peliculas(idPeli, titulo, duracion, genero, clasificacion, idioma, fecEstreno);
                lPeliculas.Add(pelicula);
            }
            return lPeliculas;
        }
        
    }
}
