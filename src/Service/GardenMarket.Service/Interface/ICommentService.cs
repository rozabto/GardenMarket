using GardenMarket.Models;

namespace GardenMarket.Service.Interface
{
    public interface ICommentService : IServiceModel<Comment>, IServiceListUserIdModel<Comment>, IServiceDeleteModel<Comment>
    {
    }
}
