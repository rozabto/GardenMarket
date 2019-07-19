using GardenMarket.Common;
using GardenMarket.Service.Interface;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GardenMarket.Web.Views.Shared.Components.Header
{
    public class HeaderViewComponent : ViewComponent
    {
        private const string KEY = "GardenMarketCookieCart";
        private readonly IJsonService _json;
        private readonly IHeaderService _header;

        public HeaderViewComponent(IJsonService json, IHeaderService header)
        {
            _json = json ?? throw new ArgumentNullException(nameof(json));
            _header = header ?? throw new ArgumentNullException(nameof(header));
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var value = Request.Cookies[KEY];
            var collection = string.IsNullOrEmpty(value) ? new List<int>() :
                (await _json.DeserializeAsync<IReadOnlyList<int>>(value));
            return View("Default", await _header.GetViewModel(collection));
        }
    }
}