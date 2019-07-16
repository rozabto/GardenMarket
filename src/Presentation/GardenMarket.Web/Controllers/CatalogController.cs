using GardenMarket.Service.Interface;
using GardenMarket.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace GardenMarket.Web.Controllers
{
    public class CatalogController : Controller
    {
        private readonly ICategoryService _category;
        private readonly ISubCategoryService _subCategory;
        private readonly ISubSubCategoryService _subSubCategory;
        private readonly IProductService _product;
        private readonly IFlowerTypeService _flowerType;


        public IActionResult Index()
        {
            return View();
        }

        [Route("p/{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var viewModel = new ProductViewModel
            {
                Product = await _product.GetByIdAsync(id),
                Colors = await _flowerType.GetAllAsync()
            };
            return View();
        }
    }
}