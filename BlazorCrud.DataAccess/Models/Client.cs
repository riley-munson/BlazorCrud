using BlazorCrud.DataAccess.ModelComponents;
using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorCrud.DataAccess.Models
{
	public class Client
	{
		[Key]
		public int Id { get; set; }
		public string? Name { get; set; }
		public string? Address1 { get; set; }
		public string? Address2 { get; set; }
		public string? City { get; set; }
		public string? State { get; set; }
		public string? PostalCode { get; set; }
		public string? Country { get; set; }
		public IEnumerable<ClientContact>? Contacts { get; set; }
    }
}
