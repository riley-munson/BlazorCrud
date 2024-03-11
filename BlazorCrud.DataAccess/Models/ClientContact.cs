using BlazorCrud.DataAccess.ModelComponents;
using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorCrud.DataAccess.Models
{
	public class ClientContact
	{
        [Dapper.Contrib.Extensions.Key]
        public int Id { get; set; }
        public int ClientId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        [EmailAddress(ErrorMessage = "Plase enter a valid email")]
        public string? Email { get; set; }
        [Phone(ErrorMessage = "Please enter a valid phone number")]
        public string? PhoneNumber1 { get; set; }
		[Phone(ErrorMessage = "Please enter a valid phone number")]
		public string? PhoneNumber2 { get; set; }
    }
}
