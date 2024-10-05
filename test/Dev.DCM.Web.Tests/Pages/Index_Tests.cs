using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace Dev.DCM.Pages;

public class Index_Tests : DCMWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}
