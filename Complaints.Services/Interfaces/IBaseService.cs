using Complaints.Core.Models;
using Complaints.Repository.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Complaints.Services.Interfaces
{
    public interface IBaseService<T, U> where T : BaseEntity where U : IBaseRepository<T>
    {
        Task<List<T>> GetAll();
        Task<T> GetById(int id);
        public Task<int> Create(T entity);
        public Task<int> Update(T entity, int id);
        public Task<int> Delete(int id);
    }
}
