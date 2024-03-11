using BlazorCrud.DataAccess.Data;
using BlazorCrud.DataAccess.Interfaces;
using BlazorCrud.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorCrud.DataAccess.Repository
{
	public class EmployeeRepository : RepositoryBase<Employee>, IEmployeeRepository
	{
        public EmployeeRepository(ISqlDataAccess db) : base(db) { }

		public async Task<Employee> GetByEmail(string email)
		{
			string sql = @"SELECT * FROM [dbo].[Employees] WHERE Email = @Email";
			return (await _db.LoadData<Employee>(sql, new { Email = email })).FirstOrDefault();
		}

	}
}
