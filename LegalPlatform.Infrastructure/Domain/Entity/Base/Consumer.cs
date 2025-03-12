namespace LegalPlatform.Infrastructure.Domain.Entity.Base
{
    public abstract class Consumer<TKey>
    {
        public TKey Id { set; get; }    
        public string FirstName { set; get; }
        public string LastName { set; get; }
        public string Address { set; get; }
    }
}
