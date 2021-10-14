using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Domain.Entities;

namespace Api.Domain.Interfaces {
    public interface IRepository<T> where T : BaseEntity { // vai ser injetado aqui qualquer classe onde tem como heranca o baseEntity
        Task<T> InsertAsync (T item);
        Task<T> UpdateAsync (T item);
        Task<bool> DeleteAsync (Guid id);
        Task<T> SelectAsync (Guid id);
        Task<IEnumerable<T>> SelectAsync (); //Ienumerable tem menos funcoes porem e mais rapido
        Task<bool> ExistAsync (Guid id);
    }
}
