﻿using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CIneLabo.Entidades.Personas;

namespace CIneLabo.Entidades.Cine
{
    public class Reservas
    {
        public int IdReserva { get; set; }
        public Cliente Cliente { get; set; }
        public DateTime FechaReserva { get; set; }

        public Reservas()
        {
            IdReserva = 0;
            FechaReserva = DateTime.Now;
            Cliente = new Cliente();
        }
        public Reservas(int id, DateTime fecha, Cliente client)
        {
            IdReserva = id;
            FechaReserva = fecha;
            Cliente = client;
            
        }
    }
}
