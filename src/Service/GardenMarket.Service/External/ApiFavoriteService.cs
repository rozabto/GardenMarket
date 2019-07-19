using GardenMarket.Data.Interface;
using GardenMarket.Models;
using GardenMarket.Service.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace GardenMarket.Service.External
{
    public class ApiFavoriteService : IApiFavoriteService
    {
        private readonly IFavoriteFactory _favoriteFactory;
        private readonly IRepository<Favorite> _favorite;

        public ApiFavoriteService(IFavoriteFactory favoriteFactory, IRepository<Favorite> favorite)
        {
            _favoriteFactory = favoriteFactory ?? throw new ArgumentNullException(nameof(favoriteFactory));
            _favorite = favorite ?? throw new ArgumentNullException(nameof(favorite));
        }

        public async Task Check(int id, string userId)
        {
            var favorite = await CheckIfLicked(id, userId);

            if (favorite != null)
            {
                await _favorite.Delete(favorite.Id);
            }
            else
            {
                favorite = _favoriteFactory.Create(id, userId);
                await _favorite.Create(favorite).ConfigureAwait(false);
            }
        }

        private async Task<Favorite> CheckIfLicked(int productId, string userId) =>
            await _favorite.GetAll()
                .Where(w => w.ProductId == productId && w.UserId == userId)
                .FirstOrDefaultAsync();
    }
}
