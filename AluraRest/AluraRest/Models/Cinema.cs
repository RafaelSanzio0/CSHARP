using AluraRest.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace FilmesAPI.Models
{
    public class Cinema
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required(ErrorMessage = "O campo de nome é obrigatório")]
        public string Nome { get; set; }
        public virtual Endereco Endereco { get; set; }
        public int EnderecoId { get; set; } // 1:1 (um endereco tem um cinema)
        public virtual Gerente Gerente { get; set; }
        public int GerenteId { get; set; } // 1:n (um gerente pode ter varios cinemas)
        [JsonIgnore]
        public virtual List<Sessao> Sessoes { get; set; }
    }
}

//iremos estabelecer um relacionamento de 1:1 entre cinema e endereco
// precisamos passar um ID para o endereco para saber qual endereco estamos nos referenciando
// e estabelecemos a REGRA de que pra um CINEMA existir ele precisa de um ENDERECO (via enderecoID)
// e podemos criar um endereco sem cinema