using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GardenMarket.Web.Controllers
{
    public class CatalogController : Controller
    {
        public IActionResult All()
        {
            return View();
        }

        
        public IActionResult GetbyID()
        {
            return PartialView();
        }

    }
}
