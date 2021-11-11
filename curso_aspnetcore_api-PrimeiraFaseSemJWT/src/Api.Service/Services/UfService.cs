using Api.Domain.Interfaces;
using Api.Domain.Interfaces.Services.User;
using AutoMapper;
using Domain.DTO.Uf;
using Domain.Entities;
using Domain.Interfaces.Services;
using Domain.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class UfService : IUfService
    {
        private IUfRepository _ufRepository;
        private readonly IMapper _mapper;

        public UfService(IUfRepository ufRepository, IMapper mapper)
        {
            _ufRepository = ufRepository;
            _mapper = mapper;
        }

        public async Task<UfDTO> Get(Guid id)
        {
            var entity = await _ufRepository.SelectAsync(id);
            return _mapper.Map<UfDTO>(entity);
        }

        public async Task<IEnumerable<UfDTO>> GetAll()
        {
            var listEntity = await _ufRepository.SelectAsync();
            return _mapper.Map<IEnumerable<UfDTO>>(listEntity);
        }
    }
}
