using System.ComponentModel.DataAnnotations;

namespace BlazorCrud.Dto
{
	public class ClientFormDto
	{
		[Required(ErrorMessage = "This field is required")]
		public string? Name { get; set; }
		public string? Address1 { get; set; }
		public string? Address2 { get; set; }
		public string? City { get; set; }
		public string? State { get; set; }
		public string? PostalCode { get; set; }
		public string? Country { get; set; }
		public List<ClientContact> Contacts { get; set; } = new List<ClientContact>();
	}
}
