using System;

namespace ByteBank
{
    // SUMMARY ABAIXO NAO É COMPILADO AI É PRECISO SELECIONAR A OPCAO GERAR DOCUMENTACAO XML E JOGAR O DLL + XML NO SISTEMA QUE UTILIZA A NOSSA LIB (BIN -> DEBUG -> ENCONTROU )
    /// Define uma conta corrente do banco byteBank
    /// </summary>
    public class ContaCorrente : IComparable
    {

        public Cliente Titular { get; set; } // como nao tenho nenhuma logica no get e set do titular eu posso simplificar desta maneira | cliente do namespae ByteBank | exemplo de composicao de classe | valor padrao do tipo referencia é nulo
        public int Agencia { get; } // deixando somente o get eu garanto que o atributo é somente LEITURA
        public int Numero { get; }
        public int ContadorSaquesNaoPermitidos { get; private set; }
        public int ContadorTransferenciasNaoPermitidos { get; private set; }
        public static int TotalDeContasCriadas { get; private set; }   //deixando o set privado pois assim é impossivel modificar seu valor fora do construtor.
        public static int TaxaOperacao { get; private set; }


        private double _saldo;
        public double Saldo // get e set novo
        {
            get
            {
                 return _saldo;
            }
            set
            {
                if (value < 0)
                {
                    return;
                }
                _saldo = value;
            }
        }

        //public double GetSaldo() //get antigo
        //{
        //    return saldo;
        //}

        //public void SetSaldo(double saldo) // set antigo
        //{
        //    if(saldo < 0)
        //    {
        //        return;
        //    }

        //    this.saldo = saldo; // preciso passar o this para referenciar o saldo da instancia e nao o saldo do argumento


        public override string ToString()
        {
            return $"Número {Numero}, Agência {Agencia}, Saldo {Saldo}";
        }


        /// <summary>
        /// Cria uma instancia de contaCorrente com os argumentos utilizados
        /// </summary>
        /// <param name="agencia"> representa o valor da propriedade <see cref="Agencia"/> e deve possuir um valor maior que 0</param>
        /// <param name="numero">representa o valor da propriedade <see cref="Numero"/> e deve possuir um valor maior que 0</param>
        public ContaCorrente(int agencia, int numero) // tratamos com uma excecao mais especifica pois nao é legal criar como exception pois atrapalha posteiormente na verificacao do erro
        {

            if (agencia <= 0)
            {
               throw new ArgumentException("Agencia deve ser maior que 0", nameof(numero));
            }

            if(numero <= 0)
            {
                throw new ArgumentException("Numero deve ser maior que 0", nameof(agencia));
            }

            Agencia = agencia;
            Numero = numero;
            TotalDeContasCriadas++;
            TaxaOperacao = 30 / TotalDeContasCriadas;
        }

        /// <summary> ... </summary>
        /// <param name="valor"> ... </param>
        /// <exception cref="ArgumentException"> Exceção lançada quando um valor negativo é utilizado no argumento <paramref name="valor"/>. </exception>
        /// <exception cref="SaldoInsuficienteException"> Exceção lançada quando o valor de <paramref name="valor"/> é maior que o valor da propriedade <see cref="Saldo"/>. </exception>
        public void Sacar(double valor)
        {
            if(valor < 0)
            {
                throw new ArgumentException("Valor de saque deve ser maior que 0", nameof(valor));
            }
            else if (this._saldo < valor)
            {
                ContadorSaquesNaoPermitidos++;
                throw new SaldoInsuficienteException(valor, _saldo);
            }
            else
            {
                this._saldo -= valor;
            }
        }

        public void Depositar(double valor)
        {
            this._saldo += valor;
        }

        public void Transferir(ContaCorrente contaDestino, double valor)
        {
            if (valor < 0)
            {
                throw new ArgumentException("Valor de transferencia deve ser maior que 0", nameof(valor));
            }
            try
            {
                Sacar(valor);
            }
            catch(SaldoInsuficienteException ex)
            {
                ContadorTransferenciasNaoPermitidos++;
                throw new OperacaoFinanceiraException("Operacao nao realizada.!!!", ex); //inner exception é quando eu uso usa exception dentro de outra, aqui nesse caso foi para escoder informacoes sensiveis do usuario aos outros sistemas.
            }
            contaDestino.Depositar(valor); // coloco o valor na conta destino
        }

        public override bool Equals(object obj)
        {
            ContaCorrente outraConta = obj as ContaCorrente;

            if(outraConta == null)
            {
                return false;
            }

            return Agencia == outraConta.Agencia && Numero == outraConta.Numero;

        }

        public int CompareTo(object obj)
        {
            var outraConta = obj as ContaCorrente;

            if(outraConta == null)
            {
                return -1;
            }

            if(Numero < outraConta.Numero)
            {
                return -1;
            }

            if(Numero > outraConta.Numero)
            {
                return 1;
            }

            return 0;

          
            // retornar negativo quando a instancia precede o obj
            // retornar 0 quando a instancia é equivalente ao obj
            // retornar positivo quando o obj precede a instancia 
        }
    }

}

//Existem duas formas de lançar exceções no C#. Quando estamos em um catch, podemos
//lançar com a instrução throw;; mas podemos também lançar com throw <objeto de exception>; (seja em um catch ou fora dele).

/*
 * O StackTrace começa quando lançamos a exceção com throw <objeto de exception>;.
 * Desta forma, se usamos esta sintaxe em blocos catch, estaremos perdendo informações da exceção original.
*/