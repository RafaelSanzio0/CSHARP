using Domain.Models;
using FilmesAPI.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

 // classe referente a uma tabela de relacionamento entre N to N filme e cinema

namespace AluraRest.Models
{
    public class SessaoModel : BaseModel
    {
        /*
        private CinemaModel _cinema;

        public virtual CinemaModel Cinema // isso é ignorado no momemnto da criacao do banco
        {
            get { return _cinema; }
            set { _cinema = value; }
        }
        

        private FilmeModel _filme;

        public virtual FilmeModel Filme  // isso tbm
        {
            get { return _filme; }
            set { _filme = value; }
        }
        */

        private int _filmeId;

        public int FilmeId
        {
            get { return _filmeId; }
            set { _filmeId = value; }
        }

        private int _cinemaId;

        public int CinemaId
        {
            get { return _cinemaId; }
            set { _cinemaId = value; }
        }

        private DateTime _horarioDeEncerramento;

        public DateTime HorarioDeEncerramento
        {
            get { return _horarioDeEncerramento; }
            set { _horarioDeEncerramento = value; }
        }

    }
}
