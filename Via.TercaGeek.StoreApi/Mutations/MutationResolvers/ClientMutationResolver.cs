using Via.TercaGeek.StoreApi.Models;
using Via.TercaGeek.StoreApi.Services;

namespace Via.TercaGeek.StoreApi.Mutations.MutationResolvers
{    
    public class ClientMutationResolver
    {
        public async Task<string> CreateClientAsync([Service] IClientService service, Client client)
        {
            var clientNew = await service.AddClientAsync(client);
            return $"Client saved with id: {clientNew.Id}";

        }

        public async Task<string> DeleteClientAsync([Service] IClientService service, [ID]Guid id)
        {
            var clientToRemove = await service.GetClientAsync(id);
            if (clientToRemove == null)
                return $"Client with id: {id} not found!!";
            await service.DeleteClientAsync(clientToRemove);
            return "Client removed with sucessfull"!;
        }
        
        public async Task<string> UpdateClientAsync([Service] IClientService service, [ID]Guid id, Client client)
        {            
            await service.UpdateClientAsync(id, client);

            return "Client update successfull";
        }
    }
}
