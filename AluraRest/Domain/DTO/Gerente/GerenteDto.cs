using FilmesAPI.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.DTO.Gerente
{
    public class GerenteDto
    {
        public string Nome { get; set; }
        public List<CinemaModel> Cinemas { get; set; }
    }
}
