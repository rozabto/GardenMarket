using GardenMarket.Common;
using GardenMarket.Service.Interface;
using GardenMarket.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
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
        private readonly IProductImageService _productImage;
        private readonly ISafeChargeService _safeCharge;

        public CatalogController(ISubCategoryService subCategory, ISubSubCategoryService subSubCategory, ICharacteristicService characteristic, IProductService product, IFlowerTypeService flowerType, IProductImageService productImage, ISafeChargeService safeCharge)
        {
            _subCategory = subCategory ?? throw new ArgumentNullException(nameof(subCategory));
            _subSubCategory = subSubCategory ?? throw new ArgumentNullException(nameof(subSubCategory));
            _characteristic = characteristic ?? throw new ArgumentNullException(nameof(characteristic));
            _product = product ?? throw new ArgumentNullException(nameof(product));
            _flowerType = flowerType ?? throw new ArgumentNullException(nameof(flowerType));
            _productImage = productImage ?? throw new ArgumentNullException(nameof(productImage));
            _safeCharge = safeCharge ?? throw new ArgumentNullException(nameof(safeCharge));
        }

        public async Task<IActionResult> Index(int id)
        {
            var subSubCategory = await _subSubCategory.GetByIdAsync(id);
            subSubCategory.Products = (await _product.GetAllByIdAsync(subSubCategory.Id))
                .Select(s =>
                {
                    s.ProductImages = _productImage.GetAllById(s.Id).ToList();
                    return s;
                }).ToList();
            var viewModel = new CatalogViewModel
            {
                Characteristics = (await _characteristic.GetAllAsync()).Select(s => 
                {
                    s.Types = _flowerType.GetAllById(s.Id).ToList();
                    return s;
                }).ToList(),
                SubCategories = (await _subCategory.GetAllByIdAsync(id)).Select(s => 
                {
                    s.SubSubCategories = _subSubCategory.GetAllById(s.Id).ToList();
                    return s;
                }).ToList(),
                SubSubCategory = subSubCategory
            };
            return View(viewModel);
        }       

        public async Task<IActionResult> GetById(int id)
        {
            var product = await _product.GetByIdAsync(id);
            product.ProductImages = (await _productImage.GetAllByIdAsync(product.Id)).ToList();
            var viewModel = new ProductViewModel
            {
                Product = product,
                Colors = await _flowerType.GetAllByIdAsync(1)
            };
            return View(viewModel);
        }

        public IActionResult Checkout()
        {
            var viewModel = new CheckoutViewModel
            {
                Url = _safeCharge.CreateRequest()
            };
            return View(viewModel);
        }
    }
}