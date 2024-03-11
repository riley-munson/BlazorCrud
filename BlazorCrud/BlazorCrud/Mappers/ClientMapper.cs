using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace BlazorCrud.Mappers
{
	public static class ClientMapper
	{
		public static DataAccess.Models.Client ToClient(this ClientFormDto dto)
		{
			return new DataAccess.Models.Client
			{
				Address1 = dto.Address1,
				Address2 = dto.Address2,
				City = dto.City,
				State = dto.State,
				PostalCode = dto.PostalCode,
				Country = dto.Country,
				Contacts = dto.Contacts,
				Name = dto.Name,
			};
		}

		public static ClientFormDto ToClientFormDto(this DataAccess.Models.Client client) 
		{
			return new ClientFormDto
			{
				Address1 = client.Address1,
				Address2 = client.Address2,
				City = client.City,
				State = client.State,
				PostalCode = client.PostalCode,
				Country = client.Country,
				Contacts = client.Contacts.ToList(),
				Name = client.Name,
			};
		}

		public static ClientListDto ToClientListDto(this DataAccess.Models.Client client)
		{
			return new ClientListDto
			{
				Id = client.Id,
				Address1 = client.Address1,
				Address2 = client.Address2,
				City = client.City,
				State = client.State,
				PostalCode = client.PostalCode,
				Country = client.Country,
				Name = client.Name,
			};
		}
	}
}
