using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AluraRest.Data.DTO
{
    public class ResultCreateFilmeDto
    {
      
        public int Id { get; set; }

        public string Titulo { get; set; }

        public string Diretor { get; set; }

        public string Genero { get; set; }

        public int Duracao { get; set; } //tem que ter 60min de duracao

        public DateTime HoraDaConsulta { get; set; }
        public int ClassificacaoEtaria { get; set; }

        public DateTime CreateAt { get; set; }

    }
}
