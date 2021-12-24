using Domain.Dto.Endereco;
using Domain.Dto.Gerente;
using Domain.Dto.Sessao;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Dto.Cinema
{
    public class CinemaDto
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }

        public EnderecoDto Endereco { get; set; }

        public GerenteDto Gerente { get; set; }

        public List<SessaoDto> Sessoes { get; set; }

    }
}
