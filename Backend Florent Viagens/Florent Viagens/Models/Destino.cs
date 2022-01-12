using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Florent_Viagens.Models
{
    public class Destino
    {

        [Key]
        public int Id { get; set; }

        [Required]
        public string Descricao { get; set; }

        
    }
}
