using GardenMarket.Data.Interface;
using GardenMarket.Models;
using GardenMarket.Service.Interface;
using GardenMarket.ViewModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace GardenMarket.Service.External
{
    public class ContactService : IContactService
    {
        private readonly IRepository<Review> _review;
        private readonly IReviewFactory _reviewFactory;

        public ContactService(IRepository<Review> review, IReviewFactory reviewFactory)
        {
            _review = review ?? throw new ArgumentNullException(nameof(review));
            _reviewFactory = reviewFactory ?? throw new ArgumentNullException(nameof(reviewFactory));
        }

        public async Task<ContactViewModel> GetViewModel()
        {
            return new ContactViewModel
            {
                FirstName = "",
                LastName = "",
                ReviewSent = false,
                ReviewsWritten = await _review.GetAll().CountAsync()
            };
        }

        public async Task<ContactViewModel> GetViewModel(string firstname, string lastname, string email, string subject)
        {
            var review = _reviewFactory.Create(firstname, lastname, email, subject);
            await _review.Create(review).ConfigureAwait(false);
            return new ContactViewModel
            {
                FirstName = firstname,
                LastName = lastname,
                ReviewSent = true,
                ReviewsWritten = await _review.GetAll().CountAsync()
            };
        }
    }
}