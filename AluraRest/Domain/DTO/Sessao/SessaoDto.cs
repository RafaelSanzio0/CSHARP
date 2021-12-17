using AluraRest.Models;
using FilmesAPI.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.DTO.Sessao
{
    public class SessaoDto
    {
        public CinemaModel Cinema { get; set; }
        public FilmeModel Filme { get; set; }
        public DateTime HorarioDeEncerramento { get; set; }

    }
}
