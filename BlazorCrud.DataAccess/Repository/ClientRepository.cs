using BlazorCrud.DataAccess.Data;
using BlazorCrud.DataAccess.Dto;
using BlazorCrud.DataAccess.Interfaces;
using BlazorCrud.DataAccess.Models;
using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BlazorCrud.DataAccess.Repository
{
	public class ClientRepository : RepositoryBase<Client>, IClientRepository
	{
		public ClientRepository(ISqlDataAccess db) : base(db)
		{
		}

		public override async Task<IEnumerable<Client>> GetAll()
		{
			var clients = await base.GetAll();
		
			string sql = @"SELECT * FROM [dbo].[ClientContacts]";
			var contacts = await _db.LoadData<ClientContact>(sql, null);

			foreach(var client in clients)
			{
				var meme = contacts.Where(x => x.ClientId == client.Id).ToList();
				client.Contacts = contacts.Where(c => c.ClientId == client.Id);
			}

			return clients;
		}

		public override async Task<Client> GetById(int id)
		{
			var client = await base.GetById(id);
			string sql = @"SELECT * FROM [dbo].[ClientContacts] WHERE ClientId = @ClientId";
			client.Contacts = await _db.LoadData<ClientContact>(sql, new { ClientId = id });
			return client;
		}

		public override async Task<int> Add(Client client)
		{
			ClientDto clientDto = new()
			{
				Name = client.Name,
				Address1 = client.Address1,
				Address2 = client.Address2,
				City = client.City,
				State = client.State,
				PostalCode = client.PostalCode,
				Country = client.Country
			};
			var id = await _db.Insert(clientDto);
			if(client.Contacts != null && client.Contacts.Count() > 0)
			{
				foreach (ClientContact contact in client.Contacts)
				{
					contact.ClientId = id;
				}

				await _db.BulkInsert(client.Contacts);
			}
			

			return id;
		}

		public override async Task<bool> Update(Client client)
		{
			ClientDto clientDto = new()
			{
				Id = client.Id,
				Name = client.Name,
				Address1 = client.Address1,
				Address2 = client.Address2,
				City = client.City,
				State = client.State,
				PostalCode = client.PostalCode,
				Country = client.Country
			};
			await _db.Update(clientDto);

			string sql = @"SELECT * FROM [dbo].[ClientContacts] WHERE ClientId = @ClientId";
			var currentContacts = await _db.LoadData<ClientContact>(sql, new {ClientId = client.Id});

			foreach(ClientContact contact in client.Contacts)
			{
				if(contact.Id == 0)
				{
					await _db.Insert(contact);
				}
				else if(currentContacts.Any(c => c.Id == contact.Id))
				{
					await _db.Update(contact);
				}
			}

			foreach(ClientContact contact in currentContacts.Where(c => !client.Contacts.Any(c2 => c2.Id == c.Id)))
			{
				await _db.Delete(contact);
			}

			return true;
		}
	}
}
