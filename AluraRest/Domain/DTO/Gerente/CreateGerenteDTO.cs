using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Dto.Gerente
{
    public class CreateGerenteDto
    {
        public string Nome { get; set; }
        //public int GerenteId { get; set; }
        public DateTime CreatAt { get; set; }
    }
}
