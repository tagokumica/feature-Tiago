using Domain.Test.Fixture.Customer;
using Xunit;

namespace Domain.Test.Collection.Customer
{
    [CollectionDefinition(nameof(CustomerCollection))]
    public class CustomerCollection : ICollectionFixture<CustomerTestFixture>
    {
        
    }
}