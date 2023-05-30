using Via.TercaGeek.StoreApi.Models;
using Via.TercaGeek.StoreApi.Services;

namespace Via.TercaGeek.StoreApi.Queries.QueryResolvers
{    
    public class ClientQueryResolver
    {
        public async Task<IEnumerable<Client>> GetClients([Service] IClientService service) =>
           await service.GetClientsAsync();

        [GraphQLNonNullType]
        public async Task<Client> GetClient([Service]IClientService service, [ID]Guid id) =>
            await service.GetClientAsync(id);
    }
}
