using GardenMarket.Common;
using GardenMarket.Service.Interface;
using GardenMarket.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GardenMarket.Web.Views.Shared.Components.Header
{
    public class HeaderViewComponent : ViewComponent
    {
        private const string KEY = "GardenMarketCookieCart";
        private readonly IJsonService _json;
        private readonly ICategoryService _category;
        private readonly ISubCategoryService _subCategory;
        private readonly ISubSubCategoryService _subSubCategory;

        public HeaderViewComponent(IJsonService json, ICategoryService category, 
            ISubCategoryService subCategory, ISubSubCategoryService subSubCategory)
        {
            _json = json ?? throw new ArgumentNullException(nameof(json));
            _category = category ?? throw new ArgumentNullException(nameof(category));
            _subCategory = subCategory ?? throw new ArgumentNullException(nameof(subCategory));
            _subSubCategory = subSubCategory ?? throw new ArgumentNullException(nameof(subSubCategory));
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var subCategories = await _subCategory.GetAllAsync();
            var subSubCategories = await _subSubCategory.GetAllAsync();
            var value = Request.Cookies[KEY];
            var collection = string.IsNullOrEmpty(value) ? new List<int>() :
                (await _json.DeserializeAsync<IReadOnlyList<int>>(value));
            var viewModel = new HeaderViewModel
            {
                Categories = (await _category.GetAllAsync()).Select(s => 
                {
                    s.SubCategories = subCategories
                    .Where(w => w.CategoryId == s.Id)
                    .Select(se =>
                    {
                        se.SubSubCategories = subSubCategories.Where(w => w.SubCategoryId == se.Id).ToList();
                        return se;
                    }).ToList();
                    return s;
                }).ToList(),
                Count = collection.Count,
                ProductIds = collection
            };
            return View("Default", viewModel);
        }
    }
}
