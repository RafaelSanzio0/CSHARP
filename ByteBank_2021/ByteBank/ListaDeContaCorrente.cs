using ByteBank.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia
{
    // [item][item][item][item][item]
    //                                ^
    //                                 `- _proximaPosicao

    public class ListaDeContaCorrente
    {
        private ContaCorrente[] _itens;
        private int _proximaPosicao;
        private int Tamanho { get { return _proximaPosicao; } }

        public ListaDeContaCorrente(int capacidadeInicial = 5)
        {
            _itens = new ContaCorrente[capacidadeInicial];
            _proximaPosicao = 0;
        }

        public void TestaArgumentoOpcional(string texto = "texto padrao", int numero = 5) //argumento opcional
        {

        }

        public void Adicionar(ContaCorrente item)
        {
            VerificarCapacidade(_proximaPosicao + 1);

            Console.WriteLine($"Adicionando item na posição {_proximaPosicao}");

            _itens[_proximaPosicao] = item;
            _proximaPosicao++;
        }

        //public void AdicionarVarios(ContaCorrente[] listaContaCorrente)
        //{
        //    foreach(ContaCorrente contaCorrente in listaContaCorrente)
        //    {
        //        Adicionar(contaCorrente);
        //    }
        //}

        public void AdicionarVarios(params ContaCorrente[] listaContaCorrente) // com o params é possivel passar varios argumentos na chamada do metodo
        {
            foreach (ContaCorrente contaCorrente in listaContaCorrente)
            {
                Adicionar(contaCorrente);
            }
        }

        public void Remover(ContaCorrente item)
        {
            int indiceItem = -1;

            for(int i = 0; i < _proximaPosicao; i++)
            {
                if (_itens[i].Equals(item))
                {
                    indiceItem = i; // achamos o cara que queremos remover
                    break;
                }
            }

            for(int i = indiceItem; i < _proximaPosicao-1; i++) // agora nesse for iremos deslocar os proximos itens para frente | // passo o -1 para nao acessar uma posicao que nao existe do ultimo elemento
            {
                _itens[i] = _itens[i + 1]; // aqui eu desloco obtendo o comportamento de colocar o valor da proxima pos na pos atual
            }

            _proximaPosicao--;
            _itens[_proximaPosicao] = null;
        }

        public ContaCorrente GetConta(int indice)
        {
            if (indice < 0 || indice >= _proximaPosicao)
            {
                throw new ArgumentOutOfRangeException(nameof(indice));
            }

            return _itens[indice];
        }

        public ContaCorrente this[int indice] // INDEXADOR
        {
            get
            {
                return GetConta(indice); // como usar ? listaDeContaCorrente[i] como um vetor
            }           
        }

        private void VerificarCapacidade(int tamanhoNecessario)
        {
            if (_itens.Length >= tamanhoNecessario)
            {
                return;
            }

            int novoTamanho = _itens.Length * 2;
            if (novoTamanho < tamanhoNecessario)
            {
                novoTamanho = tamanhoNecessario;
            }

            Console.WriteLine("Aumentando capacidade da lista!");

            ContaCorrente[] novoArray = new ContaCorrente[novoTamanho];

            Array.Copy( // utilizando argumentos nomeados 
              sourceArray: _itens,
              destinationArray: novoArray,
              length: _itens.Length);

            _itens = novoArray;


            //for (int i = 0; i < _itens.Length; i++) //AO INVES DE USAR ESSE CODIGO UTILIAR O COPY
            //{
            //    novoArray[i] = _itens[i];
            //    Console.WriteLine(".");
            //}

            //_itens = novoArray;
        }

    }
}