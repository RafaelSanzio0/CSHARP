using Domain.Dto.Cinema;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Dto.Endereco
{
    public class EnderecoDto
    {
        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public int Numero { get; set; }
        public virtual CinemaDto Cinema { get; set; }
    }
}
