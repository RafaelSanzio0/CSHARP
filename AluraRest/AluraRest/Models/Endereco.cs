using FilmesAPI.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace AluraRest.Models
{
    public class Endereco
    {
        [Required(ErrorMessage = "O campo ID é obrigatorio")]
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "O campo Logradouro é obrigatorio")]
        public string Logradouro { get; set; }
        [Required(ErrorMessage = "O campo Bairro é obrigatorio")]
        public string Bairro { get; set; }
        [Required(ErrorMessage = "O campo Numero é obrigatorio")]
        public int Numero { get; set; }
        [JsonIgnore] // resolve o problema de ciclo de informações, já que ao retornar um Cinema, ele retornará um Endereco, que por sua vez retornará um Cinema repetidamente.
        public virtual Cinema Cinema { get; set; } // digo que é um lazy
    }
}