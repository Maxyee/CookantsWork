using CookantsEntity;
using CookantsEntity.Model;

namespace CookantsRepository.Repository
{

    #region // User Details Repository Interface
    public interface IOrderRepository : IGenericRepository<Order>
    {

    }
    #endregion

    #region User Details Repository Implementation
    public class OrderRepository :
        GenericRepository<CookAntsDbContext, Order>, IOrderRepository
    {

    }
    #endregion
}
