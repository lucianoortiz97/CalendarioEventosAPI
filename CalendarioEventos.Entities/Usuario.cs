using System;
using System.Collections.Generic;

namespace CalendarioEventos.Entities
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public List<Evento> Eventos { get; set; } = new List<Evento> ();
    }
}   