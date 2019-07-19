using GardenMarket.Common;
using GardenMarket.Models;
using GardenMarket.Service.Interface;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;

namespace GardenMarket.Web.Views.Shared.Components.Header
{
    public class HeaderViewComponent : ViewComponent
    {
        private const string KEY = "GardenMarketCookieCartKey";
        private readonly IJsonService _json;
        private readonly IHeaderService _header;

        public HeaderViewComponent(IJsonService json, IHeaderService header)
        {
            _json = json ?? throw new ArgumentNullException(nameof(json));
            _header = header ?? throw new ArgumentNullException(nameof(header));
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var userId = HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (userId == null)
            {
                var value = Request.Cookies[KEY];
                var collection = string.IsNullOrEmpty(value) ? new List<CartHolder>() :
                    (await _json.DeserializeAsync<IReadOnlyList<CartHolder>>(value));
                return View("Default", await _header.GetViewModel(collection));
            }
            else
            {
                return View("Default", await _header.GetViewModel(userId));
            }
        }
    }
}