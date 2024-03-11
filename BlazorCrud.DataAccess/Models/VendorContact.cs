using BlazorCrud.DataAccess.ModelComponents;
using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorCrud.DataAccess.Models
{
	public class VendorContact : Contact
	{
		[Key]
		public int Id { get; set; }
        public int VendorId { get; set; }
    }
}
