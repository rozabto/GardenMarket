using GardenMarket.Service.Interface;
using GardenMarket.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace GardenMarket.Web.Views.Shared.Components.HeaderSubCategory
{
    public class HeaderSubCategoryViewComponent : ViewComponent
    {
        private readonly ISubCategoryService _subCategory;

        public HeaderSubCategoryViewComponent(ISubCategoryService subCategory)
        {
            _subCategory = subCategory ?? throw new ArgumentNullException(nameof(subCategory));
        }

        public async Task<IViewComponentResult> InvokeAsync(int id)
        {
            var viewModel = new HeaderSubCategoryViewModel
            {
                SubCategories = await _subCategory.GetAllByIdAsync(id)
            };
            return View("Default", viewModel);
        }
    }
}
