using Xunit;

namespace Dev.DCM.EntityFrameworkCore;

[CollectionDefinition(DCMTestConsts.CollectionDefinitionName)]
public class DCMEntityFrameworkCoreCollection : ICollectionFixture<DCMEntityFrameworkCoreFixture>
{

}
