using System;
using ByteBank.Modelos;
using ByteBank.Sistemas;

namespace ByteBank.Funcionarios // criei essa classe apenas para utilizar nos usuarios que tem permissao de login no sistema EXEMPLO --> DIRETOR
{
    public abstract class FuncionarioAutenticavel : Funcionario, IAutenticavel
    {
        public string Senha { get; set; }
        private AutenticacaoHelper _autenticacaoHelper = new AutenticacaoHelper();


        public FuncionarioAutenticavel(double salario, string cpf) : base(salario, cpf) 
        {
        }

        public bool Autenticar(string senha)
        {
            return _autenticacaoHelper.CompararSenhas(Senha, senha);
        }
    }
}
