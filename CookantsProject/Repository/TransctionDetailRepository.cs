using CookantsEntity;
using CookantsEntity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookantsRepository.Repository
{
    #region // TransctionDetailRepository  Interface
    public interface ITransctionDetailRepository : IGenericRepository<TransctionDetail>
    {

    }
    #endregion

    #region TransctionDetailRepository  Implementation
    public class TransctionDetailRepository :
        GenericRepository<CookAntsDbContext, TransctionDetail>, ITransctionDetailRepository
    {

    }
    #endregion
  
}
