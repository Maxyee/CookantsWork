using CookantsEntity;
using CookantsEntity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookantsRepository.Repository
{

    #region // Address Repository Interface
    public interface ICuponReposotory : IGenericRepository<Coupon>
    {

    }
    #endregion

    #region Address Repository Implementation
    public class CouponReposotory :
        GenericRepository<CookAntsDbContext, Coupon>, ICuponReposotory
    {

    }
    #endregion

}
