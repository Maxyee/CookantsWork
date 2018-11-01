using CookantsEntity;
using CookantsEntity.Model;

namespace CookantsRepository.Repository
{

    #region // User Details Repository Interface
    public interface IBusinessAreaRepository : IGenericRepository<BusinessArea>
    {

    }
    #endregion

    #region User Details Repository Implementation
    public class BusinessAreaRepository :
        GenericRepository<CookAntsDbContext, BusinessArea>, IBusinessAreaRepository
    {

    }
    #endregion
}
