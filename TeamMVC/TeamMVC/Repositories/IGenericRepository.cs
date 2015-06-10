using System;
using System.Collections.Generic;
using System.Linq;

namespace TeamMVC.Repositories
{
    public interface IGenericRepository : IDisposable
    {
        IQueryable<T> Query<T>() where T : class;
        IQueryable Query(string entityTypeName);
        T Find<T>(params object[] keyValues) where T : class;
        void Add<T>(T entityToCreate) where T : class;
        void Delete<T>(params object[] keyValues) where T : class;
        void SaveChanges();
        IEnumerable<T> SqlQuery<T>(string sql, params object[] paramerters);
    }
}