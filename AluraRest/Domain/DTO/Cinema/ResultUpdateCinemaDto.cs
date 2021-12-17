using AluraRest.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.DTO.Cinema
{
    public class ResultUpdateCinemaDto
    {
      
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public EnderecoModel Endereco { get; set; }
        public GerenteModel Gerente { get; set; }
        public DateTime UpdateAt { get; set; }
    }
}
