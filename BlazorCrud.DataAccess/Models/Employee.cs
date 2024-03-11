using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorCrud.DataAccess.Models
{
	public class Employee
	{
        [Key]
		public int Id { get; set; }
        public string? Email { get; set; }
		public string? FirstName { get; set; }
		public string? LastName { get; set; }
		public string? Title { get; set; }
        public string? Department { get; set; }
        public DateTime HireDate { get; set; }
        public DateTime? LeaveDate { get; set; }
        public bool IsManager { get; set; }
        public bool IsExecutive { get; set; }
        public bool IsTerminated { get; set; }
    }
}
