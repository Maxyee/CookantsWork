using CookantsEntity;
using CookantsEntity.Model;

namespace CookantsRepository.Repository
{

    #region // User Details Repository Interface
    public interface IBusinessZoneRepository : IGenericRepository<BusinessZone>
    {

    }
    #endregion

    #region User Details Repository Implementation
    public class BusinessZoneRepository :
        GenericRepository<CookAntsDbContext, BusinessZone>, IBusinessZoneRepository
    {

    }
    #endregion
}
