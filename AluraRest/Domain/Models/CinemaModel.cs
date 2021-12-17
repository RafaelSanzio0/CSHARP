using AluraRest.Models;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace FilmesAPI.Models
{
    public class CinemaModel : BaseModel
    {
        private string _nome;

        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        /* COMENTANDO TEMPORARIAMENTE POIS ACREDITO QUE AS RELACOES DEVE FICAR NA ENTITY
        private EnderecoModel _endereco;

        public EnderecoModel Endereco
        {
            get { return _endereco; }
            set { _endereco = value; }
        }
        */

        private int _enderecoId;

        public int EnderecoId // 1:1 (um ENDERECO pode ter um CINEMA)
        {
            get { return _enderecoId; }
            set { _enderecoId = value; }
        }

        /*
        private GerenteModel _gerente;

        public GerenteModel Gerente
        {
            get { return _gerente; }
            set { _gerente = value; }
        }

        */

        private int _gerenteId;

        public int GerenteId // 1:n (um gerente pode ter varios cinemas)
        {
            get { return _gerenteId; }
            set { _gerenteId = value; }
        }

        /*
        private List<SessaoModel> _sessoes;

        [JsonIgnore] // duvida se deixo aqui ou na DTO
        public virtual List<SessaoModel> Sessoes
        {
            get { return _sessoes; }
            set { _sessoes = value; }
        }
        */
    }
}

//iremos estabelecer um relacionamento de 1:1 entre cinema e endereco
// precisamos passar um ID para o endereco para saber qual endereco estamos nos referenciando
// e estabelecemos a REGRA de que pra um CINEMA existir ele precisa de um ENDERECO (via enderecoID)
// e podemos criar um endereco sem cinema