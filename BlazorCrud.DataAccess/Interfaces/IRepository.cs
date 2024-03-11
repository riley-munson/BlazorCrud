using BlazorCrud.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorCrud.DataAccess.Interfaces
{
	public interface IRepository<T>
	{
		Task<T> GetById(int id);
		Task<IEnumerable<T>> GetAll();
		Task<int> Add(T model);
		Task AddMany(IEnumerable<T> models);
		Task<bool> Update(T model);
		Task<bool> Delete(T model);
	}
}
