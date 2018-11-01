using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CookantsEntity;
using CookantsEntity.Model;

namespace CookantsRepository.Repository
{

    #region // Address Repository Interface
    public interface IUserComplainRepository : IGenericRepository<UserComplain>
    {

    }
    #endregion

    #region Address Repository Implementation
    public class UserComplainRepository :
        GenericRepository<CookAntsDbContext, UserComplain>, IUserComplainRepository
    {

    }
    #endregion
}
