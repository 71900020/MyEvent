using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyEvent.Models
{
    public class Convidado
    {
        [Key]
        public int PKConvidado { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public int FKEvento { get; set; }
    }
}
