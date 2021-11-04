using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyEvent.Models
{
    public class Evento
    {
        [Key]
        public int PKEvento { get; set; }
        public string Nome { get; set; }
        public string DataEvento { get; set; }
        public string Horario { get; set; }
        public int IdadeMinima { get; set; }
        public int FkLocal { get; set; }
        public int FkUsuario { get; set; }
    }
}
