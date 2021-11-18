using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Domain.Entities;

namespace Api.Domain.Interfaces {
    public interface IRepository<T> where T : BaseEntity
    { // vai ser injetado aqui qualquer classe onde tem como heranca o baseEntity
        Task<T> InsertAsync(T item); // post
        Task<T> UpdateAsync(T item); // put
        Task<bool> DeleteAsync(Guid id); // delete
        Task<T> SelectAsync(Guid id); // get por id
        Task<IEnumerable<T>> SelectAsync(); //Ienumerable tem menos funcoes porem e mais rapido getall
        Task<bool> ExistAsync(Guid id);
    }
}
