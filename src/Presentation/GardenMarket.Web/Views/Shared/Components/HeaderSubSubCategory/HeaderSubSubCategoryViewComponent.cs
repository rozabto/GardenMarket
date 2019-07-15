using GardenMarket.Service.Interface;
using GardenMarket.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace GardenMarket.Web.Views.Shared.Components.HeaderSubSubCategory
{
    public class HeaderSubSubCategoryViewComponent : ViewComponent
    {
        private readonly ISubSubCategoryService _subSubCategory;

        public HeaderSubSubCategoryViewComponent(ISubSubCategoryService subSubCategory)
        {
            _subSubCategory = subSubCategory ?? throw new ArgumentNullException(nameof(subSubCategory));
        }

        public async Task<IViewComponentResult> InvokeAsync(int id)
        {
            var viewModel = new HeaderSubSubCategoryViewModel
            {
                SubSubCategories = await _subSubCategory.GetAllByIdAsync(id)
            };
            return View("Default", viewModel);
        }
    }
}
