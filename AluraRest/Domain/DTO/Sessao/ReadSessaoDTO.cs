using AluraRest.Models;
using FilmesAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AluraRest.Data.DTO.Sessao
{
    public class ReadSessaoDTO
    {
        public int id { get; set; }
        public FilmeModel Filme { get; set; }
        public Cinema Cinema { get; set; }
        public DateTime HorarioDeEncerramento { get; set; }
        public DateTime HorarioDeInicio { get; set; }

    }
}
