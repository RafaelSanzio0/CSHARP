using AluraRest.Models;
using FilmesAPI.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.DTO.Sessao
{
    public class ResultUpdateSessaoDto
    {
        public int id { get; set; }
        public FilmeModel Filme { get; set; }
        public CinemaModel Cinema { get; set; }
        public DateTime HorarioDeEncerramento { get; set; }
        public DateTime HorarioDeInicio { get; set; }
        public DateTime UpdateAt { get; set; }
    }
}
