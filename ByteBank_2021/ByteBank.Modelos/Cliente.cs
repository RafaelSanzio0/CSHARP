using System;

namespace ByteBank

{
    public class Cliente
    {   
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Profissao { get; set; }
            

        public Cliente()
        {
        }

        public override bool Equals(object obj) //recebe um obj qualquer
        {
            Cliente outroCliente = obj as Cliente; // se o obj nao é um tipo CLIENTE ele retorna null

            if (outroCliente == null)
            {
                return false;
            }

            return CPF == outroCliente.CPF; //Você pode comparar todos os atributos ou apenas os identificadores, como o CPF. Isto depende da lógica do seu negócio e como estes objetos são recuperados.
        }
    }
}
