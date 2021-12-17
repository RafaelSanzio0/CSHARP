using FilmesAPI.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Domain.Entities
{
    public class GerenteEntity : BaseEntity
    {
        public string Nome { get; set; }

        [JsonIgnore]
        public List<CinemaModel> Cinemas { get; set; }
    }
}
