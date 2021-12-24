using Domain.Dto.Gerente;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IGerenteService
    {
        Task<GerenteDto> Get(Guid id);
        Task<IEnumerable<GerenteDto>> GetAll();
        Task<ResultCreateGerenteDto> Post(CreateGerenteDto cinema);
        Task<ResultUpdateGerenteDto> Put(UpdateGerenteDto cinema);
        Task<bool> Delete(Guid id);
    }
}
