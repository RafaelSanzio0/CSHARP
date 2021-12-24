using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Dto.Gerente
{
    public class ResultUpdateGerenteDto
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public object Cinemas { get; set; }
        public DateTime UpdateAt { get; set; }
    }
}
