using FilmesAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AluraRest.Data.DTO.Gerente
{
    public class ReadGerenteDTO
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public object Cinemas { get; set; } // mudei pra OBJECT pra ter acesso ao metodo select no gerenteProfiel
    }
}
