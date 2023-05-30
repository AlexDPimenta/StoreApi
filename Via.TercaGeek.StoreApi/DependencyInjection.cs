using Microsoft.EntityFrameworkCore;
using Via.TercaGeek.StoreApi.Context;
using Via.TercaGeek.StoreApi.Mutations.MutationTypes;
using Via.TercaGeek.StoreApi.Queries.QueryTypes;
using Via.TercaGeek.StoreApi.Services;

namespace Via.TercaGeek.StoreApi
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApiServices(this IServiceCollection services)
        {
            services.AddScoped<IClientService, ClientService>();
            services.AddDbContext<StoreDb>(opt => opt.UseInMemoryDatabase("StoreDb"));
            services.AddEndpointsApiExplorer();
            services.AddGraphQLServer()
                .AddQueryType(q => q.Name("Query"))
                    .AddType<ClientQueryTypeExtension>()
                .AddMutationType(m => m.Name("Mutation"))
                    .AddType<ClientMutateTypeExtension>();                
            return services;
        }
    }
}
