using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.DTO.Sessao
{
    public class UpdateSessaoDto
    {
        public int CinemaId { get; set; }
        public int FilmeId { get; set; }
        public DateTime HorarioDeEncerramento { get; set; }
    }
}
