using GardenMarket.Data.Interface;
using GardenMarket.Models;
using GardenMarket.Service.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace GardenMarket.Service.External
{
    public class ApiCartService : IApiCartService
    {
        private readonly IRepository<Cart> _cart;
        private readonly ICartFactory _cartFactory;

        public ApiCartService(IRepository<Cart> cart, ICartFactory cartFactory)
        {
            _cart = cart ?? throw new ArgumentNullException(nameof(cart));
            _cartFactory = cartFactory ?? throw new ArgumentNullException(nameof(cartFactory));
        }

        public async Task Check(int id, string userId)
        {
            var cart = await GetCart(id, userId);
            if (cart == null)
            {
                cart = _cartFactory.Create(id, userId);
                await _cart.Create(cart);
            }
            else
            {
                cart.Amount++;
                await _cart.Update(cart);
            }
        }

        private async Task<Cart> GetCart(int id, string userId) =>
            await _cart
                .GetAll()
                .FirstOrDefaultAsync(f => f.ProductId == id && f.UserId == userId);
    }
}
