using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Threading;
using System.Threading.Tasks;
//using EntityFramework.BulkInsert.Extensions;

namespace MI.ERP.BackEndServices.Repository.Contracts
{
    public interface IDbContextCommon : IDisposable
    {
        Database Database { get; }
        int SaveChanges();
        Task<int> SaveChangesAsync();
        DbSet<TEntity> Set<TEntity>() where TEntity : class;
        DbSet Set(Type entityType);
        DbEntityEntry Entry(object entity);
        DbEntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;

        // BulkInsert Extention
        //void BulkInsertExtention<T>(IEnumerable<T> entities, int? batchSize = null);
        //void BulkInsertExtention<T>(IEnumerable<T> entities, BulkInsertOptions options);

        //void BulkInsertExtention<T>(IEnumerable<T> entities, SqlBulkCopyOptions sqlBulkCopyOptions,
        //    int? batchSize = null);

        //void BulkInsertExtention<T>(IEnumerable<T> entities, IDbTransaction transaction,
        //    SqlBulkCopyOptions sqlBulkCopyOptions = SqlBulkCopyOptions.Default, int? batchSize = null);
    }
}
