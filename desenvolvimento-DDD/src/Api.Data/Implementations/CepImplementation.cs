using Api.Data.Context;
using Api.Data.Repository;
using Domain.Entities;
using Domain.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Data.Implementations
{
    public class CepImplementation : BaseRepository<CepEntity>, ICepRepository
    {
        private DbSet<CepEntity> _dataset;
        public CepImplementation(MyContext context) : base(context)
        {
            _dataset = context.Set<CepEntity>();
        }
        public async Task<CepEntity> SelectAsync(string cepValue)
        {
            return await _dataset.Include(cep => cep.MunicipioEntity)
                                    .ThenInclude(municipio => municipio.UfEntity)  
                                    .FirstOrDefaultAsync(cep => cep.Cep.Equals(cepValue));
        }
    }
}

//  cep possui um municipio que possui um uf, por isso eu passei o include e then include no metodo acima