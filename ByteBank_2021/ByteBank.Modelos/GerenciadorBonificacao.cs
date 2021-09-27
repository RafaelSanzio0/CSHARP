using System;
using ByteBank.Funcionarios;

namespace ByteBank
{
    public class GerenciadorBonificacao
    {
        private double _totalBonificacao;

        public GerenciadorBonificacao()
        {
        }


        public void registrar(Funcionario funcionario)
        {
            _totalBonificacao += funcionario.GetBonificacao();

        }

        //public void registrar(Diretor diretor) // sobrecarga do metudo registrar
        //{
        //    _totalBonificacao += diretor.GetBonificacao();

        //}

        public double GetTotalBonificacao ()
        {
            return _totalBonificacao;
        }
    }
}
