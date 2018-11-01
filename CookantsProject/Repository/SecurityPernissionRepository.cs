using CookantsEntity;
using CookantsEntity.Model;

namespace CookantsRepository.Repository
{
    
    #region // User Details Repository Interface
    public interface ISecurityPernissionRepository : IGenericRepository<SecurityPermission>
    {

    }
    #endregion

    #region User Details Repository Implementation
    public class SecurityPernissionRepository :
        GenericRepository<CookAntsDbContext, SecurityPermission>, ISecurityPernissionRepository
    {

    }
    #endregion
}
