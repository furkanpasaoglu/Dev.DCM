using Dev.DCM.Samples;
using Xunit;

namespace Dev.DCM.EntityFrameworkCore.Applications;

[Collection(DCMTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<DCMEntityFrameworkCoreTestModule>
{

}
