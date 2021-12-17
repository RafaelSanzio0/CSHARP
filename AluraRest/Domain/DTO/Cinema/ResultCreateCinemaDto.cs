using AluraRest.Models;
using FilmesAPI.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace FilmesAPI.Data.Dtos
{
    public class ResultCreateCinemaDto
    {

        public Guid Id { get; set; }
        public string Nome { get; set; }
        public EnderecoModel Endereco { get; set; }
        public GerenteModel Gerente { get; set; }
        public DateTime CreateAt { get; set; }

    }
}
