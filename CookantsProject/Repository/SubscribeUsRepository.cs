using CookantsEntity;
using CookantsEntity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookantsRepository.Repository
{

    #region // SubscribeUsRepository Repository Interface
    public interface ISubscribeUsRepository : IGenericRepository<SubscribeUs>
    {

    }
    #endregion

    #region SubscribeUsRepository Repository Implementation
    public class SubscribeUsRepository :
        GenericRepository<CookAntsDbContext, SubscribeUs>, ISubscribeUsRepository
    {

    }
    #endregion
}
