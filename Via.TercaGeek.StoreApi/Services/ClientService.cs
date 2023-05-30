using Microsoft.EntityFrameworkCore;
using Via.TercaGeek.StoreApi.Context;
using Via.TercaGeek.StoreApi.Models;

namespace Via.TercaGeek.StoreApi.Services
{
    public class ClientService : IClientService
    {
        private readonly StoreDb _db;

        public ClientService(StoreDb db)
        {
            _db = db;
        }

        public async Task<Client> AddClientAsync(Client client)
        {
            _db.Clients.Add(client);
            await _db.SaveChangesAsync();
            return client;
        }

        public async Task DeleteClientAsync(Client client)
        {
            _db.Clients.Remove(client);
            await _db.SaveChangesAsync();
        }                  
            
        

        public async Task<Client> GetClientAsync(Guid id) => 
            await _db.Clients.Include(c => c.Addresses).FirstOrDefaultAsync(c => c.Id == id) ?? default;

        public async Task<IEnumerable<Client>> GetClientsAsync() =>
            await _db.Clients.Include(c => c.Addresses).ToListAsync();

        public async Task<Client> UpdateClientAsync(Guid id, Client client)
        {
            var clientToUpdate = await _db.Clients.FirstOrDefaultAsync(c => c.Id == id);
            if (clientToUpdate == null)
                return default;
            clientToUpdate.Name = client.Name;
            clientToUpdate.Age = client.Age;
            clientToUpdate.IdentificationDocument = client.IdentificationDocument;
            clientToUpdate.Addresses = client.Addresses;
            await _db.SaveChangesAsync();

            return client;
        }       
    }
}
