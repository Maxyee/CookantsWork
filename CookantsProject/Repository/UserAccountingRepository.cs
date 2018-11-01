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
    public interface IUserAccountingRepository : IGenericRepository<UserAccounting>
    {

    }
    #endregion

    #region Address Repository Implementation
    public class UserAccountingRepository :
        GenericRepository<CookAntsDbContext, UserAccounting>, IUserAccountingRepository
    {

    }
    #endregion

}
