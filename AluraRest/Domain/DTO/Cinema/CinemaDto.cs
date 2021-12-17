using AluraRest.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Dto.Cinema
{
    public class CinemaDto
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }

        public EnderecoModel Endereco { get; set; }

        public GerenteModel Gerente { get; set; }

        public List<SessaoModel> Sessoes { get; set; }

    }
}
