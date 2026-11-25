using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using Microsoft.Data.SqlClient;
using Dapper;
using System;

namespace Demo.Repository.GenricRepo
{
    public class GenericRepository<TEntity> where TEntity : class
    {
        /// <summary>
        /// Generates a connection string
        /// </summary>
        /// <typeparamname=""></typeparam>
        /// <paramname=""></param>
        /// <returns></returns>
        private IDbConnection CreateConnection()
        {
            string cn = "Data Source=tcp:einvoicing.database.windows.net;Initial Catalog=UATDemoPortal;User ID=E-Invoicing;Password=Admin@1234;Persist Security Info=True;";
            return new SqlConnection(cn);
        }
        /// <summary>
        /// Return the collection of T type
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sql"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public async Task<IEnumerable<T>> CollectionsAsync<T>(string sql, object parameters = null)
        {
            try
            {
                using (var connection = CreateConnection())
                {
                    var QueryResponse = await connection.QueryAsync<T>(sql: sql, param: parameters, commandType: CommandType.StoredProcedure);

                    return QueryResponse;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        /// <summary>
        /// Return the single row
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sql"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public async Task<T> SingleAsync<T>(string sql, object parameters = null)
        {
            try
            {
                using (var connection = CreateConnection())
                {
                    var QueryResponse = await connection.QuerySingleOrDefaultAsync
                    <T>(new CommandDefinition(commandText: sql, parameters: parameters, commandType: CommandType.StoredProcedure));

                    return QueryResponse;

                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
        /// <summary>
        /// Used to perform insert, update, delete
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sql"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public async Task<T> CommandAsync<T>(string sql, object parameters = null)
        {
            try
            {
                using (var connection = CreateConnection())
                {
                    var QueryResponse = await connection.QuerySingleAsync<T>(sql: sql, param: parameters, commandType: CommandType.StoredProcedure);
                    return QueryResponse;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Used for executing a stored procedure without any response 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sql"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public async Task ExecuteScalarAsync(string sql)
        {
            using (var connection = CreateConnection())
            {
                await connection.ExecuteScalarAsync(sql, commandType: CommandType.StoredProcedure);

            }
        }
    }
}
