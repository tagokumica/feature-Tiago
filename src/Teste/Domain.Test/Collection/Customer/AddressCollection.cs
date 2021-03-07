using Domain.Test.Fixture.Customer;
using Xunit;

namespace Domain.Test.Collection.Customer
{
    [CollectionDefinition(nameof(AddressCollection))]
    public class AddressCollection : ICollectionFixture<AddressTestFixture>
    {
        
    }
}