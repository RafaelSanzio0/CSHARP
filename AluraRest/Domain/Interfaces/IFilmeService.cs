using Domain.Dto.Filme;
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
        Task<ResultUpdateFilmeDto> Put(UpdateFilmeDto filme);
        Task<bool> Delete(Guid id);
    }
}
