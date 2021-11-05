using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.DTO.Uf
{
    public class UfDTO
    {
        public Guid Id { get; set; }

        public string Sigla { get; set; }

        public string Nome { get; set; }
    }
}

// essa DTO foi criada pensando em retorno de uma lista
