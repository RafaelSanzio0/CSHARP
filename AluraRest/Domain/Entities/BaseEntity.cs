using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Domain.Entities
{
    public abstract class BaseEntity
    {

        [Key]
        [Required(ErrorMessage = "O campo ID é obrigatorio")]
        public Guid Id { get; set; }

        private DateTime? _createAt; //pode receber um null
        public DateTime? CreateAt
        { //criado no banco de dados como CreateAt
            get { return _createAt; }
            set { _createAt = (value == null ? DateTime.UtcNow : value); }
        }

        public DateTime? UpdateAt { get; set; }
    }
}

