using AluraRest.Data.DTO;
using Domain.DTO.Endereco;
using FilmesAPI.Data.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IEnderecoService
    {
        Task<EnderecoDto> Get(Guid id);
        Task<IEnumerable<EnderecoDto>> GetAll();
        Task<ResultCreateCinemaDto> Post(CreateEnderecoDto endereco);
        Task<ResultUpdateEnderecoDto> Put(UpdateEnderecoDto endereco);
        Task<bool> Delete(Guid id);
    }
}
