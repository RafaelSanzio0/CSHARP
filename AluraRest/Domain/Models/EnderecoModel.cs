using Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class EnderecDto : BaseModel
    {

        private string _logradouro;

        public string Logradouro
        {
            get { return _logradouro; }
            set { _logradouro = value; }
        }

        private string _bairro;

        public string Bairro
        {
            get { return _bairro; }
            set { _bairro = value; }
        }

        private int _numero;

        public int Numero
        {
            get { return _numero; }
            set { _numero = value; }
        }

        /*
        private CinemaModel _cinema;

        [JsonIgnore] // resolve o problema de ciclo de informações, já que ao retornar um Cinema, ele retornará um Endereco, que por sua vez retornará um Cinema repetidamente.
        public virtual CinemaModel Cinema // digo que é um lazy
        {
            get { return _cinema; }
            set { _cinema = value; }
        }
        */
    }
}