using Dev.DCM.Samples;
using Xunit;

namespace Dev.DCM.EntityFrameworkCore.Domains;

[Collection(DCMTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<DCMEntityFrameworkCoreTestModule>
{

}
