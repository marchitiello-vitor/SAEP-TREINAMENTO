using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SAEP_vitor.Models
{
    public class Comentarios
    {
        public int Id { get; set; }
        public string Comentario { get; set; }

        [ForeignKey("Perfis")]
        public int IdPerfil { get; set; }
        public Perfis Perfis { get; set; }

        [ForeignKey("Equipamentos")]
        public Equipamentos Equipamento { get; set; }
        public DateTime Data { get; set; }

    }
}
