using System;
namespace ByteBank.Funcionarios
{
    public class Designer : Funcionario
    {
        public Designer(double salario, string cpf) : base(salario, cpf)
        {
            Console.WriteLine("Criando Designer");
        }

        public Designer(string cpf) : base(cpf) // Não preenchi o salário! Quero que seja o salário padrão
        {
        }

        internal protected override double GetBonificacao()
        {
            return Salario * 0.17;
        }

        public override void AumentarSalario()
        {
            Salario *= 1.11;
        }
    }
}
