using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CookantsEntity;
using CookantsEntity.Model;

namespace CookantsRepository.Repository
{
    

    #region // AboutUsRepository  Interface
    public interface IOrderItemQueueRepository : IGenericRepository<OrderItemQueue>
    {

    }
    #endregion

    #region AboutUsRepository  Implementation
    public class OrderItemQueueRepository : GenericRepository<CookAntsDbContext, OrderItemQueue>, IOrderItemQueueRepository
    {

    }
    #endregion
}
