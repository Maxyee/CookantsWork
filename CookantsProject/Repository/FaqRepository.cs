using CookantsEntity;
using CookantsEntity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookantsRepository.Repository
{
   
    #region // Faq Repository Interface
    public interface IFaqRepository : IGenericRepository<Faq>
    {

    }
    #endregion

    #region Faq Repository Implementation
    public class FaqRepository :
        GenericRepository<CookAntsDbContext, Faq>, IFaqRepository
    {

    }
    #endregion
}
