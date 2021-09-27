using FilmesAPI.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

 // classe referente a uma tabela de relacionamento entre N to N filme e cinema

namespace AluraRest.Models
{
    public class Sessao
    {
        [Key]
        [Required]
        public int Id { get; set; }
        public virtual Cinema Cinema { get; set; } // isso é ignorado no momemnto da criacao do banco
        public virtual Filme Filme { get; set; } // isso tbm
        public int FilmeId { get; set; }
        public int CinemaId { get; set; }
        public DateTime HorarioDeEncerramento { get; set; }
    }
}
