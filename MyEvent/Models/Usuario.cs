using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyEvent.Models
{
    public class Usuario
    {
        [Key]
        public int PKUsuario { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
    }
}
