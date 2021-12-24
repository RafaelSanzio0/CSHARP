using Domain.Dto.Cinema;
using Domain.Dto.Filme;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Dto.Sessao
{
    public class SessaoDto
    {
        public CinemaDto Cinema { get; set; }
        public FilmeDto Filme { get; set; }
        public DateTime HorarioDeEncerramento { get; set; }

    }
}
