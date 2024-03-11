using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorCrud.DataAccess.Models
{
	public class Vendor
	{
		[Key]
		public int Id { get; set; }
		public string? Name { get; set; }
		public ICollection<string> Services { get; set; }
        public ICollection<VendorContact> Contacts { get; set; }
    }
}
