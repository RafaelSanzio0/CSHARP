using Domain.DTO.Cep;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Services
{
    public interface ICepService
    {
        Task<CepDTO> Get(Guid id);
        Task<CepDTO> Get(string cep);
        Task<IEnumerable<CepDTO>> GetAll();
        Task<CepDTOCreateResult> Post(CepDTOCreate cep);
        Task<CepDTOUpdateResult> Put(CepDTOUpdate cep);
        Task<bool> Delete(Guid id);
    }
}
