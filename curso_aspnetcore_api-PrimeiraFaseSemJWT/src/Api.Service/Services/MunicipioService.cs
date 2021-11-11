using Api.Domain.Interfaces;
using AutoMapper;
using Domain.DTO.Municipio;
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
    public class MunicipioService : IMunicipioService
    {

        private IMunicipioRepository _municipioRepository;
        private readonly IMapper _mapper;

        public MunicipioService(IMunicipioRepository municipioRepository, IMapper mapper)
        {
            _municipioRepository = municipioRepository;
            _mapper = mapper;
        }

        public async Task<bool> Delete(Guid id)
        {
            return await _municipioRepository.DeleteAsync(id);
        }

        public async Task<MunicipioDTO> Get(Guid id)
        {
            var entity = await _municipioRepository.SelectAsync(id);
            return _mapper.Map<MunicipioDTO>(entity);
        }

        public async Task<IEnumerable<MunicipioDTO>> GetAll()
        {
            var listEntity = await _municipioRepository.SelectAsync();
            return _mapper.Map<IEnumerable<MunicipioDTO>>(listEntity);
        }

        public async Task<MunicipioDTOCompleto> GetCompleteByIBGE(int codIBGE)
        {
            var entity = await _municipioRepository.GetCompleteByIBGE(codIBGE);
            return _mapper.Map<MunicipioDTOCompleto>(entity);
        }

        public async Task<MunicipioDTOCompleto> GetCompleteByID(Guid id)
        {
            var entity = await _municipioRepository.GetCompleteByID(id);
            return _mapper.Map<MunicipioDTOCompleto>(entity);
        }

        public async Task<MunicipioDTOCreateResult> Post(MunicipioDTOCreate municipio)
        {
            var model = _mapper.Map<MunicipioModel>(municipio);
            var entity = _mapper.Map<MunicipioEntity>(model);
            var result  = await _municipioRepository.InsertAsync(entity);
            return _mapper.Map<MunicipioDTOCreateResult>(result);
        }

        public async Task<MunicipioDTOUpdateResult> Put(MunicipioDTOUpdate municipio)
        {
            var model = _mapper.Map<MunicipioModel>(municipio);
            var entity = _mapper.Map<MunicipioEntity>(model);
            var result = await _municipioRepository.UpdateAsync(entity);
            return _mapper.Map<MunicipioDTOUpdateResult>(result);
        }
    }
}
