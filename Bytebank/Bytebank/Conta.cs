using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Conta
{
   
    public int numeroAgencia;
    public int numeroConta;
    public int saldo;
    public string titular;
    Cliente cliente;


    public Conta()
    {

    }

    public Conta(int numeroAgencia, int numeroConta) // construtor
    {
        Console.WriteLine("Criando obj pelo construtor . . .");

        this.numeroAgencia = numeroAgencia;
        this.numeroConta = numeroConta;
        Console.WriteLine("numero agencia " + numeroAgencia);
        Console.WriteLine("Numero da conta " + numeroConta);
       

    }

    public void saca (double valor)
    {
        if(saldo > valor)
        {
            double saldoAtual = this.saldo - valor;
            Console.WriteLine("Saldo antes do saque " + saldo + "Saldo depois do saque "+ saldoAtual);
        }
        else
        {
            Console.WriteLine("saldo insuficiente");
        }
    }





}