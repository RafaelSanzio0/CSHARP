using Domain.Dto.Cinema;
using Domain.DTO.Cinema;
using FilmesAPI.Data.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface ICinemaService
    {
        Task<CinemaDto> Get(Guid id);
        Task<IEnumerable<CinemaDto>> GetAll();
        Task<ResultCreateCinemaDto> Post(CreateCinemaDto cinema);
        Task<ResultUpdateCinemaDto> Put(UpdateCinemaDto cinema);
        Task<bool> Delete(Guid id);
    }
}
