using Calendar.Models.Models.Auth;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendar.Repository.Repository.Generic
{
    public interface IGenericRepository<T> where T : class
    {
        Task<List<T>> GetAll();
        Task<IEnumerable<T>> GetAll(int offset, int limit);
        Task<T> FindByName(string name);
        Task<T> FindById(int id);
        Task<T> Insert(T entity);
        Task<T> Update(T entity);
        Task<T> Delete(T entity);
        DbSet<T> GetDbSet();
        Task<List<T>> FromSqlRaw(string sqlQuery);
        Task<User> checkEmailExist(string email);
        Task<Application> checkApplicationExist(string applicationName);
        Task<UserRole> checkuserRoleExist(int userId, int applicationId, int roleId);
    }
}
