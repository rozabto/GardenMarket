using GardenMarket.Common;
using GardenMarket.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GardenMarket.Web.Components
{
    public class HeaderViewComponent : ViewComponent
    {
        private const string KEY = "GardenMarketCookieCart";
        private readonly IJsonService _json;

        public HeaderViewComponent(IJsonService json)
        {
            _json = json ?? throw new ArgumentNullException(nameof(json));
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var value = Request.Cookies[KEY];
            var collection = string.IsNullOrEmpty(value) ? new List<int>() :
                (await _json.DeserializeAsync<IReadOnlyList<int>>(value));
            var viewModel = new HeaderViewModel
            {
                Count = collection.Count,
                ProductIds = collection
            };
            return View("Default", viewModel);
        }
    }
}
