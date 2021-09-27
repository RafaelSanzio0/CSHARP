using System;
namespace ByteBank
{
    public class SaldoInsuficienteException : OperacaoFinanceiraException
    {
        public double ValorSaque { get; }
        public double Saldo { get; }

        public SaldoInsuficienteException()
        {
        }

        public SaldoInsuficienteException(double valorSaque, double saldo) : this("Saldo insuficiente!! Tentativa de saque "+valorSaque+ " em uma conta de saldo "+saldo)
        {
            ValorSaque = valorSaque;
            Saldo = saldo;
        }

        public SaldoInsuficienteException(string message) : base(message)
        {
        }

        public SaldoInsuficienteException(string message, Exception exceptionInterna) : base(message, exceptionInterna)
        {
        }
    }
}
