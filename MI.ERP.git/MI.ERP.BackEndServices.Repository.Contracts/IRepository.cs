﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

//using EntityFramework.BulkInsert.Extensions;

namespace MI.ERP.BackEndServices.Repository.Contracts
{
    public interface IRepository<TEntity> : IDisposable where TEntity : class
    {
        IQueryable<TEntity> GetAll();

        TEntity Get(long id);
        Task<TEntity> GetAsync(long id);

        IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> filter = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null, string includeProperties = "");

        TEntity Add(TEntity t);
        Task<TEntity> AddAsync(TEntity t);

        void Delete(TEntity entityToDelete);
        Task<int> DeleteAsync(TEntity entityToDelete);

        int Count();
        Task<int> CountAsync();

        IEnumerable<TEntity> ExecuteSqlQueryResult(string query, int commandTimeOut, params object[] parameters);


        void ExecuteSqlQuery(string query, int commandTimeOut, params object[] parameters);
        Task<int> ExecuteSqlQueryAsync(string query, int commandTimeOut, params object[] parameters);

        TEntity Update(TEntity modifiableObject);
        Task<TEntity> UpdateAsync(TEntity modifiableObject);

       // void BulkInserts(IEnumerable<TEntity> entities, BulkInsertOptions options);
    }
}
