using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

// classe referente a uma tabela de relacionamento entre N to N filme e cinema

namespace Domain.Entities
{
    public class SessaoEntity : BaseEntity
    {

        public CinemaEntity Cinema { get; set; }
        public int CinemaId { get; set; }

        public FilmeEntity Filme { get; set; }
        public int FilmeId { get; set; }

        public DateTime HorarioDeEncerramento { get; set; }

    }
}
