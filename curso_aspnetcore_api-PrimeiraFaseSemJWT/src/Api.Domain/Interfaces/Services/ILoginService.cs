using Api.Domain.Entities;
using Domain.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface ILoginService
    {
        Task<object> FindByLogin(CreateLoginDTO user);
    }
}
