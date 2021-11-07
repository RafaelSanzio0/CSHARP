using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    public class MunicipioModel : BaseModel
    {
        private string _nome;

        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        private int _codIBGE;

        public int CodIBGE
        {
            get { return _codIBGE; }
            set { _codIBGE = value; }
        }

        private Guid _ufId;

        public Guid UfID
        {
            get { return _ufId; }
            set { _ufId = value; }
        }
    }
}

// como a ideia é validar campos que sera utilizado no momento do post nao é preciso inserir o restante
// entao a dica é criar o model em cima dos create