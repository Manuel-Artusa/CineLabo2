﻿namespace Cines.Clases.Cine
{
    public class Salas
    {
        public int IdSala { get; set; }
        public int Numero { get; set; }

        public TipoSala tipo { get; set; }

        public int Asientos { get; set; }

        public CineClase cine { get; set; }

        public Salas()
        {
            IdSala = 0;
            Numero = 0;
            tipo = new TipoSala();
            Asientos = 0;
            cine = new CineClase();
        }
        public Salas(int id, int nro, TipoSala tip, int asient, CineClase cin)
        {
            IdSala = id;
            Numero = nro;
            tipo = tip;
            Asientos = asient;
            cine = cin;
             
        }
    }
}