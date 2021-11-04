using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyEvent.Models
{
    public class Gasto
    {
        [Key]
        public int PKGasto { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public int FKEvento { get; set; }
    }
}
