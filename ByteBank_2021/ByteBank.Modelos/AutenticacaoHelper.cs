using System;
namespace ByteBank.Modelos
{
    internal class AutenticacaoHelper // criamos essa clase helper pois tinhamos o mesmo comportamento de autenticar em 2 classes diferentes, parceiroComercial e funcionarioAutenticavel
    {
        public AutenticacaoHelper()
        {
        }

        public bool  CompararSenhas(string senhaCorreta, string senhaTentativa)
        {
            return senhaCorreta == senhaTentativa;
        }
    }
}

/*
 * DEIXAMOS A CLASSE INTERNAL PARA EVITAR PROBLEMAS FUTUROS COMO POR EXEMPLO:
 * SUPONHA QUE ALTERAMOS A QTD DE PARAMETROS NO METODO COMPARAR > NA PROGRAM.CS ESTE METODO ESTEVA SENDO UTILIZADO POR OUTRAS CLASSES FORA DO PACOTE .MODELOS > APLICACAO QUEBRA.
 * 
 * COMO DEIXAMOS INTERNAL ELA FUNCIONA(PODE SER INSTANCIADA) SOMENTE INTERNAMENTE OU SEJA DENTRO DO .MODELOS
 * 
 * SE A CLASSE BASE DEFINE O METODO COMO INTERNAL A CLASSE DERIVADA TBM PRECISA DEFINIR ESTE METODO COMO INTERNAL
 */
