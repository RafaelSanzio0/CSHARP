using Api.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Domain.Entities
{
    public class MunicipioEntity : BaseEntity
    {
        [Required]
        [MaxLength(45)]
        public string Nome { get; set; }

        [Required]
        public int CodIBGE { get; set; }

        [Required]
        public Guid UfID { get; set; } // chave FK da classe UfEntity

        public UfEntity UfEntity { get; set; } // um municipio possui 1 uf

        public IEnumerable<CepEntity> CepEntities { get; set; } // um municipio possui N cep
    }
}
