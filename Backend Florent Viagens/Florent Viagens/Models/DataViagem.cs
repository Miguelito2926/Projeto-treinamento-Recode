using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Florent_Viagens.Models
{
    public class DataViagem
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public DateTime Data { get; set; }

        [Required]
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }


        [Required]
        public int DestinoId { get; set; }
        public Destino Destino { get; set; }


    }
}
