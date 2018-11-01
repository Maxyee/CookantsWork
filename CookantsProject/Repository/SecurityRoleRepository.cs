using CookantsEntity;
using CookantsEntity.Model;

namespace CookantsRepository.Repository
{

    #region // User Details Repository Interface
    public interface ISecurityRoleRepository : IGenericRepository<SecurityRole>
    {

    }
    #endregion

    #region User Details Repository Implementation
    public class SecurityRoleRepository :
        GenericRepository<CookAntsDbContext, SecurityRole>, ISecurityRoleRepository
    {

    }
    #endregion
}
