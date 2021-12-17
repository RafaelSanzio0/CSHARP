using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AluraRest.Data.DTO
{
    public class CreateFilmeDto
    {
        [Required(ErrorMessage = "O campo titulo é obrigatorio")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "O campo Diretor é obrigatorio")]
        public string Diretor { get; set; }

        [Required(ErrorMessage = "O campo Genero é obrigatorio")]
        [StringLength(30, ErrorMessage = "O campo Genero deve ter no maximo 30 caracteres")]
        public string Genero { get; set; }

        [Range(1, 600, ErrorMessage = "A duracao do filme deve ter no minimi 1 e no maximo 600 minutos")]
        public int Duracao { get; set; }
        public int ClassificacaoEtaria { get; set; }

    }
}
