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
    public class DaoFuncion
    {
        public List<Peliculas> TraerPeliculas()
        {
            List<Peliculas> lpeliculas = new List<Peliculas>();

            DataTable peliculas = DbHelper.GetInstancia().Consultar("SP_CONSULTAR_PELICULAS");
            foreach (DataRow r in peliculas.Rows)
            {
                Peliculas p = new Peliculas();
                //Los IF son para que no me acpete valores Nulos

                if (int.TryParse(r["ID_PELICULA"].ToString(), out int id))
                    p.IdPelicula = id;

                p.Titulo = r["TITULO"].ToString();

                if (int.TryParse(r["ID_GENERO"].ToString(), out int idGenero))
                    p.Genero.IdGenero = idGenero;

                if (DateTime.TryParse(r["DURACION"].ToString(), out DateTime duracion))
                    p.Duracion = duracion;

                if (int.TryParse(r["ID_CLASIFICACION"].ToString(), out int idClasificacion))
                    p.clasificacion.Id_clasificacion = idClasificacion;

                if (int.TryParse(r["ID_IDIOMA"].ToString(), out int idIdioma))
                    p.Idioma.Id_Idioma = idIdioma;

                if (int.TryParse(r["ID_PAIS_ORIGEN"].ToString(), out int idPais))
                    p.IdPais.IdPais = idPais;

                lpeliculas.Add(p);
            }

            return lpeliculas;
        }

        public Peliculas TraerPeliculaPorId(int idPelicula)
        {
            List<Peliculas> lpeliculas = TraerPeliculas();
            Peliculas peliculaEncontrada = lpeliculas.FirstOrDefault(p => p.IdPelicula == idPelicula);
            return peliculaEncontrada;

        }
        public List<Funciones> ObtenerFuncion(string pelicula, string fechaf, int sala)
        {
            List<Funciones> lFunciones = new List<Funciones>();

            DataTable funciones = DbHelper.GetInstancia().ConsultarConParametrosFunciones("SP_CONSULTAR_FUNCIONES", pelicula, fechaf, sala);
            foreach (DataRow r in funciones.Rows)
            {
                Funciones f = new Funciones();
                //Los IF son para que no me acpete valores Nulos

                if (int.TryParse(r["ID_FUNCION"].ToString(), out int idFuncion))
                    f.IdFuncion = idFuncion;

                if (DateTime.TryParse(r["HORA"].ToString(), out DateTime hora))
                    f.Hora = hora;

                if (DateTime.TryParse(r["FECHA"].ToString(), out DateTime fecha))
                    f.Fecha = fecha;

                if (int.TryParse(r["ID_PELICULA"].ToString(), out int idPelicula))
                {
                    f.pelicula = TraerPeliculaPorId(idPelicula); // Agregar este método
                    f.pelicula.IdPelicula = idPelicula;
                }


                if (double.TryParse(r["PRECIO_ACTUAL"].ToString(), out double precio))
                    f.Precio = precio;

                lFunciones.Add(f);
            }

            return lFunciones;
        }

    }
}
