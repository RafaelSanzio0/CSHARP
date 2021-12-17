using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AluraRest.Data.DTO
{
    public class ResultCreateEnderecoDto
    {
        public int Id { get; set; }

        public string Logradouro { get; set; }

        public string Bairro { get; set; }

        public int Numero { get; set; }

        public DateTime HoraDaConsulta { get; set; }

        public DateTime CreateAt { get; set; }

    }
}
