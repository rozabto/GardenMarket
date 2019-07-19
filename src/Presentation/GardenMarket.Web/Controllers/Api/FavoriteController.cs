using GardenMarket.Service.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Security.Claims;
using System.Threading.Tasks;

namespace GardenMarket.Web.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class FavoriteController : ControllerBase
    {
        private readonly IApiFavoriteService _favorite;

        public FavoriteController(IApiFavoriteService favorite)
        {
            _favorite = favorite ?? throw new ArgumentNullException(nameof(favorite));
        }

        [HttpPost]
        public async Task Post(int id) =>
            await _favorite.Check(id, HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier));
    }
}