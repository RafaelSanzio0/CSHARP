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
    public class GerenteModel : BaseModel
    {
        private string _nome;

        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        private List<CinemaModel> _cinemas;

        [JsonIgnore]
        public virtual List<CinemaModel> Cinemas // 1:n com gerente | GERENTE PODE TER VARIOS CINEMAS
        {
            get { return _cinemas; }
            set { _cinemas = value; }
        }
    }
}
