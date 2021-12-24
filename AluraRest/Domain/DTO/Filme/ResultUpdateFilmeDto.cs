using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Dto.Filme
{
    public class ResultUpdateFilmeDto
    {
        public int Id { get; set; }

        public string Titulo { get; set; }

        public string Diretor { get; set; }

        public string Genero { get; set; }

        public int Duracao { get; set; } //tem que ter 60min de duracao

        public DateTime HoraDaConsulta { get; set; }
        public int ClassificacaoEtaria { get; set; }

        public DateTime UpdateAt { get; set; }
    }
}
