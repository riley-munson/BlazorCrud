using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorCrud.DataAccess.Models
{
	public class VendorService
	{
		[Key]
		public int Id { get; set; }
        public Vendor Vendor { get; set; }
        public string? Service { get; set; }
    }
}
