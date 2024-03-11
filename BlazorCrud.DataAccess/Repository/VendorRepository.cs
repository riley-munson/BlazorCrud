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
	public class VendorRepository : RepositoryBase<Vendor>, IVendorRepository
	{
		public VendorRepository(ISqlDataAccess db) : base(db)
		{
		}
	}
}
