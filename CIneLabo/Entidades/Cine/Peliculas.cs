using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CIneLabo.Entidades.Ubicacion;

namespace CIneLabo.Entidades.Cine
{
    public class Peliculas
    {
        public int IdPelicula { get; set; }
        public string Titulo { get; set; }
        private DateTime Duracion { get; set; }
        private Genero Genero { get; set; }
        private Clasificacion clasificacion { get; set; }

        private Idioma Idioma { get; set; }
        private DateTime Fec_Estreno { get; set; }
        

        public Peliculas()
        {
            IdPelicula = 0;
            Titulo = string.Empty;
            Duracion = DateTime.Now;
            Genero = new Genero();
            clasificacion = new Clasificacion();
            Idioma = new Idioma();
            Fec_Estreno = DateTime.Now;
            
        }
        public Peliculas(int id, string title, DateTime dur, Genero gen, Clasificacion clasf, Idioma idiom, DateTime estreno)
        {
            IdPelicula = id;
            Titulo = title;
            Duracion = dur;
            Genero = gen;
            clasificacion = clasf;
            Idioma = idiom;
            Fec_Estreno = estreno;
            
        }
    }
}
