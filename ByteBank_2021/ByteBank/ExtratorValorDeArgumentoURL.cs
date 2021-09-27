using System;
namespace ByteBank
{
    public class ExtratorValorDeArgumentoURL
    {
        public string Url { get; }

        public ExtratorValorDeArgumentoURL(string url)
        {
            if (string.IsNullOrEmpty(url) == true)
            {
                throw new ArgumentException("Valor nao pode ser nullo", nameof(url));
            }
        
            Url = url;
        }

        /*
         * 1.) O método IndexOf sempre retorna o índice da primeira ocorrência da string ou char no texto original. Sabemos que os argumentos possuem a
         * sintaxe <nome>=<valor> Para tornar o método GetValor(string nomeParametro) mais robusto, podemos aplicar o truque de buscar o índice de nomeParametro + "=" no 
         * lugar de apenas nomeParametro:
         * 
         * 3.) Para resolver isto, precisamos remover do resultado o que vem depois do &:
        */

        public string GetValor(string nomeParametro)
        {
            string termo = nomeParametro + "=";
            int indiceTermo = Url.IndexOf(termo);

            //REMOVENDO
            string resultado = Url.Substring(indiceTermo + termo.Length);
            int indiceEComercial = resultado.IndexOf('&');

            /*
             * 4.) Contudo, este código irá lançar uma exceção quando não houver um '&' na variável resultado, pois, o método IndexOf 
             * devolverá -1 e este não é um valor válido para o método Remove.
             */


            //5.) A correção é simples. Caso indiceEComercial seja igual a -1, retorne resultado:
            if (indiceEComercial == -1)
            {
                return resultado;
            }

            return Url.Substring(indiceTermo + termo.Length);
        }
    }
}