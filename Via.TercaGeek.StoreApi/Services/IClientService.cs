using Via.TercaGeek.StoreApi.Models;

namespace Via.TercaGeek.StoreApi.Services
{
    public interface IClientService
    {
        Task<Client> AddClientAsync(Client client);
        Task<Client> GetClientAsync(Guid id);
        Task<IEnumerable<Client>> GetClientsAsync();
        Task DeleteClientAsync(Client client);
        Task<Client> UpdateClientAsync(Guid id, Client client);
    }
}
