using System.Text.Json.Serialization;

namespace Via.TercaGeek.StoreApi.Models
{
    public class Address
    {        
        public Guid Id { get; set; }
        public string? Street { get; set; }
        public int Number { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? Country { get; set; }
        [JsonIgnore]
        public Client? Client { get; set; }
        [JsonIgnore]
        [GraphQLIgnore]
        public Guid ClientId { get; set; }
    }
}