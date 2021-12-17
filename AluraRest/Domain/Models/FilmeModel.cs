using Domain.Models;
using FilmesAPI.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace AluraRest.Models
{
    public class FilmeModel : BaseModel
    {

        private string _titulo;

        public string Titulo
        {
            get { return _titulo; }
            set { _titulo = value; }
        }

        private string _diretor;

        public string Diretor
        {
            get { return _diretor; }
            set { _diretor = value; }
        }

        private string _genero;

        public string Genero
        {
            get { return _genero; }
            set { _genero = value; }
        }

        private int _duracao;

        public int Duracao
        {
            get { return _duracao; }
            set { _duracao = value; }
        }

        private int _classificacaoEtaria;

        public int ClassificacaoEtaria
        {
            get { return _classificacaoEtaria; }
            set { _classificacaoEtaria = value; }
        }

        /*
        private  List<SessaoModel> _sessoes;

        [JsonIgnore]
        public virtual List<SessaoModel> Sessoes
        {
            get { return _sessoes; }
            set { _sessoes = value; }
        }
        */

    }
}

//Para estabelecer um relacionamento n:n,
//devemos ter uma tabela específica para armazenar os dados deste relacionamento.

//O Entity é capaz de gerar automaticamente uma tabela de relacionamento.
// com isso nao precisamos criar um Builder referente a este relacionamento n to n filme cinemca  | POREM NOS CRIAMOS SIM  O BUILDER PARA REPRSENTAR A NOSSA CLASE DE RELACIONAMENTO SESSAO