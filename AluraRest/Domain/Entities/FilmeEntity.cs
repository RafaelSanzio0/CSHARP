using AluraRest.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class FilmeEntity : BaseEntity
    {
        public string Titulo { get; set; }
        public string Diretor { get; set; }
        public int Duracao { get; set; }
        public int ClassificacaoEtaria { get; set; }
        public List<SessaoModel> Sessoes { get; set; }
    }
}

//Para estabelecer um relacionamento n:n,
//devemos ter uma tabela específica para armazenar os dados deste relacionamento.

//O Entity é capaz de gerar automaticamente uma tabela de relacionamento.
// com isso nao precisamos criar um Builder referente a este relacionamento n to n filme cinemca  | POREM NOS CRIAMOS SIM  O BUILDER PARA REPRSENTAR A NOSSA CLASE DE RELACIONAMENTO SESSAO
