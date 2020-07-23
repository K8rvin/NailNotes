using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;

namespace LizokasNail.Core.Dao
{
    /// <summary>
    /// Базовый функционал работы с БД
    /// </summary>
    public class BaseDao
    {
        private IDataSource _dataSource;

        private DbContext GetContext()
        {
            return _dataSource.GetContext();
        }

        /// <summary>
        /// Контекст БД передается из DI-контейнера через реализацию IDataSource
        /// </summary>
        /// <param name="dataSource">поставщик контекста БД</param>
        public BaseDao(IDataSource dataSource)
        {
            _dataSource = dataSource;
        }

        /// <summary>
        /// Чтение данных из контекста.
        /// </summary>
        /// <typeparam name="T">тип возвращаемого значения</typeparam>
        /// <param name="action">операция над контекстом</param>
        /// <returns>результат операции</returns>
        public T ReadContext<T>(Func<DbContext, T> action)
        {
            var db = GetContext();
            try
            {
                var result = action(db);
                return result;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Обновление контекста без возвращаемого значения.
        /// </summary>
        /// <param name="action">операция над контекстом</param>
        /// <returns>результат операции</returns>
        public void UpdateContext(Action<DbContext> action)
        {
            var db = GetContext();

            try
            {
                action(db);
                db.SaveChanges();
            }

            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Обновление контекста без возвращаемого значения в одной транзакции.
        /// </summary>
        /// <param name="action">операция над контекстом</param>
        /// <returns>результат операции</returns>
        public void UpdateContextInTransaction(Action<DbContext> action)
        {
            var db = GetContext();

            using (var transaction = db.Database.BeginTransaction())
            {
                try
                {
                    action(db);
                    db.SaveChanges();
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }

        public void CheckCmdConnection(DbCommand cmd)
        {
            while (cmd.Connection.State == ConnectionState.Connecting
                || cmd.Connection.State == ConnectionState.Executing
                || cmd.Connection.State == ConnectionState.Fetching)
            { }

            if (cmd.Connection.State != ConnectionState.Open)
                cmd.Connection.Open();
        }

        public List<T> RawSqlQuery<T>(string query, Func<DbDataReader, T> map)
        {
            var context = GetContext();

            using (var command = context.Database.GetDbConnection().CreateCommand())
            {
                command.CommandText = query;
                command.CommandType = CommandType.Text;

                CheckCmdConnection(command);
                //context.Database.OpenConnection();

                using (var result = command.ExecuteReader())
                {
                    var entities = new List<T>();

                    while (result.Read())
                    {
                        entities.Add(map(result));
                    }

                    return entities;
                }
            }
        }
    }
}
