using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Domain.Entities;
using Api.Domain.Interfaces;
using Api.Domain.Interfaces.Services.User;
using AutoMapper;
using Domain.DTO.User;
using Domain.Models;

namespace Api.Service.Services {
    public class UserService : IUserService {

        private IRepository<UserEntity> _repository; // injecao de dependencia
        private IMapper _mapper;


        public UserService(IRepository<UserEntity> repository, IMapper mapper) // injecao de dependencia | passa o que recebi no construtor para o atributo acima
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<bool> Delete(Guid id)
        {
            return await _repository.DeleteAsync(id);
        }

        public async Task<UserDTO> Get(Guid id)
        {
            var entity =  await _repository.SelectAsync(id);
            return _mapper.Map<UserDTO>(entity); //converteu de entidade para DTO
        }

        public async Task<IEnumerable<UserDTO>> GetAll()
        {
            var listEntity = await _repository.SelectAsync();
            return _mapper.Map<IEnumerable<UserDTO>>(listEntity);
        }

        public async Task<ReadUserCreateDTO> Post(CreateUserDTO user)
        {
            var model = _mapper.Map<UserModel>(user); // converto de DTO pra MODEL(onde ha validacoes de campos)
            var entity = _mapper.Map<UserEntity>(model); // converte de MODEL pra ENTIDADE
            var result =  await _repository.InsertAsync(entity); // salva no banco pois é uma entidade
            return _mapper.Map<ReadUserCreateDTO>(result); // converte de entidade para readDTO
        }

        public async Task<ReadUserUpdateDTO> Put(UpdateUserDTO user)
        {
            var model = _mapper.Map<UserModel>(user);
            var entity = _mapper.Map<UserEntity>(model);
            var result = await _repository.UpdateAsync(entity);
            return _mapper.Map<ReadUserUpdateDTO>(result);
        }
    }
}

// service é o cara que conversa com o banco de dados, validando as regras de negocio
// service interage com a camada de data