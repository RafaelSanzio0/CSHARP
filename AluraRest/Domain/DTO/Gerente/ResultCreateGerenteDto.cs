using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Dto.Gerente
{
    public class ResultCreateGerenteDto
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public object Cinemas { get; set; } // mudei pra OBJECT pra ter acesso ao metodo select no gerenteProfiel

        public DateTime CreateAt { get; set; }
    }
}
