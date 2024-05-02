using Calendar.DbContexts.DbContexts;
using Calendar.Models.Models.Auth;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendar.Repository.Repository.Generic
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {

        #region declaration

        private readonly CalendarDbContext _dbContext;
        private readonly DbSet<T> _dbSet;
        #endregion

        #region constructor
        public GenericRepository(CalendarDbContext dbContext)
        {

            _dbContext = dbContext;

            _dbSet = _dbContext.Set<T>();
        }
        #endregion
        #region Generic delete

        public async Task<T> Delete(T entity)
        {
            //First, fetch the record from the table
            T existing = _dbSet.Find(entity);
            //This will mark the Entity State as Deleted
            _dbSet.Remove(entity);

            return entity;
        }
        #endregion


        #region Generic findbyid
        public async Task<T> FindById(int id)
        {
            return _dbSet.Find(id);
        }
        #endregion

        #region Generic findbyname
        public async Task<T> FindByName(string name)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Generic getalllimit
        public async Task<IEnumerable<T>> GetAll(int offset, int limit)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Generic getdbset
        public DbSet<T> GetDbSet()
        {
            throw new NotImplementedException();
        } 
        #endregion


        #region Generic getall
        public async Task<List<T>> GetAll()
        {
            return _dbSet.ToList();
        }
        #endregion


        #region Generic insert
        public async Task<T> Insert(T entity)
        {
            //throw new NotImplementedException();

            _dbSet.Add(entity);

            await _dbContext.SaveChangesAsync();

            return entity;
        }
        #endregion

        #region Generic updateall
        public async Task<T> Update(T entity)
        {
            _dbSet.Attach(entity);
            //Then set the state of the Entity as Modified
            _dbContext.Entry(entity).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();

            return entity;
        }
        #endregion

        #region Generic sqlraw
        public async Task<List<T>> FromSqlRaw(string sqlQuery)
        {
            var result = await _dbSet.FromSqlRaw<T>(sqlQuery).ToListAsync();
            return result;
        }
        #endregion

        #region Generic EmailExist
        public async Task<User> checkEmailExist(string email)
        {

            User user = new User();
            var result = await _dbContext.Users.Where(x => x.Email == email).SingleOrDefaultAsync();
            if (result != null)
            {
                user.Id = result.Id;
                user.Username=result.Username;
                user.Email = result.Email;
                user.ApplicationId = result.ApplicationId;
                user.SecretKey = result.SecretKey;
              
                return user;
            }
            else
            {
                return new User();
            }


        }
        #endregion



        #region Generic ApplicationExist
        public async Task<Application> checkApplicationExist(string applicationName)
        {
            Application application = new Application();
            var result = await _dbContext.Applications.Where(x => x.ApplicationName == applicationName).SingleOrDefaultAsync();
            if (result != null) {
                application.Id = result.Id;
                application.ApplicationName = result.ApplicationName;
                application.IsActive = result.IsActive;
                return application;
            }
            else
            {
                return new Application();
            }
            
        }
        #endregion


        #region Generic UserRoleExist
        public async Task<UserRole> checkuserRoleExist(int applicationId, int userId, int roleId)
        {

            UserRole userRole = new UserRole();
            var result = await _dbContext.UserRoles.Where(x => x.ApplicationId == applicationId && x.UserId == userId && x.RoleId == roleId).SingleOrDefaultAsync();
            if (result != null)
            {
                userRole.Id = result.Id;
                userRole.ApplicationId = result.ApplicationId;
                userRole.UserId = result.UserId;
                userRole.RoleId = roleId;
                userRole.IsActive = result.IsActive;
                return userRole;
            }
            else
            {
                return new UserRole();
            }
        }
        #endregion

    }
}
