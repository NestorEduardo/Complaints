using Complaints.Core.Models;
using Complaints.Repository.Interfaces;
using Complaints.Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Complaints.Services.Implementations
{
    public abstract class BaseService<T, U> : IBaseService<T, U> where T : BaseEntity where U : IBaseRepository<T>
    {
        protected U repository;
        public BaseService(U repository) => this.repository = repository;
        public async Task<int> Create(T entity) => await repository.Insert(entity);
        public async Task<int> Update(T entity, int id) => await repository.Update(entity, id);
        public async Task<int> Delete(int id) => await repository.SoftDelete(id);
        public virtual async Task<List<T>> GetAll() => await repository.GetAll();
        public async Task<T> GetById(int id) => await repository.GetById(id);
    }
}
