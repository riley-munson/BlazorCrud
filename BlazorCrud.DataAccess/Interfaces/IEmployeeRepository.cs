using BlazorCrud.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorCrud.DataAccess.Interfaces
{
	public interface IEmployeeRepository : IRepository<Employee>
	{
		Task<Employee> GetByEmail(string email);
	}
}
