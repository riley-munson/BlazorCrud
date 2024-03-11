using Dapper;
using Dapper.Contrib.BulkInsert;
using Dapper.Contrib.Extensions;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorCrud.DataAccess.Data
{
	public class SqlDataAccess : ISqlDataAccess
	{
		private readonly string _connectionString;
		public SqlDataAccess(IConfiguration config)
		{
			_connectionString = config.GetConnectionString("default")!;
		}

		public async Task<IEnumerable<T>> GetAll<T>() where T : class
		{
			using (IDbConnection connection = new SqlConnection(_connectionString))
			{
				return await connection.GetAllAsync<T>();
			}
		}

		public async Task<T> GetById<T>(int id) where T : class
		{
			using (IDbConnection connection = new SqlConnection(_connectionString))
			{
				return await connection.GetAsync<T>(id);
			}
		}

		public async Task<bool> Update<T>(T entity) where T : class
		{
			using (IDbConnection connection = new SqlConnection(_connectionString))
			{
				return await connection.UpdateAsync(entity);
			}
		}

		public async Task<int> Insert<T>(T entity) where T : class
		{
			using (IDbConnection connection = new SqlConnection(_connectionString))
			{
				return await connection.InsertAsync(entity);
			}
		}

		public async Task BulkInsert<T>(IEnumerable<T> entities) where T : class
		{
			using (IDbConnection connection = new SqlConnection(_connectionString))
			{
				await connection.InsertBulkAsync(entities);
			}
		}

		public async Task<bool> Delete<T>(T entity) where T : class
		{
			using (IDbConnection connection = new SqlConnection(_connectionString))
			{
				return await connection.DeleteAsync(entity);
			}
		}

		public async Task<IEnumerable<T>> LoadData<T>(string sql, object parameters = null, CommandType commandType = CommandType.Text)
		{
			using (IDbConnection connection = new SqlConnection(_connectionString))
			{
				return await connection.QueryAsync<T>(sql, parameters, commandType: commandType);
			}
		}

		public async Task<IEnumerable<TReturn>> LoadData<T1, T2, TReturn>(string sql, Func<T1, T2, TReturn> map, object parameters = null, CommandType commandType = CommandType.Text, string splitOn = "Id")
		{
			using (IDbConnection connection = new SqlConnection(_connectionString))
			{
				return await connection.QueryAsync(sql, map, parameters, commandType: commandType, splitOn: splitOn);
			}
		}

		public async Task<int> SaveData<T>(string sql, object parameters, CommandType command = CommandType.Text)
		{
			using (IDbConnection connection = new SqlConnection(_connectionString))
			{
				return await connection.ExecuteAsync(sql, parameters, commandType: command);
			}
		}
	}
}
