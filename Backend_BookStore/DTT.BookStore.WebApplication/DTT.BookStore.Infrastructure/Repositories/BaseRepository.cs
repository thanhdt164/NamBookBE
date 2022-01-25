using DTT.BookStore.Core.Interfaces;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Dapper;
using System.Linq;

namespace DTT.BookStore.Infrastructure.Repositories
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity>
    {
        #region Declare
        IConfiguration _configuration;
        string _connectionString = string.Empty;
        protected IDbConnection _dbConnection;
        protected string _entityName = string.Empty;
        #endregion
        #region Constructor
        public BaseRepository(IConfiguration configuration)
        {
            _configuration = configuration;
            _connectionString = _configuration.GetConnectionString("DTTBookStore");
            _dbConnection = new MySqlConnection(_connectionString);
            _entityName = typeof(TEntity).Name;
        }
        #endregion

        public IEnumerable<TEntity> GetAll()
        {
            var entities = _dbConnection.Query<TEntity>($"Proc_Get{_entityName}s", commandType: CommandType.StoredProcedure);
            return entities;
        }

        public TEntity GetById(int entityId)
        {
            //var parameter = new DynamicParameters();
            //parameter.Add($"@{_entityName}_id", entityId, DbType.String);
            //var entity = _dbConnection.Query<TEntity>($"Proc_Get{_entityName}ById", param: parameter, commandType: CommandType.StoredProcedure).FirstOrDefault();
            var sql = $"Select * from tbl{_entityName} where {_entityName}_id = '{entityId.ToString()}'";
            var entity = _dbConnection.Query<TEntity>(sql, commandType: CommandType.Text).FirstOrDefault();
            return entity;
        }

        public virtual int Insert(TEntity entity)
        {
            var parameters = MappingDbType(entity);
            var rowAffects = _dbConnection.Execute($"Proc_Insert{_entityName}", param: parameters, commandType: CommandType.StoredProcedure);
            return rowAffects;
        }

        public int Update(TEntity entity)
        {
            var parameters = MappingDbType(entity);
            var rowAffects = _dbConnection.Execute($"Proc_Update{_entityName}", param: parameters, commandType: CommandType.StoredProcedure);
            return rowAffects;
        }

        public int Delete(int entityId)
        {
            var sql = $"Delete from tbl{_entityName} where {_entityName}_id = '{entityId.ToString()}'";
            var rowAffects = _dbConnection.Execute(sql, commandType: CommandType.Text);
            return rowAffects;
        }

        /// <summary>
        /// Hàm mapping dữ liệu 
        /// </summary>
        /// <typeparam name="TEntity">Kiểu dữ liệu dùng chung</typeparam>
        /// <param name="entity">Instance kiểu dữ liệu dùng chung</param>
        /// <returns>Tham số sau mapping</returns>
        private DynamicParameters MappingDbType(TEntity entity)
        {
            var parameters = new DynamicParameters();
            var properties = entity.GetType().GetProperties();
            foreach (var property in properties)
            {
                if(property.Name == "created_at" || property.Name == "updated_at" || property.Name == "deleted_at")
                {
                    continue;
                }
                var propertyName = property.Name;
                var propertyValue = property.GetValue(entity);
                var propertyType = property.PropertyType;
                if (propertyType == typeof(Guid) || propertyType == typeof(Guid?))
                {
                    parameters.Add($"@{propertyName}", propertyValue, DbType.String);
                }
                else
                {
                    parameters.Add($"@{propertyName}", propertyValue);
                }
            }
            return parameters;
        }

    }
}
