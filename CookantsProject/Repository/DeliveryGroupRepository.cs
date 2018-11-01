using CookantsEntity;
using CookantsEntity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookantsRepository.Repository
{
    #region // DeliveryGroupRepository  Interface
    public interface IDeliveryGroupRepository : IGenericRepository<DeliveryGroup>
    {

    }
    #endregion

    #region DeliveryGroupRepository  Implementation
    public class DeliveryGroupRepository :
        GenericRepository<CookAntsDbContext, DeliveryGroup>, IDeliveryGroupRepository
    {

    }
    #endregion
    
}
