using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Dev.DCM.Services.Cities;
using Dev.DCM.Services.Countries;
using Dev.DCM.Services.UserDetails;
using Dev.DCM.Web.Extensions;
using Dev.DCM.Web.ViewModels.Cities;
using Dev.DCM.Web.ViewModels.UserDetails;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Localization;
using Volo.Abp.Application.Dtos;
using Volo.Abp.AspNetCore.Mvc.UI.Bootstrap.TagHelpers.Form;
using Volo.Abp.Identity;
using Volo.Abp.Localization;

namespace Dev.DCM.Web.Pages.UserDetails;

public class EditModal(IUserDetailAppService userDetailAppService, IIdentityUserAppService ıdentityUserAppService) : DCMPageModel
{
    [BindProperty(SupportsGet = true)]
    public UserDetailEditViewModel UserDetailEditViewModel { get; set; } = new();

    public async Task OnGetAsync()
    {
        if (UserDetailEditViewModel.Id.HasValue)
        {
            var createUpdateUserDetailDto = await userDetailAppService.GetAsync(UserDetailEditViewModel.Id.Value);

            UserDetailEditViewModel = new UserDetailEditViewModel
            {
                Id = createUpdateUserDetailDto.Id,
                BirthDate = createUpdateUserDetailDto.BirthDate,
                IdentityNumber = createUpdateUserDetailDto.IdentityNumber,
                PhoneNumber = createUpdateUserDetailDto.PhoneNumber,
                UserId = createUpdateUserDetailDto.UserId
            };
        }

        var users = await ıdentityUserAppService.GetListAsync(new GetIdentityUsersInput());
        UserDetailEditViewModel.Users = users.Items
            .Select(c => new SelectListItem($"{c.Name} {c.Surname}", c.Id.ToString()))
            .ToList();
        UserDetailEditViewModel.Users.AddSelectOption(L["Select"]);
    }

    public async Task<IActionResult> OnPostAsync()
    {
        if (UserDetailEditViewModel.Id.HasValue)
        {
            await userDetailAppService.UpdateAsync(UserDetailEditViewModel.Id.Value, new CreateUpdateUserDetailDto
            {
                BirthDate = UserDetailEditViewModel.BirthDate,
                IdentityNumber = UserDetailEditViewModel.IdentityNumber,
                PhoneNumber = UserDetailEditViewModel.PhoneNumber,
                UserId = UserDetailEditViewModel.UserId
            });
        }
        return NoContent();
    }
}