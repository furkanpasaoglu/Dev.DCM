using System.Linq;
using System.Threading.Tasks;
using Dev.DCM.Services.Cities;
using Dev.DCM.Services.Countries;
using Dev.DCM.Services.UserDetails;
using Dev.DCM.Web.Extensions;
using Dev.DCM.Web.ViewModels.Cities;
using Dev.DCM.Web.ViewModels.UserDetails;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Identity;

namespace Dev.DCM.Web.Pages.UserDetails;

public class CreateModal(IUserDetailAppService userDetailAppService, IIdentityUserAppService identityUserAppService): DCMPageModel
{
    [BindProperty]
    public UserDetailEditViewModel UserDetailEditViewModel { get; set; } = new();

    public async Task OnGet()
    {
        var users = await identityUserAppService.GetListAsync(new GetIdentityUsersInput());
        UserDetailEditViewModel.Users = users.Items
            .Select(c => new SelectListItem(c.Name, c.Id.ToString()))
            .ToList();
        UserDetailEditViewModel.Users.AddSelectOption(L["Select"]);
    }

    public async Task<IActionResult> OnPostAsync()
    {
        await userDetailAppService.CreateAsync(new CreateUpdateUserDetailDto
        {
            BirthDate = UserDetailEditViewModel.BirthDate,
            IdentityNumber = UserDetailEditViewModel.IdentityNumber,
            PhoneNumber = UserDetailEditViewModel.PhoneNumber,
            UserId = UserDetailEditViewModel.UserId
        });
        return NoContent();
    }
}