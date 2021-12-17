using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AluraRest.Data.DTO
{
    public class CreateEnderecoDto
    {

        [Required(ErrorMessage = "O campo Logradouro é obrigatorio")]
        public string Logradouro { get; set; }

        [Required(ErrorMessage = "O campo Bairro é obrigatorio")]
        public string Bairro { get; set; }

        [Required(ErrorMessage = "O campo Numero é obrigatorio")]
        public int Numero { get; set; }
    }
}
