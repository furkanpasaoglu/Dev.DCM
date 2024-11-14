using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Volo.Abp.AspNetCore.Mvc.UI.Bootstrap.TagHelpers.Form;

namespace Dev.DCM.Web.ViewModels.Cities;

public class CityEditViewModel
{
    [HiddenInput]
    public Guid? Id { get; set; }

    [Required(ErrorMessage = "CityNameIsRequired")]
    [Display(Name = "CityName")]
    [Placeholder("CityNamePlaceholder")]
    [DisplayOrder(1)]
    public string Name { get; set; }
    
    [DisplayOrder(2)]
    [Display(Name = "CityCode")]
    public string? Code { get; set; }
    
    [Required(ErrorMessage = "CountryIsRequired")]
    [SelectItems(nameof(Countries))]
    [Display(Name = "Country")]
    [DisplayOrder(3)]
    public Guid CountryId { get; set; }

    public List<SelectListItem> Countries { get; set; } = [];
}