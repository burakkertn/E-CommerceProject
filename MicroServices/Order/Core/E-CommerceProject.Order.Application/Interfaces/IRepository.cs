﻿using System.Linq.Expressions;

namespace E_CommerceProject.Order.Application.Interfaces
{
    public interface IRepository<T> where T : class
    {
        Task<List<T>> GetAllAsync();
        Task<T> GetByIdAsync(int id);
        Task CreateAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(T Entity);
        Task<T> GetByFilterAsync(Expression<Func<T, bool>> filter);
    }
}
