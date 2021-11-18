using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Domain.DTO.Municipio
{
    public class MunicipioDTOUpdate
    {
        [Required(ErrorMessage = "ID do Municipio obrigatório")]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Nome do Municipio obrigatório")]
        [StringLength(60, ErrorMessage = "Nome deve possuir no máximo 45 caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "CodIBGE do Municipio obrigatório")]
        [Range(0, int.MaxValue, ErrorMessage = "CodIBGE do Municipio inválido")]
        public int CodIBGE { get; set; }

        [Required(ErrorMessage = "Codigo de UF do Municipio obrigatório")]
        public Guid UfId { get; set; }
    }
}
