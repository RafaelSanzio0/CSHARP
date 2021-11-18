using Api.Domain.Interfaces;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repository
{
    public interface ICepRepository : IRepository<CepEntity>
    {
        Task<CepEntity> SelectAsync (string cep); // tenho dois get com o mesmo nome na classe ICepService, aqui eu fiz uma sobrecarga alterando o parametro, diferente do que foi feito na IMunicipioRepository
    }
}
