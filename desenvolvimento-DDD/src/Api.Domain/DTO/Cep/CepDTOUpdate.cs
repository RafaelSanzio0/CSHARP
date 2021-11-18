using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Domain.DTO.Cep
{
    public class CepDTOUpdate
    {

        [Required(ErrorMessage = "Campo Id obrigatório")]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Campo CEP obrigatório")]
        public string Cep { get; set; }

        [Required(ErrorMessage = "Campo Logradouro obrigatório")]
        public string Logradouro { get; set; }

        [Required(ErrorMessage = "Campo Numero obrigatório")]
        public string Numero { get; set; }

        [Required(ErrorMessage = "Campo MunicipioID obrigatório")]
        public Guid MunicipioID { get; set; }
    }
}
