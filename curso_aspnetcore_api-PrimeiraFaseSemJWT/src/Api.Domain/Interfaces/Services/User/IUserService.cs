using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Domain.Entities;
using Domain.DTO.User;

namespace Api.Domain.Interfaces.Services.User {
    public interface IUserService {
        Task<UserDTO> Get(Guid id);
        Task<IEnumerable<UserDTO>> GetAll();
        Task<ReadUserCreateDTO> Post(CreateUserDTO user);
        Task<ReadUserUpdateDTO> Put(UpdateUserDTO user);
        Task<bool> Delete(Guid id);
    }
}
// deixar generico futuramente
// a camada de aplication que trabalha com esses metodos da service
// alterando de userEntity para userDTO