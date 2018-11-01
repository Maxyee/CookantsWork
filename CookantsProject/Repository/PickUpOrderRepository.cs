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
    public interface IPickUpOrderRepository : IGenericRepository<PickupOrder>
    {

    }
    #endregion

    #region AboutUsRepository  Implementation
    public class PickUpOrderRepository : GenericRepository<CookAntsDbContext, PickupOrder>, IPickUpOrderRepository
    {

    }
    #endregion
}
