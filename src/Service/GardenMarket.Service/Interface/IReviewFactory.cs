using GardenMarket.Models;

namespace GardenMarket.Service.Interface
{
    public interface IReviewFactory
    {
        Review Create(string firstname, string lastname, string email, string subject);
    }
}
