using GardenMarket.Models;
using GardenMarket.Service.Interface;

namespace GardenMarket.Service.Internal
{
    public class ReviewFactory : IReviewFactory
    {
        public Review Create(string firstname, string lastname, string email, string subject) =>
            new Review
            {
                FirstName = firstname,
                LastName = lastname,
                Email = email,
                Subject = subject
            };
    }
}
