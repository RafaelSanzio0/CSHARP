using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    public class UfModel : BaseModel
    {
        private string _nome;
        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        private string _sigla;
        public string Sigla
        {
            get { return _sigla; }
            set { _sigla = value; }
        }
    }
}
