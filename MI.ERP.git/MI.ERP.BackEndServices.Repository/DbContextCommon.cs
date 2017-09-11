using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;

using MI.ERP.BackEndServices.Repository.Contracts;

namespace MI.ERP.BackEndServices.Repository
{
    public class DbContextCommon : DbContext, IDbContextCommon
    {
        public DbContextCommon(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {
        }

        public DbContextCommon()
        {
        }

        //public void BulkInsertExtention<T>(IEnumerable<T> entities, int? batchSize = null)
        //{
        //    this.BulkInsert(entities, batchSize);
        //}

        //public void BulkInsertExtention<T>(IEnumerable<T> entities, BulkInsertOptions options)
        //{
        //    this.BulkInsert(entities, options);
        //}

        //public void BulkInsertExtention<T>(IEnumerable<T> entities, SqlBulkCopyOptions sqlBulkCopyOptions,
        //    int? batchSize = null)
        //{
        //    this.BulkInsert(entities, sqlBulkCopyOptions, batchSize);
        //}

        //public void BulkInsertExtention<T>(IEnumerable<T> entities, IDbTransaction transaction,
        //    SqlBulkCopyOptions sqlBulkCopyOptions = SqlBulkCopyOptions.Default, int? batchSize = null)
        //{
        //    this.BulkInsert(entities, transaction, sqlBulkCopyOptions, batchSize);
        //}
    }
}
