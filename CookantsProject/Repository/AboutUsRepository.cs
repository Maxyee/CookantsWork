using CookantsEntity;
using CookantsEntity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookantsRepository.Repository
{

    #region // AboutUsRepository  Interface
    public interface IAboutUsRepository : IGenericRepository<AboutUs>
    {

    }
    #endregion

    #region AboutUsRepository  Implementation
    public class AboutUsRepository :
        GenericRepository<CookAntsDbContext, AboutUs>, IAboutUsRepository
    {

    }
    #endregion
}
