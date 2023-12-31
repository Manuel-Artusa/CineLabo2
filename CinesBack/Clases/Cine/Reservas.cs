﻿using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cines.Clases.Personas;

namespace Cines.Clases.Cine
{
    public class Reservas
    {
        public int IdReserva { get; set; }
        public Clientes Cliente { get; set; }
        public DateTime FechaReserva { get; set; }

        public Reservas()
        {
            IdReserva = 0;
            FechaReserva = DateTime.Now;
            Cliente = new Clientes();
        }
        public Reservas(int id, DateTime fecha, Clientes client)
        {
            IdReserva = id;
            FechaReserva = fecha;
            Cliente = client;
            
        }
    }
}
