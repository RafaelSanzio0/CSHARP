using AluraRest.Data.DTO;
using Domain.DTO.Filme;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IFilmeService
    {
        Task<FilmeDto> Get(Guid id);
        Task<IEnumerable<FilmeDto>> GetAll();
        Task<ResultCreateFilmeDto> Post(CreateFilmeDto filme);
        Task<ResultUpdateFilmeDto> Put(UpdateFilmeDTO filme);
        Task<bool> Delete(Guid id);
    }
}
