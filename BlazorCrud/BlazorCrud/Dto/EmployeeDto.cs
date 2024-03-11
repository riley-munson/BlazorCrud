using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace BlazorCrud.Dto
{
	public class EmployeeDto
	{
		[Required(ErrorMessage = "This field is required")]
		[EmailAddress(ErrorMessage = "Please enter a valid email address")]
		public string Email { get; set; }
		[Required(ErrorMessage = "This field is required")]
		public string FirstName { get; set; }
		[Required(ErrorMessage = "This field is required")]
		public string LastName { get; set; }
		[Required(ErrorMessage = "This field is required")]
		public string? Title { get; set; }
		[Required(ErrorMessage = "This field is required")]
		public string? Department { get; set; }
		[Required(ErrorMessage = "This field is required")]
		public DateTime HireDate { get; set; } = DateTime.Today;
		public DateTime? LeaveDate {  get; set; }
		public bool IsManager { get; set; }
		public bool IsExecutive { get; set; }
		public bool IsTerminated { get; set; }
	}
}
