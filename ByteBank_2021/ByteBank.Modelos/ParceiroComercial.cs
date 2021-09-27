using System;
using ByteBank.Modelos;
using ByteBank.Sistemas;

namespace ByteBank
{
    public class ParceiroComercial : IAutenticavel
    {
        public string Senha { get; set; }
        private AutenticacaoHelper _autenticacaoHelper;

        public ParceiroComercial()
        {
        }

        public bool Autenticar(string senha)
        {
           return _autenticacaoHelper.CompararSenhas(Senha, senha);
        }
    }
}
