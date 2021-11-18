using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Data.Context;
using Api.Domain.Entities;
using Api.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Api.Data.Repository {
    public class BaseRepository<T> : IRepository<T> where T : BaseEntity {

        protected readonly MyContext _context; //INJECAO DE DEPENDENCIA
        private DbSet<T> _dataset; //trabalha com qualquer tipo de table

        public BaseRepository (MyContext context) { //TODA VEZ QUE A CLASSE É INSTANCIADA EU PEGO O CONTEXTO E PASSO PARA A VARIAVEL ABAIXO, AI SIM VOU CONSEGUIR ENXEGAR O CONTEXTO EM TODA MINHA CLASSE
            _context = context;
            _dataset = _context.Set<T>(); //ao inves de toda vez ter que setar o _context.Set<t> já defino apenas uma vez
        }

        public async Task<bool> DeleteAsync(Guid id)
        {
            try
            {
                var result = await _dataset.SingleOrDefaultAsync (ids => ids.Id.Equals(id));

                if (result == null)
                {
                    return false;
                }

                _dataset.Remove(result);
                await _context.SaveChangesAsync(); // da commit no banco

                return true;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public async Task<T> InsertAsync(T item)
        {
            try
            {
                if(item.Id == Guid.Empty) //certifica que o item recebido ta sem ID, se tiver sem a gente cria
                {
                    item.Id = Guid.NewGuid();
                }

                item.CreateAt = DateTime.UtcNow;
                _dataset.Add(item);

                await _context.SaveChangesAsync();
            }
            catch(Exception ex)
            {
                throw ex;
            }

            return item;
        }

        public async Task<bool> ExistAsync(Guid id)
        {
            return await _dataset.AnyAsync(ids => ids.Id.Equals(id)); // metodo AnyAsync retorna verdadeiro ou falso
        }

        public async Task<T> SelectAsync(Guid id)
        {
            try
            {
                return await _dataset.SingleOrDefaultAsync(ids => ids.Id.Equals(id));
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public async Task<IEnumerable<T>> SelectAsync() {
            try
            {
                return await _dataset.ToListAsync(); //FAMOSO select sem where
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public async Task<T> UpdateAsync(T item)
        {
            try
            {
                var result = await _dataset.SingleOrDefaultAsync(itens => itens.Id.Equals(item.Id)); // a busca e feita no BD | INFORMACAO VINDA DO FRONT

                if (result == null)
                {
                    return null;
                }

                item.UpdateAt = DateTime.UtcNow;
                item.CreateAt = result.CreateAt; // garanti a data que foi criado o update

                _context.Entry(result).CurrentValues.SetValues(item); // faz o update na base
                await _context.SaveChangesAsync();
            }
            catch(Exception ex)
            {
                throw ex;
            }

            return item;
        }
    }
}
