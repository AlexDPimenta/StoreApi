using Via.TercaGeek.StoreApi.Mutations.MutationResolvers;
using Via.TercaGeek.StoreApi.Types;

namespace Via.TercaGeek.StoreApi.Mutations.MutationTypes
{
    public class ClientMutateTypeExtension: ObjectTypeExtension
    {
        protected override void Configure(IObjectTypeDescriptor descriptor)
        {
            descriptor.Name("Mutation");

            descriptor.Field("CreateClientAsync")
            .ResolveWith<ClientMutationResolver>(m => m.CreateClientAsync(default!,default!))
            .Argument("client", _ => _.Type<ClientInputType>())              
            .Name("CreateClient");

            descriptor.Field("DeleteClientAsync")
                .ResolveWith<ClientMutationResolver>(_ => _.DeleteClientAsync(default!, default!))
                .Argument("id", _ => _.Type<StringType>())                
                .Name("RemoveClient");

            descriptor.Field("UpdateClientAsync")
                .ResolveWith<ClientMutationResolver>(_ => _.UpdateClientAsync(default!, default!, default!))
                .Argument("id", _ => _.Type<StringType>())
                .Argument("client", _=> _.Type<ClientInputType>())
                .Name("UpdateClient");
        }
    }
}
