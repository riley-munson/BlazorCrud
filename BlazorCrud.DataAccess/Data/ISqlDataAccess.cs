using System.Data;

namespace BlazorCrud.DataAccess.Data
{
	public interface ISqlDataAccess
	{
		Task BulkInsert<T>(IEnumerable<T> entities) where T : class;
		Task<bool> Delete<T>(T entity) where T : class;
		Task<IEnumerable<T>> GetAll<T>() where T : class;
		Task<T> GetById<T>(int id) where T : class;
		Task<int> Insert<T>(T entity) where T : class;
		Task<IEnumerable<T>> LoadData<T>(string sql, object parameters = null, CommandType commandType = CommandType.Text);
		Task<IEnumerable<TReturn>> LoadData<T1, T2, TReturn>(string sql, Func<T1, T2, TReturn> map, object parameters = null, CommandType commandType = CommandType.Text, string splitOn = "Id");
		Task<int> SaveData<T>(string sql, object parameters, CommandType command = CommandType.Text);
		Task<bool> Update<T>(T entity) where T : class;
	}
}