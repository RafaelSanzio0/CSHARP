using Domain.Dto.Endereco;
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
        Task<ResultCreateEnderecoDto> Post(CreateEnderecoDto endereco);
        Task<ResultUpdateEnderecoDto> Put(UpdateEnderecoDto endereco);
        Task<bool> Delete(Guid id);
    }
}
