using GardenMarket.Service.Interface;
using GardenMarket.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace GardenMarket.Web.Controllers
{
    public class CatalogController : Controller
    {
        private readonly ISubCategoryService _subCategory;
        private readonly ISubSubCategoryService _subSubCategory;
        private readonly ICharacteristicService _characteristic;
        private readonly IProductService _product;
        private readonly IFlowerTypeService _flowerType;

        public CatalogController(ISubCategoryService subCategory, ISubSubCategoryService subSubCategory, ICharacteristicService characteristic, IProductService product, IFlowerTypeService flowerType)
        {
            _subCategory = subCategory ?? throw new ArgumentNullException(nameof(subCategory));
            _subSubCategory = subSubCategory ?? throw new ArgumentNullException(nameof(subSubCategory));
            _characteristic = characteristic ?? throw new ArgumentNullException(nameof(characteristic));
            _product = product ?? throw new ArgumentNullException(nameof(product));
            _flowerType = flowerType ?? throw new ArgumentNullException(nameof(flowerType));
        }

        public IActionResult Index(int id)
        {
            var viewModel = new CatalogViewModel
            {
                Characteristics = _characteristic.GetAll(),
                SubCategories = _subCategory.GetAll(),
                SubSubCategory = _subSubCategory.GetById(id)
            };
            return View(viewModel);
        }       

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