using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace refatoracao.R19.ReplaceArrayWithObject.antes
{
    class Empresa
    {
        public Empresa()
        {
            using (var streamReader = File.OpenText("clientes.csv"))
            {
                string linha = string.Empty;
                while ((linha = streamReader.ReadLine()) != null)
                {
                    string[] campos = linha.Split(',');

                    Cliente cliente = new Cliente(campos[0], campos[1], campos[2], campos[4]);

                    Console.WriteLine("Dados do Cliente");
                    Console.WriteLine("================");
                    Console.WriteLine("ID: " + cliente.Id);
                    Console.WriteLine("Nome: " + cliente.Nome);
                    Console.WriteLine("Telefone: " + cliente.Telefone);
                    Console.WriteLine("Website: " + cliente.WebSite);
                    Console.WriteLine("================");
                }
            }
        }
    }

    class Cliente
    {
        private readonly string id;
        private readonly string nome;
        private readonly string telefone;
        private readonly string webSite;

        public string Id => id;

        public string Nome => nome;

        public string Telefone => telefone;

        public string WebSite => webSite;

        public Cliente(string id, string nome, string telefone, string webSite)
        {
            this.id = id;
            this.nome = nome;
            this.telefone = telefone;
            this.webSite = webSite;
        }
    }
}
