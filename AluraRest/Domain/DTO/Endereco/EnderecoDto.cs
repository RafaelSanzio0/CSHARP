using FilmesAPI.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.DTO.Endereco
{
    public class EnderecoDto
    {
        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public int Numero { get; set; }
        public virtual CinemaModel Cinema { get; set; }
    }
}
