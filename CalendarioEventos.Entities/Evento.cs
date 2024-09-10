using System;
using System.Collections.Generic;

namespace CalendarioEventos.Entities
{
    public class Evento
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public DateTime Fecha { get; set; }
        public string Categoria { get; set; }
        public int UsuarioId { get; set; } 
        public bool EsRecordatorio { get; set; }
        public DateTime? FechaRecordatorio { get; set; }  
    }
}
