using CookantsEntity;
using CookantsEntity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookantsRepository.Repository
{
    #region // TermsRepository Interface
    public interface ITermsRepository : IGenericRepository<Terms>
    {

    }
    #endregion

    #region TermsRepository Implementation
    public class TermsRepository :
        GenericRepository<CookAntsDbContext, Terms>, ITermsRepository
    {

    }
    #endregion
}
