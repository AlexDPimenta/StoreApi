namespace Via.TercaGeek.StoreApi.Models
{
    public class Client
    {        
        public Guid Id { get; set; }        
        public string? Name { get; set; }
        public int Age { get; set; }
        public string? IdentificationDocument { get; set; }
        public IList<Address>? Addresses { get; set; }        

    }
}
