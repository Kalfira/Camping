using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Linq;
using System.Web;

namespace TeamMVC.Repositories
{
    public class GenericRepository : IGenericRepository
    {
        private DbContext _db;

        public GenericRepository(DbContext db)
        {
            _db = db;
        }

        public IQueryable<T> Query<T>() where T : class
        {
            return _db.Set<T>().AsQueryable();
        }

        public IQueryable Query(string entityTypeName)
        {
            var entityType = Type.GetType(entityTypeName);
            return _db.Set(entityType).AsQueryable();
        }

        public T Find<T>(params object[] keyValues) where T : class
        {
            return _db.Set<T>().Find(keyValues);
        }

        public void Add<T>(T entityToCreate) where T : class
        {
            _db.Set<T>().Add(entityToCreate);
        }

        public void Delete<T>(params object[] keyValues) where T : class
        {
            var entity = this.Find<T>(keyValues);
            _db.Set<T>().Remove(entity);
        }

        public void SaveChanges()
        {
            try
            {
                _db.SaveChanges();
            }
            catch (DbEntityValidationException dbval)
            {
                var firstError = dbval.EntityValidationErrors.First().ValidationErrors.First().ErrorMessage;
                throw new ValidationException(firstError);
            }
        }

        public IEnumerable<T> SqlQuery<T>(string sql, params object[] paramerters)
        {
            return _db.Database.SqlQuery<T>(sql, paramerters);
        }

        public void Dispose()
        {
            _db.Dispose();
        }
    }
}