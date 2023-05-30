using Via.TercaGeek.StoreApi.Queries.QueryResolvers;

namespace Via.TercaGeek.StoreApi.Queries.QueryTypes
{
    public class ClientQueryTypeExtension: ObjectTypeExtension
    {
        protected override void Configure(IObjectTypeDescriptor descriptor)
        {
            descriptor.Name("Query");

            descriptor.Field("GetClients")
                .ResolveWith<ClientQueryResolver>(c => c.GetClients(default!))
                .Name("clients");

            descriptor.Field("GetClient")
                .ResolveWith<ClientQueryResolver>(c => c.GetClient(default!, default!))
                .Argument("id", _ => _.Type<StringType>())
                .Name("client");

        }
    }
}
