using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SAEP_vitor.Models
{
    public class Perfis
    {
        [Key]
        public int Id { get; set; }
        public string perfil { get; set; }
        public ICollection<Usuarios> Usuarios { get; set; }
        public ICollection<Comentarios> Comentarios { get; set; } 

    }
}
