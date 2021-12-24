using Domain.Dto.Cinema;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Dto.Gerente
{
    public class GerenteDto
    {
        public string Nome { get; set; }
        public List<CinemaDto> Cinemas { get; set; }
    }
}
