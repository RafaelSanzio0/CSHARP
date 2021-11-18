using System;
using System.ComponentModel.DataAnnotations;

namespace Api.Domain.Entities {
    public abstract class BaseEntity {

        [Key]
        [Required(ErrorMessage = "O campo ID é obrigatorio")]
        public Guid Id { get; set; }

        private DateTime? _createAt; //pode receber um null
        public DateTime? CreateAt { //criado no banco de dados como CreateAt
            get { return _createAt; }
            set { _createAt = (value == null ? DateTime.UtcNow : value); } //SET precisa de uma logica
        }

        public DateTime? UpdateAt { get; set; }
    }
}

/* entidade é uma relacao com o banco de dados
 * obrigatorio ter um id,um updateAt e um createAt */
