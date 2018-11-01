using CookantsEntity;
using CookantsEntity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookantsRepository.Repository
{
    #region // TransctionRepository  Interface
    public interface ITransctionRepository : IGenericRepository<Transction>
    {

    }
    #endregion

    #region TransctionRepository  Implementation
    public class TransctionRepository :
        GenericRepository<CookAntsDbContext, Transction>, ITransctionRepository
    {

    }
    #endregion
   
}
