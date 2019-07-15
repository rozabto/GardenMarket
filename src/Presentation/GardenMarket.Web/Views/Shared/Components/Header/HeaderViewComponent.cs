using GardenMarket.Common;
using GardenMarket.Service.Interface;
using GardenMarket.ViewModel;
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
        private readonly ICategoryService _category;

        public HeaderViewComponent(IJsonService json, ICategoryService category)
        {
            _json = json ?? throw new ArgumentNullException(nameof(json));
            _category = category ?? throw new ArgumentNullException(nameof(category));
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var value = Request.Cookies[KEY];
            var collection = string.IsNullOrEmpty(value) ? new List<int>() :
                (await _json.DeserializeAsync<IReadOnlyList<int>>(value));
            var viewModel = new HeaderViewModel
            {
                Categories = (await _category.GetAllAsync()),
                Count = collection.Count,
                ProductIds = collection
            };
            return View("Default", viewModel);
        }
    }
}
