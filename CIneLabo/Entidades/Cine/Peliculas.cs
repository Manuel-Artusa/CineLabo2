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
        public DateTime Duracion { get; set; }
        public Genero Genero { get; set; }
        public Clasificacion clasificacion { get; set; }

        public Idioma Idioma { get; set; }
        public DateTime Fec_Estreno { get; set; }
        
        
        public Pais IdPais { get; set; }

        public Peliculas()
        {
            IdPelicula = 0;
            Titulo = string.Empty;
            Duracion = DateTime.Now;
            Genero = new Genero();
            clasificacion = new Clasificacion();
            Idioma = new Idioma();
            Fec_Estreno = DateTime.Now;
            IdPais = new Pais();
            
        }
        public Peliculas(int id, string title, DateTime dur, Genero gen, Clasificacion clasf, Idioma idiom, DateTime estreno, Pais pais)
        {
            IdPelicula = id;
            Titulo = title;
            Duracion = dur;
            Genero = gen;
            clasificacion = clasf;
            Idioma = idiom;
            Fec_Estreno = estreno;
            IdPais = pais;
            
        }
    }
}
