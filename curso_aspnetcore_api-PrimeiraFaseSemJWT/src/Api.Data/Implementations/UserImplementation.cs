using Api.Data.Context;
using Api.Data.Repository;
using Api.Domain.Entities;
using Domain.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Data.Implementations
{
    public class UserImplementation : BaseRepository<UserEntity>, IUserRepository
    {
        private DbSet<UserEntity> _dataset;

        public UserImplementation(MyContext context) : base(context)
        {  
             _dataset = context.Set<UserEntity>();
        }

        public async Task<UserEntity> FindByLogin(string email) //serve para encontrar o email que o usuario passou no momento do login
        {
            return await _dataset.FirstOrDefaultAsync(user => user.Email.Equals(email));
        }
    }
}
