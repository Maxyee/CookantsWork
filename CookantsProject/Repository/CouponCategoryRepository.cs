using CookantsEntity;
using CookantsEntity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookantsRepository.Repository
{
    #region // CouponCategoryRepository  Interface
    public interface ICouponCategoryRepository : IGenericRepository<CouponCategory>
    {

    }
    #endregion

    #region CouponCategoryRepository  Implementation
    public class CouponCategoryRepository :
        GenericRepository<CookAntsDbContext, CouponCategory>, ICouponCategoryRepository
    {

    }
    #endregion
    
}
