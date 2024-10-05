using Microsoft.AspNetCore.Builder;
using Dev.DCM;
using Volo.Abp.AspNetCore.TestBase;

var builder = WebApplication.CreateBuilder();
await builder.RunAbpModuleAsync<DCMWebTestModule>();

public partial class Program
{
}
