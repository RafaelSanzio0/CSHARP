using Domain.DTO.Municipio;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.DTO.Cep
{
    public class CepDTOUpdateResult
    {
        public Guid Id { get; set; }

        public string Cep { get; set; }

        public string Logradouro { get; set; }

        public string Numero { get; set; }

        public Guid MunicipioID { get; set; }

        public MunicipioDTOCompleto Municipio { get; set; }

        public DateTime UpdateAt { get; set; }
    }
}
