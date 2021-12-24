using Domain.Dto.Cinema;
using Domain.Dto.Filme;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Dto.Sessao
{
    public class ResultCreateSessaoDto
    {
        public int id { get; set; }
        public FilmeDto Filme { get; set; }
        public CinemaDto Cinema { get; set; }
        public DateTime HorarioDeEncerramento { get; set; }
        public DateTime HorarioDeInicio { get; set; }
        public DateTime CreateAt { get; set; }
    }
}
