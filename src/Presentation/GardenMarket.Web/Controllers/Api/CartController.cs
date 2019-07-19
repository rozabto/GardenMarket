using GardenMarket.Common;
using GardenMarket.Models;
using GardenMarket.Service.Extension;
using GardenMarket.Service.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace GardenMarket.Web.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartController : ControllerBase
    {
        private const string KEY = "GardenMarketCookieCartKey";
        private readonly IJsonService _json;
        private readonly IApiCartService _cart;

        public CartController(IJsonService json, IApiCartService cart)
        {
            _json = json ?? throw new ArgumentNullException(nameof(json));
            _cart = cart ?? throw new ArgumentNullException(nameof(cart));
        }

        [HttpPost]
        public async Task Post(int id)
        {
            var userId = HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (userId == null)
            {
                var value = Request.Cookies[KEY];
                var collection = string.IsNullOrEmpty(value) ? new List<CartHolder>() :
                    (await _json.DeserializeAsync<IList<CartHolder>>(value));
                var index = collection.FindIndex(f => f.Id == id);
                if (index != -1)
                {
                    collection[index].Amount++;
                }
                else
                {
                    collection.Add(new CartHolder
                    {
                        Id = id,
                        Amount = 1
                    });
                }

                Response.Cookies.Append(KEY, _json.Serialize(collection),
                    new CookieOptions
                    {
                        Expires = DateTime.Now.AddDays(5)
                    });
            }
            else
            {
                await _cart.Check(id, userId);
            }
        }
    }
}
