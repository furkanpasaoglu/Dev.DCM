using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;
using Volo.Abp.AspNetCore.Mvc.UI.Bootstrap.TagHelpers.Form;
using static Dev.DCM.Permissions.DCMPermissions.Locations;

namespace Dev.DCM.Web.ViewModels.UserDetails
{
    public class UserDetailEditViewModel
    {
        [HiddenInput]
        public Guid? Id { get; set; }

        [Display(Name = "IdentityNumber")]
        [Placeholder("IdentityNumberPlaceholder")]
        [DisplayOrder(1)]
        public string? IdentityNumber { get; set; }

        [Display(Name = "BirthDate")]
        [Placeholder("BirthDatePlaceholder")]
        [DisplayOrder(2)]
        public DateTime? BirthDate { get; set; }


        [Display(Name = "PhoneNumber")]
        [Placeholder("PhoneNumberPlaceholder")]
        [DisplayOrder(3)]
        public string? PhoneNumber { get; set; }

        [Required(ErrorMessage = "UserIsRequired")]
        [SelectItems(nameof(Users))]
        [Display(Name = "User")]
        [DisplayOrder(4)]
        public Guid UserId { get; set; }

        public List<SelectListItem> Users { get; set; } = [];
    }
}
