using BlazorCrud.DataAccess.Data;
using BlazorCrud.DataAccess.Interfaces;
using BlazorCrud.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorCrud.DataAccess.Repository
{
	public abstract class RepositoryBase<T> : IRepository<T> where T : class
	{
        protected readonly ISqlDataAccess _db;
        public RepositoryBase(ISqlDataAccess db)
        {
            _db = db;
        }

		public virtual async Task<int> Add(T model)
		{
			return await _db.Insert(model);
		}

		public virtual async Task AddMany(IEnumerable<T> models)
		{
			await _db.BulkInsert(models);
		}

		public virtual async Task<bool> Delete(T model)
		{
			return await _db.Delete(model);
		}

		public virtual async Task<IEnumerable<T>> GetAll()
		{
			return await _db.GetAll<T>();
		}

		public virtual async Task<T> GetById(int id)
		{
			return await _db.GetById<T>(id);
		}

		public virtual async Task<bool> Update(T model)
		{
			return await _db.Update(model);
		}
	}
}
