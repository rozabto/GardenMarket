using GardenMarket.Models;

namespace GardenMarket.Service.Interface
{
    public interface ICommentService : IServiceModel<Comment>, IServiceListModel<Comment>, IServiceDeleteModel<Comment>
    {
    }
}
