using Domain.Dto.Sessao;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface ISessaoService
    {
        Task<SessaoDto> Get(Guid id);
        Task<IEnumerable<SessaoDto>> GetAll();
        Task<ResultCreateSessaoDto> Post(CreateSessaoDto sessao);
        Task<ResultUpdateSessaoDto> Put(UpdateSessaoDto sessao);
        Task<bool> Delete(Guid id);
    }
}
