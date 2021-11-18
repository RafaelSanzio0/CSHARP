using Api.Domain.Interfaces;
using AutoMapper;
using Domain.DTO.Cep;
using Domain.Entities;
using Domain.Interfaces.Services;
using Domain.Models;
using Domain.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class CepService : ICepService
    {
        private ICepRepository _cepRepository;
        private IMapper _mapper;

        public CepService(ICepRepository cepRepository, IMapper mapper)
        {
            _cepRepository = cepRepository;
            _mapper = mapper;
        }

        public async Task<bool> Delete(Guid id)
        {
            return await _cepRepository.DeleteAsync(id);
        }

        public async Task<CepDTO> Get(Guid id)
        {
            var entity = await _cepRepository.SelectAsync(id);
            return _mapper.Map<CepDTO>(entity);
        }

        public async Task<CepDTO> Get(string cep)
        {
            var entity = await _cepRepository.SelectAsync(cep);
            return _mapper.Map<CepDTO>(entity);
        }
       
        public async Task<IEnumerable<CepDTO>> GetAll()
        {
            var listEntity = await _cepRepository.SelectAsync();
            return _mapper.Map<IEnumerable<CepDTO>>(listEntity);
        }

        public async Task<CepDTOCreateResult> Post(CepDTOCreate cep)
        {
            var model = _mapper.Map<CepModel>(cep); 
            var entity = _mapper.Map<CepEntity>(model); 
            var result = await _cepRepository.InsertAsync(entity); 
            return _mapper.Map<CepDTOCreateResult>(result);
        }

        public async Task<CepDTOUpdateResult> Put(CepDTOUpdate cep)
        {
            var model = _mapper.Map<CepModel>(cep);
            var entity = _mapper.Map<CepEntity>(model);
            var result = await _cepRepository.UpdateAsync(entity);
            return _mapper.Map<CepDTOUpdateResult>(result);
        }
    }
}
