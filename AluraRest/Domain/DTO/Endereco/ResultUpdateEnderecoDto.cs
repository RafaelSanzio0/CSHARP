using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Dto.Endereco
{
    public class ResultUpdateEnderecoDto
    {
        public int Id { get; set; }

        public string Logradouro { get; set; }

        public string Bairro { get; set; }

        public int Numero { get; set; }

        public DateTime HoraDaConsulta { get; set; }

        public DateTime UpdateAt { get; set; }
    }
}
