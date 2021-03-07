using Domain.Test.Fixture.Address;
using Xunit;

namespace Domain.Test.Collection.Address
{
    [CollectionDefinition(nameof(AddressCollection))]
    public class AddressCollection : ICollectionFixture<AddressTestFixture>
    {
        
    }
}