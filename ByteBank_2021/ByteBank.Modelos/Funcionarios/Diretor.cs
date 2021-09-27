using System;
namespace ByteBank.Funcionarios
{
    public class Diretor : FuncionarioAutenticavel
    {
        public Diretor(string cpf) : base(5000, cpf) // passando o cpf da classe DERIVADA como valor para a classe pai FUNCIONARIO | o 5000 é o salario como padrao
        {
            Console.WriteLine("Criando DIRETOR");
        }

        internal protected override double GetBonificacao()
        {
        return Salario * 0.5; // com o base chamamos o metudo da classe PAI (implementacao original)
        }

        public override void AumentarSalario()
        {
            Salario *= 1.15; // 1.15 igual salario vezes ele mesmo + 0.15 % | aqui estamos tendo acesso ao Salario(set) apenas pq ele foi definido como protecd
        }
    }
}
