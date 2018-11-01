using CookantsEntity;
using CookantsEntity.Model;

namespace CookantsRepository.Repository
{

    #region // User Details Repository Interface
    public interface IOrderItemRepository : IGenericRepository<OrderItem>
    {

    }
    #endregion

    #region User Details Repository Implementation
    public class OrderItemRepository :
        GenericRepository<CookAntsDbContext, OrderItem>, IOrderItemRepository
    {

    }
    #endregion
}
