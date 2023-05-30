using Via.TercaGeek.StoreApi.Models;

namespace Via.TercaGeek.StoreApi.Types
{
    public class ClientInputType: InputObjectType<Client>
    {
        protected override void Configure(IInputObjectTypeDescriptor<Client> descriptor)
        {
            descriptor.Name("ClientInput");           
            descriptor.Field(_ => _.Name);                
            descriptor.Field(_ => _.Age);
            descriptor.Field(_ => _.IdentificationDocument);
            descriptor.Field(_ => _.Addresses);
        }
    }
}
