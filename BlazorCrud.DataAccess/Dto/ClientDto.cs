using BlazorCrud.DataAccess.Models;
using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorCrud.DataAccess.Dto
{
	[Table("Clients")]
	public class ClientDto
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
	}
}
