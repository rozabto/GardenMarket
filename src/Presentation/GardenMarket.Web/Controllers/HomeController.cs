﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GardenMarket.Web.Models;
using GardenMarket.Service.Interface;

namespace GardenMarket.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductService _product;

        public HomeController(IProductService product)
        {
            _product = product ?? throw new ArgumentNullException(nameof(product));
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public async Task<IActionResult> Product()
        {
            return View();
        }
        public async Task<IActionResult> Shop()
        {
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
