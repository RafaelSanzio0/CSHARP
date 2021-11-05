using Domain.DTO.Municipio;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.DTO.Cep
{
    public class CepDTOCreateResult
    {
        public Guid Id { get; set; }

        public string Cep { get; set; }

        public string Logradouro { get; set; }

        public string Numero { get; set; }

        public Guid MunicipioID { get; set; }

        public MunicipioDTOCompleto Municipio { get; set; }

        public DateTime CreateAt { get; set; }

    }
}
