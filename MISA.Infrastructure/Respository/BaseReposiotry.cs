﻿using Dapper;
using Microsoft.Extensions.Configuration;
using MISA.Core.Interfaces.Repository;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.Infrastructure.Respository
{
    public class BaseReposiotry<T> : IBaseRepository<T>
    {
        IConfiguration _configuration;
        string _connectionString = string.Empty;
        protected IDbConnection _dbConnection = null;
        protected string _tableName;
        public BaseReposiotry(IConfiguration configuration)
        {
            _configuration = configuration;
            _connectionString = _configuration.GetConnectionString("MISACukcukConnectionString");
            _dbConnection = new MySqlConnection(_connectionString);
            _tableName = typeof(T).Name;
        }
        public int Delete(Guid entityId)
        {
            DynamicParameters dynamicParameters = new DynamicParameters();
            var storeEntityId = $"@{_tableName}Id";
            dynamicParameters.Add(storeEntityId, entityId);

            var res = _dbConnection.Execute($"Proc_Delete{_tableName}ById", param: dynamicParameters, commandType: CommandType.StoredProcedure);
            return res;
        }

        public IEnumerable<T> Get()
        {
            var entities = _dbConnection.Query<T>($"Proc_Get{_tableName}s", commandType: CommandType.StoredProcedure);
            return entities;
        }

        public T GetById(Guid entityId)
        {
            DynamicParameters dynamicParameters = new DynamicParameters();
            var storeEntityId = $"@{_tableName}Id";
            dynamicParameters.Add(storeEntityId, entityId);

            var customerGroup = _dbConnection.Query<T>($"Proc_Get{_tableName}ById", param: dynamicParameters, commandType: CommandType.StoredProcedure).FirstOrDefault();
            return customerGroup;
        }

        public int Insert(T entity)
        {
            var parmeters = MappingDbType(entity);
            var row = _dbConnection.Execute($"Proc_Insert{_tableName}", parmeters, commandType: CommandType.StoredProcedure);

            return row;
        }

        public int Update(T entity)
        {
            var parmeters = MappingDbType(entity);
            var row = _dbConnection.Execute($"Proc_Update{_tableName}", parmeters, commandType: CommandType.StoredProcedure);

            return row;
        }

        private DynamicParameters MappingDbType(T entity)
        {
            var properties = entity.GetType().GetProperties();
            var parameters = new DynamicParameters();
            foreach (var property in properties)
            {
                var propertyName = property.Name;
                var propertyValue = property.GetValue(entity);
                var propertyType = property.PropertyType;
                if (propertyType == typeof(Guid) || propertyValue == typeof(Guid?))
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

        public T GetEntityBySpecs(string propertyName, object propertyValue)
        {
            var query = $"SELECT * FROM {_tableName} WHERE {propertyName} = '{propertyValue}'";
            var entity = _dbConnection.Query<T>(query, commandType: CommandType.Text).FirstOrDefault();
            return entity;
        }
    }
}