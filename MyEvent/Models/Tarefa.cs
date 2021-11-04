using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyEvent.Models
{
    public class Tarefa
    {
        [Key]
        public int PKTarefa { get; set; }
        public string Descricao { get; set; }
        public bool FoiRealizado { get; set; }
        public int FKEvento { get; set; }
    }
}
