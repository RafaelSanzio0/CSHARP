using Domain.DTO.Municipio;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Services
{
    public interface IMunicipioService
    {
        Task<MunicipioDTO> Get(Guid id);
        Task<MunicipioDTOCompleto> GetCompleteByID(Guid id);
        Task<MunicipioDTOCompleto> GetCompleteByIBGE(int codIBGE);
        Task<IEnumerable<MunicipioDTO>> GetAll();
        Task<MunicipioDTOCreateResult> Post(MunicipioDTOCreate municipio);
        Task<MunicipioDTOUpdateResult> Put(MunicipioDTOUpdate municipio);
        Task<bool> Delete(Guid id);
    }
}
