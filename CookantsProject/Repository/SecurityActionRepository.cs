using CookantsEntity;
using CookantsEntity.Model;

namespace CookantsRepository.Repository
{

    #region // User Details Repository Interface
    public interface ISecurityActionRepository : IGenericRepository<SecurityAction>
    {

    }
    #endregion

    #region User Details Repository Implementation
    public class SecurityActionRepository :
        GenericRepository<CookAntsDbContext, SecurityAction>, ISecurityActionRepository
    {

    }
    #endregion
}
