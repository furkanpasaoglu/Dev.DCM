using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Dev.DCM.Web.Extensions;

public static class SelectListItemExtensions
{
    /// <summary>
    /// İlk eleman olarak seçiniz seçeneğini ekler
    /// </summary>
    /// <param name="items"> </param>
    /// <param name="placeholderKey"></param>
    /// <returns></returns>
    // Method to add the select option to the SelectListItem
    public static List<SelectListItem> AddSelectOption(this List<SelectListItem> items, string placeholderKey)
    {
        items.Insert(0, new SelectListItem { Value = "", Text = placeholderKey });
        return items;
    }
    
    /// <summary>
    /// Listeyi SelectListItem listesine çevirir
    /// </summary>
    /// <param name="items"></param>
    /// <param name="selector"></param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public static List<SelectListItem> ToSelectListItems<T>(this List<T> items, Func<T, SelectListItem> selector)
    {
        return items.Select(selector).ToList();
    }
    
}