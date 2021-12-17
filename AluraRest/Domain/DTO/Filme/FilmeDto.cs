using AluraRest.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.DTO.Filme
{
    public class FilmeDto
    {
        public string Titulo { get; set; }
        public string Diretor { get; set; }
        public int Duracao { get; set; }
        public int ClassificacaoEtaria { get; set; }
        public DateTime HoraDaConsulta { get; set; }

        public List<SessaoModel> Sessoes { get; set; }

    }
}
